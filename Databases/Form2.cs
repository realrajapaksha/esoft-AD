using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databases
{
    public partial class Form2 : Form
    {
        string con;
        MySqlConnection dbCon;
        public Form2()
        {
            InitializeComponent();
            con = "datasource=localhost:port=3306;username=root;password=;database=first";
            dbCon = new MySqlConnection(con);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtSID.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "" || txtSID.Text.Trim() == "" || txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Details");
                return;
            }
            else
            {
                idCheck(txtSID.Text);
            }
        }

        private void idCheck(string id)
        {
            string quary = "SELECT * FROM student where id='" + id + "'";

            MySqlCommand mySqlCommand = new MySqlCommand(quary, dbCon);
            mySqlCommand.CommandTimeout = 60;

            try
            {
                dbCon.Open();
                MySqlDataReader data = mySqlCommand.ExecuteReader();
                if (data.HasRows)
                {
                    MessageBox.Show("Id " + id + " already exist");
                    txtSID.Focus();
                    dbCon.Close();
                }
                else
                {
                    dbCon.Close();
                    insertStudentInfo();
                }
            }
            catch (Exception ex)
            {
                dbCon.Close();
                MessageBox.Show("Error " + ex);
            }

        }

        private void insertStudentInfo()
        {
            string quary = $"INSERT INTO student VALUES('{txtSID.Text}','{txtname.Text}','{txtAddress.Text}');";

            MySqlCommand mySqlCommand = new MySqlCommand(quary, dbCon);

            try
            {
                dbCon.Open();
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Successfull Inserted");
                dbCon.Close();

            }
            catch (Exception ex)
            {
                dbCon.Close();
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
