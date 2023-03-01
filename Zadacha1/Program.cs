using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers count : ");
            byte n = byte.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number : ");
                int item = int.Parse(Console.ReadLine());
                numbers.Add(item);
            }

            //dobavq v sredata
            int newIndex = n / 2;
            numbers.Insert(newIndex, 6);
            //dobavqne na min element v kraq
            int min = numbers.Min();
            numbers.Add(min);
            //iztriva vsichki nuli

            while (numbers.Contains(0))
            {
               numbers.Remove(0);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

            Console.WriteLine("Numbers count is " + numbers.Count);
             
        }
    }
}
