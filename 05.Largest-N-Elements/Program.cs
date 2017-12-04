using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            numbers.Sort();

            List<int> resultNumbers = new List<int>();

            for (int i = numbers.Count; i >= numbers.Count - n; i--)
            {
                resultNumbers.Add(numbers[i]);
            }

            Console.WriteLine(String.Join(" ", resultNumbers));
        }
    }
}
