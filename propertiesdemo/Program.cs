using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesdemo
{
    class Customer
    {
        private int customerid;
        private string customername;
        public void setcustomerid(int k)
        {
            this.customerid = k;
        }
        public void setcustomername(string name1)
        {
            this.customername = name1;
        }
        public int getcustomerid()
        {
            return this.customerid;
        }
        public string getcustomername()
        {
            return this.customername;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.setcustomerid(101);
            c1.setcustomername("sudha");
            Console.WriteLine($"{c1.getcustomerid()}---{c1.getcustomername()}");
            Console.ReadLine();
        }
    }
}
