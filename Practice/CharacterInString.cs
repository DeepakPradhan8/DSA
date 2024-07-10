using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class CharacterInString
    {
        //finding the no of occurence of a specific character in the given string
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string s= Console.ReadLine();

            //character whose no of occurence to be found
            Console.Write("Enter the character to count: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = 0;
            foreach (char c1 in s)
            {
                if (c == c1) 
                count++;
            }
            Console.Write(c + " is repeated " +count+ " times in the given string.");
            Console.ReadLine();
        }
    }
}
