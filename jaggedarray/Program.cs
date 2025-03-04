using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[][] jdarray = new int[4][];
            jdarray[0] = new int[2] { 2, 3 };
            jdarray[1] = new int[3] {1, 2, 3 };
            jdarray[2] = new int[1] { 1 };
            jdarray[3] = new int[5] { 1,2,3,2, 3 };

            //FROM USER 
            int[][] jdArray = new int[4][];
            Console.WriteLine("read from the user ..");
            for (i = 0; i < jdArray.Length; i++)
            {
                Console.WriteLine($"\n I am in row :{i + 1} asking u to enter  ");

                Console.WriteLine("\nenter columns or elemnts in the row ");
                int colsize = Convert.ToInt32(Console.ReadLine());
                jdArray[i] = new int[colsize];
                for (j = 0; j < jdArray[i].Length; j++)
                {
                    Console.WriteLine($"\nenter element at [{i + 1},{j + 1}]");
                    jdArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (i=0;i<jdArray.Length;i++)
            {
                Console.WriteLine($"I am in the row {i + 1} and having {jdArray[i].Length} elements");
                for (j = 0; j < jdArray[i].Length; j++)
                {
                    Console.Write($"{jdArray[i][j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
