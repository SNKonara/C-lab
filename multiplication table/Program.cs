using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int multi = 1;

            for(int i = 1; i < 13; i++)
            {
                multi = num * i;
                Console.WriteLine(num + " *" + i + "= " + multi);
               
            }
            Console.ReadLine() ;
        } 

    }
}
