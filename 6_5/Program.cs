using System.Text;
using System.Text.RegularExpressions;

namespace _6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Корректный номер имеет формат: +7(XXX)XXX-XX-XX");
            string[] test =
            {
                "+7-999-777-00-00", "+7(967)", "+7(999)888-77-66", " а тут вообще буковки одни"
            };

            string filtrik = @"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$";
            Regex reg = new Regex(filtrik);

            foreach (string str in test)
                if (reg.IsMatch(str))
                    Console.WriteLine("{0} - ok", str);
                else
                    Console.WriteLine("{0} -  не ok", str);

            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}