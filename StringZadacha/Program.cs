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
            //int sum = 0;
            int[] sumsCharCode = new int[Math.Max(str1.Length, str2.Length)];
            sumsCharCode = MultiplyAllChars(str1, str2,sumsCharCode);
            int finalResult = SumAllCodes(sumsCharCode);

            //int length = Math.Min(str1.Length, str2.Length);

            //for (int i = 0; i < length; i++)
            //{
            //    sumsCharCode[i] = (int)str1[i] * (int)str2[i];
            //}

            //for (int j = length; j < sumsCharCode.Length; j++)
            //{
            //    if (str1.Length > str2.Length)
            //    {
            //        sumsCharCode[j] = (int)str1[j];
            //    }
            //    else
            //    {
            //        sumsCharCode[j] = (int)str2[j];
            //    }
            //}

            Console.WriteLine($"Умножението на char-овете: {string.Join(", ", sumsCharCode)}");
            Console.WriteLine($"Сборът на char-овете е {finalResult}");
        }

        private static int SumAllCodes(int[] sumsCharCode)
        {
            int result = 0;
            for (int i = 0; i < sumsCharCode.Length; i++)
            {
                result = result + sumsCharCode[i];
            }
            return result;
        }

        private static int[] MultiplyAllChars(string str1, string str2, int[] sumsCharCode)
        {
            int length = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < length; i++)
            {
                sumsCharCode[i] = (int)str1[i] * (int)str2[i];
            }

            for (int j = length; j < sumsCharCode.Length; j++)
            {
                if (str1.Length > str2.Length)
                {
                    sumsCharCode[j] = (int)str1[j];
                }
                else
                {
                    sumsCharCode[j] = (int)str2[j];
                }
            }
            return sumsCharCode;
        }
    }
}
