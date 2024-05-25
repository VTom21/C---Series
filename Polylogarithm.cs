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
            double k = 1;
            double z = 5;
            List<string> values = new List<string>();
            List<string> values_terminal = new List<string>();
            List<double> final_values = new List<double>();

            Console.Write($"Give a value: ");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                double result = (double)Math.Pow(z,k) / (k);

                if (i < num)
                {
                    values.Add($"{result} + ");
                    values_terminal.Add($"({z}^{k}) / ({k}) + ");
                    final_values.Add(result);
                }
                else
                {
                    values.Add($"{result}");
                    values_terminal.Add($"({z}^{k}) / ({k})");
                    final_values.Add(result);
                }
                k++;
            }
            k = k - num;
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
            Console.WriteLine($"The sum of these values: Li{k}({z}) ==> {final_values.Sum()}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
