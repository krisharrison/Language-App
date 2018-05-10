using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Vitamin_C
{

    // Author : 	Javer, Zakim
    partial class FlashCard : Form
    {
        //    private MainMenu ss;;
        //eng words
        List<string> _engWords = new List<string>();

        //ger words
        List<string> _gerWords = new List<string>();
        public FlashCard()
        {
            InitializeComponent();
            
            getWord();
        }
        int totalQuestions = 3;
        private void getWord()
        {
            //clear the Lists
            _engWords.Clear();
            _gerWords.Clear();

            //gets the random words from the database
            string query = "SELECT TOP " + totalQuestions + "* FROM German ORDER BY newid()";

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Vitamin_c_DataBase.mdf;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable eng = new System.Data.DataTable();

            try
            {
                adapter.Fill(eng);
            }
            catch
            {
                throw;
            }
                //adding words to the lists
                for (int i = 0; i < totalQuestions; i++)
                {
                    _engWords.Add(eng.Rows[i].ItemArray[0].ToString().Trim());
                    _gerWords.Add(eng.Rows[i].ItemArray[2].ToString().Trim());
                }
                connection.Close();
            

            ChangeWord(0);


        }
        private void ChangeWord(int question)
        {
            //gets the next random word
            _lblRandomWord.Text = _gerWords[question];
        }
        private void _lblOverallScore_Click(object sender, EventArgs e)
        {

        }

        private void FlashCard_Load(object sender, EventArgs e)
        {
        }

        private void _menuFileMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new MainMenu();
            ((MainMenu)main).Controls["lblScore"].Text = _lblScore.Text;
            ((MainMenu)main).Controls["lblId"].Text = _lblUserID.Text;
            ((MainMenu)main).Controls["lblUserName"].Text = _lblUserName.Text;
            ((MainMenu)main).Controls["lblTheme"].Text = _lblTheme.Text;
            string theme = _lblTheme.Text;
            if (theme == "Blue")
            {
                ((MainMenu)main).BackColor = Color.Blue;
                ((MainMenu)main).ForeColor = Color.Yellow;
            }

            if (theme == "Red")
            {
                ((MainMenu)main).BackColor = Color.Red;
                ((MainMenu)main).ForeColor = Color.Snow;
            }

            if (theme == "Green")
            {
                ((MainMenu)main).BackColor = Color.Green;
                ((MainMenu)main).ForeColor = Color.SkyBlue;
            }
            main.Show();
        }

        private void _menuFileLogout_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Close();
        }

        private void _menuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int question = 0;
        int correct = 0;
        private void _btnCheck_Click(object sender, EventArgs e)
        {
            if (_btnCheck.Text == "Reset")
            {
                question = 0;
                

                _btnCheck.Text = "Check";
                _lblCScore.Text = "-";
                FlashCardHelper flashcard = new FlashCardHelper();
                flashcard.Score = correct *10;
                flashcard.UserID = int.Parse(_lblUserID.Text);
                flashcard.update();
                //start all over
                correct = 0;
                getWord();
            }
            else
            {

                if (_txtInput.Text == _engWords[question]) //checks to see if the answere is correct
                {
                    //if ansere is correct it increments correct 
                    correct++;
                }
                else
                {
                    //shows the correct answere 
                    MessageBox.Show("That is incorrect. The Correct ansere is: " + _engWords[question]);
                }
                //checks if there are any more words in the list
                if (question < totalQuestions - 1)
                {
                    //changes the question
                    question++;
                    ChangeWord(question);
                }
                else
                {
                    MessageBox.Show("All the questions are done. You got " + correct + " out of " + (question + 1) + " correct");
                    int score = correct * 10;
                    _lblCScore.Text = score.ToString();
                    _btnCheck.Text = "Reset";

                    _lblRandomWord.Text = "";
                }
            }

            _txtInput.Text = "";


        }

        private void _txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void _lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void _lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void _menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call 909-0191-0029",
"Help Message");
        }
    }
}
