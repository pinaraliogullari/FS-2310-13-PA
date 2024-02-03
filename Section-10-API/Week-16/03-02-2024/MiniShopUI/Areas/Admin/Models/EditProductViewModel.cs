using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.MVC.Areas.Admin.Models
{
    public class EditProductViewModel
    {

        public int Id { get; set; }

        [JsonPropertyName("Name")]
        [DisplayName("�r�n")] //bunu yapma sebebimiz merkezi bir yerden isimleri kontrol etmek istememiz. bir �ok yerde varsa her yerden de�i�tirmemize gerek kalmaz. 
        [Required(ErrorMessage = "{0} alan� bo� b�rak�lamaz.")]   //validation i�in mvcnin bize sundu�u data annotai�n� kullanaca��z. ba�ka yollar� da var.
        [MinLength(5,ErrorMessage ="{0} alan�na uzunlu�u {1} karakterden k���k de�er girilemez.")]


        public string Name { get; set; }


        [JsonPropertyName("Properties")]//Jsondan glen keyin ad�
        [DisplayName("�r�n �zellikleri")] //g�r�necek olan isim
        public string Properties { get; set; } //benim tercih etti�im isim 

        
        [JsonPropertyName("Price")]
        [DisplayName("�r�n Fiyat�")]
        [Required(ErrorMessage = "{0} alan� bo� b�rak�lamaz.")]
        public decimal? Price { get; set; }


        [JsonPropertyName("ImageUrl")]
        [DisplayName("Resim")]
        public string ImageUrl { get; set; } 


        [JsonPropertyName("Url")]
        public string Url { get; set; }

        
        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif �r�n")]
        public bool IsActive { get; set; }

        
        [JsonPropertyName("IsHome")]
        [DisplayName("Ana Sayfa �r�n�")]
        public bool IsHome { get; set; }


        [JsonPropertyName("CategoryIds")]
        public List<int> CategoryIds { get; set; }


        [DisplayName("Kategoriler")]
        public List<CategoryViewModel> Categories { get; set; }
    }
}