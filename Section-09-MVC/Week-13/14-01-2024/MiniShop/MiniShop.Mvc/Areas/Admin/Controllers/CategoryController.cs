using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Core.ViewModels;

namespace MiniShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;

        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            var categories = _categoryManager.GetAll( false, false);
            return View(categories);
           
        }

        public IActionResult Create()
        {
          
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(CategoryViewModel categoryViewmodel)
        {
            //burada viewe veri gitmiyor. form aracılığıyla modelbinding yöntemiyle viewden veri geliyor.ve dbye kaydeedilmek üzere categorymanagerdaki create metoduna gönderiliyor.
            _categoryManager.Create(categoryViewmodel);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {

            CategoryViewModel editedCategory = _categoryManager.GetCategoryById(id);
            return View(editedCategory);

        }
        [HttpPost]
        public IActionResult Edit(CategoryViewModel editCategory)
        {

            //burada viewe veri gitmiyor. form aracılığıyla modelbinding yöntemiyle viewden veri geliyor.ve dbye kaydeedilmek üzere categorymanagerdaki update metoduna gönderiliyor.
            _categoryManager.Update(editCategory);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            //silinecek kategori bilgilerini olduğu viewi gösteren yer 
            CategoryViewModel deletedCategory = _categoryManager.GetCategoryById(id);
            return View(deletedCategory);
        }

        public IActionResult HardDelete(int id)
        {
            _categoryManager.HardDelete(id);
            return RedirectToAction("Index");

        }

        public IActionResult SoftDelete(int id)
        {
            _categoryManager.SoftDelete(id);
            return RedirectToAction("Index");

        }


    }
}
