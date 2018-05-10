using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitamin_C
{
    // Author : 	Altamimi, Hussein 
    public partial class Sentances : Form
    {
        public Sentances()
        {
            InitializeComponent();
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

        private void Sentances_Load(object sender, EventArgs e)
        {

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



        private void button1_Click(object sender, EventArgs e)
        {
            // GET SENTENCE FROM UI TO TRANSLATE
            string EnglishSentence = txtEnglishSentence.Text;
            // CREATE TRANSLATOR OBJECT
            Translator MyTranslator = new Translator();
            // TRANSLATE ENGLISH SENTENCE TO GERMAN.
            string German = MyTranslator.TranslateToGerman(EnglishSentence);
            // SHOW TRANSLATED STRING ON UI.
            TxtGermanSentence.Text = German;
        }

        private void _menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call 909-0191-0029",
    "Help Message");
        }
    }
}
