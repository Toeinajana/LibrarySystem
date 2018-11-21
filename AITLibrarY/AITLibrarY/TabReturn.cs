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
    public partial class TabReturn : Form
    {
        public TabReturn()
        {
            InitializeComponent();
        }

        DataTable data;
        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");

            string sql = "delete from sql5031.DB_9AB8B7_B18ES6010.dbo.TabBorrow where BID='" + this.textBID.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conString);
            SqlDataReader reader;

            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridViewReturn.Update();
                MessageBox.Show("Returned book");

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
            //refresh data in datagrid
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabBorrow", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewReturn.DataSource = data;
            dataGridViewReturn.Update();
        }

        private void TabReturn_Load(object sender, EventArgs e)
        {
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabBorrow", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridViewReturn.DataSource = data;
            dataGridViewReturn.Refresh();
            dataGridViewReturn.Update();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu back = new MainMenu();
            back.Show();
        }

        private void dataGridViewReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {// look at books' detail
            Search search = new Search();
            search.Show();
        }
        }
    }
