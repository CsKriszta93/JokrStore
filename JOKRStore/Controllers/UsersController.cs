using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;

namespace JOKRStore.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> UserDetails(Guid id)
        {
            var userDto = await userService.GetUserByIdAsync(id);
            var user = mapper.Map<UserViewModel>(userDto);

            return View(user);
        }
    }
}