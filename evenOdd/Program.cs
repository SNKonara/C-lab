using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter number");
               int num = int.Parse(Console.ReadLine());

                int mod = num % 2;

                if (mod == 0)
                {
                    Console.WriteLine(num + " is even number " );
                }
                else
                {
                    Console.WriteLine(num + " is odd number");
                }

                Console.ReadLine();


            }
        }
    }
}
