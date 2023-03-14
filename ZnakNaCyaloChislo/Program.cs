using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnakNaCyaloChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число: ");
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        private static void PrintSign(int number)
        {
            if (number>0)
            {
                Console.WriteLine($"Числото {number} положително.");
            }
            else if (number<0)
            {
                Console.WriteLine($"Числото {number} отрицателно.");
            }
            else
            {
                Console.WriteLine($"Числото {number} е нула.");
            }
        }
    }
}
