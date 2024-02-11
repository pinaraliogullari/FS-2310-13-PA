using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.UI.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _categoryManager.GetTopCategories(3);
            return View(response.Data);
        }
    }
}
