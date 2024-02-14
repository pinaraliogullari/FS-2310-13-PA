﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly IShoppingCartService _shoppingCartManager;

        public ShoppingCartController(UserManager<User> userManager, IShoppingCartService shoppingCartManager)
        {
            _userManager = userManager;
            _shoppingCartManager = shoppingCartManager;
        }

        //kullanıcının sepetini gösterecek.
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddToCart(string userId,int productId, int quantity = 1)
        {
            var userId = _userManager.GetUserId(User);
           // await _shoppingCartManager.AddToCartAsync();
            return View();
        }
    }
}
