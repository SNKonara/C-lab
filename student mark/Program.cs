using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter marks");
            int mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name);

                    
            if (mark > 100 || mark< 0)
            {
                Console.WriteLine("invalid mark!!");
            }

            if(mark > 74)
            {
                Console.WriteLine("Grade: A");
            }

            if(60 < mark && mark < 74)
            {
                Console.WriteLine("Grade: B");
            }

            if(50 < mark && mark < 59)
            {
                Console.WriteLine("Grade: c");
            }

            if(40 < mark && mark < 49)
            {
                Console.WriteLine("Grade: D");
            }

            if(mark< 40)
            {
                Console.WriteLine("Failed");
            }


            Console.ReadLine();
        }
    }
}
