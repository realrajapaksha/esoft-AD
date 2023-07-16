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
    public partial class ListView : Form
    {

        public ListView()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lstItems.Items.Add("Name\t\tMarks");
            lstItems.Items.Add("------------------------------------------------");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstItems.Items.Add(txtName.Text + "\t\t" + txtMarks.Text);
        }
    }
}
