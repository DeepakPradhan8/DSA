using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class AsteriskPyramid
    {
        //Inverted asterisk(*) pyramid
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of rows");
            int n = int.Parse(Console.ReadLine());
            int i, j, temp = 1;
            for (i = n;  i >= 0; i--)
            {
                for (j = 1;  j < temp; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }
                temp++;
                n--;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
