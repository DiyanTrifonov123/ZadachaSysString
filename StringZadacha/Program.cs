using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи два символни низа разделени със Space: ");
            string[] str = Console.ReadLine().Split().ToArray();
            string str1 = str[0];
            string str2 = str[1];
            int result = CharCodes(str1, str2);
            Console.WriteLine($"Сборът на string-овете е: {result}");
        }

        private static int CharCodes(string str1, string str2)
        {
            int length = Math.Max(str1.Length, str2.Length);
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                int charCode1 = i < str1.Length ? (int)str1[i] : 1;
                int charCode2 = i < str2.Length ? (int)str2[i] : 1;
                sum += charCode1 * charCode2;
            }

            return sum;
        }
    }
}
