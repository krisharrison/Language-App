using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Vitamin_C
{
    // Author : 	Harrison, Kristien
    public partial class DictionaryForm : Form
    {
        //Update object
        Update _update = new Update();
        //Lists
        List<string> _english = new List<string>();//Holds english words
        List<string> _article = new List<string>();//Holds articles
        List<string> _german = new List<string>();//Holds german words
        //Data binding
        BindingSource _bindingItem1 = new BindingSource();
        BindingSource _bindingItem2 = new BindingSource();
        BindingSource _bindingItem3 = new BindingSource();


        public DictionaryForm()
        {
            InitializeComponent();

            //Load english column into list _english
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Vitamin_c_DataBase.mdf;Integrated Security=True"))
            {
                SqlDataAdapter englishDA = new SqlDataAdapter("SELECT English FROM German", con);
                DataSet englishDS = new DataSet();
                englishDA.Fill(englishDS, "German");

                foreach (DataRow row in englishDS.Tables["German"].Rows)
                {
                    _english.Add(row["English"].ToString());
                }

            }

            //Load article column into list _article
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Vitamin_c_DataBase.mdf;Integrated Security=True"))
            {
                SqlDataAdapter articleDA = new SqlDataAdapter("SELECT Article FROM German", con);
                DataSet articleDS = new DataSet();
                articleDA.Fill(articleDS, "German");

                foreach (DataRow row in articleDS.Tables["German"].Rows)
                {
                    _article.Add(row["Article"].ToString());
                }
            }

            //Load german column into list _aticle
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Vitamin_c_DataBase.mdf;Integrated Security=True"))
            {
                SqlDataAdapter germanDA = new SqlDataAdapter("SELECT German FROM German", con);
                DataSet germanDS = new DataSet();
                germanDA.Fill(germanDS, "German");

                foreach (DataRow row in germanDS.Tables["German"].Rows)
                {
                    _german.Add(row["German"].ToString());
                }
            }

            _lstEnglish.DataSource = null;
            _lstArticle.DataSource = null;
            _lstGerman.DataSource = null;
            //Loads all the words from the database into the list boxes: _lstEnglish,_lstArticle,_lstGerman
            _lstEnglish.DataSource = _english;
            _lstArticle.DataSource = _article;
            _lstGerman.DataSource = _german;

        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            /*SEARCH DOES NOT PULL FROM THE DATABASE!
             THE DATABASE IS LOADED INTO THE ARRAYS WHEN THE DICTIONARY PAGE IS FIRST LOADED.
             THE SEARCH ONLY SCROLLS THROUGH _lstEnglish LIST
             WORDS CAN ONLY BE SEARCHED IN ENGLISH*/

            var index = 0; //For loop index

            //var selectedIndex = 0;//This variable stores the index at which the word is found in the list
            for (index = 0; index < _english.Count; index++)
            {
                if (this._txtSearch.Text == _english[index])//If word in _txtSearch field matches a word found in _lstEnglish
                {
                    //Highlight searched word
                    _lstEnglish.SelectedIndex = index;


                    break;

                }
            }



            //Update can still access the search word even though it's not necessarily needed
            _update.SearchWord = this._txtSearch.Text;

            //Search text field is is cleared to offer feed back to the user
            this._txtSearch.Clear();
        }

        private void _btnUpdate_Click(object sender, EventArgs e)
        {




            string selectedEnglishWord;
            int selectedIndex;
            if (this._txtEnglish != null)
            {

                selectedIndex = _lstEnglish.SelectedIndex;
                _english[selectedIndex] = this._txtEnglish.Text;

                //Ensure that the item selected in the list box is accessible in the update class
                selectedEnglishWord = _lstEnglish.GetItemText(_lstEnglish.SelectedItem); //Get selected word
                _update.EnglishWord = selectedEnglishWord; //Store english word
                _update.UpdatedEnglishWord = this._txtEnglish.Text; // store updated english word

                _update.updateEnglishWord();


            }




            string selectedGermanWord2;
            int selectedIndex2;
            //Update german if txtGerman is not null
            if (this._txtGerman != null)
            {
                selectedIndex2 = _lstGerman.SelectedIndex;
                _german[selectedIndex2] = this._txtGerman.Text;

                //Ensure that the item selected in the list box is accessible in the update class
                selectedGermanWord2 = _lstGerman.GetItemText(_lstGerman.SelectedItem);
                _update.GermanWord = selectedGermanWord2; //Store german word
                _update.UpdatedGermanWord = this._txtGerman.Text; //Store updated german word
                _update.PrimaryKey = _english[selectedIndex2]; //Store english word as primary key

                _update.updateGermanWord();



            }


            string article;
            int selectedIndex3;
            //Replace article in list if txtArticle is not null
            if (this._txtArticle != null)
            {
                selectedIndex3 = _lstArticle.SelectedIndex;
                _article[selectedIndex3] = this._txtArticle.Text;
                //Ensure that the item selected in the list box is accessible in the update class
                article = _lstArticle.GetItemText(_lstArticle.SelectedItem);
                _update.Article = article; // Store article
                _update.UpdatedArticle = this._txtArticle.Text; // store updated article
                _update.PrimaryKey = _english[selectedIndex3];//store english word as primary key

                _update.updateArticle();



            }



            //Set datasource to null to reset listboxes of english,article and german
            _lstEnglish.DataSource = null;
            _lstArticle.DataSource = null;
            _lstGerman.DataSource = null;

            _bindingItem1.DataSource = _english;
            _bindingItem2.DataSource = _article;
            _bindingItem3.DataSource = _german;
            //Set data source
            _lstEnglish.DataSource = _bindingItem1;
            _lstArticle.DataSource = _bindingItem2;
            _lstGerman.DataSource = _bindingItem3;
            //Clear text fields as feedback for the user
            this._txtGerman.Clear();
            this._txtArticle.Clear();
            this._txtEnglish.Clear();
        }

        //Delete word from Lists and German table in the database
        private void _btnDelete_Click(object sender, EventArgs e)
        {

            //Set English word to selected item selected in _lstEnglish list box
            //EnglishWord is accessible in the update class is used to query German table in Database
            string selectedValue = _lstEnglish.GetItemText(_lstEnglish.SelectedItem);
            _update.EnglishWord = selectedValue;

            //Get selected index in the english listbox
            int selectedIndex = _lstEnglish.SelectedIndex;

            //Remove all translations - including english word selected
            _english.RemoveAt(selectedIndex);
            _article.RemoveAt(selectedIndex);
            _german.RemoveAt(selectedIndex);

            //Set datasource to null to reset listboxes of english,article and german
            _lstEnglish.DataSource = null;
            _lstArticle.DataSource = null;
            _lstGerman.DataSource = null;

            //Set data source
            _lstEnglish.DataSource = _english;
            _lstArticle.DataSource = _article;
            _lstGerman.DataSource = _german;

            //Call deleteWord from update class
            //Remove words from table - German
            _update.deleteWord();

            //Clear text field as feedd back to user
            this._txtGerman.Clear();
            this._txtArticle.Clear();
            this._txtEnglish.Clear();

            //Let user know that the word was deleted
            this._lblErrorMessage.Text = "Word deleted";
        }

        //Saving words to Lists and German table in the databae
        private void _btnSave_Click(object sender, EventArgs e)
        {
            //Set article, GermanWord, English -- Allows _txtArticle,_txtGerman,_txtEnglish to be accessed in Update class
            _update.Article = this._txtArticle.Text;
            _update.GermanWord = this._txtGerman.Text;
            _update.EnglishWord = this._txtEnglish.Text;

            //Add english word to _english list
            _english.Add(this._txtEnglish.Text);
            //Add article word to _article list
            _article.Add(this._txtArticle.Text);
            //Add german word to _german list
            _german.Add(this._txtGerman.Text);

            //Add words to database
            //Call addword method from update class
            //Save words to table - German
            _update.addWord();

            //Let user know that the word was added
            this._lblErrorMessage.Text = "Word added";

            _lstEnglish.DataSource = null;
            _lstArticle.DataSource = null;
            _lstGerman.DataSource = null;

            _lstEnglish.DataSource = _english;
            _lstArticle.DataSource = _article;
            _lstGerman.DataSource = _german;


            this._txtGerman.Clear();
            this._txtArticle.Clear();
            this._txtEnglish.Clear();
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



        private void _lstEnglish_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _lstArticle.SelectedIndex = _lstEnglish.SelectedIndex;
                _lstGerman.SelectedIndex = _lstEnglish.SelectedIndex;
            }
            catch
            {

            }


        }


        private void _lstArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _lstEnglish.SelectedIndex = _lstArticle.SelectedIndex;
                _lstGerman.SelectedIndex = _lstArticle.SelectedIndex;
            }
            catch
            {

            }

        }

        private void _lstGerman_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _lstEnglish.SelectedIndex = _lstGerman.SelectedIndex;
                _lstArticle.SelectedIndex = _lstGerman.SelectedIndex;
            }
            catch
            {

            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //This method is not needed
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
        //This method is not attached to anything and should be deleted
        private void _btnSave_Click_1(object sender, EventArgs e)
        {

        }
        //This method is not attached to anything and should be deleted
        private void _menuViewWords_Click_1(object sender, EventArgs e)
        {

        }

        private void _menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call 909-0191-0029",
"Help Message");
        }

        private void DictionaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
