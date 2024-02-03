namespace MiniShop.MVC.Extensions
{
    //Imagei parçalı bir yapıya dönüştüreceğiz.Yani resmi sayısal değere dönüştürüyoruz.  OpenReadStream classını extend edeceğiz. İçersinde extend etme işlemi olan bir sınıf yazıyorsak bu class static olmak zorunda.
    public static class ConvertImage
    {
        public static byte[] ToByteArray( this Stream stream)//bu uygulamanın içindeki stream classı artık bu metodu da içeriyor.
        {
            byte[] buffer= new byte[16 * 1024];
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
