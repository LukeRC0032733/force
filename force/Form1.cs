using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace force
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate1_Click(object sender, EventArgs e)
        {
            try
            {
                double f = double.Parse(txtbx1.Text);
                double a = double.Parse(txtbx2.Text);
                double fx = f * cos(a);
                double fy = f * sin(a);
                label1.Text = "fx =" + fx + "N";
                label2.Text = "fy =" + fy + "N"; 
            }
            catch
            {
                MessageBox.Show("enter a number");
            }
        }

        double sin(double a)
        {

            return Math.Sin(a / 180.0 * Math.PI);
        }

        double cos(double a)
        {

            return Math.Cos(a / 180.0 * Math.PI);
        }
    }
}

