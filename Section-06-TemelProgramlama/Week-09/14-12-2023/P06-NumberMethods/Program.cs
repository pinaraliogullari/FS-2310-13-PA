namespace P06_NumberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 40;
            //int number2 = 60;
            //Console.WriteLine($"En Küçük: {Math.Min(number1,number2)}");
            //Console.WriteLine($"En Büyük: {Math.Max(number1, number2)}");

            //int sayi = 4;
            //int us = 2;
            //int sonuc = Convert.ToInt32(Math.Pow(sayi, us));
            ////double sonuc2=Math.Pow(sayi,us);
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Bir sayı giriniz: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir sayı giriniz: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number1+number2);

            //Console.Write("Taban sayıyı giriniz: ");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Us sayıyı giriniz: ");
            //int us = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{taban} sayısının {us}. kuvveti: {Math.Pow(taban,us)}");

            double sayi = 5.493486;
            Console.WriteLine(sayi);
            Console.WriteLine($" Ceiling:{ Math.Ceiling(sayi)}");
            Console.WriteLine($" Floor:{Math.Floor(sayi)}");
            Console.WriteLine($" Round:{Math.Round(sayi)}");
            Console.WriteLine($" Round2:{Math.Round(sayi,2)}");




            Console.ReadLine();
        }
    }
}