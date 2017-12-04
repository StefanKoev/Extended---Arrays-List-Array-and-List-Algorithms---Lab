using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Numbers_at_Odd_Positins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string prefix = "Index";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0 && numbers[i] % 2 != 0)
                {
                    Console.WriteLine($"{prefix} {i} -> {numbers[i]}");
                }
            }
        }
    }
}
