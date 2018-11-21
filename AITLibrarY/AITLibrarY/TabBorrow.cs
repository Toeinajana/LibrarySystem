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
using System.Data.SqlClient;


namespace AITLibrarY
{
    public partial class TabBorrow : Form
    {
        public TabBorrow()
        {
            InitializeComponent();
        }

        DataTable data;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conString = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");

            string sql = "insert into sql5031.DB_9AB8B7_B18ES6010.dbo.TabBorrow (UID,MediaID,BorrowDate,ReturnDate) values (@UID, @MediaID, @BorrowDate, @ReturnDate)";
            //string sql = "insert into sql5031.DB_9AB8B7_B18ES6010.dbo.TabBorrow (UID,MediaID,BorrowDate,ReturnDate) values ('" + this.textUID.Text + "','" + this.textMID.Text + "','" + this.BorrowDate.Text.ToString() + "','" + this.ReturnDate.Text.ToString() + "');";




            SqlCommand cmd = new SqlCommand(sql, conString);


            cmd.Parameters.Add("@UID", SqlDbType.Int);
            cmd.Parameters["@UID"].Value = int.Parse(textUID.Text);

            cmd.Parameters.Add("@MediaID", SqlDbType.Int);
            cmd.Parameters["@MediaID"].Value = int.Parse(textMID.Text);

            cmd.Parameters.Add("@BorrowDate", SqlDbType.Date);
            cmd.Parameters["@BorrowDate"].Value = dateTimeBorrowDate.Value;

            cmd.Parameters.Add("@ReturnDate", SqlDbType.Date);
            cmd.Parameters["@ReturnDate"].Value = dateTimeReturnDate.Text;


            SqlDataReader reader;

            try
            {
                conString.Open();
                reader = cmd.ExecuteReader();
                dataGridView1.Refresh();

                MessageBox.Show("Confirmed your borrow");

                while (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabBorrow_Load(object sender, EventArgs e)
        {

            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabBorrow", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Refresh();
            dataGridView1.Update();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu back = new MainMenu();
            back.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //refresh data in datagrid
            SqlConnection showUser = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabBorrow", showUser);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.Update();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            // look at books' detail
            Search search = new Search();
            search.Show();
        }
    }
}
