using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <ulong> numbers = new List<ulong>();
            numbers.Add(1);
            numbers.Add(1);

            Console.Write("Enter count of Fibonacci numbers : ");
            byte n = byte.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                numbers.Add(numbers[i - 1] + numbers[i - 2]);
            }

            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
