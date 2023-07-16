using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Design
{
    public partial class Calculator : Form
    {
        double first = 0.0;
        double second = 0.0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(txtFirst.Text);
            second = Convert.ToDouble(txtSecond.Text);

            txtAns.Text = (first + second).ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(txtFirst.Text);
            second = Convert.ToDouble(txtSecond.Text);

            txtAns.Text = (first - second).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(txtFirst.Text);
            second = Convert.ToDouble(txtSecond.Text);

            txtAns.Text = (first * second).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(txtFirst.Text);
            second = Convert.ToDouble(txtSecond.Text);

            txtAns.Text = (first / second).ToString();
        }
    }
}
