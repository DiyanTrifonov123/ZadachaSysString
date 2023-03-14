using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGolqmaOtDveStoinosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи тип: ");
            string type = Console.ReadLine();
            if (type == "int")
            {
                Console.Write("Въведи първото число: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("Въведи второто число: ");
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine($"По-голямото число е {max}");
            }
            else if (type == "char")
            {
                Console.Write("Въведи първия символ: ");
                char first = char.Parse(Console.ReadLine());
                Console.Write("Въведи втория символ: ");
                char second = char.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine($"По-големия символ е {(char) max}");
            }
            else if (type == "string")
            {
                Console.Write("Въведи първия низ от символи: ");
                string first = Console.ReadLine();
                Console.Write("Въведи втория низ от символи: ");
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine($"По-големия низ от символи е {max}");
            }
        }
        private static string GetMax(string first, string second)
        {
            string result = "";
            if (first.CompareTo(second) >= 0)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
            }
        }


            private static int GetMax(char first, char second)
        {
            int result = 0;
            if ((int) first > (int) second)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
            }
        }

            private static int GetMax(int first, int second)
        {
            int result = 0;
            if (first> second)
            {
                result = first;
                return result;
            }
            else
            {
                result = second;
                return result;
            }
        }
    }
}
