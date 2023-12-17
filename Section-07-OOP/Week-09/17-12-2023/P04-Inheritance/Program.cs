namespace P04_Inheritance
{
    public class Alive
    {
        public string Category { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //eğer bu metodun miras alan sınıflarda yeniden yazılabilmesine izin vermek istiyorsak virtual keywordü ile işaretleriz.
        virtual public void Intro()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}");
        }
    }

    public class Student: Person
    {
        public int StudentNumber { get; set; }
    }

    public class Teacher : Person
    {
        public string Branch { get; set; }
        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName} Branch: {Branch}");
        }


    }




    public class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            //Teacher teacher = new Teacher();
            //teacher.FirstName = "Pinar";
            //teacher.LastName = "Aliogullari";
            //teacher.Branch = "Fizik";
            //teacher.Intro();

            Base nesne = new Base();
            
   
            Console.ReadLine();
        }
    }
}