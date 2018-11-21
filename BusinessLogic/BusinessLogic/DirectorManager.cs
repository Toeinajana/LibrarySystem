using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    public interface DirectorManager
    {
        List<Director> FillByDirector();
        DataTable viewAllDirectorInTable();
    }
}
