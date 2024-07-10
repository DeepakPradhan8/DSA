using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Pascle_sTriangle
    {
        // Function to find the elements
        // of rowIndex in Pascal's Triangle
        public static List<int> getRow(int rowIndex)
        {
            List<int> currow = new List<int>();
            // 1st element of every row is 1
            currow.Add(1);
            // Check if the row that has to
            // be returned is the first row
            if (rowIndex == 0)
            {
                return currow;
            }
            // Generate the previous row
            List<int> prev = getRow(rowIndex - 1);
            for (int i = 1; i < prev.Count; i++)
            {
                // Generate the elements
                // of the current row
                // by the help of the
                // previous row
                int curr = prev[i - 1] + prev[i];
                currow.Add(curr);
            }
            currow.Add(1);
            // Return the row
            return currow;
        }
        public static void Main(String[] args)
        {
            int n = 3;
            List<int> arr = getRow(n);
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == arr.Count - 1)
                    Console.Write(arr[i]);
                else
                    Console.Write(arr[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}

