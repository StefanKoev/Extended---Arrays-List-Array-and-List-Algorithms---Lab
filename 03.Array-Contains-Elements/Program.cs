using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Array_Contains_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (n == numbers[i])
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
