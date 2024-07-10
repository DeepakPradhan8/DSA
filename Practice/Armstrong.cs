using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Armstrong
    {
        //A number that is equal to the sum of cube of its digits
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int a = n;
            int r;
            int sum = 0;

            //extract each digits and then add its cube to the sum
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (a == sum)
            {
                Console.WriteLine("It is an Armstrong number");
            }
            else
            {
                Console.WriteLine("It is not an Armstrong number");
            }
            Console.ReadLine();
        }
    }
}
