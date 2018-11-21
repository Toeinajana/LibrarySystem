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

namespace BusinessLogic
{
    public class DirectorManagerImpl : DirectorManager
    {
        public List<Director> FillByDirector()
        {
            List<Director> allDirector = new List<Director>();

            var datatable = new DataAccessLayer.UserDS.TabDirectorDataTable();
            var dataAdapter = new DataAccessLayer.UserDSTableAdapters.TabDirectorTableAdapter();

            dataAdapter.FillByDirector(datatable);

            foreach(DataRow dt in datatable.Rows)
            {

                allDirector.Add(new Director(int.Parse(dt["DID"].ToString()), (dt["DirectorName"]).ToString()));
            }
            return allDirector;
        }

        public DataTable viewAllDirectorInTable()
        {
            List<Director> allDirector = new List<Director>();

            var datatable = new DataAccessLayer.UserDS.TabDirectorDataTable();
            var dataAdapter = new DataAccessLayer.UserDSTableAdapters.TabDirectorTableAdapter();

            dataAdapter.FillByDirector(datatable);

            return datatable;
        }


    }
}
