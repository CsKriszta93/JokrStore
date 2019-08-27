using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JOKRStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using JOKRStore.Web.Helpers;
using BLL.ServiceInterfaces;
using AutoMapper;
using System.Security.Claims;

namespace JOKRStore.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IGameService gameService;
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public CartController(IGameService gameService, IUserService userService, IMapper mapper)
        {
            this.gameService = gameService;
            this.userService = userService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Price);
            return View();
        }

        public async Task<IActionResult> AddToCart(Guid Id)
        {
            List<GameViewModel> cart;
            if (SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart") == null)
            {
                cart = new List<GameViewModel>();
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            } 
            else
                cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");

            if (isExist(cart, Id) == -1)
            {
                var gameDto = await gameService.GetGameByIdAsync(Id);
                var game = mapper.Map<GameViewModel>(gameDto);
                cart.Add(game);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }

            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Price);

            return View("../Games/Cart");
        }

        public async Task<IActionResult> Buy()
        {
            List<GameViewModel> cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;

            foreach (var c in cart)
                await gameService.AddGameToUser(Guid.Parse(UserId), c.Id);

            return RedirectToAction("Index", "Games");
        }

        public async Task<IActionResult> Remove(Guid id)
        {
            List<GameViewModel> cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");
            int index = isExist(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index", "Games");
        }

        private int isExist(List<GameViewModel> cart, Guid id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
