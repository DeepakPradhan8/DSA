using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class NumberPalindrome
    {
        //a number similar when read from either side is known as palindrome
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int a = n;
            int i = 0;
            while (n > 0)
            {
                i = i * 10 + n % 10;
                n = n / 10;
            }
            if (a == i)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
            }
            Console.ReadLine();
        }
    }
}
