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
    public partial class Marks : Form
    {
        public Marks()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtMaths.Text.Trim() == "" || txtScience.Text.Trim() == "" || txtEnglish.Text.Trim() == "")
            {
                MessageBox.Show("Error Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maths = Convert.ToInt16(txtMaths.Text);
            int science = Convert.ToInt16(txtScience.Text);
            int english = Convert.ToInt16(txtEnglish.Text);

            int total = maths + science + english;
            lblSum.Text = total.ToString();
            lblAverage.Text = (total / 3).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnglish.Clear();
            txtScience.Clear();
            txtMaths.Clear();

            lblSum.Text = "";
            lblAverage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            cdl.ShowDialog();
            this.BackColor = cdl.Color;
        }

        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            txtMaths.TextAlign = HorizontalAlignment.Right;
            txtScience.TextAlign = HorizontalAlignment.Right;
            txtEnglish.TextAlign = HorizontalAlignment.Right;
        }
    }
}
