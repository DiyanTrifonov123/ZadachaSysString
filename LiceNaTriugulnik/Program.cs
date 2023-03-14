using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceNaTriugulnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи ширината: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Въведи височината: ");
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, height);
            Console.WriteLine($"Лицето на триъгълника е {area} cm.");
        }

        private static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
