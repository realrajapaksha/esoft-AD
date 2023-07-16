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
    public partial class MoveTwoList : Form
    {
        public MoveTwoList()
        {
            InitializeComponent();
        }

        private void btnOneLToR_Click(object sender, EventArgs e)
        {
            lstRight.Items.Add(lstLeft.SelectedItem);
            lstLeft.Items.Remove(lstLeft.SelectedItem);
        }

        private void btnMulLToR_Click(object sender, EventArgs e)
        {
            /*int i = 0;
            while (lstLeft.SelectedItems.Count != 0)
            {
                lstRight.Items.Add(lstLeft.SelectedItems[i]);
                Console.WriteLine(i+"");
                i++;
            }*/

            /*foreach (var item in lstLeft.SelectedItems)
            {
                lstRight.Items.Add(item);
            }*/
            while (lstLeft.SelectedItems.Count > 0)
            {
                lstRight.Items.Add(lstLeft.SelectedItems[0]);
                lstLeft.Items.Remove(lstLeft.SelectedItems[0]);
            }
        }

        private void btnOneRToL_Click(object sender, EventArgs e)
        {
            lstLeft.Items.Add(lstRight.SelectedItem);
            lstRight.Items.Remove(lstRight.SelectedItem);
        }

        private void btnMulRToL_Click(object sender, EventArgs e)
        {

        }
    }
}
