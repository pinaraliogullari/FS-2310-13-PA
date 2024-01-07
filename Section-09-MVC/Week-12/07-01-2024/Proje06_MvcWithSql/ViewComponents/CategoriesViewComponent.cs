using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.ViewComponents

{
    public class CategoriesViewComponent : ViewComponent
    {
        public async Task <IViewComponentResult> InvokeAsync()
        {
            Db.OpenCn();
             string queryString = @"select 
                             c.CategoryID as Id,
                             c.CategoryName as Name
                       from Categories c"
            ;


            SqlCommand cmd = new SqlCommand(queryString, Db.connection);     //SqlAdaptere alternatif olarak; çalıştırma sürecine bu yöntemle daha çok karışabilriiz.
            SqlDataReader reader = cmd.ExecuteReader();
            List<CategoryViewModel> categories = new List<CategoryViewModel>();
            CategoryViewModel category = null;
            while (reader.Read())
            {
                category = new CategoryViewModel
                {
                    Id = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString()
                };
                categories.Add(category);
            }
            Db.CloseCn();
            return View(categories);


        }
    }
}
