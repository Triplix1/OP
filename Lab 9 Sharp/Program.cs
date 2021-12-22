using System;

namespace Lab_9_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {                
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.Write("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            func(str, k);
        }

        static void func(string str, int k)
        {
            int i = 0;
            int number = 0;
            while ( i < str.Length)
            {
                number = str.IndexOf(" ", i) > 0 ? str.IndexOf(" ",i) : str.Length;
                if (number - i < k)
                {
                    Console.WriteLine($"{str.Substring(i, number - i)}");
                }
                i = number + 1;
            }
        }
    }
}
