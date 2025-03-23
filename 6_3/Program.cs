using System.Text;

namespace _6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            Console.Write("Введите год: ");
            string year = Console.ReadLine();
            Console.Write("Введите сумму продаж: ");
            double sellsum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество проданных товаров: ");
            double totalcnt = Convert.ToDouble(Console.ReadLine());
            string otbivka = new ('-', 27);

            double midcost = sellsum / totalcnt;

            Console.Clear();
            Console.WriteLine(otbivka);
            Console.WriteLine("\nОтчёт о продажах за {0} {1}\n", month, year);
            Console.WriteLine(otbivka);
            Console.WriteLine("\nОбщая сумма продаж: {0:N2} р.", sellsum);
            Console.WriteLine("\nКоличество проданных товаров: {0} шт.", totalcnt);
            Console.WriteLine("\nСредняя стоимость товара: {0:N2} р.\n", midcost);
            Console.WriteLine(otbivka);


            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
