using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ResponseDTOs
{



    //kullanıcı endpointi hatalı yazabilir/hatalı bir istekte bulunabilir. O durumda da bir cevap dönmemiz gerekir.(200,201,404 vs)
    //aşağıdaki metotlar eğer varsa hataları  ve dataları beraber dönen nesneler üretir.
    //response ı newlememek için metotlar static.
    public class Response<T>
    {
        public T Data { get; set; }
        public List<string>  Errors { get; set; }
      
        public int statusCode { get; set; }
        public bool IsSucceeded { get; set; }



        /// <summary>
        /// Vu metot, yapılan işlemin başarılı olduğu durumlarda başarılı bir cevapla birlikte üretilen datayı ve status code u döndürmek için kullanılır.
        /// </summary>
        /// <param name="data">Geriye döndürülecek veri</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200,201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(T data, int statusCode) 
        {

            return new Response<T>
            {
                Data = data,
                statusCode = statusCode,
                IsSucceeded = true

            };


        }
        /// <summary>
        /// Bu metot, işlemin başarılı ifade eden bir status code döndürmek için kullanılır.
        /// </summary>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200,201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T>Success(int statusCode)
        {
            return new Response<T>
            {
                Data = default(T),  //boş bir nesne döndürecek.
                statusCode = statusCode,
                IsSucceeded = true
            };
        }
        /// <summary>
        /// Bu metot, geriye başarısız bir cevap olarak bir hata listesini döndürmek için kullanılır.
        /// </summary>
        /// <param name="errors">Hata metni</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200,201 vb)</param>
        /// <returns>zResponse<typeparamref name="T"/></returns>
        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T>
            {
                Errors = errors,
                statusCode = statusCode,
                IsSucceeded = false
            };
        }
        /// <summary>
        /// Bu metot, geriye başarısız bir cevap olarak içinde bir hata olan hata listesini döndürmek için kullanılır.
        /// </summary>
        /// <param name="error">Hata metni</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200,201 vb)</param>
        /// <returns>zResponse<typeparamref name="T"/></returns>
        public static Response<T> Fail(string error, int statusCode) 
        {
            return new Response<T>
            {
                Errors = new List<string> { error },
                statusCode = statusCode,
                IsSucceeded = false
            };
        
        }
    }
}
