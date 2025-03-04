using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        int a = 1;
        public void count()
        {
            a += 1;
            Console.WriteLine($"The value of a is: {a}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            abcd obj= new abcd();
            obj.count();
        }
    }
}

//refer notes for other type
//non static to static outside class
// non static to static inside class
// static to static outside class
// static to static inside class
//fully static (int too)