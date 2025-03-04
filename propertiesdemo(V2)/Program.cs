using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesdemo_V2_
{
    class Customer
    {
        private int customerid;
        private string customername;
        public int CUSTID  // using CUSTID proeprty u will fill customerid which is private 
        {
            set
            {
                customerid = value;//here value means externally u will put some value
            }
            get
            {
                return customerid;
            }
        }

        public string CUSTNAME
        {
            set
            {
                customername = value;
            }
            get
            {
                return customername;
            }


        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
            Customer c1 = new Customer();
            c1.CUSTID = 101;//setting
            c1.CUSTNAME = "Ravi";
            Console.WriteLine($"{c1.CUSTID}--{c1.CUSTNAME}");
            Console.ReadLine();
        }
        }
    }


