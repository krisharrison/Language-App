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
    public partial class Login : Form
    {
        // Author : 	Altamimi, Hussein 
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             // CREATE ACCOUNT HELPER OBJECT.
            AccountHelper accountHelper = new AccountHelper();
            // GET USER FROM ACCOUNT HELPER WITH PROVIDED USERNAME & PASSWORD
            User Checkuser = accountHelper.Authenticate(txtUserName.Text, txtPass.Text);
             
            //SqlDataReader dr;
            MainMenu mainMenu = new MainMenu();
            // IF USER IS NOT NULL, IT MEANS USERNAME AND PASSWORD BELONGS TO SOME USER. 
            // USER HAS LOGGED IN
            if (Checkuser != null)
            {


                 this.Hide();
                Form main = new MainMenu();
                main.Show();
                // PUT DATA ON UI
                ((MainMenu)main).Controls["lblId"].Text = Checkuser.Id.ToString();
                ((MainMenu)main).Controls["lblUserName"].Text = Checkuser.Username; ;
                ((MainMenu)main).Controls["lblTheme"].Text = Checkuser.Theme;
                ((MainMenu)main).Controls["lblScore"].Text = Checkuser.LastScore.ToString();


            }
            else
            {
                // GIVEN USERNAME AND PASSWORD IS INCORRECT.
                MessageBox.Show("sorry the userName and or Password are wrong", "Error");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (rbtnBlue.Checked)
            {
                lblColor.Text = "blue";
            }
            if (rbtnRed.Checked)
            {
                lblColor.Text = "red";
            }
            if (rbtnGreen.Checked)
            {
                lblColor.Text = "green";
            }

            if (txtRPass.Text == txtVRPass.Text)
            {
                if (txtRUserName.Text != "" & txtRPass.Text != "" & lblColor.Text != "")
                {

                    AccountHelper accountHelper = new AccountHelper();
                    if (accountHelper.CreateAccount(txtRUserName.Text, txtRPass.Text, lblColor.Text))
                    {

                        MessageBox.Show("Thanks for registering, please sign in Now", "Success");
                    }
                    else
                    {

                        MessageBox.Show("Issue with your input or Input incomplete", "Error");
                    }







                }

                else
                {
                    MessageBox.Show("Issue with your input or Input incomplete", "Error");
                }
            }
            else
            {
                MessageBox.Show("passwords do not match", "Error");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void grpReg_Enter(object sender, EventArgs e)
        {

        }



        // end of login 
    }
}

