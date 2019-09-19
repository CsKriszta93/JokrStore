using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;

namespace JOKRStore.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly IHardwareService hardwareService;
        private readonly IMapper mapper;

        public UsersController(IUserService userService, IHardwareService hardwareService, IMapper mapper)
        {
            this.userService = userService;
            this.hardwareService = hardwareService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> UserDetails(Guid id)
        {
            var userDto = await userService.GetUserByIdAsync(id);
            var user = mapper.Map<UserViewModel>(userDto);
            string UserId;

            if (User.Claims.Count() > 0)
            {
                UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
                user.isMyUser = Guid.Parse(UserId) == user.Id;
            }
            else
                user.isMyUser = false;
            
            return View(user);
        }

        public async Task<IActionResult> EditUserConfig()
        {
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
            var userDto = await userService.GetUserByIdAsync(Guid.Parse(UserId));
            ConfigEditViewModel conf_edit = new ConfigEditViewModel();
            conf_edit.CPUs = mapper.Map<IEnumerable<CPUViewModel>>(await hardwareService.GetCPUsAsync());
            conf_edit.GPUs = mapper.Map<IEnumerable<GPUViewModel>>(await hardwareService.GetGPUsAsync());
            conf_edit.OSes = mapper.Map<IEnumerable<OSViewModel>>(await hardwareService.GetOSesAsync());
            conf_edit.Config = mapper.Map<UserViewModel>(userDto).Config;
            return View(conf_edit);
        }


        [HttpPost]
        public async Task<IActionResult> SaveUserConfig(Guid CPUId, int RAM, Guid GPUId, int GPU_size, Guid OSId, string other)
        {
            var UserId = Guid.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value);
            var new_conf = new BLL.DTO.ConfigDto()
            {
                UserId = UserId,
                CPUId = CPUId,
                RAM = RAM,
                GPUId = GPUId,
                GPU_size = GPU_size,
                OSId = OSId,
                others = other             
            };

            await userService.SaveConfigAsync(UserId, new_conf);

            return RedirectToAction("UserDetails", "Users", new {Id = UserId}); 
        }
    }
}
