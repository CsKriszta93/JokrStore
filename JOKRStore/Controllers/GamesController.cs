using AutoMapper;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JOKRStore.Web.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameService gameService;
        private readonly IMapper mapper;

        public GamesController(IGameService gameService, IMapper mapper)
        {
            this.gameService = gameService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var gameDtos = await gameService.GetGamesAsync();
            var games = gameDtos.Select(x => mapper.Map<GameViewModel>(x));

            return View(games);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var gameDto = await gameService.GetGameByIdAsync(id);
            var game = mapper.Map<GameViewModel>(gameDto);

            return View(game);
        }
    }
}