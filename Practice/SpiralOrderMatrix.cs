using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class SpiralOrderMatrix
    {
        //assigning the elements in the matrix in spiral order
        static List<List<int>> GenerateMatrix(int A)
        {
            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < A; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < A; j++)
                {
                    matrix[i].Add(0);
                }
            }

            int num = 1;
            int top = 0, bottom = A - 1, left = 0, right = A - 1;

            while (num <= A * A)
            {
                for (int i = left; i <= right; i++)
                {
                    matrix[top][i] = num++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    matrix[i][right] = num++;
                }
                right--;

                for (int i = right; i >= left; i--)
                {
                    matrix[bottom][i] = num++;
                }
                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    matrix[i][left] = num++;
                }
                left++;
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the value of A: ");
            int A = int.Parse(Console.ReadLine());

            List<List<int>> result = GenerateMatrix(A);

            Console.WriteLine("Generated matrix:");
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    Console.Write(result[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
