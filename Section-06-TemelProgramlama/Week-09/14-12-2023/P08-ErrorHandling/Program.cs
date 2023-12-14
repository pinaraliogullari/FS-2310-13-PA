namespace P08_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Intro
            /*
           * Uygulamalarımı çalıştıkları esnada birtakım hatalardan dolayı durabilir. Bu tür hatalaraRuntime errors (Çalışma zamanı hataları) denir.
           * Run Time Errors'ı kontrol altına alabilmek için try-catch-finaly yapısını kullanacağız.
           */

            /*
             * try
             * {
             * çalışmasını beklediğimiz kodları buraya yazacağız. yani hata verme olasılığı olan kodlar.Dolayısıyla buraya yazdığımız kodları şu şekilde düşünebiliriz. Bu kodları çalıştırmayı dene.Çalışıyorsa hiçbir sorun olmadan devam eder, yani catch scope unu atlar, yani çalıştırmaz. Çalışmıyorsa /hata varsa catch scope una geçer..
             * }
             * catch
             * {
             * Eğer try scope undaki kodda bir hata meydana gelirse bu bölümdeki kodlar çalışır.
             * }
             * 
             * finally
             * {
             * try ya da catch scıpelarından hangisi çalışmış olursa olsun her halükarda bu kısımda yazılan kodlar çalıştırılır.
             * }
             */
            #endregion

            #region Example01
            //Console.Write("Lütfen karesi alınacak sayıyı giriniz: ");
            //try
            //{
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int sonuc = Convert.ToInt32(Math.Pow(sayi, 2));
            //    Console.WriteLine("sonuc");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //Console.WriteLine("Hata yaptınız. Yeniden deneyiniz.");
            //}
            #endregion

            #region Example2
            try
            {
                Console.Write("Bölünen: ");
                int bolunen = int.Parse(Console.ReadLine());
                Console.Write("Bölen: ");
                int bolen = int.Parse(Console.ReadLine());
                int sonuc = bolunen / bolen;
                Console.WriteLine($"{bolunen}/{bolen}={sonuc}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("0 a bölme yapılamaz!");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata var");

            }
            #endregion

            Console.ReadLine();
        }
    }
}