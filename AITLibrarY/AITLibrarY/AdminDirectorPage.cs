using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AITLibrarY
{
    public partial class AdminDirectorPage : Form
    {
        public AdminDirectorPage()
        {
            InitializeComponent();
        }

        DataTable data = new DataTable();
        private void AdminDirectorPage_Load(object sender, EventArgs e)
        {
            // show data in datagrid
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabDirector", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewDirector.DataSource = data;
            dataGridViewDirector.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // refresh
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabDirector", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewDirector.DataSource = data;
            dataGridViewDirector.Update();
        }

        private void button1_Click(object sender, EventArgs e) // insert
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");

            string sql = "insert into sql5031.DB_9AB8B7_B18ES6010.dbo.TabDirector (DirectorName) values ('" + this.textBoxDirector.Text + "');";

            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;

            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();

                MessageBox.Show("Saved");

                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e) // update
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");

            string sql = "update sql5031.DB_9AB8B7_B18ES6010.dbo.TabDirector set DirectorName='" + this.textBoxDirector.Text + "' where DID='" + this.textDID.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;

            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewDirector.Update();
                MessageBox.Show("Updated");

                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) // delete
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            string sql = "delete from sql5031.DB_9AB8B7_B18ES6010.dbo.TabDirector where DID='" + this.textDID.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;


            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewDirector.Update();
                MessageBox.Show("Deleted");

                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridViewDirector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {// back to admin main menu
            this.Hide();
            AdminMainPage admin = new AdminMainPage();
            admin.Show();
        }

        private void textDID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // logout button
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
