namespace P07_DateTimeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);
            //DateTime birthday = new DateTime(1975, 7, 16);
            //Console.WriteLine(birthday.ToShortDateString());
            //Console.WriteLine(birthday.ToLongDateString());
            //DateTime today = DateTime.Now;
            //Console.WriteLine(today.ToShortTimeString());
            //Console.WriteLine(today.ToLongTimeString());

            //Gelecek yılın ilk gününün tarihini bulduran kodu yazıyoruz.
            //int year = DateTime.Now.Year+1;
            //int month = 1;
            //int day = 1;
            //DateTime resultDate = new DateTime(year, month, day);
            //Console.WriteLine(resultDate.ToLongDateString());

            //Tam bir yıl sonraki aynı günün tarihini bulduran kodu yazınız.
            DateTime today = DateTime.Today;
            int year = today.Year + 1;
            int month = today.Month;
            int day = today.Day;

            DateTime resultDate = new DateTime(year, month, day);
            Console.WriteLine(resultDate.ToLongDateString());




            //ARAŞTIRMA ÖDEVİ: C# ta tarihlerle ilgili yapılabilecek işlemleri araştırnız.
            //3 ay sonrasını veren bir fonk var mı mesela?
            Console.ReadLine();
        }
    }
}