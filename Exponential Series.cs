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
            List<double> values = new List<double>();
            List<string> values_terminal = new List<string>();
            int n = 0;
            int u = 3;
            int factorial_n = 1;
            int counter = 0;
            Console.Write("Write a value: ");
            int series = Int32.Parse(Console.ReadLine());
            while (counter < series)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial_n *= i;

                }
                double result = Math.Pow(u, n) / factorial_n;
                string result_terminal = $"({u}^{n}) / ({n}!); ";
                values.Add(result);
                values_terminal.Add(result_terminal);
                n++;
                counter++;
                factorial_n = 1;
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
                Console.Write($"{item}; ");
            }
            Console.ReadKey();
        }
    }
}

