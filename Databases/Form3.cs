using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Databases
{
    public partial class Form3 : Form
    {
        string con;
        MySqlConnection dbCon;
        public Form3()
        {
            InitializeComponent();
            con = "datasource=localhost:port=3306;username=root;password=;database=first";
            dbCon = new MySqlConnection(con);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaths.Text = "";
            txtScience.Text = string.Empty;
            txtEnglish.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbSID.Items.Add("select");
            cmbSID.Items.Add("ah");
            cmbSID.SelectedIndex = cmbSID.Items.IndexOf("Select");

            string query = "SELECT * from student";
            MySqlCommand dbCommand = new MySqlCommand(query, dbCon);
            dbCommand.CommandTimeout = 60;

            try
            {
                dbCon.Open();
                MySqlDataReader myReader = dbCommand.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        string s = myReader.GetString(0);
                        cmbSID.Items.Add(s);
                    }
                }
                dbCon.Close();
            }
            catch (Exception ex)
            {
                dbCon.Close();
                MessageBox.Show("Error " + ex);
            }
        }

        private void cmbSID_SelectedValueChanged(object sender, EventArgs e)
        {
            String item = cmbSID.SelectedItem.ToString();
            checkID(item);
        }

        private void checkID(string id)
        {
            string quary = "SELECT * FROM marks where sid='" + id + "'";

            MySqlCommand mySqlCommand = new MySqlCommand(quary, dbCon);
            mySqlCommand.CommandTimeout = 60;

            try
            {
                dbCon.Open();
                MySqlDataReader data = mySqlCommand.ExecuteReader();
                if (data.HasRows)
                {
                    MessageBox.Show("Id " + id + " already exist");
                    cmbSID.Focus();
                    dbCon.Close();
                }
                else
                {
                    dbCon.Close();
                    insertMarks();
                }
            }
            catch (Exception ex)
            {
                dbCon.Close();
                MessageBox.Show("Error " + ex);
            }

        }

        private void insertMarks()
        {
            string quary = $"INSERT INTO marks VALUES('{1}','{cmbSID.SelectedItem.ToString()}','{txtMaths.Text}','{txtScience.Text}','{txtEnglish.Text}');";

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

        private void cmbSID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
