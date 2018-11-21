using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class borrow
    {
        //private UserDS userdataset;
       // public static void BorrowBook()
        ///{ 
        public int BID;
        public int UID;
        public int MediaID;
        DateTime td = DateTime.Now;
        //string tdString = td.ToString();
        //DateTime rtDate = td.AddDays(7);
        public string BorrowDate; //= DateTime.ToString("ddMMyyyy");
        public string ReturnDate;
        public string ActualReturnDate;
        public int Latefee;
    //}
    }

       /*public void _Latefee()
       {
           ReturnDate = BorrowDate + 7;
           
          // DateTime today = DateTime.Today;

           if(ActualReturnDate > ReturnDate)
           {
               Latefee = (ActualReturnDate - ReturnDate) + 2;
               Console.WriteLine("You return book late, the late fee is " +Latefee);
           }


       }*/





    }

