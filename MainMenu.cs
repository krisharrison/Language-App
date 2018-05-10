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
    public partial class MainMenu : Form
    {
        // Author : 	Altamimi, Hussein 

        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _imgDictionary_Click(object sender, EventArgs e)
        {
            Form DicCon = new DictionaryForm();
            DicCon.Show();
            ((DictionaryForm)DicCon).Controls["_lblScore"].Text = lblScore.Text;
            ((DictionaryForm)DicCon).Controls["_lblUserID"].Text = lblId.Text;
            ((DictionaryForm)DicCon).Controls["_lblUserName"].Text = lblUserName.Text;
            ((DictionaryForm)DicCon).Controls["_lblTheme"].Text = lblTheme.Text;
            string theme = lblTheme.Text;
            if (theme == "Blue")
            {
                ((DictionaryForm)DicCon).BackColor = Color.Blue;
                ((DictionaryForm)DicCon).ForeColor = Color.Yellow;
            }

            if (theme == "Red")
            {
                ((DictionaryForm)DicCon).BackColor = Color.Red;
                ((DictionaryForm)DicCon).ForeColor = Color.Snow;
            }

            if (theme == "Green")
            {
                ((DictionaryForm)DicCon).BackColor = Color.Green;
                ((DictionaryForm)DicCon).ForeColor = Color.SkyBlue;
            }
            this.Close();

        }


        // send info to flashcard
        private void _imgFlashCard_Click(object sender, EventArgs e)
        {
            Form Flash = new FlashCard();
            Flash.Show();
            ((FlashCard)Flash).Controls["_lblScore"].Text = lblScore.Text; 
            ((FlashCard)Flash).Controls["_lblUserID"].Text = lblId.Text;
            ((FlashCard)Flash).Controls["_lblUserName"].Text = lblUserName.Text;
            ((FlashCard)Flash).Controls["_lblTheme"].Text = lblTheme.Text;

            string theme = lblTheme.Text;
            if (theme == "Blue")
            {
                ((FlashCard)Flash).BackColor = Color.Blue;
                ((FlashCard)Flash).ForeColor = Color.Yellow;
            }

            if (theme == "Red")
            {
                ((FlashCard)Flash).BackColor = Color.Red;
                ((FlashCard)Flash).ForeColor = Color.Snow;
            }

            if (theme == "Green")
            {
                ((FlashCard)Flash).BackColor = Color.Green;
                ((FlashCard)Flash).ForeColor = Color.SkyBlue;
            }
            this.Close();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
          
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void _menuFileLogout_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Close();
        }

        private void _imgSentance_Click(object sender, EventArgs e)
        {
            Form Sent = new Sentances();
            Sent.Show();
            ((Sentances)Sent).Controls["_lblScore"].Text = lblScore.Text;
            ((Sentances)Sent).Controls["_lblUserID"].Text = lblId.Text;
            ((Sentances)Sent).Controls["_lblUserName"].Text = lblUserName.Text;
            ((Sentances)Sent).Controls["_lblTheme"].Text = lblTheme.Text;
            string theme = lblTheme.Text;
            if (theme == "Blue")
            {
                ((Sentances)Sent).BackColor = Color.Blue;
                ((Sentances)Sent).ForeColor = Color.Yellow;
            }

            if (theme == "Red")
            {
                ((Sentances)Sent).BackColor = Color.Red;
                ((Sentances)Sent).ForeColor = Color.Snow;
            }

            if (theme == "Green")
            {
                ((Sentances)Sent).BackColor = Color.Green;
                ((Sentances)Sent).ForeColor = Color.SkyBlue;
            }
            this.Close();
        }


        private void _menuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call 909-0191-0029",
"Help Message");
        }
    }
}
