using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class LengthOfString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            int len = s.Length;
            Console.WriteLine("Length of the string is: " + len);
            Console.ReadLine();
        }
    }
}
