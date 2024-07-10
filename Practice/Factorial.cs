using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Factorial
    {
        //Factorial of a given number
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num= int.Parse(Console.ReadLine());
            int fact = 1;
            while (num != 0)
            {
                fact *= num;
                num--;
            }
            Console.WriteLine("factorial is: " + fact);
            Console.ReadLine();
        }
    }
}
