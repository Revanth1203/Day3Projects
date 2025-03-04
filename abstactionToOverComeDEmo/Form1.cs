using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static abstactionToOverComeDEmo.Form1;

namespace abstactionToOverComeDEmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Polygon2
        {
            public abstract void side(int s);
        }
        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("**************************");//no need of it
            }
            public abstract void area(int a, int b);// abstarct method 

        }

        class Triangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of Triangle is :" + 0.5 * a * b);
            }
        }
        class Rectangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of rectangle is :" + (a * b));
            }
        }
        class Square : Polygon2
        {
            public override void side(int s)
            {
                MessageBox.Show("The are of square is :" + (s * s));
            }
        }

        interface A
        {
            //int a1 { set; get; }//allowed
            void area(int a, int b);
        }
        interface B
        {
            //int a1 { set; get; }//allowed
            void side(int s);
        }
        class NewShape : A, B
        {
            public void area(int a, int b)
            {
                
                MessageBox.Show("The area of Rectangle: " + (a + b));
                MessageBox.Show("The area of trinagle: " + (0.5*a * b));
            }

            public void side(int s)
            {
                MessageBox.Show("The area of Square: " + (s * s));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Polygon obj;// it is a car without a petrol 
            obj = new Triangle();// allocating memory of triangle class in base class only putting petrol
            obj.area(12, 3);
            obj = new Rectangle();// it can allocate memeory of rectanglealso 
            obj.area(12, 4);
            //obj.testfunction();
            // now i can use base class refercne object and i can call sub class function which 
            //is happening here first limitiation of inheritnace is overcome 
            Polygon2 obj2;
            obj2 = new Square();
            obj2.side(4);

            //interface

            A aobj;
            aobj = new NewShape();
            aobj.area(12, 3);
            aobj.area(2, 3);
            B bobj;
            bobj = new NewShape();
            bobj.side(5);
        }
    }
}
