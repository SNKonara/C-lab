using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibbonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of terms (N)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci Series:");

            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine(FibonacciSeries(i) + "");
            }
            Console.ReadLine();
        }

        static int FibonacciSeries(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            else
            {
                return FibonacciSeries(n-1) + FibonacciSeries(n-2);            }
        }
    }
}
