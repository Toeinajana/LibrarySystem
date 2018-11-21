using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.UserDSTableAdapters;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogic
{
    class UserLogin
    {
        public DataSet FillAll(string UserName, string Password) //connect database for login
        {
            DataSet1 dSet = new DataSet1();
            SqlConnection con = new SqlConnection(@"Data Source=SQL5031.site4now.net;Initial Catalog=DB_9AB8B7_B18ES6010;Persist Security Info=True;User ID=DB_9AB8B7_B18ES6010_admin;Password=LRFt58nF;");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT UID, UserLevel, UserEmail FROM dbo.TabUser WHERE UserName = '" + UserName + "' AND Password = '" + Password + "'", con);
            DataSet dataset = new DataSet();
            SqlDataAdapter dataAdapt = new SqlDataAdapter(command);
            dataAdapt.Fill(dataset);
            return dataset;
        }
    }
}