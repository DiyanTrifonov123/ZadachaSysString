using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovdiganeNaStepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число: ");
            double number = double.Parse(Console.ReadLine());
            Console.Write("Въведи степен: ");
            int stepen = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, stepen);
            Console.WriteLine($"{number} на степен {stepen} = {result}");
        }

        private static double RaiseToPower(double number, int stepen)
        {
            double result = 0d;
            result = Math.Pow(number, stepen);
            return result;
        }
    }
}
