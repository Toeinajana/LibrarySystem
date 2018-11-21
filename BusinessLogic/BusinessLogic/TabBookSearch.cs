using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogic
{
    class TabBookSearch
    {
        private int _Did;
        private string _DirectName = "";
        private int _Gid;
        private string _Genre = "";

        public int DID
        {
            get
            {
                return _Did;
            }
            set
            {
                _Did = value;
            }
        }

        public string DirectorName
        {
            get
            {
                return _DirectName;
            }
            set
            {
                _DirectName = value;
            }
        }

        public int Gid
        {
            get
            {
                return _Gid;
            }
            set
            {
                _Gid = value;
            }
        }

        public string GenreName
        {
            get
            {
                return _Genre;
            }
            set
            {
                _Genre = value;
            }
        }

           }
}
