using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BusinessLogic
{
    public class MediaManagerImpl : MediaManager
    {

        public List<Genre> GetAllGenre() // show genre
        {

            List<Genre> allGenre = new List<Genre>();

            var datatable = new DataAccessLayer.DataSet1.TabGenreDataTable();
            var dataAdapter = new DataAccessLayer.DataSet1TableAdapters.TabGenreTableAdapter();

            dataAdapter.GetAllGenre(datatable);



            foreach (DataRow dt in datatable.Rows)
            {
                //Browse Data
                //GID, GenreName 
                allGenre.Add(new Genre(int.Parse(dt["GID"].ToString()), (dt["GenreName"]).ToString()));

            }
            return allGenre;

        }

        public DataTable viewAllGenreInTable()
        {
            List<Genre> allGenre = new List<Genre>();

            var datatable = new DataAccessLayer.DataSet1.TabGenreDataTable();
            var dataAdapter = new DataAccessLayer.DataSet1TableAdapters.TabGenreTableAdapter();

            dataAdapter.GetAllGenre(datatable);

            return datatable;

        }
    }
}

