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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //borrow botton
            this.Hide();
            TabBorrow bor = new TabBorrow();
            bor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reserve button
            this.Hide();
            TabReserve rev = new TabReserve();
            rev.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //serch botton
            this.Hide();
            Search open = new Search();
            open.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //logout botton
            this.Hide();
            Login logout = new Login();
            logout.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //logout botton
            this.Hide();
            TabReturn TabReturn = new TabReturn();
            TabReturn.Show();
        }
    }
}
