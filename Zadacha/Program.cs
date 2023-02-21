using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа: ");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //average
            Average(numbers);
            //print all elements on one row
            PrintAll(numbers);
            //count and print the count of zeros
            CountZeros(numbers);
            //print all elements and index on new row
            PrintNewRow(numbers);
        }

        private static void PrintNewRow(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Числото {numbers[i]} се намира на индекс {i}");
            }
        }

        private static void CountZeros(int[] numbers)
        {
            byte count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Броят на нулите в масива е {count}");
        }

        private static void PrintAll(int[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Average(int[] numbers)
        {
            Console.WriteLine($"Средно аритметично = {(double)numbers.Average()}");
        }
    }
}
