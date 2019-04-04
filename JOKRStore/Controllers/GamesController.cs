using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.ServiceInterfaces;
using JOKRStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JOKRStore.Controllers
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
            var gameDtos = await gameService.GetGames();
            var games = gameDtos.Select(x => mapper.Map<GameViewModel>(x));

            return View(games);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var gameDto = await gameService.GetGame(id);
            var game = mapper.Map<GameViewModel>(gameDto);
            System.Diagnostics.Debug.WriteLine(game.GameName);

            return View(game);
        }
    }
}