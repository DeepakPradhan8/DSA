using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class MultiplicationTable
    {
        //Multiplication Table of any number
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nMultiplication table of {num}");
            for (int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num} x {i} = {result}");
            }
            Console.ReadLine();
        }
    }
}
