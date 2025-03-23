using System.Text;

namespace _6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.Write("Введите Имя: ");
            sb.Append("Имя: " + Console.ReadLine() + ", ");
            Console.Write("Введите Возраст: ");
            sb.Append("Возраст: " + Console.ReadLine() + ", ");
            Console.Write("Введите Город: ");
            sb.Append("Город: " + Console.ReadLine() + ".");

            Console.WriteLine(sb);
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
