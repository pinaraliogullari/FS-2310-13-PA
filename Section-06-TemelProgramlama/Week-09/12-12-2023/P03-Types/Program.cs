using System.Collections.Concurrent;

namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TAMSAYILAR
            //C#'ta veri tipleri çok önemlidir. Çeşitli veri tipleri bulunmaktadır. Özellikle sayılar ve sayı olmayanlar şeklinde incelemek iyi olacaktır.
            //TAM SAYILAR
            //byte sayi1 = 255; //0 dan 255 e kadar değer alır. 1 byte 8 bittir.(11111111)Negatif değer alamaz.
            //sbyte sayi2 = 15;


            //Console.WriteLine(sayi1.GetType());
            //Console.WriteLine(sayi1 +  " sayısının alabileceği min değer: " + byte.MinValue);
            //Console.WriteLine(sayi1 + " sayısının alabileceği max değer: " + byte.MaxValue);
            //Console.WriteLine(sayi1 + " sayısının bellekte kapladığı alan: " + sizeof(byte) + "byte");

            //işaretsiz
            //byte sayi1 = 10;
            //ushort sayi2 = 10;
            //uint sayi3 = 40;
            //ulong sayi4 = 50;

            ////işaretli
            //sbyte sayi5 = -50;
            //short sayi6 = -6;
            //int sayi7 = -7;
            //long sayi8 = -8;

            //Console.WriteLine(ulong.MinValue);
            //Console.WriteLine(ulong.MaxValue);
            //Console.WriteLine(sizeof(ulong) + " byte");



            #endregion

            #region ONDALIKLI SAYILAR
            //float sayi1 = 56.7F;
            //double sayi2 = 56.78;
            //decimal sayi3 = 76.669M;

            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(sizeof(float) + " byte");
            //Console.WriteLine(sayi1.GetType());
            //Console.WriteLine();
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(sizeof(double) + " byte");
            //Console.WriteLine();
            //Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(decimal.MaxValue);
            //Console.WriteLine(sizeof(decimal) + " byte");






            #endregion

            #region METİN VE KARAKTERLER
            //char answer = 'A';
            //string name = "Ali Veli";
            //Console.WriteLine(answer + " tipi: " + answer.GetType() +"-Min" + char.MinValue);
            //Console.WriteLine(name);




            #endregion

            #region MANTIKSAL

            //bool isActive = true;
            //Console.WriteLine(isActive);


            #endregion

            #region TARİH 
            //DateTime birthday = new DateTime(1975, 7, 16);
            #endregion

            Console.ReadLine();

        }
    }
}