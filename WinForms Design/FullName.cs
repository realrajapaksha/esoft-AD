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
    public partial class FullName : Form
    {
        public FullName()
        {
            InitializeComponent();
        }

        private void btnFullName_Click(object sender, EventArgs e)
        {
            lblFullName.Text = txtFirstName.Text + " " + txtSecondName.Text;
        }
    }
}
