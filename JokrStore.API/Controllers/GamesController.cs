using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using BLL.ServiceInterfaces;
using BLL.DTO;
using BLL.Helpers;

namespace JokrStore.API.Controllers
{
    [Route("api/games")]
    [ApiController]
    [AllowAnonymous]
    public class GamesController : ControllerBase
    {
        private readonly IGameService gameService;
        private readonly UserManager<Model.User> userManager;

        public GamesController(IGameService gameService, UserManager<Model.User> userManager)
        {
            this.gameService = gameService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Games([FromQuery] GameParams gameFilers)
        {
            int totalCount = await gameService.GetGamesCountAsync();
            int totalPages = (int)Math.Ceiling(totalCount / (double)gameFilers.PageSize);

            Response.AddPagination(gameFilers.CurrentPage, gameFilers.PageSize, totalCount, totalPages);

            return Ok(new { games = await gameService.GetGamesAsync(gameFilers) });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details([FromRoute] Guid id)
        {
            GameDto gameDto = await gameService.GetGameByIdAsync(id);
            bool isOwned;
            bool isMyDevelopment;

            try
            {
                var UserId = Guid.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value);
                isOwned = gameService.IsOwnedGame(UserId, id);
                isMyDevelopment = gameDto.UserId == UserId;
            }
            catch (Exception e)
            {
                isOwned = false;
                isMyDevelopment = false;
            }

            return Ok(new
            {
                game = gameDto,
                isOwned = isOwned,
                isMyDevelopment = isMyDevelopment
            });
        }

        /*public async Task<ActionResult> Download_demo(Guid Id)
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
            
        }*/

        [HttpGet("my-games")]
        public async Task<IActionResult> UserGameList()
        {
            string UserId = userManager.GetUserId(User);
            return Ok(await gameService.GetUserGames(Guid.Parse(UserId)));
        }

        /*public async Task<IActionResult> EditBase(Guid Id)
        {
            var UserId = Guid.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value); 
            var gameDto = await gameService.GetGameByIdAsync(Id);  
            var genresDto = await gameService.GetPropertyDtosAsync(0);
            var gameModeDto = await gameService.GetPropertyDtosAsync(1);
            

            if (gameDto != null)
                for (int i=0; i<genresDto.Count(); i++)
                    genresDto.Selected = await gameService.GameHasPropery(GameEdit.Game.Id, GameEdit.Genres[i].Id);

            if (Id == Guid.Empty || UserId == gameDto.UserId)
                return Ok(gameDto, genresDto, gameModeDto);
            return Ok("Error during editing game. Access violation occoured.");
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
            }*/

    }
}