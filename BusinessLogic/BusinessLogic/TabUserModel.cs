using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Windows.Forms;

namespace BusinessLogic
{
     public class TabUserModel
     {
    
     private int _Uid;
     private string _UserName = "";
     private string _Password = "";
     private int _UserLevel;
     private string _UserEmail = "";
     
       


     public int Uid
     {
         
         get 
         {
             return _Uid; 
         }
         set
         {
             _Uid = value; 
         }
     }

     public string Username
     {
         get
         {
             return _UserName;
         } 
         set
         {
             _UserName = value;
         }
     }
 
     public string Password
     {
         get
         {
             return _Password;
         } 
         set
         {
             _Password = value;
         }
     }

     public int UserLevel
     {
         get
         {
             return _UserLevel;
         } 
         set
         {
             _UserLevel = value;
         }
     }

     public string UserEmail
     {
         get
         {
             return _UserEmail;
         }
         set
         {
             _UserEmail = value;
         }
     }

    

     UserLogin da = new UserLogin(); //login

     public bool getUser()
     {
         if (da.FillAll(Username, Password).Tables[0].Rows.Count == 0)
         {
             return false;
         }
         else
         {
             return true;
         }
     }
     
     }
 }