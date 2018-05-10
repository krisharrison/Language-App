using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Vitamin_C
{
    // Author : 	Javer, Zakim
    class FlashCardHelper
    {
        public int _score;
        public int _userID;
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        public int UserID
        {
            get
            {
                return this._userID;
            }
            set
            {
                this._userID = value;
            }
        }

        public void update()
        {

        //
        string query = "UPDATE users SET lastScore = "+ Score + " WHERE id = "+ UserID;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hussein Altamimi\Desktop\faC#\Vitamin_C\Vitamin_c_DataBase.mdf';Integrated Security=True");
        connection.Open();
        SqlCommand cmd = new SqlCommand(query, connection);
        //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

        cmd.ExecuteNonQuery();
        connection.Close();
        }
    }
}
