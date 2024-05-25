using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 6;
            List<string> values = new List<string>();
            List<string> values_terminal = new List<string>();
            List<double> final_values = new List<double>();

            double v = n - 1;
            double factorial_value = 1;

            for (int i = 1; i <= v; i++)
            {
                factorial_value *= i;
                if (i < v)
                {
                    values.Add($"{i} *");
                }
                else
                {
                    values.Add($"{i}");
                }

            }
            values_terminal.Add($"({n} - 1)!");
            final_values.Add(factorial_value);

            Console.Write("The Series Shown: ");
            foreach (var item in values_terminal)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("The values Shown: ");
            foreach (var item in values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of these values: gamma({n}) ==> {final_values.Sum()}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
