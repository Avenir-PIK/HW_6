using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;

namespace _6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания, разделитель - пробел");
            string vvod = Console.ReadLine();
            string reverse = string.Empty;

            string normal = vvod.Replace(" ", "");
            normal = normal.ToLower();

            for (int i = normal.Length - 1; i >= 0; i--)
            {
                reverse += normal[i];
            }

            Console.WriteLine("\n{0} - исходное предложение", normal);
            Console.WriteLine("\n{0} - реверсивное предложение", reverse);

            if (reverse == normal)
            {
                Console.WriteLine("\nУРА! Это полиндром ! =)");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
