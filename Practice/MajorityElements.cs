using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class MajorityElements
    {
        static void findMajority(int[] arr, int n)
        {
            int maxCount = 0;
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }
            }
            if (maxCount >= n / 2)
                Console.WriteLine("Majority element is: " +arr[index]);

            else
                Console.WriteLine("No Majority Element");
            Console.ReadLine(); 
        }
        public static void Main(string[] args) 
        {
            //example array

            int[] arr = { 1, 1, 2, 1, 3, 5, 1, 4 };
            int n = arr.Length;
            findMajority(arr, n);
        }
    }
}
