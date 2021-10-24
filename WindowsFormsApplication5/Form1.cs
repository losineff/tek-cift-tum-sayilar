using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for ( int a = 1; a < 100; a++)
            {
                listBox3.Items.Add(a);
                if (a % 2 == 1) listBox1.Items.Add(a);
                else if (a % 2 == 0) listBox2.Items.Add(a);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
