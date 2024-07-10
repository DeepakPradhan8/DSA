using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class EvenAndOdd
    {
        //all even and odd numbers under a given number
        static void Main(string[] args)
        {
            //number under which all odd and even numbers to be found
            Console.WriteLine("Write a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Even numbers are:");
            for (int i = 2; i <= num; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Odd numbers are:");
            for (int i = 1; i <= num; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}

