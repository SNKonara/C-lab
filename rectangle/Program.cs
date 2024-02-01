using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the width");
            int width = int.Parse(Console.ReadLine());

            

            int area = RecArea(length, width);

            Console.WriteLine("Area:" + area);
            Console.ReadLine();
        }

        static int RecArea(int lenght, int width)
        {
            int area = lenght * width;
            return area;
        }
    }
}
