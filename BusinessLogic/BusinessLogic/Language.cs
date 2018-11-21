using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Language
    {
        public int LID { get; set; }
        public string LanguageName { get; set; }

        public Language(int lid, string languageName)
        {
            this.LID = LID;
            this.LanguageName = LanguageName;
        }



    }
}
