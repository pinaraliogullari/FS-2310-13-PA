using System.Collections;

namespace P12_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DİZİ TANIMLAMA VARYASYONLARI
            //int[] numbers = new int[3];
            //int[] ages = new int[3] { 5, 3, 15 };
            //int[] sizes = { 5, 3, 2, 4, 5, 6, 7, 8 };

            //Console.WriteLine(sizes[3]);

            //int[] sayilar = new int[50];
            //Random rnd = new Random();
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = rnd.Next(1, 101);
            //}

            //ArrayList tekSayilar = new ArrayList();
            //ArrayList ciftSayilar = new ArrayList();

            //foreach(int sayi in sayilar)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        ciftSayilar.Add(sayi);
            //    }
            //    else
            //    {
            //        tekSayilar.Add(sayi); 
            //    }
            //}
            //Console.WriteLine($"Çift Sayı Adeti: {ciftSayilar.Count}");
            //Console.WriteLine($"Tek Sayı Adeti: {tekSayilar.Count}");


            //üretilen 50 sayının 25 i tek 25 i çift olsun .
            int[] tekSayilar = new int[25];
            int[] ciftSayilar = new int[25];

            Random rnd = new Random();
            for (int i = 0; i < 25; i++)
            {
                int sayi = 0;
                do
                {
                    sayi = rnd.Next(1, 101);
                } while (sayi % 2 == 0);
                tekSayilar[i] = sayi;
                do
                {
                    sayi = rnd.Next(1, 101);
                } while (sayi % 2 == 1);
                ciftSayilar[i] = sayi;
            }

            Console.WriteLine("Tek sayılar");
            foreach (int i in tekSayilar)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Çift sayılar");

            foreach (int i in ciftSayilar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}