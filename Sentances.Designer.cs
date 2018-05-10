namespace Vitamin_C
{
    partial class Sentances
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
            this._lblUserID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEnglishSentence = new System.Windows.Forms.TextBox();
            this.TxtGermanSentence = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._lblTheme = new System.Windows.Forms.Label();
            this._lblScore = new System.Windows.Forms.Label();
            this._lblUserName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblUserID
            // 
            this._lblUserID.AutoSize = true;
            this._lblUserID.Location = new System.Drawing.Point(491, 97);
            this._lblUserID.Name = "_lblUserID";
            this._lblUserID.Size = new System.Drawing.Size(21, 17);
            this._lblUserID.TabIndex = 25;
            this._lblUserID.Text = "ID";
            this._lblUserID.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(613, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuFileMainMenu,
            this._menuFileLogout,
            this._menuFileClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // _menuFileMainMenu
            // 
            this._menuFileMainMenu.Name = "_menuFileMainMenu";
            this._menuFileMainMenu.Size = new System.Drawing.Size(154, 26);
            this._menuFileMainMenu.Text = "MainMenu";
            this._menuFileMainMenu.Click += new System.EventHandler(this._menuFileMainMenu_Click);
            // 
            // _menuFileLogout
            // 
            this._menuFileLogout.Name = "_menuFileLogout";
            this._menuFileLogout.Size = new System.Drawing.Size(154, 26);
            this._menuFileLogout.Text = "Logout";
            this._menuFileLogout.Click += new System.EventHandler(this._menuFileLogout_Click);
            // 
            // _menuFileClose
            // 
            this._menuFileClose.Name = "_menuFileClose";
            this._menuFileClose.Size = new System.Drawing.Size(154, 26);
            this._menuFileClose.Text = "Close";
            this._menuFileClose.Click += new System.EventHandler(this._menuFileClose_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // _menuAbout
            // 
            this._menuAbout.Name = "_menuAbout";
            this._menuAbout.Size = new System.Drawing.Size(125, 26);
            this._menuAbout.Text = "About";
            this._menuAbout.Click += new System.EventHandler(this._menuAbout_Click);
            // 
            // txtEnglishSentence
            // 
            this.txtEnglishSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishSentence.Location = new System.Drawing.Point(51, 78);
            this.txtEnglishSentence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnglishSentence.Name = "txtEnglishSentence";
            this.txtEnglishSentence.Size = new System.Drawing.Size(387, 28);
            this.txtEnglishSentence.TabIndex = 30;
            // 
            // TxtGermanSentence
            // 
            this.TxtGermanSentence.AutoSize = true;
            this.TxtGermanSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGermanSentence.Location = new System.Drawing.Point(48, 157);
            this.TxtGermanSentence.Name = "TxtGermanSentence";
            this.TxtGermanSentence.Size = new System.Drawing.Size(0, 29);
            this.TxtGermanSentence.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Enter English Sentence: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 33;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lblTheme
            // 
            this._lblTheme.AutoSize = true;
            this._lblTheme.Location = new System.Drawing.Point(476, 128);
            this._lblTheme.Name = "_lblTheme";
            this._lblTheme.Size = new System.Drawing.Size(52, 17);
            this._lblTheme.TabIndex = 27;
            this._lblTheme.Text = "Theme";
            this._lblTheme.Visible = false;
            // 
            // _lblScore
            // 
            this._lblScore.AutoSize = true;
            this._lblScore.Location = new System.Drawing.Point(476, 157);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(45, 17);
            this._lblScore.TabIndex = 34;
            this._lblScore.Text = "Score";
            this._lblScore.Visible = false;
            // 
            // _lblUserName
            // 
            this._lblUserName.AutoSize = true;
            this._lblUserName.Location = new System.Drawing.Point(476, 193);
            this._lblUserName.Name = "_lblUserName";
            this._lblUserName.Size = new System.Drawing.Size(75, 17);
            this._lblUserName.TabIndex = 35;
            this._lblUserName.Text = "UserName";
            this._lblUserName.Visible = false;
            // 
            // Sentances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 274);
            this.Controls.Add(this._lblUserName);
            this.Controls.Add(this._lblScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtGermanSentence);
            this.Controls.Add(this.txtEnglishSentence);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._lblTheme);
            this.Controls.Add(this._lblUserID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sentances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentances";
            this.Load += new System.EventHandler(this.Sentances_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lblUserID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuFileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem _menuFileLogout;
        private System.Windows.Forms.ToolStripMenuItem _menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuAbout;
        private System.Windows.Forms.TextBox txtEnglishSentence;
        private System.Windows.Forms.Label TxtGermanSentence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _lblTheme;
        private System.Windows.Forms.Label _lblScore;
        private System.Windows.Forms.Label _lblUserName;
    }
}