using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n,n];
            input(ref arr, n);
            output(arr, n);
            find(ref arr, n);
            Console.WriteLine("Result:");
            output(arr, n);
        }
        static void input(ref int[,] arr, int x)
        {
            var rand = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    arr[i,j] = rand.Next(0, 20) - 10;                   
                }               
            }
        }

        static void output(int[,] arr, int x)
        {           
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("{0}\t",arr[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void find(ref int[,] arr, int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (arr[j,i] == 0)
                    {
                        for(int k = 0; k < x; k++)
                        {
                            arr[k,i] = arr[k, k];
                        }
                    }
                }
                
            }
        }
    }
}
