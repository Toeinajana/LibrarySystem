using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
   public class LanguageManagerImpl : LanguageManager
    {
        public List<Language> FillByLanguage() // show language table
        {

            List<Language> allLanguage = new List<Language>();

            var datatable = new DataAccessLayer.UserDS.TabLanguageDataTable();
            var dataAdapter = new DataAccessLayer.UserDSTableAdapters.TabLanguageTableAdapter();

            dataAdapter.FillByLanguage(datatable);



            foreach (DataRow dt in datatable.Rows)
            {
                //Browse Data
                //LID,KLanguageName 
                allLanguage.Add(new Language(int.Parse(dt["LID"].ToString()), (dt["LanguageName"]).ToString()));

            }
            return allLanguage;

        }

        public DataTable viewAllLanguageInTable()
        {
            List<Language> allLanguage = new List<Language>();

            var datatable = new DataAccessLayer.UserDS.TabLanguageDataTable();
            var dataAdapter = new DataAccessLayer.UserDSTableAdapters.TabLanguageTableAdapter();

            dataAdapter.FillByLanguage(datatable);

            return datatable;

        }
    }
}
