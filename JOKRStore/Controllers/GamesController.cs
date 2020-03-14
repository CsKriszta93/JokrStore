using AutoMapper;
using BLL.ServiceInterfaces;
using JOKRStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JOKRStore.Web.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameService gameService;
        private readonly IMapper mapper;
        private readonly IHostingEnvironment _hostingEnvironment;

        public GamesController(IGameService gameService, IMapper mapper, IHostingEnvironment hostingEnvironment)
        {
            this.gameService = gameService;
            this.mapper = mapper;
            this._hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var gameDtos = await gameService.GetGamesAsync();
            GameIndexViewModel games = new GameIndexViewModel();
            games.new_release = gameDtos.OrderBy(x => x.Release).Take(8).Select(x => mapper.Map<GameViewModel>(x));
            games.popular = gameDtos.OrderBy(x => x.Release).Take(8).Select(x => mapper.Map<GameViewModel>(x));

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
                var UserId = Guid.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value);
                game.owned = gameService.IsOwnedGame(UserId, id);
                game.MyDevelopment = game.UserId == UserId;
            }
            catch (Exception e)
            {
                 game.owned = false;
                 game.MyDevelopment = false;
            }
            
            return View(game);
        }

        public async Task<ActionResult> Download_demo(Guid Id)
        {
            try {
                var gameDto = await gameService.GetGameByIdAsync(Id);
                return File(gameDto.DemoLink, System.Net.Mime.MediaTypeNames.Application.Octet, gameDto.GameName + "(Demo).exe");
            }
            catch (Exception e) {
                return Content("An error occoured: " + e.Message);
            }
        }

        public async Task<ActionResult> Download(Guid Id)
        {
            try {
                var gameDto = await gameService.GetGameByIdAsync(Id);
                if (gameDto.Price == 0)
                    return File(gameDto.DownloadLink, System.Net.Mime.MediaTypeNames.Application.Octet, gameDto.GameName + ".exe");
  
                var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;
                if (gameService.IsOwnedGame(Guid.Parse(UserId), Id))
                    return File(gameDto.DownloadLink, System.Net.Mime.MediaTypeNames.Application.Octet, gameDto.GameName + ".exe");
            }
            catch (Exception e)
            {
                return Content("An error occoured: " + e.Message +  " Access denied.");
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

        public async Task<IActionResult> EditBase(Guid Id)
        {
            var UserId = Guid.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value); 
            var gameDto = await gameService.GetGameByIdAsync(Id);  
            var genresDto = await gameService.GetPropertyDtosAsync(0);
            var gameModeDto = await gameService.GetPropertyDtosAsync(1);
            var GameEdit = new GameEditViewModel
            {
                Game =  mapper.Map<GameViewModel>(gameDto),
                Genres = mapper.Map<IEnumerable<PropertyViewModel>>(genresDto).ToArray(),
                GameModes = mapper.Map<IEnumerable<PropertyViewModel>>(gameModeDto).ToArray()
            };

            if (GameEdit.Game != null)
                for (int i=0; i<GameEdit.Genres.Count(); i++)
                    GameEdit.Genres[i].Selected = await gameService.GameHasPropery(GameEdit.Game.Id, GameEdit.Genres[i].Id);

            if (Id == Guid.Empty || UserId == gameDto.UserId)
                return View(GameEdit);
            return Content("Error during editing game. Access violation occoured.");
        }

        [HttpPost]
        public async Task<IActionResult> SaveGameBase(Guid GameId, string GameName, decimal Price, int ReleaseYear,
                                                        int ReleaseMonth, int ReleaseDay,
                                                        IEnumerable<PropertyViewModel> Genres, List<IFormFile> CoverArt, List<IFormFile> Medias)
        {
            var UserId = Guid.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value);
            var new_game = new BLL.DTO.GameDto()
            {
                Id = GameId,
                GameName = GameName,
                Release = DateTime.Parse(ReleaseYear.ToString() + "-" + ReleaseMonth.ToString() + "-" + ReleaseDay.ToString() + " 0:00"),
                Price = Price,
                UserId = UserId
            };

            var genresDto = mapper.Map<IEnumerable<BLL.DTO.PropertyDto>>(Genres.Where(x => x.Selected));

            if (GameId == Guid.Empty)
                await gameService.AddGameAsync(UserId, new_game, genresDto, Medias, CoverArt, _hostingEnvironment.WebRootPath + "/images/Games//" + GameName);
            else
                await gameService.EditGameAsync(UserId, new_game, genresDto, Medias, CoverArt, _hostingEnvironment.WebRootPath + "/images/Games/" + GameName);

            System.Diagnostics.Debug.WriteLine("Count of uploaded files:" + CoverArt.Count().ToString());

            return RedirectToAction("Details", "Games", new {Id = new_game.Id}); 
        }

        public async Task<IActionResult> SaveGameSysReq(GameViewModel Game)
        {
            var MinSysReqDto = mapper.Map<BLL.DTO.SysReqDto>(Game.MinSysReq);
            var RecSysReqDto = mapper.Map<BLL.DTO.SysReqDto>(Game.RecSysReq);

            await gameService.EditGameSysReqAsync(Game.Id, MinSysReqDto, RecSysReqDto);

            return RedirectToAction("Details", "Games", new {Id = Game.Id}); 
        }

        public async Task<IActionResult> DeleteMedia(Guid Id)
            {
                await gameService.DeleteMediaAsync(Id);
                return Ok();
            }

    }
}