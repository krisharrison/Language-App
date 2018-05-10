namespace Vitamin_C
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLUsername = new System.Windows.Forms.Label();
            this.lblLpass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpReg = new System.Windows.Forms.GroupBox();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtVRPass = new System.Windows.Forms.TextBox();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblVpass = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRUserName = new System.Windows.Forms.TextBox();
            this.grpReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(58, 65);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblLUsername
            // 
            this.lblLUsername.AutoSize = true;
            this.lblLUsername.Location = new System.Drawing.Point(113, 101);
            this.lblLUsername.Name = "lblLUsername";
            this.lblLUsername.Size = new System.Drawing.Size(79, 17);
            this.lblLUsername.TabIndex = 2;
            this.lblLUsername.Text = "UserName:";
            // 
            // lblLpass
            // 
            this.lblLpass.AutoSize = true;
            this.lblLpass.Location = new System.Drawing.Point(113, 157);
            this.lblLpass.Name = "lblLpass";
            this.lblLpass.Size = new System.Drawing.Size(73, 17);
            this.lblLpass.TabIndex = 3;
            this.lblLpass.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(222, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 26);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpReg
            // 
            this.grpReg.Controls.Add(this.rbtnGreen);
            this.grpReg.Controls.Add(this.rbtnRed);
            this.grpReg.Controls.Add(this.rbtnBlue);
            this.grpReg.Controls.Add(this.lblColor);
            this.grpReg.Controls.Add(this.txtVRPass);
            this.grpReg.Controls.Add(this.txtRPass);
            this.grpReg.Controls.Add(this.btnReg);
            this.grpReg.Controls.Add(this.lblTheme);
            this.grpReg.Controls.Add(this.lblVpass);
            this.grpReg.Controls.Add(this.lblpass);
            this.grpReg.Controls.Add(this.lblUsername);
            this.grpReg.Location = new System.Drawing.Point(32, 298);
            this.grpReg.Name = "grpReg";
            this.grpReg.Size = new System.Drawing.Size(471, 328);
            this.grpReg.TabIndex = 10;
            this.grpReg.TabStop = false;
            this.grpReg.Text = "Register";
            this.grpReg.Enter += new System.EventHandler(this.grpReg_Enter);
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(360, 216);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(69, 21);
            this.rbtnGreen.TabIndex = 22;
            this.rbtnGreen.TabStop = true;
            this.rbtnGreen.Text = "Green";
            this.rbtnGreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnGreen.UseVisualStyleBackColor = true;
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Location = new System.Drawing.Point(274, 218);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(55, 21);
            this.rbtnRed.TabIndex = 21;
            this.rbtnRed.TabStop = true;
            this.rbtnRed.Text = "Red";
            this.rbtnRed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnRed.UseVisualStyleBackColor = true;
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Location = new System.Drawing.Point(183, 218);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(57, 21);
            this.rbtnBlue.TabIndex = 20;
            this.rbtnBlue.TabStop = true;
            this.rbtnBlue.Text = "Blue";
            this.rbtnBlue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnBlue.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(383, 107);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(0, 17);
            this.lblColor.TabIndex = 19;
            this.lblColor.Visible = false;
            // 
            // txtVRPass
            // 
            this.txtVRPass.Location = new System.Drawing.Point(183, 164);
            this.txtVRPass.Name = "txtVRPass";
            this.txtVRPass.Size = new System.Drawing.Size(100, 22);
            this.txtVRPass.TabIndex = 18;
            this.txtVRPass.UseSystemPasswordChar = true;
            // 
            // txtRPass
            // 
            this.txtRPass.Location = new System.Drawing.Point(183, 102);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.Size = new System.Drawing.Size(100, 22);
            this.txtRPass.TabIndex = 14;
            this.txtRPass.UseSystemPasswordChar = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(190, 279);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 28);
            this.btnReg.TabIndex = 17;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(55, 218);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(99, 17);
            this.lblTheme.TabIndex = 15;
            this.lblTheme.Text = "Select Theme:";
            // 
            // lblVpass
            // 
            this.lblVpass.AutoSize = true;
            this.lblVpass.Location = new System.Drawing.Point(37, 164);
            this.lblVpass.Name = "lblVpass";
            this.lblVpass.Size = new System.Drawing.Size(113, 17);
            this.lblVpass.TabIndex = 14;
            this.lblVpass.Text = "Verify Password:";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(77, 107);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(73, 17);
            this.lblpass.TabIndex = 13;
            this.lblpass.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(77, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 17);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "UserName:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(222, 101);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(222, 157);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 22);
            this.txtPass.TabIndex = 12;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtRUserName
            // 
            this.txtRUserName.Location = new System.Drawing.Point(215, 349);
            this.txtRUserName.Name = "txtRUserName";
            this.txtRUserName.Size = new System.Drawing.Size(100, 22);
            this.txtRUserName.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 665);
            this.Controls.Add(this.txtRUserName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.grpReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLpass);
            this.Controls.Add(this.lblLUsername);
            this.Controls.Add(this.lblLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.grpReg.ResumeLayout(false);
            this.grpReg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLUsername;
        private System.Windows.Forms.Label lblLpass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpReg;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtVRPass;
        private System.Windows.Forms.TextBox txtRPass;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblVpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRUserName;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.RadioButton rbtnBlue;
    }
}

