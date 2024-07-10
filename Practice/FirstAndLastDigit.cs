using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class FirstAndLastDigit
    {
        //starting and ending digits of a given number
        static void Main(string[] args)
        {
            double num, last;
            Console.WriteLine("enter any number:");
            num=double.Parse(Console.ReadLine());
            last = num % 10;
            Console.WriteLine("the last digit of the entered number is: " + last);
            while (num >= 10)
            {
                num = Math.Floor(num / 10);
                
            }
            Console.WriteLine("the first digit of the entered number is: " + num);
            Console.ReadLine();
        }
    }
}
