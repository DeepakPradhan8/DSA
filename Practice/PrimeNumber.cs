using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class PrimeNumber
    {
        //prime numbers falling under a given number
        static void Main(string[] args)
        {
            bool isprime = true;
            Console.Write("enter a number : ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Prime Numbers : ");
            for (int i = 2; i <= num; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write(i + " ");
                }
                isprime = true;
            }
            Console.ReadLine();
        }
    }
}
