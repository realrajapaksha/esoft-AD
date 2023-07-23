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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string query = txtQuery.Text;
            getData(query);
        }

        private void getData(string query)
        {
            string con = "datasource=localhost:port=3306;username=root;password=;database=first";
            MySqlConnection mySqlConnection = new MySqlConnection(con);
            MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
            sqlCommand.CommandTimeout = 60;

        }

    }
}
