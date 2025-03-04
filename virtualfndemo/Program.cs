using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualfndemo
{
    class BaseClass
    {
        public virtual void display()
        {
            Console.WriteLine("Base class display");
        }
    }
    class SubClass : BaseClass
    {
        public override void display()
        {
            Console.WriteLine("Sub Class display");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj;
            obj= new SubClass();
            obj.display();
        }
    }
}
