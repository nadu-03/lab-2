using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the length: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the width: ");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;


            Console.WriteLine("the area of the rectangle is: \n" + area);
            Console.ReadLine();
        }
    }
}
