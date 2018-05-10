namespace Vitamin_C
{
    partial class FlashCard
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
            this._lblCurrentScore = new System.Windows.Forms.Label();
            this._lblOverallScore = new System.Windows.Forms.Label();
            this._lblResult = new System.Windows.Forms.Label();
            this._btnCheck = new System.Windows.Forms.Button();
            this._txtInput = new System.Windows.Forms.TextBox();
            this._lblRandomWord = new System.Windows.Forms.Label();
            this._lblScore = new System.Windows.Forms.Label();
            this._lblCScore = new System.Windows.Forms.Label();
            this._lblUserName = new System.Windows.Forms.Label();
            this._lblUserID = new System.Windows.Forms.Label();
            this._lblTheme = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblCurrentScore
            // 
            this._lblCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCurrentScore.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblCurrentScore.Location = new System.Drawing.Point(392, 273);
            this._lblCurrentScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblCurrentScore.Name = "_lblCurrentScore";
            this._lblCurrentScore.Size = new System.Drawing.Size(154, 39);
            this._lblCurrentScore.TabIndex = 16;
            this._lblCurrentScore.Text = "Current Score: ";
            this._lblCurrentScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblOverallScore
            // 
            this._lblOverallScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblOverallScore.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._lblOverallScore.Location = new System.Drawing.Point(86, 268);
            this._lblOverallScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblOverallScore.Name = "_lblOverallScore";
            this._lblOverallScore.Size = new System.Drawing.Size(156, 51);
            this._lblOverallScore.TabIndex = 15;
            this._lblOverallScore.Text = "Last Score: ";
            this._lblOverallScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblOverallScore.Click += new System.EventHandler(this._lblOverallScore_Click);
            // 
            // _lblResult
            // 
            this._lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblResult.Location = new System.Drawing.Point(188, 219);
            this._lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblResult.Name = "_lblResult";
            this._lblResult.Size = new System.Drawing.Size(244, 72);
            this._lblResult.TabIndex = 14;
            this._lblResult.Text = "Result";
            this._lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnCheck
            // 
            this._btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCheck.Location = new System.Drawing.Point(258, 172);
            this._btnCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._btnCheck.Name = "_btnCheck";
            this._btnCheck.Size = new System.Drawing.Size(102, 39);
            this._btnCheck.TabIndex = 11;
            this._btnCheck.Text = "Check";
            this._btnCheck.UseVisualStyleBackColor = true;
            this._btnCheck.Click += new System.EventHandler(this._btnCheck_Click);
            // 
            // _txtInput
            // 
            this._txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtInput.Location = new System.Drawing.Point(218, 117);
            this._txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtInput.Name = "_txtInput";
            this._txtInput.Size = new System.Drawing.Size(206, 41);
            this._txtInput.TabIndex = 10;
            // 
            // _lblRandomWord
            // 
            this._lblRandomWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRandomWord.Location = new System.Drawing.Point(178, 37);
            this._lblRandomWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblRandomWord.Name = "_lblRandomWord";
            this._lblRandomWord.Size = new System.Drawing.Size(281, 89);
            this._lblRandomWord.TabIndex = 9;
            this._lblRandomWord.Text = "Random Word";
            this._lblRandomWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblScore
            // 
            this._lblScore.AutoSize = true;
            this._lblScore.Location = new System.Drawing.Point(129, 317);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(45, 17);
            this._lblScore.TabIndex = 17;
            this._lblScore.Text = "Score";
            // 
            // _lblCScore
            // 
            this._lblCScore.AutoSize = true;
            this._lblCScore.Location = new System.Drawing.Point(451, 317);
            this._lblCScore.Name = "_lblCScore";
            this._lblCScore.Size = new System.Drawing.Size(13, 17);
            this._lblCScore.TabIndex = 18;
            this._lblCScore.Text = "-";
            // 
            // _lblUserName
            // 
            this._lblUserName.AutoSize = true;
            this._lblUserName.Location = new System.Drawing.Point(26, 136);
            this._lblUserName.Name = "_lblUserName";
            this._lblUserName.Size = new System.Drawing.Size(75, 17);
            this._lblUserName.TabIndex = 20;
            this._lblUserName.Text = "UserName";
            this._lblUserName.Visible = false;
            // 
            // _lblUserID
            // 
            this._lblUserID.AutoSize = true;
            this._lblUserID.Location = new System.Drawing.Point(23, 80);
            this._lblUserID.Name = "_lblUserID";
            this._lblUserID.Size = new System.Drawing.Size(21, 17);
            this._lblUserID.TabIndex = 19;
            this._lblUserID.Text = "ID";
            this._lblUserID.Visible = false;
            // 
            // _lblTheme
            // 
            this._lblTheme.AutoSize = true;
            this._lblTheme.Location = new System.Drawing.Point(29, 202);
            this._lblTheme.Name = "_lblTheme";
            this._lblTheme.Size = new System.Drawing.Size(52, 17);
            this._lblTheme.TabIndex = 21;
            this._lblTheme.Text = "Theme";
            this._lblTheme.Visible = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(630, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this._menuAbout.Size = new System.Drawing.Size(216, 26);
            this._menuAbout.Text = "About";
            this._menuAbout.Click += new System.EventHandler(this._menuAbout_Click);
            // 
            // FlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 374);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._lblTheme);
            this.Controls.Add(this._lblUserName);
            this.Controls.Add(this._lblUserID);
            this.Controls.Add(this._lblCScore);
            this.Controls.Add(this._lblScore);
            this.Controls.Add(this._lblCurrentScore);
            this.Controls.Add(this._lblOverallScore);
            this.Controls.Add(this._lblResult);
            this.Controls.Add(this._btnCheck);
            this.Controls.Add(this._txtInput);
            this.Controls.Add(this._lblRandomWord);
            this.Name = "FlashCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlashCard";
            this.Load += new System.EventHandler(this.FlashCard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblCurrentScore;
        private System.Windows.Forms.Label _lblOverallScore;
        private System.Windows.Forms.Label _lblResult;
        private System.Windows.Forms.Button _btnCheck;
        private System.Windows.Forms.TextBox _txtInput;
        private System.Windows.Forms.Label _lblRandomWord;
        public System.Windows.Forms.Label _lblScore;
        private System.Windows.Forms.Label _lblCScore;
        private System.Windows.Forms.Label _lblUserName;
        private System.Windows.Forms.Label _lblUserID;
        private System.Windows.Forms.Label _lblTheme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuFileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem _menuFileLogout;
        private System.Windows.Forms.ToolStripMenuItem _menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuAbout;
    }
}