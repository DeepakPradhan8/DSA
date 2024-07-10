using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class ProductOfDigits
    {
        //product of the digits of a number
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num=int.Parse(Console.ReadLine());
            int mul = 1;
            while (num != 0)
            {
                mul = mul * (num % 10);
                num = num / 10;
            }
            Console.WriteLine("products of the digits are:" + mul);
            Console.ReadLine();
        }
    }
}
