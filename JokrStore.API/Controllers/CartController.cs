using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using BLL.ServiceInterfaces;
using AutoMapper;
using BLL.DTO.GameDtos;

namespace JOKRStore.Web.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly IGameService gameService;
        private readonly IUserService userService;

        public CartController(IGameService gameService, IUserService userService)
        {
            this.gameService = gameService;
            this.userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Buy(IEnumerable<CartGameDto> games)
        {
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;

            foreach (var game in games)
                await gameService.AddGameToUser(Guid.Parse(UserId), game.Id);

            return Ok("Games are bought successfull");
        }
    }
}
