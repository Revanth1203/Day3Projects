﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingdemo
{
    class abcd
    {
        public void add(int x, int y)
        {
            Console.WriteLine($"The sum is {x + y}");
        }

        public int add(int k, decimal ss, double jj)
        {
            return (k + Convert.ToInt32(ss) + Convert.ToInt32(jj));
        }

        public decimal add(float k, decimal ss, double jj)
        {
            return (Convert.ToDecimal(k) + ss + Convert.ToDecimal(jj));
        }
    }

    class cde : abcd
    {
        public void add(int kk, char ch)
        {
            Console.WriteLine($"The sum is :{kk + ch} ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            cde cde = new cde();
            cde.add(12, 34);
            cde.add(12, 'A');
            Console.WriteLine($"The sum is {cde.add(12.34F, 123.34M, 345.567)}");
            Console.WriteLine($"The sum is {cde.add(123, 345.56M, 345.567)}");
            Console.ReadLine();
        }
    }
}
