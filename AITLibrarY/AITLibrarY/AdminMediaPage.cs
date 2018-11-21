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
    public partial class AdminMediaPage : Form
    {
        public AdminMediaPage()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();
        private void AdminMediaPage_Load(object sender, EventArgs e)
        {
            // show data in data grid
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabMedia", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewMedia.DataSource = data;
            dataGridViewMedia.Update();
        }

        private void textTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDirector_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBudget_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e) // insert
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");

            string sql = "insert into sql5031.DB_9AB8B7_B18ES6010.dbo.TabMedia (Title,Genre,Director,Language,PublishYear,Budget) values ('" + this.textTitle.Text + "','" + this.textGenre.Text + "','" + this.textDirector.Text + "','" + this.textLan.Text + "','" + this.textYear.Text + "','" + this.textBudget.Text + "');";

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

            string sql = "update sql5031.DB_9AB8B7_B18ES6010.dbo.TabMedia set Title='" + this.textTitle.Text + "',Genre='" + this.textGenre.Text + "',Director='" + this.textDirector.Text + "',Language='" + this.textLan.Text + "', PublishYear='" + this.textYear.Text + "',Budget='" + this.textBudget.Text + "' where Title='" + this.textTitle.Text + "' ;";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;

            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewMedia.Update();
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
            string sql = "delete from sql5031.DB_9AB8B7_B18ES6010.dbo.TabMedia where Title='" + this.textTitle.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;


            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewMedia.Update();
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // refresh data
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabMedia", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewMedia.DataSource = data;
            dataGridViewMedia.Update();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // logout button
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // back button
            this.Hide();
            AdminMainPage admin = new AdminMainPage();
            admin.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
