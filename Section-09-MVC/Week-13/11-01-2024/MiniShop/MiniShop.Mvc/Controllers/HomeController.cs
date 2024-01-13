using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Mvc.Models;
using System.Diagnostics;

namespace MiniShop.Mvc.Controllers
{
    public class HomeController : Controller
    {

       /* private readonly IProductService _productManager;

        public HomeController(IProductService productManager)
        {
            _productManager = productManager;
        }*/


        ProductManager _productManager = new ProductManager();
        public IActionResult Index()
        {
            var products = _productManager.GetAll(true);
            return View(products);
        }

    

     
    }
}
