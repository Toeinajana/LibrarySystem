using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccessLayer;
using System.Data.SqlClient;


namespace AITLibrarY
{
    public partial class AdminUserPage : Form
    {
        public AdminUserPage()
        {
            InitializeComponent();
        }

        DataTable data = new DataTable();

        public void GridBind()
        {
           
        }

        private void button1_Click(object sender, EventArgs e) //insert data
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
          
            string sql = "insert into sql5031.DB_9AB8B7_B18ES6010.dbo.TabUser (UserName,Password,UserLevel,UserEmail) values ('" + this.textUsername.Text + "','" + this.textPassword.Text + "','" + this.textUserLevel.Text + "','" + this.textEmail.Text + "');";
            
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
        
        
        private void button2_Click(object sender, EventArgs e) // update data
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            
            string sql = "update sql5031.DB_9AB8B7_B18ES6010.dbo.TabUser set UserName='" + this.textUsername.Text + "', Password='" + this.textPassword.Text + "',UserLevel='" + this.textUserLevel.Text + "',UserEmail='" + this.textEmail.Text + "' where UserName='" + this.textUsername.Text + "' ;";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;

            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewUser.Update();
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

        private void button3_Click(object sender, EventArgs e) // delete data
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            string sql = "delete from sql5031.DB_9AB8B7_B18ES6010.dbo.TabUser where UserName='" + this.textUsername.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;
            

            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewUser.Update();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AdminPage_Load(object sender, EventArgs e) //show data in datagrid
        {
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabUser", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewUser.DataSource = data;
            dataGridViewUser.Update();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {   // back to login page
            this.Hide();
            Login logout = new Login();
            logout.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //refresh data in datagrid
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabUser", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewUser.DataSource = data;
            dataGridViewUser.Update();

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
