using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Vitamin_C
{
    // Author : 	Harrison, Kristien
    class Update
    {




        public string _searchWord;
        public string _englishWord;
        public string _germanWord;
        public string _article;
        public string _updatedEnglishWord;
        public string _updatedArticle;
        public string _updatedGermanWord;
        public string _errorMessage;
        public string _primaryKey;

        //Stores and return primary key
        public string PrimaryKey
        {
            get { return this._primaryKey; }
            set { this._primaryKey = value; }


        }
        //Stores and return updated english word
        public string UpdatedEnglishWord
        {
            get { return this._updatedEnglishWord; }
            set { this._updatedEnglishWord = value; }


        }
        //Stores and return updated article
        public string UpdatedArticle
        {
            get { return this._updatedArticle; }
            set
            { this._updatedArticle = value; }
        }
        //Stores and return updated english word
        public string UpdatedGermanWord
        {
            get { return this._updatedGermanWord; }
            set { this._updatedGermanWord = value; }
        }
        //sets and gets _txtSearch
        public string SearchWord
        {
            get { return this._searchWord; }
            set
            {
                if (value != null)
                {
                    this._searchWord = value;
                }
                else
                {
                    this._errorMessage = "Search cannot be null";
                }
            }
        }
        //stores german word from _txtGerman
        public string GermanWord
        {
            get { return this._germanWord; }
            set
            {
                if (value != null)
                {
                    this._germanWord = value;
                }
                else
                {
                    this._errorMessage = "The value for the german word cannot be Null!";
                }
            }
        }
        //Sets and gets _txtEnglish
        public string EnglishWord
        {
            get { return this._englishWord; }
            set
            {
                if (value != null)
                {
                    this._englishWord = value;
                }
                else
                {
                    this._errorMessage = "The value for the english word cannot be Null!";
                }
            }
        }
        //Sets and gets article
        public string Article
        {
            get { return this._article; }
            set
            {
                if (value != null)
                {
                    this._article = value;
                }
                else
                {
                    this._errorMessage = "The value for the german article cannot be Null!";
                }
            }
        }

        //Gets error message
        public string ErrorMessage
        {
            get
            {
                return this._errorMessage;
            }
        }

        //Adds english word, article and german word to database
        public void addWord()
        {
            //Insert new words into database
            string queryString = "INSERT INTO German(English,Article,German) VALUES(@English,@Article,@German)";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hussein Altamimi\Desktop\faC#\Vitamin_C\Vitamin_c_DataBase.mdf';Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(queryString, con);
                    
            cmd.Parameters.Add("@English", SqlDbType.VarChar, 50).Value = EnglishWord;
            cmd.Parameters.Add("@Article", SqlDbType.VarChar, 3).Value = Article;
            cmd.Parameters.Add("@German", SqlDbType.VarChar, 50).Value = GermanWord;

            cmd.ExecuteNonQuery();

                    
             con.Close();


        }

        //Deletes selected word in database
        public void deleteWord()
        {
            //Delete row - English is the primary key
            string queryString = "DELETE FROM German WHERE English = @englishWord";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hussein Altamimi\Desktop\faC#\Vitamin_C\Vitamin_c_DataBase.mdf';Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(queryString, con);


            cmd.Parameters.Add("@englishWord", SqlDbType.VarChar, 50).Value = EnglishWord;
            cmd.ExecuteNonQuery();

            con.Close();
               

        }

        //Updates english word
        public void updateEnglishWord()
        {
            string queryString = "UPDATE German SET English = @newWord WHERE English = @oldWord";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hussein Altamimi\Desktop\faC#\Vitamin_C\Vitamin_c_DataBase.mdf';Integrated Security=True");
             con.Open();
            SqlCommand cmd = new SqlCommand(queryString, con);
                 
             cmd.Parameters.Add("@newWord", SqlDbType.VarChar, 50).Value = UpdatedEnglishWord;
             cmd.Parameters.Add("@oldWord", SqlDbType.VarChar, 50).Value = EnglishWord;
             cmd.ExecuteNonQuery();

                 
             con.Close();
               
        }
        //updates artcile
        public void updateArticle()
        {
            string queryString = "UPDATE German SET Article = @newArticle WHERE English =  @primaryKey";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hussein Altamimi\Desktop\faC#\Vitamin_C\Vitamin_c_DataBase.mdf';Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(queryString, con);

            cmd.Parameters.Add("@newArticle", SqlDbType.VarChar, 3).Value = UpdatedArticle;
            cmd.Parameters.Add("@PrimaryKey", SqlDbType.VarChar, 50).Value = PrimaryKey;
            cmd.ExecuteNonQuery();
             con.Close();
             

          
        


    }
        //updates german word
        public void updateGermanWord()
        {
            string queryString = "UPDATE German SET German = @newWord WHERE English = @PrimaryKey";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hussein Altamimi\Desktop\faC#\Vitamin_C\Vitamin_c_DataBase.mdf';Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(queryString, con);

            cmd.Parameters.Add("@newWord", SqlDbType.VarChar, 50).Value = UpdatedGermanWord;
            cmd.Parameters.Add("@PrimaryKey", SqlDbType.VarChar, 50).Value = PrimaryKey;
            cmd.ExecuteNonQuery();

            con.Close();

        }


    }
}
