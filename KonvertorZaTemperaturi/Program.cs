using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonvertorZaTemperaturi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи градуси по фаренхайт: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsium = FahrenheitToCelsium(fahrenheit);
            Console.WriteLine($"Градусите по Целзий: {celsium:f2}");
        }

        private static double FahrenheitToCelsium(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
