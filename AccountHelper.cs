using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitamin_C
{
    class AccountHelper
    {
        // Author : 	Altamimi, Hussein 
        public User Authenticate(string username, string password)
        {
            User ResultAccount = null;
            // RESULT: TRANSLATED SENTENCE IN GERMAN
            string result = "";
            // CREATE DB HELPER OBJECT
            DatabaseHelper dbHelper = new DatabaseHelper();
            // OPEN DB HELPER CONNECTION
            dbHelper.Open();


            // EXECUTE QUERY ON DB HELPER. AND GET SQL DATA READER OBJECT TO READ DATA FROM DB.
            SqlDataReader reader = dbHelper.ExecuteQuery("select id,userName,password,theme,lastScore from  Users where userName='" + username + "' and password='" + password + "'");
            // IF DB READER CAN READ DATA. THIS MEANS QUERY EXXECUTED SUCCESSFULLY AND GOT SOME DATA
            if (reader.Read())
            {
                ResultAccount = new User();
                if(!reader.IsDBNull(0)) ResultAccount.Id =  reader.GetInt32(0);
                if (!reader.IsDBNull(1)) ResultAccount.Username = reader.GetString(1);
                if (!reader.IsDBNull(2)) ResultAccount.Password = reader.GetString(2);
                if (!reader.IsDBNull(3)) ResultAccount.Theme = reader.GetString(3);
                if (!reader.IsDBNull(4)) ResultAccount.LastScore = reader.GetInt32(4);


            }
            reader.Close();
            return ResultAccount;
        }
        public bool CreateAccount(string username, string password, string theme)
        {
             
            // CREATE DB HELPER OBJECT
            DatabaseHelper dbHelper = new DatabaseHelper();
            
            
            // OPEN DB HELPER CONNECTION
            dbHelper.Open();
            if (dbHelper.InsertAccount(username, password, theme))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
