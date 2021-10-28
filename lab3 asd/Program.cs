using System;

namespace lab3_asd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your E (0;1): ");

            double E = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your x [-1;0) : ");

            double x = Convert.ToDouble(Console.ReadLine());

            while (x < -1 || x >= 0)
            {
                Console.WriteLine("Enter your x [-1;0) : ");

                x = Convert.ToDouble(Console.ReadLine());
            }

            while (E <= 0 || E >= 1)
            {
                Console.WriteLine("Enter your E [-1;0) : ");

                E = Convert.ToDouble(Console.ReadLine());
            }

            int factm = 1;
            int factm_i = 1;
            int facti = 1;

            double result = 0.5;

            double resbef = 1;

            int m = 1;

            int i = m;

            int repm = m;
            int repi = i;
            int repm_i = m - i;
            double minus = Math.Abs(result - resbef);

            while (minus > E)
            {
                resbef = result;
                result = 1;
               
                while (repm > 1)
                {
                    factm *= repm;
                    repm--;
                }

                while (i > 0)
                {
                    factm_i = 1;
                    facti = 1;
                    repi = i;
                    repm_i = m - i;
                    while (repi > 1)
                    {
                        facti *= repi;
                        repi--;
                    }
                    while (repm_i > 1)
                    {
                        factm_i *= repm_i;
                        repm_i--;
                    }
                    result += (factm * Math.Pow(x, i)) / (factm_i * facti);
                    i--;
                }
                m++;
                i = m;
                repm = m;
                factm = 1;
                minus = Math.Abs(result - resbef);
            }

            Console.WriteLine(result);
        }
    }
}
