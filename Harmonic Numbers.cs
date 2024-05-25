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
            int H = 1;
            List<string> values = new List<string>();
            List<string> values_terminal = new List<string>();
            List<double> final_values = new List<double>();

            Console.Write($"Give a number: ");
            
            int num = Int32.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 1; i <= num; i++)
            {
                double result = (double) 1 / H;
                if (i < num)
                {
                    values_terminal.Add($"(1 / {i}) +");
                    values.Add($"({(double)1 / i}) + ");
                    final_values.Add(result);
                }
                else
                {
                    values_terminal.Add($"(1 / {i}) ");
                    values.Add($"({(double)1 / i}) ");
                    final_values.Add(result);
                }
                H++;
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
            Console.WriteLine($"The sum of these Harmonic Numbers: H({num}) ==> {final_values.Sum()}");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
