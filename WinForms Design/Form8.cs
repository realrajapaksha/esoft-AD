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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void tsmFullName_Click(object sender, EventArgs e)
        {
            FullName fn = new FullName();
            fn.MdiParent = this;
            fn.Show();
        }

        private void importImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportImage im = new ImportImage();
            im.MdiParent = this;
            im.Show();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView list = new ListView();
            list.MdiParent = this;
            list.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.MdiParent = this;
            cal.Show();
        }

        private void marksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marks mark = new Marks();
            mark.MdiParent = this;
            mark.Show();
        }
    }
}
