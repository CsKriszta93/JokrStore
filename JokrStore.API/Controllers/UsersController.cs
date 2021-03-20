using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using BLL.ServiceInterfaces;

namespace JOKRStore.Web.Controllers
{
    [Route("api/users")]
    [ApiController]
    [AllowAnonymous]
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly IHardwareService hardwareService;

        public UsersController(IUserService userService, IHardwareService hardwareService)
        {
            this.userService = userService;
            this.hardwareService = hardwareService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> UserDetails(Guid id)
        {
            var _user = await userService.GetUserByIdAsync(id);
            bool _isMyUser = false;
            string UserId;

            if (User.Claims.Count() > 0)
            {
                UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
                _isMyUser = Guid.Parse(UserId) == _user.Id;
            }
            
            return Ok(new {
                user = _user,
                isMyUser = _isMyUser
            });
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
                GPUSize = GPU_size,
                OSId = OSId,
                others = other             
            };

            await userService.SaveConfigAsync(UserId, new_conf);

            return Ok(); 
        }
    }
}
