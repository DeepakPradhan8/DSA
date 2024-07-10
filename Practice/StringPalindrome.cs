using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class StringPalindrome
    {
        //a sring which is similar when reversed is known as string palindrome
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine(s + " is Palindrome and reverse is: " + revs);
            }
            else
            {
                Console.WriteLine(s + " is not a Palindrome and reverse is: " + revs);
            }
            Console.ReadLine();
        }
    }
}
