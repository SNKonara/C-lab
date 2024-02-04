using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            if(num<=0)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
            else
            {
                for(int i = 1; i <= num; i++)
                {
                    sum = sum + i;
                }

                Console.WriteLine("summation: " + sum);
                Console.ReadLine();
            }
        }
    }
}
