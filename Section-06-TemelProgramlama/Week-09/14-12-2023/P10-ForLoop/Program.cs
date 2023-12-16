namespace P10_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Intro
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}
            #endregion

            #region ForEach
            //string[] names = { "Ayşenur", "Zeynep", "Ece", "Ferda", "Murat" };
            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] newNumbers = new int[5];
            //int index = 0;
            //foreach (int number in numbers)
            //{
            //    newNumbers[index] = number*2;
            //    index++;
            //}

            //Klavyeden girilecek bir sayıya kadar olan sayıların içinden kaç tanesinin çift kaç tanesinin de 3 ün katı olduğunu yazdıralım.

            Console.Write("Lütfen bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int countCift = 0;
            int countThree = 0;

            for (int i = 0; i <= number; i++) 
            {
                if (i % 2 == 0) countCift++;
                if (i % 3 == 0) countThree++;

            }
            Console.Clear();
            Console.WriteLine("sonuç");
            Console.WriteLine("----------");
            Console.WriteLine($"0-{number} arasındaki çift sayıların adeti: {countCift}");
            Console.WriteLine($"0-{number} arasındaki üçün katı sayıların adeti: {countThree}");


            #endregion


            Console.ReadLine();
        }
    }
}