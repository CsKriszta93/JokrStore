﻿using AutoMapper;
using BLL.DTO;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Identity;
using Model;
using System;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AuthService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<LoginResultDto> GetCreateUserResultAsync(UserRegisterDto userRegisterDto)
        {
            var userToCreate = mapper.Map<User>(userRegisterDto);
            userToCreate.Registration = DateTime.Now;
            userToCreate.LastLogin = DateTime.Now;

            var result = await userManager.CreateAsync(userToCreate, userRegisterDto.Password);

            return new LoginResultDto
            {
                Result = result,
                User = mapper.Map<UserDto>(userToCreate)
            };
        }

        public async Task<SignInResultDto> GetSignInResultAsync(UserLoginDto userLoginDto)
        {
            var user = await userManager.FindByNameAsync(userLoginDto.UserName);
            var result = await signInManager.CheckPasswordSignInAsync(user, userLoginDto.Password, false);

            if (result.Succeeded)
            {
                user.LastLogin = DateTime.Now;
                await signInManager.UserManager.UpdateAsync(user);
            }

            return new SignInResultDto
            {
                Succeeded = result.Succeeded,
                User = mapper.Map<UserDto>(user)
            };
        }
    }
}
