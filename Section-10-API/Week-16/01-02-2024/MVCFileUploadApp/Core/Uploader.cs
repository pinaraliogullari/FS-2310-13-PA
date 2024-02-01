namespace MVCFileUploadApp.Core
{
    public class Uploader
    {
        public static string UploadImage(IFormFile image)
        {
            //dosyaismi.uzantı
            //manzara.kadikoy.png=[manzara, kadikoy,png]
            //Örnek image ismi: iphone12.png


            var extension="." + image.FileName.Split('.')[image.FileName.Split('.').Length-1];// sonuc olarak .png verecek.

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");//localhost:5000/wwwroot/images
            if(!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

           
            var fileName=$"{Guid.NewGuid().ToString()} {extension}";  //hasgdasdjgj.png
            var path=Path.Combine(filePath, fileName); //localhost:5000/wwwroot/images/hasgdasdjgj.png
            using (var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return fileName;
        }
    }
}
