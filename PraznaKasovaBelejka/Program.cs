using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraznaKasovaBelejka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        private static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        private static void PrintReceiptFooter()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        private static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to _______________");
            Console.WriteLine("Received by _______________");
        }

        private static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("---------------------------------------");
        }
    }
}
