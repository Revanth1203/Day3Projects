using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritancedemo
{
    public partial class Form1 : Form
    {
        //multi level
        public Form1()
        {
            InitializeComponent();
        }
        class father
        {
            public void maruthicar()
            {
                MessageBox.Show("maruti Car...");
            }
        }
        class son: father
        {
            public void MBcar()
            {
                MessageBox.Show("mercedes benz car....");
            }
        }
        class grandson : son
        {
            public void BMWcar()
            {
                MessageBox.Show("BMW car...");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grandson me = new grandson();
            me.maruthicar();
            me.MBcar();
            me.BMWcar();
        }
    }
}
