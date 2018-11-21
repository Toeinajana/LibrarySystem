using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BusinessLogic
{
    public interface LanguageManager
    {
        List<Language> FillByLanguage();
        DataTable viewAllLanguageInTable();
    }
}
