using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitamin_C
{

    // THIS CLASS IS RESPONSIBLE FOR CONNECTION WITH DB AND EXECUTING QUERIES.
    // Author : 	Altamimi, Hussein 
    class DatabaseHelper
    {
        SqlConnection connection;
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hussein Altamimi\Desktop\faC#\Vitamin_C\Vitamin_c_DataBase.mdf';Integrated Security=True";
        public DatabaseHelper()
        {
            // CREATE CONNECITON TO DB.
            this.connection = new SqlConnection(ConnectionString);
            
        }
        public bool Open()
        {
            // OPEN  CONNECTION
            this.connection.Open();
            return true;
        }
        // THIS FUNCTION EXECUTES QUERY ON DB.
       public  SqlDataReader ExecuteQuery(string Query)
        {
            // CREATE SQL COMMAND WITH QUERY AND CONNECTION
            SqlCommand sqlCommand = new SqlCommand(Query, this.connection);
            // EXECUTE COMMAND ON SQL DB AND RETURN SQL DATA READER SO CALLER OF THIS FUNCTION CAN READ DATA.
            return sqlCommand.ExecuteReader();
        }
        public bool ExecuteNonQuery(string Query)
        {
            // CREATE SQL COMMAND WITH QUERY AND CONNECTION
            SqlCommand sqlCommand = new SqlCommand(Query, this.connection);
            // EXECUTE COMMAND ON SQL DB AND RETURN SQL DATA READER SO CALLER OF THIS FUNCTION CAN READ DATA.
            // NON QUERY BECAUSE WE ARE NOT QUERYIENG DATA OR RETURNING DATA FROM DB.
            // IT RETURNS NUMBER OF AFFECTED ROWS. 
            int Affectedrows = sqlCommand.ExecuteNonQuery() ;
            // IF 1 ROW WAS AFFECTED IT MEANS OUR RECORD SUCCESSFULLY ADDED
            if(Affectedrows == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool InsertAccount(string username, string password, string theme)
        {
            string query = "insert into Users(userName, password, theme) Values(@userName,@password,@theme)  ";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = username;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
                    cmd.Parameters.Add("@theme", SqlDbType.VarChar, 50).Value = theme;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    return true;

                     

                }
            }
            catch(Exception ex)
            {
                return false;
            }
          
            
        }
    
    }
}
