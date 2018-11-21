using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Director
    {
        public int DID { get; set; }
        public string DirectorName { get; set; }

        public Director(int did, string directorName)
        {
            this.DID = DID;
            this.DirectorName = DirectorName;
        }



    }
}
