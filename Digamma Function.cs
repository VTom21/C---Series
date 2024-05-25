using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 9;
            List<string> values_terminal = new List<string>();
            List<string> values = new List<string>();
            List<double> final_values = new List<double>();

            double v = n;

            double factorial_value = -0.57721;

            for (int i = 2; i <= n; i++)
            {
                double value = Math.Abs(1.0 / (n - i + 1));
                factorial_value += value;

                if (i < n)
                {
                    values_terminal.Add($"(1 / {i}) - (1 / {v}) + ");
                    values.Add($"{value} + ");
                }
                else
                {
                    values_terminal.Add($"(1 / {i}) - (1 / {v})");
                    values.Add($"{value}");
                }
                v++;
            }
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
            Console.WriteLine($"The sum of these values: digamma({n}) ==> {final_values[0]}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
