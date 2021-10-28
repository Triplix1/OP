using System;

namespace Lab_4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int n = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + Math.Sin(0.5) / i / i;
            }
            result = 1 / sum;
            Console.WriteLine(result);
        }
    }
}
