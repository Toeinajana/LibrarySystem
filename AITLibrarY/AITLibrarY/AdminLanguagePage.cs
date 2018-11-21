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
    public partial class AdminLanguagePage : Form
    {
        public AdminLanguagePage()
        {
            InitializeComponent();
        }

        DataTable data = new DataTable();
        private void button5_Click(object sender, EventArgs e)
        { // refresh data
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabLanguage", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewLanguage.DataSource = data;
            dataGridViewLanguage.Update();
        }

        private void button1_Click(object sender, EventArgs e) // insert
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");

            string sql = "insert into sql5031.DB_9AB8B7_B18ES6010.dbo.TabLanguage (LanguageName) values ('" + this.textLan.Text + "');";

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

        private void button2_Click(object sender, EventArgs e) // update
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");

            string sql = "update sql5031.DB_9AB8B7_B18ES6010.dbo.TabLanguage set LanguageName='" + this.textLan.Text + "' where LID='" + this.textLID.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;

            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewLanguage.Update();
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

        private void button3_Click(object sender, EventArgs e) //delete
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            string sql = "delete from sql5031.DB_9AB8B7_B18ES6010.dbo.TabLanguage where LID='" + this.textLID.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;


            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewLanguage.Update();
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

        private void button4_Click(object sender, EventArgs e)
        {
            // logout button
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void AdminLanguagePage_Load(object sender, EventArgs e)
        { //  show data
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabLanguage", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewLanguage.DataSource = data;
            dataGridViewLanguage.Update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textLan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // back button
            this.Hide();
            AdminMainPage admin = new AdminMainPage();
            admin.Show();
        }
    }
}
