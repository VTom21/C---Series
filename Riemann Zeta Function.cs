using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponential_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();
            List<string> values_terminal = new List<string>();
            List<double> final_values = new List<double>();
            double n = 1;
            double s = 2;
            int counter = 0;
            Console.Write("Write a value: ");
            int series = Int32.Parse(Console.ReadLine());
            while (counter < series)
            {
                double result = 1 / Math.Pow(n, s);
                if (counter != series - 1)
                {
                    string result_terminal = $"1 / ({n}^{s}) +";
                    values.Add($"{result} +");
                    values_terminal.Add(result_terminal);
                }
                else
                {
                    string result_terminal = $"1 / ({n}^{s})";
                    values.Add($"{result}");
                    values_terminal.Add(result_terminal);
                }
                final_values.Add(result);
                n++;
                counter++;
            }
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
            Console.WriteLine($"The sum of these values: Zeta({2}) ==> {final_values.Sum()}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

