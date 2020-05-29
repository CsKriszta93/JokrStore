﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using BLL.ServiceInterfaces;
using AutoMapper;


namespace JOKRStore.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IGameService gameService;
        private readonly IUserService userService;

        public CartController(IGameService gameService, IUserService userService)
        {
            this.gameService = gameService;
            this.userService = userService;
        }

        /*public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Price);
            return View();
        }

        public async Task<IActionResult> AddToCart(Guid Id)
        {
            if (!User.Identity.IsAuthenticated)
                return View("../Areas/Identity/Pages/Account/Login");

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
        }*/

        [HttpPost]
        public async Task<IActionResult> Buy()
        {
            /*List<GameViewModel> cart = SessionHelper.GetObjectFromJson<List<GameViewModel>>(HttpContext.Session, "cart");
            var UserId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).First().Value;

            foreach (var c in cart)
                await gameService.AddGameToUser(Guid.Parse(UserId), c.Id);*/

            return RedirectToAction("Index", "Games");
        }

        /*public async Task<IActionResult> Remove(Guid id)
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
        }*/
    }
}
