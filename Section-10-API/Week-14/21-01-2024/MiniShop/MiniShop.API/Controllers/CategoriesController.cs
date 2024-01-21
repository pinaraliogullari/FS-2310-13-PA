using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs;
using System.Text.Json;

namespace MiniShop.API.Controllers
{
    //localhost:5000/api/Categories
    //[Route("[controller]/[action]")]

    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryManager.GetAllAsync();
            var jsonResponse=JsonSerializer.Serialize(response);
            return Ok(jsonResponse); 
        }

        [HttpGet("getnondeleted/{isDeleted?}")]
        public async Task<IActionResult> GetNonDeleted( bool isDeleted=false)
        {
            var response = await _categoryManager.GetIsDeletedCategories(isDeleted);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpGet("getactives/{isActive?}")]
        public async Task<IActionResult> GetActives(bool isActive = true)
        {
            var response = await _categoryManager.GetIsActiveCategories(isActive);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }


        [HttpGet("getwithproducts")]
        public async Task<IActionResult> GetWithProducts()
        {
            var response = await _categoryManager.GetAllCategoriesWithProductAsync();
            var jsonResponse=JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("getbyid/{id}")] //buralarda aslında isteğin patternini tanımlamış oluyoruz. yani istek yapılırken endpoint böyle olsun diyoruz.
        public async Task <IActionResult>GetById(int id)
        {
            var response = await _categoryManager.GetByIdAsync(id);
            var jsonResponse=JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("add")] 
        public async Task<IActionResult> Create(AddCategoryDTO addCategoryDTO)
        {
            var response = await _categoryManager.CreateAsync(addCategoryDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPut("update")] //bu metot güncelleme işlemlerinde kullanılır.
        public async Task<IActionResult> Update(EditCategoryDTO editCategoryDTO)
        {
            var response = await _categoryManager.UpdateAsync(editCategoryDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("harddelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _categoryManager.HardDeleteASync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("softdelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _categoryManager.SoftDeleteASync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        
    }
}
