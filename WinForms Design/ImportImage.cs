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
    public partial class ImportImage : Form
    {
        public ImportImage()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtLocation.Text = ofd.FileName;
            picBox.Image = Image.FromFile(ofd.FileName);
            //picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;
        }
    }
}
