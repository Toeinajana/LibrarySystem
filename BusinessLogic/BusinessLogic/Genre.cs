using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Genre
    {
        public Genre(int id, string title)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.title=title;
        }
        public int id { get; set; }
        public string title { get; set; }
    }
}
