using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class FibonacciSeries
    {
        //fibonacci series - a sequence where a number is the sum of it's two preceding numbers.
        static void Main(string[] args)
        {

            int a = 0, b = 1, c, n;
            Console.WriteLine("enter the range of fabionacci series");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Fabionacci series:");
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                //if (c > n)
                //    break;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
