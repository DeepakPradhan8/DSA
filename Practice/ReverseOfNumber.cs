using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class ReverseOfNumber
    {
        //reverse number
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (num != 0)
            {
                reverse = (reverse * 10) + (num % 10);
                num = num / 10;
            }
            Console.WriteLine("reversed number is: " + reverse);
            Console.ReadLine();
        }
    }
}
