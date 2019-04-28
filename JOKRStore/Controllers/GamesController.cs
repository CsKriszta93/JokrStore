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
            var games = gameDtos.Select(x => mapper.Map<GameViewModel>(x));

            return View(games);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var gameDto = await gameService.GetGameByIdAsync(id);
            var game = mapper.Map<GameViewModel>(gameDto);
            ViewData["Game"] = game;

            return View(game);
        }

        [HttpPost]
        public IActionResult PostComment(string new_comment_str)
        {
            _currentUserGuid = _httpContextAccessor.HttpContext.User.Claims.FindFirst(UserClaimsKey.Sub);

            CommentViewModel new_comment = new CommentViewModel
            {
                Commenter = User.Claims.Where(c => c.Value)
            }
            return RedirectToAction("Detalils");
        }

        public async Task<IActionResult> UserDetails(Guid id)
        {
            var userDto = await gameService.GetUserByIdAsync(id);
            var user = mapper.Map<UserViewModel>(userDto);

            return View(user);
        }
    }
}