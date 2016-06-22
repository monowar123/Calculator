using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class About_Calculator : Form
    {
        public About_Calculator()
        {
            InitializeComponent();
           
            label4.Text = "Developer";
            label1.Text = "Md.Monowarul Islam";
            label2.Text = "CE-09016";
            label3.Text = "Dept. of CSE,";
            label5.Text = "Mawlana Bhashani Science && Technology University.";
            label6.Text = "Email: monowar.mbstu@gmail.com";
            label7.Text = "Cell: 01558-651205";
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
