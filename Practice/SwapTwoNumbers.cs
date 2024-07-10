using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class SwapTwoNumbers
    {
        static void Main(string[] args)
        {
            //using a third variable to swap numbers

            int a, b, x;
            Console.WriteLine("Before Swapping");
            Console.Write("enter the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter the second number: ");
            b = int.Parse(Console.ReadLine());
            x = a;
            a = b;
            b = x;
            Console.WriteLine("after swapping: ");
            Console.WriteLine("first number is: " + a);
            Console.WriteLine("second number is: " + b);
            Console.ReadLine();


            /*
            //without using a third variable

            int a, b;
            Console.WriteLine("enter a, b values");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("before swaping a, b values are " + a + "," + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swapping a, b values are " + a + "," + b);
            Console.ReadLine();
            */
        }
    }
}
