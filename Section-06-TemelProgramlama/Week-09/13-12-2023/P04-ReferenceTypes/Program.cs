namespace P04_ReferenceTypes
{
     class Product
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //int number1=5;
            //Console.WriteLine(number1);

            Random random = new Random();
            int sayi1 = random.Next();
            Console.WriteLine(sayi1);


         

            Console.ReadLine();

            Product urun1 = new Product();

        }
    }
}