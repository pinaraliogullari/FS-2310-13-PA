﻿namespace MiniShop.Mvc.Models
{
    //buradaki view modal kullanım amacı: kullanıcıya sunmak istediğimiz bilgileri düzenlemek. ama benim bildiğim view modal: birden fazla nesne gönderiminde kullanılan bir yol.
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Properties { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

    }
}
