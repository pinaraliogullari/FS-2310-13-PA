namespace MiniShop.MVC.Areas.Admin.Models
{
    public class DeleteProductViewModel
    {
        //burada da display name kullanabilir miyiz
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
