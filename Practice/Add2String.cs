using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Add2String
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter the 2nd string: ");
            string s2 = Console.ReadLine();
            string result = s1 + s2;
            Console.WriteLine("Outcome: " + result);
            Console.ReadLine();
        }
    }
}
