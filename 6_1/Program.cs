using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания, разделитель - пробел");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            int max = 0;
            string bigword = string.Empty;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    bigword = word;
                }
            }
                Console.WriteLine("\nСамое длинное слово: {0}\nСостоит из {1} букв", bigword, max);
                Console.WriteLine("\nPress any key to continue");

                Console.ReadKey();
            }
        }
    }
