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

namespace AITLibrarY
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabUserModel obj = new TabUserModel(); //login
            obj.Username = textBox1.Text;
            obj.Password = textBox2.Text;
            //abc.Service1Client newClient = new abc.Service1Client();
            //newClient.GetData(5);

            if(obj.getUser())
            {
                if (obj.Username == "admin") // if admin login will go to another page
                {
                    this.Hide();
                    AdminMainPage admin = new AdminMainPage();
                    admin.Show();
                }
                else
                {
                    this.Hide();
                    MainMenu pp = new MainMenu();
                    pp.Show();
                }
            }
            else
            {
                MessageBox.Show("Please check your Username and Password"); //check password

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Login_Load(object sender, EventArgs e)
        {
          
        }
    }

    }

