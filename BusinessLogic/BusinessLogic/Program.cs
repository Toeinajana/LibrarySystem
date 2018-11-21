using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BusinessLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var datatable = new DataAccessLayer.DataSet1.TabGenreDataTable();
            var dataAdapter = new DataAccessLayer.DataSet1TableAdapters.TabGenreTableAdapter();

            dataAdapter.GetAllGenre(datatable);

            foreach (DataRow dt in datatable.Rows)
            {
                //Browse Data

                var genreName = dt["GenreName"].ToString();
                Console.WriteLine(genreName);
            }

        }
    }
}
