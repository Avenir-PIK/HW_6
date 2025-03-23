using System.Text.RegularExpressions;

namespace _6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // про группы узнал на https://stackoverflow.com/questions/2370015/regular-expression-for-password-validation
            // протестировал на https://regex101.com/
            string pass = string.Empty;
            string filtrik = @"^.*(?=.{14,})(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!#;%:?*]).*$";
            Regex reg = new Regex(filtrik);
            int attemp = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("{0} раз введён неподходящий пароль", attemp);
                Console.WriteLine("Пароль должен состоять минимум из 14 символов и иметь в составе минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*");
                Console.WriteLine("Введите пароль");
                pass = Console.ReadLine();
                attemp++;
                if (reg.IsMatch(pass)) break;
            }
            Console.Clear();
            Console.WriteLine("Пароль\n{0}\nподходит под требования", pass);
            Console.WriteLine("\nВам потребовалось {0} попыток, чтобы придти к успеху", attemp);
            Console.WriteLine("\nPress any key to continue\n");
            Console.ReadKey();
        }
    }
}
