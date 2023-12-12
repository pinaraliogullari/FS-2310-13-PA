namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes
            //C#'ta veri tipleri çok önemlidir. Çeşitli veri tipleri bulunmaktadır. Özellikle sayılar ve sayı olmayanlar şeklinde incelemek iyi olacaktır.
            //TAM SAYILAR
            byte sayi1 = 255; //0 dan 255 e kadar değer alır. 1 byte 8 bittir.(11111111)Negatif değer alamaz.
            sbyte sayi2 = 15;

            Console.WriteLine(sayi1 +  " sayısının alabileceği min değer: " + byte.MinValue);
            Console.WriteLine(sayi1 + " sayısının alabileceği max değer: " + byte.MaxValue);
            Console.WriteLine(sayi1 + " sayısının bellekte kapladığı alan: " + sizeof(byte) + "byte");


            Console.WriteLine(sayi2 + "-" + sizeof(sbyte) + "byte");


            #endregion

            Console.ReadLine();
        }
    }
}