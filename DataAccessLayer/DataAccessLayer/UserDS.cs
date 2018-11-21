
namespace DataAccessLayer {

    
    
    public partial class UserDS {
        
        partial class TabUserDataTable
        {
             
            public int UID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public int UserLevel { get; set; }
            public string UserEmail { get; set; }


            public void AddTabUserRow(TabUserDataTable _TabUserTable)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
