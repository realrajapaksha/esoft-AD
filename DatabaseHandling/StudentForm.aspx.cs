using MySql.Data.MySqlClient;
using System;
using System.Web.UI;


namespace DatabaseHandling
{
    public partial class StudentForm : System.Web.UI.Page
    {
        public MySqlConnection dbCon;
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            MakeConnection();
        }

        private void MakeConnection()
        {
            try
            {
                MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
                conn_string.Server = "localhost";
                conn_string.Port = 3306;
                conn_string.UserID = "root";
                conn_string.Password = "";
                conn_string.Database = "first";

                dbCon = new MySqlConnection(conn_string.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            if (ValidationCheck())
            {
                string quary = $"INSERT INTO `student`(`Name`, `Id`, `Address`) VALUES ('{txtName.Text}','{txtID.Text}','{txtAddress.Text}')";
                MySqlCommand command = new MySqlCommand(quary, dbCon);

                try
                {
                    dbCon.Open();

                    command.ExecuteNonQuery();
                    Response.Write($"Successfull Inserted.");
                    // to refresh data gridview
                    GridView1.DataBind();
                    dbCon.Close();
                }
                catch (Exception ex)
                {
                    dbCon.Close();
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private bool ValidationCheck()
        {
            try
            {
                string quary = $"SELECT * FROM student WHERE id= '{txtID.Text}'";
                MySqlCommand command = new MySqlCommand(quary, dbCon);

                command.CommandTimeout = 60;

                dbCon.Open();
                MySqlDataReader data = command.ExecuteReader();
                if (data.HasRows)
                {
                    Response.Write($"{txtID.Text} id already exists.");
                    dbCon.Close();
                    return false;
                }
                else
                {
                    dbCon.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                dbCon.Close();
                Response.Write($"error {ex}");
                return false;
            }
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtID.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        protected void FindBtn_Click(object sender, EventArgs e)
        {
            string quary = $"SELECT Name, Id, Address FROM student WHERE id='{txtID.Text}'";
            MySqlCommand command = new MySqlCommand(quary, dbCon);
            command.CommandTimeout = 60;

            try
            {
                dbCon.Open();
                MySqlDataReader data = command.ExecuteReader();
                if (data.HasRows)
                {
                    if (data.Read())
                    {
                        txtName.Text = data.GetString(0);
                        txtID.Text = data.GetString(1);
                        txtAddress.Text = data.GetString(2);
                    }
                    dbCon.Close();
                }
                else
                {
                    Response.Write($"{txtID.Text} id not found.");
                    dbCon.Close();
                }
            }
            catch (Exception ex)
            {
                dbCon.Close();
                Response.Write($"error {ex}");
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            string quary = $"DELETE FROM student WHERE id='{txtID.Text}'";
            MySqlCommand command = new MySqlCommand(quary, dbCon);
            command.CommandTimeout = 60;

            try
            {
                dbCon.Open();
                int resut = command.ExecuteNonQuery();
                if (resut <= 0)
                {
                    Response.Write($"{txtID.Text} id not found.");
                }
                else
                {
                    Response.Write($"{txtID.Text} id delete succesfull.");
                }
                // to refresh data gridview
                GridView1.DataBind();
                dbCon.Close();

            }
            catch (Exception ex)
            {
                dbCon.Close();
                Response.Write($"error {ex}");
            }
        }
    }
}