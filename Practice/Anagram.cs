using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Anagram
    {
        //Anagram is a word or phrase that is formed by rearranging the letters of another word or phrase
        static void Main()
        {
            Console.Write("Enter the 1st string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string s2 = Console.ReadLine();
            bool areAnagrams = CheckAnagram(s1, s2);
            if (areAnagrams)
                Console.WriteLine("The strings are anagrams.");
            else
                Console.WriteLine("The strings are not anagrams.");
            Console.ReadLine();
        }
        static bool CheckAnagram(string s1, string s2)
        {
            // Remove any whitespace and convert to lowercase
            s1 = s1.Replace(" ", "").ToLower();
            s2 = s2.Replace(" ", "").ToLower();

            // Convert strings to char arrays and sort them
            char[] charArray1 = s1.ToCharArray();
            char[] charArray2 = s2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // Compare sorted char arrays
            return charArray1.SequenceEqual(charArray2);
        }
    }
}
