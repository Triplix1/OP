using System;

namespace Lab_3_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your E (0;1): ");

            double E = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your x [-1;0) : ");

            double x = Convert.ToDouble(Console.ReadLine());

            while (x < -1 || x >=0)
            {
                Console.WriteLine("Enter your x [-1;0) : ");

                x = Convert.ToDouble(Console.ReadLine());
            }

            while (E <= 0 || E >= 1)
            {
                Console.WriteLine("Enter your x [-1;0) : ");

                x = Convert.ToDouble(Console.ReadLine());
            }
            int n = 1;

            double result = 1;

            double resbef = 0;

            int m = 3;

            int i = m;

            int z = m - 1;

            int b = 1;

            while(Math.Abs(result - resbef) > E)
            {
                resbef = result;
                result = 1;
                

                result += Math.Pow(x, m);

                i--;

                while (i > 0)
                {                   
                    result += (Fact(m) * Math.Pow(x, m-b)) / (Fact(b)) /(m - (m - i));

                    
                    b++;

                    i--;
                }

                
                m++;
                i = m;
                z = m - 1;

                
            }

            Console.WriteLine(result);

            static int Fact(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * Fact(n - 1);
            }
        }
    }
}
