using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class SumOfDigits
    {
        //sum of the digits of a number
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine("sum of the digits are: " + sum);
            Console.ReadLine();
        }
    }
}
