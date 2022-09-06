using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch(new int[] { 1, 2, 3 }, 3);
            Console.ReadLine();
        }
        public static void BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;                                                                    
            int max = inputArray.Length - 1;                                                
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    Console.WriteLine("Индекс числа {0} в массиве равен {1}", 3, mid);
                    break;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
        }
    }
}
//O(log n) — логарифмическая сложность