namespace P09_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Intro

            //Console.WriteLine("Yaş: ");
            //int yas = int.Parse(Console.ReadLine());
            //if (yas>=18)
            //{
            //    Console.WriteLine("Giriş yapabilirsisniz");
            //}
            //else
            //{
            //    Console.WriteLine("Giremezsiniz");
            //}
            #endregion

            #region Tek Satırlık If
            //if(true) Console.WriteLine("Doğru");
            #endregion

            #region If-ElseIf
            //int age = 45;
            //if(age<18)
            //{
            //    Console.WriteLine("Çocuk");
            //}else if(age<40)
            //{
            //    Console.WriteLine("genç");
            //}
            //else
            //{
            //    Console.WriteLine("yaşlı");
            //}


            #endregion

            #region SwitchCase
            //int x = 25;
            //switch (x)
            //{
            //    case 5:
            //        Console.WriteLine("Bugün ayın beşi");
            //        break;
            //    case 10:
            //        Console.WriteLine("Bugün ayın onu");
            //        break;
            //    case 15:
            //        Console.WriteLine("Bugün ayın onbeşi");
            //        break;
            //    case 20:
            //        Console.WriteLine("Bugün ayın yirmisi");
            //        break;
            //    case 25:
            //        Console.WriteLine("Bugün ayın yirmibeşi");
            //        break;
            //    case 30:
            //        Console.WriteLine("Bugün ayın otuzu");
            //        break;
            //    default:
            //        Console.WriteLine("söylenecek bir şey yok");
            //        break;
            //}
            #endregion

            #region SwithCase
            int x = 11;
            switch (x)
            {
                case 5:
                case 10:
                case 15:
                case 20:
                case 25:
                case 30:
                    Console.WriteLine("Beşin katı...");
                    break;
                default:
                    Console.WriteLine("Söylenecek bir şey yok...");
                    break;

            }
            #endregion

            Console.ReadLine();
        }
    }
}