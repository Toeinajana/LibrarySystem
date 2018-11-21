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
using System.Configuration;
using DataAccessLayer;
using BusinessLogic;



namespace AITLibrarY
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        DataTable data;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //show all
        {
            SqlConnection conShow = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            SqlDataAdapter dataadapt = new SqlDataAdapter("Select * FROM TabMedia", conShow);
            data = new DataTable();
            dataadapt.Fill(data);
            dataGridView1.DataSource = data; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; //clear datagrid
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Title")  //dropdown box and search
            {
                SqlConnection conShow = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
                SqlDataAdapter dataadapt1 = new SqlDataAdapter("Select Title, Genre, Director, Language, PublishYear, Budget FROM TabMedia WHERE Title like '" + textBox1.Text + "%'", conShow);
                data = new DataTable();
                dataadapt1.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Genre")
            {
                                       
                SqlConnection conShow = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
                SqlDataAdapter dataadapt1 = new SqlDataAdapter("Select Title, Genre, Director, Language, PublishYear, Budget FROM TabMedia WHERE Genre like '" + textBox1.Text + "%'", conShow);

                data = new DataTable();
                dataadapt1.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Director")
            {
                SqlConnection conShow = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
                SqlDataAdapter dataadapt1 = new SqlDataAdapter("Select Title, Genre, Director, Language, PublishYear, Budget FROM TabMedia WHERE Director like '" + textBox1.Text + "%'", conShow);
                data = new DataTable();
                dataadapt1.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Language")
            {
                SqlConnection conShow = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
                SqlDataAdapter dataadapt1 = new SqlDataAdapter("Select Title, Genre, Director, Language, PublishYear, Budget FROM TabMedia WHERE Language like '" + textBox1.Text + "%'", conShow);
                data = new DataTable();
                dataadapt1.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "PublishYear")
            {
                SqlConnection conShow = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
                SqlDataAdapter dataadapt1 = new SqlDataAdapter("Select Title, Genre, Director, Language, PublishYear, Budget FROM TabMedia WHERE PublishYear like '" + textBox1.Text + "%'", conShow);
                data = new DataTable();
                dataadapt1.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Budget")
            {
                SqlConnection conShow = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
                SqlDataAdapter dataadapt1 = new SqlDataAdapter("Select Title, Genre, Director, Language, PublishYear, Budget FROM TabMedia WHERE Budget like '" + textBox1.Text + "%'", conShow);
                data = new DataTable();
                dataadapt1.Fill(data);
                dataGridView1.DataSource = data;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //back botton
            this.Hide();
            MainMenu back = new MainMenu();
            back.Show();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Genre")  //dropdown box and show table detail
            {
                MediaManager mediaManager = new MediaManagerImpl();
                List<Genre> genre = mediaManager.GetAllGenre();

                dataGridView2.DataSource = mediaManager.viewAllGenreInTable();
            }
            else if(comboBox2.Text == "Director")
            {
                DirectorManager directorManager = new DirectorManagerImpl();
                List<Director> director = directorManager.FillByDirector();

                dataGridView2.DataSource = directorManager.viewAllDirectorInTable();
                
            }
            else if (comboBox2.Text == "Language")
            {
                LanguageManager languageManager = new LanguageManagerImpl();
                List<Language> language = languageManager.FillByLanguage();

                dataGridView2.DataSource = languageManager.viewAllLanguageInTable();

            }
            

        }
    }
}
