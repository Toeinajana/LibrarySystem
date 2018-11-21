using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using DataAccessLayer;
using DataAccessLayer.UserDSTableAdapters;

namespace BusinessLogic
{
    public class UserManagerImpl : UserManager
    {
        public List<User> viewAllUsers() //view users
        {
            List<User> allUsers = new List<User>();

            var datatable = new DataAccessLayer.DataSet1.TabUserDataTable();
            var dataAdapter = new DataAccessLayer.DataSet1TableAdapters.TabUserTableAdapter();

            dataAdapter.ViewAllUsers(datatable);



            foreach (DataRow dt in datatable.Rows)
            {
                //Browse Data


                allUsers.Add(new User(int.Parse(dt["UID"].ToString()), (dt["UserName"]).ToString(), (dt["Password"]).ToString(), int.Parse(dt["UserLevel"].ToString()), (dt["UserEmail"]).ToString()));

            }
            return allUsers;

        }


        public DataTable viewAllUsersInTable()
        {
            List<User> allUsers = new List<User>();

            var datatable = new DataAccessLayer.DataSet1.TabUserDataTable();
            var dataAdapter = new DataAccessLayer.DataSet1TableAdapters.TabUserTableAdapter();

            dataAdapter.ViewAllUsers(datatable);

            return datatable;

        }

       
    }
}
