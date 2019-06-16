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

namespace JOKRStore.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IGameService gameService;
        private readonly IMapper mapper;

        public CartController(IGameService gameService, IMapper mapper)
        {
            this.gameService = gameService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Price);
            return View();
        }

        public async Task<IActionResult> Buy(Guid Id)
        {
            List<GameViewModel> cart;
            if (SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart") == null)
            {
                cart = new List<GameViewModel>();
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                System.Diagnostics.Debug.Print("Cart list created!\n");
            } 
            else
                cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");

            if (isExist(cart, Id) == -1)
            {
                System.Diagnostics.Debug.Print("Buying game id: " + Id.ToString());
                var gameDto = await gameService.GetGameByIdAsync(Id);
                var game = mapper.Map<GameViewModel>(gameDto);
                System.Diagnostics.Debug.Print(game.Id.ToString() + " " + game.GameName + " " + game.Price.ToString());
                cart.Add(game);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                System.Diagnostics.Debug.Print("Game added to the cart!\n");
            }

            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Price);

            return View("../Games/Cart");
        }

        public IActionResult Remove(Guid id)
        {
            List<GameViewModel> cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");
            int index = isExist(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
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
