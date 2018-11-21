using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITLibrarY
{
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Genre botton
            this.Hide();
            AdminGenrePage adminGenre = new AdminGenrePage();
            adminGenre.Show();
        }

        private void buttonDirector_Click(object sender, EventArgs e)
        {

            //director botton
            this.Hide();
            AdminDirectorPage adminDirect = new AdminDirectorPage();
            adminDirect.Show();
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            //language botton
            this.Hide();
            AdminLanguagePage adminLan = new AdminLanguagePage();
            adminLan.Show();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            //logout botton
            this.Hide();
            AdminUserPage AdminUser = new AdminUserPage();
            AdminUser.Show();
        }

        private void buttonMedia_Click(object sender, EventArgs e)
        {
            //media botton
            this.Hide();
            AdminMediaPage media = new AdminMediaPage();
            media.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //logout botton
            this.Hide();
            Login logout = new Login();
            logout.Show();
        }
    }
}
