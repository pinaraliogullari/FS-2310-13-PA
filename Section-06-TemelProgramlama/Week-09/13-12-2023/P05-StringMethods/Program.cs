namespace P05_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringMethods

            //string name = "halil Umut MELER";
            //int len = name.Length;
            //Console.WriteLine(name + " değerinin uzunluğu: " + len + " karakterdir.");
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());

            //string m1 = "Bahçeşehir";
            //string m2 = "Üniversitesi";
            //int year = 1996;
            //Console.WriteLine(m1+ " " + m2);
            //Console.WriteLine(String.Concat(m1," ", m2));
            //string result = $"{m1} {m2}";
            //string result2 = $"{m1} {m2} {year} yılında kurulmuştur"; 
            //Console.WriteLine(result2);

            //string name = "Ece";
            //int age = 13;
            //string school = "Yeditepe İÖO";
            //string result = $"Ad: {name}\nYas: {age}\nOkul: {school}";
            //Console.WriteLine(result);
            //Console.WriteLine($"{name}\t{age}\t{school}");

            //string courseName = "FullStack Web Developer Eğitimi";
            //string findText = "web";
            //bool result = courseName.ToLower().Contains(findText.ToLower());
            //Console.WriteLine(result);

            //string name = "Zeyno";
            //Console.WriteLine(name.IndexOf("y"));
            //Console.WriteLine(name.StartsWith("A"));
            //Console.WriteLine(name.EndsWith("no"));

            //string school = "Yeditepe İlköğretim Mektebi";
            //string result=school.Replace("Mektebi", "Okulu");

            //string title = "C#'ta Metinsel İşlemler";
            //Console.WriteLine(title.Replace("","-").ToLower());
            //string text = "Bugün hava çok güzeldi. Ama akşama doğru, hava bozdu. Öyle bozdu, öyle bozdu ki. Daha da bozmaz dedik, daha da bozdu. Bozdukça bozdu.";
            //Console.WriteLine(text.Replace(",", "").Replace(".",""));//metinden virgül ve noktaları kaldırır.


            string title = "Tesla, 2 milyon'dan fazla aracı otopilot yazılımını güncellemek için geri çağıracak!";
            Console.WriteLine(title);
            title = title.ToLower();
            title = title.Replace(" ", "-");
            title = title.Replace(",", " ");
            title = title.Replace("ı", "i");
            title = title.Replace("ç", "c");


            Console.WriteLine(title);
       


            #endregion

            Console.ReadLine();
        }
    }
}