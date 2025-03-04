using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutliDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basic
            int i, j, sum = 0;
            for(i= 0; i <= 5;i++)
            {
                for(j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            // 2D array (for 2D we need to use 2 for loops)  
            int[,] a = new int[3, 3];//2D
            int[,,] b = new int[3, 3, 3];//3D

            Console.WriteLine("Enetr the 2D array: ");
            //if length is unknown the use (a.GetLength(0)) for rows
            for (i = 0; i < 3; i++) 
            {
                //if length is unknown the use (a.GetLength(1)) for coloums
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"Enter the {i + 1},{j + 1} element: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("\n");
            }
            
            //printing
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.Write("\n");
            }
            //sum of the arrays
            Console.WriteLine("\n sum of elements in matrix");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    sum +=  a[i, j];
                }

            }
            Console.WriteLine($"\n the sum is {sum}");

        }
    }
}
