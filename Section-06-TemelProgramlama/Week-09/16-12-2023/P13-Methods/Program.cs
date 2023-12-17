using System.Drawing;

namespace P13_Methods
{
    internal class Program
    {

        static void SelamVer()
        {
            Console.WriteLine("Günaydın");
        }

        static int KacKelime(string metin)
        {
          string[] kelimeler=  metin.Split(' ');
         
            return kelimeler.Length;
        }

        static int KelimeAdeti(string metin, string arananMetin,bool buyukKucuk)
        {
            if (!buyukKucuk)
            {
                metin = metin.ToLower();
                arananMetin = arananMetin.ToLower();
            }

            string[] kelimeler = metin.Split(' ');
            int adet = 0;
            foreach (var kelime in kelimeler)
            {
                if (kelime == arananMetin) adet++;
            }
            return adet;

        }

        static int[] SayiUret(int adet, int min, int max)
        {
            Random random = new Random();
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = random.Next(min, max);
            }
            return sayilar;
        }

        static int SesliHarfAdeti(string metin)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int sesliHarfAdeti = 0;
            metin = metin.ToLower();
            for (int i = 0; i < metin.Length; i++)
           {
                if (sesliHarfler.Contains(metin[i])) sesliHarfAdeti++;

            }
           return sesliHarfAdeti;
        }
        static int[] SesliSessizHarfAdeti(string metin)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] sessizHarfler = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };
            int sesliHarfAdeti = 0;
            int sessizHarfAdeti = 0;
            metin=metin.ToLower();

        
        
            for (int i = 0; i < metin.Length; i++)
            {
                if (sesliHarfler.Contains(metin[i]))
                {
                    sesliHarfAdeti++;
                }else if (sessizHarfler.Contains(metin[i]))
                {
                    sessizHarfAdeti++; 
                }
            }
            int[] sesliSessizHarfAdetleri = { sesliHarfAdeti, sessizHarfAdeti };
            return sesliSessizHarfAdetleri;
        }

        //içinde türkçe karakter barındırmadan tüm küçük harfleri, 0-9 arasındaki rakamları, nokta(.) işaretini, virgül(,) işaretini  (+) ve (-) işaretini barındırabilen, toplam uzunluğu 6 karakter olacak şekilde rastgele bir şifre üreten metodu yazınız.

        static string sifreUret()
        {
            string karakterler = "abcdefghijklmnoprstuvyz0123456789.,+-";
            Random random = new Random();
            string sifre = "";
            for(int i = 0; i < 6; i++)
            {
                sifre += karakterler[random.Next(0, karakterler.Length)];
            }
            return sifre;
        }

        //Şifre Üretme
        //1) Şifre mutlaka harf ile başlamalı
        //2)Şifrenin içinde mutlaka bir adet rakam olmalı.
        //3)Şifrenin içinde mutlaka bir adet özel karakter olmalı.(. , + -)
        //4) Kalan karakterler harf olmalı.
        //5)Şifre 6 karakterden oluşmalı.
        //6) Büyük harf kullanılmamalı.

        static string SifreUret2()
        {
            string harfler = "abcçdefgğhıijklmnoöprsştuüvyz";
            string rakamlar = "0123456789";
            string ozelKarakterler = ".,+-";
            char[] password = new char[6];
            Random random = new Random();

         
            password[0] = harfler[random.Next(0, harfler.Length)];


            int rakamIndex = random.Next(1, 6);
            password[rakamIndex] = rakamlar[random.Next(0, rakamlar.Length)];


            password[random.Next(1, 6)] = ozelKarakterler[random.Next(0, ozelKarakterler.Length)];


            for (int i = 1; i < 6; i++)
            {
                if (password[i] == 0) // Boş olanları harf ile doldur
                {
                    password[i] = harfler[random.Next(0, harfler.Length)];
                }
            }
   
            string olusturulanParola = new string(password);

            return olusturulanParola;
        }
    




        static void Main(string[] args)
        {
            //SelamVer();
            //Console.Write("Bir cümle giriniz...:");
            //string cumle = Console.ReadLine();
            //int kelimeSayisi=KacKelime(cumle);
            ////Console.WriteLine($"\'{cumle}\' cümlesindeki kelime sayısı: {kelimeSayisi}");
            //int adet = KelimeAdeti("Bugün çok güzel. Çok mutluyum. Çok iyiyim", "çok", false);
            //Console.WriteLine(adet);

            //int[] sayilar = SayiUret(10,1,101);
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //Console.WriteLine(SesliHarfAdeti("Pınar Alioğulları"));
            //int[] sonuc = SesliSessizHarfAdeti("Pınar");
            //Console.WriteLine($"Sesli Harf Adeti: {sonuc[0]}");
            //Console.WriteLine($"Sessiz Harf Adeti: {sonuc[1]}");

            //Console.WriteLine(sifreUret());

            string sifre=SifreUret2();
            Console.WriteLine(sifre);
            Console.ReadLine();
        }
    }
}