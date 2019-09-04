using AutoMapper;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
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
            GameIndexViewModel games = new GameIndexViewModel();
            games.new_release = gameDtos.OrderBy(x => x.Release).Take(6).Select(x => mapper.Map<GameViewModel>(x));
            games.popular = gameDtos.OrderBy(x => x.Release).Take(6).Select(x => mapper.Map<GameViewModel>(x));

            return View(games);
        }

        public async Task<IActionResult> Games()
        {
            var gameDtos = await gameService.GetGamesAsync();
            var games = gameDtos.Select(x => mapper.Map<GameViewModel>(x));

            return View(games);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var gameDto = await gameService.GetGameByIdAsync(id);
            var game = mapper.Map<GameViewModel>(gameDto);

            try {
                var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
                game.owned = gameService.IsOwnedGame(Guid.Parse(UserId), id);
            }
            catch (Exception e)
            {
                 game.owned = false;
            }
            
            return View(game);
        }

        public async Task<ActionResult> Download(Guid Id)
        {
            try {
                var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
                if (gameService.IsOwnedGame(Guid.Parse(UserId), Id))
                {
                    var gameDto = await gameService.GetGameByIdAsync(Id);
                    return File(gameDto.DownloadLink, System.Net.Mime.MediaTypeNames.Application.Octet, gameDto.GameName + ".exe");
                }
            }
            catch (Exception e)
            {
                return Content("Access denied");
            }

            return Content("Access denied");
            
        }

        public async Task<IActionResult> UserGameList()
        {
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
            var gameDtos = await gameService.GetUserGames(Guid.Parse(UserId));
            var games = gameDtos.Select(x => mapper.Map<GameViewModel>(x));

            return View(games);
        }

    }
}