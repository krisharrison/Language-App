using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitamin_C
{

    // CLASS TRANSLATOR RESPONSIBLE FOR TRANSLATIONS
    // Author : 	Altamimi, Hussein 
    class Translator
    {
        /// THIS FUNCTION TRANSLATE SENTENCE INTO GERMAN FROM ENLGISH AND RETURNS IT
        public String TranslateToGerman(string sentence)
        {
            // RESULT: TRANSLATED SENTENCE IN GERMAN
            string result = "";
            // CREATE DB HELPER OBJECT
            DatabaseHelper dbHelper = new DatabaseHelper();
            // OPEN DB HELPER CONNECTION
            dbHelper.Open();

            // SPLIT SENTENCE INTO WORDS INTO ARRAY. 
            string[] words = sentence.Split(' ');
            // ITERATE THROUGH EACH WORD.
            for(int i =0; i < words.Length; i ++)
            {
                // EXECUTE QUERY ON DB HELPER. AND GET SQL DATA READER OBJECT TO READ DATA FROM DB.
                SqlDataReader reader = dbHelper.ExecuteQuery("SELECT * FROM GERMAN where English='" + words[i] + "'");
                // IF DB READER CAN READ DATA. THIS MEANS QUERY EXXECUTED SUCCESSFULLY AND GOT SOME DATA
                if (reader.Read())
                {
                    // IF A WORD HAS ALREADY BEEN ADDED TO TRANSLTED SENTENCE, ADD A SPACE (TO SEPERATE WORDS)
                    if(result.Length > 0)
                    {
                        result += " ";
                    }
                    // APPEND TRANSATED WORD TO SENTENCE. 
                    result += " " + reader.GetString(2);
                }
                // CLOSE SQL DATA READER.
                reader.Close();
            }
           // RETURN TRANSATED SENTENCE.
            return result;
        }
    }
}
