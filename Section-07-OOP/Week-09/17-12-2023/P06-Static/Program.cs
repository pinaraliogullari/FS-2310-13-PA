using P06_Static.Helper;
namespace P06_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

         

            string name = "Alex?de?Sauza";
            //HelperMethods helper = new HelperMethods();
            //Console.WriteLine(helper.EditText(name)); ;

            Console.WriteLine(HelperMethods.EditText(name)); ;

            Console.ReadLine();

        }
    }
}