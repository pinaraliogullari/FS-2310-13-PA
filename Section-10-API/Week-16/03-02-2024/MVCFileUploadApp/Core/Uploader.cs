namespace MVCFileUploadApp.Core
{
    public static class Uploader
    {
        public static string UploadImage(IFormFile image)
        {
            //dosyaismi.uzantı
            //manzara.kadikoy.png = [manzara,kadikoy,png]
            //Örnek image ismi: iphone12.png


            //.png
            var extension = "." + image.FileName.Split('.')[image.FileName.Split('.').Length - 1];
            
            //localhost:5000/wwwroot/images
            var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","images");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            //aksdahjflkasdhldskafjhladksfhjladskfjhasdklfsadj.png
            var fileName = $"{Guid.NewGuid()}{extension}";
            //localhost:5000/wwwroot/images/aksdahjflkasdhldskafjhladksfhjladskfjhasdklfsadj.png
            var path = Path.Combine(filePath, fileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            };
            return fileName;
        }
    }
}
