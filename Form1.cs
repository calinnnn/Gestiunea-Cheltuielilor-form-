using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiunea_Cheltuielilor__form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ven;
        int chelt;
        int econ;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ven = Int32.Parse(textBox1.Text);
            if (ven > 0)
            {
                chelt = (ven * 45) / 100;
                econ = (ven * 55) / 100;
                textBox3.Text = chelt.ToString();
                textBox2.Text = econ.ToString();
            } else textBox1.Text = "val gresita";
        }
    }
}
