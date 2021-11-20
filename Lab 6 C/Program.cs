using System;

namespace Lab_6_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n>0:");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0) 
            { 
                Console.WriteLine("Enter n>0 !!! :");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter i>0:");
            int i = Convert.ToInt32(Console.ReadLine());
            while (i <= 0)
            {
                Console.WriteLine("Enter i>0 !!! :");
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter m>0:");
            int m = Convert.ToInt32(Console.ReadLine());
            while (m <= 0)
            {
                Console.WriteLine("Enter m>0 !!! :");
                m = Convert.ToInt32(Console.ReadLine());
            }
            int result = gcd(n, i,m);
            Console.WriteLine($"Result: {result}");
        }

        static int gcd(int a, int b, int c) 
        {
            return gcd(gcd(a, b), c);         
        }

        static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
    }
}
