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
            double n = 3;
            double k = 0;

            List<string> values = new List<string>();
            List<string> terminal_values = new List<string>();
            List<double> final_values = new List<double>();


            double factorial_n = 1;
            double factorial_k = 1;
            double n_k = n - k;
            double last_factorial = 1;
            int counter = 0;

            while (counter <= n)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial_n *= i;
                }
                for (int i = 1; i <= k; i++)
                {
                    factorial_k *= i;
                }
                for (int i = 1; i <= n - k; i++)
                {
                    last_factorial *= i;
                }


                if (counter < n)
                {
                    double result = (factorial_n) / (factorial_k * last_factorial);
                    string result2 = $"({n}!) / (({k})! * ({n - k}))! + ";
                    string result3 = $"{n} under {k} + ";
                    terminal_values.Add(result2);
                    values.Add(result3);
                    final_values.Add(result);
                }
                else
                {
                    double result = (factorial_n) / (factorial_k * last_factorial);
                    string result2 = $"({n}!) / (({k})! * ({n - k}))!";
                    string result3 = $"{n} under {k}";
                    terminal_values.Add(result2);
                    values.Add(result3);
                    final_values.Add(result);
                }
                counter++;
                k++;
                factorial_n = 1;
                factorial_k = 1;
                last_factorial = 1;
            }


            Console.Write("The Series Shown: ");
            foreach (var item in terminal_values)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
            Console.Write("The values Shown: ");
            foreach (var item in values)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of these values: ==> {final_values.Sum()}");
            Console.ReadKey();
        }
    }
}

