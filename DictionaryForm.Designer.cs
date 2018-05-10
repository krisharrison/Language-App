namespace Vitamin_C
{
    partial class DictionaryForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lstGerman = new System.Windows.Forms.ListBox();
            this._lstEnglish = new System.Windows.Forms.ListBox();
            this._txtSearch = new System.Windows.Forms.TextBox();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnSearch = new System.Windows.Forms.Button();
            this._txtArticle = new System.Windows.Forms.TextBox();
            this._txtGerman = new System.Windows.Forms.TextBox();
            this._txtEnglish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this._menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._lblTheme = new System.Windows.Forms.Label();
            this._lblUserName = new System.Windows.Forms.Label();
            this._lblUserID = new System.Windows.Forms.Label();
            this._lblScore = new System.Windows.Forms.Label();
            this._errorMessage = new System.Windows.Forms.Label();
            this._lstArticle = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this._lblErrorMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "German";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "English";
            // 
            // _lstGerman
            // 
            this._lstGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lstGerman.FormattingEnabled = true;
            this._lstGerman.ItemHeight = 25;
            this._lstGerman.Location = new System.Drawing.Point(519, 320);
            this._lstGerman.Margin = new System.Windows.Forms.Padding(4);
            this._lstGerman.Name = "_lstGerman";
            this._lstGerman.Size = new System.Drawing.Size(233, 129);
            this._lstGerman.TabIndex = 32;
            this._lstGerman.SelectedIndexChanged += new System.EventHandler(this._lstGerman_SelectedIndexChanged);
            // 
            // _lstEnglish
            // 
            this._lstEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lstEnglish.FormattingEnabled = true;
            this._lstEnglish.ItemHeight = 25;
            this._lstEnglish.Location = new System.Drawing.Point(16, 320);
            this._lstEnglish.Margin = new System.Windows.Forms.Padding(4);
            this._lstEnglish.Name = "_lstEnglish";
            this._lstEnglish.Size = new System.Drawing.Size(233, 129);
            this._lstEnglish.TabIndex = 31;
            this._lstEnglish.SelectedIndexChanged += new System.EventHandler(this._lstEnglish_SelectedIndexChanged);
            // 
            // _txtSearch
            // 
            this._txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSearch.Location = new System.Drawing.Point(49, 129);
            this._txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.Size = new System.Drawing.Size(132, 30);
            this._txtSearch.TabIndex = 29;
            // 
            // _btnUpdate
            // 
            this._btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUpdate.Location = new System.Drawing.Point(237, 239);
            this._btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this._btnUpdate.Name = "_btnUpdate";
            this._btnUpdate.Size = new System.Drawing.Size(100, 28);
            this._btnUpdate.TabIndex = 28;
            this._btnUpdate.Text = "Update";
            this._btnUpdate.UseVisualStyleBackColor = true;
            this._btnUpdate.Click += new System.EventHandler(this._btnUpdate_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDelete.Location = new System.Drawing.Point(359, 239);
            this._btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(100, 28);
            this._btnDelete.TabIndex = 27;
            this._btnDelete.Text = "Delete";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSave.Location = new System.Drawing.Point(483, 239);
            this._btnSave.Margin = new System.Windows.Forms.Padding(4);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(99, 28);
            this._btnSave.TabIndex = 26;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnSearch
            // 
            this._btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSearch.Location = new System.Drawing.Point(49, 91);
            this._btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(100, 30);
            this._btnSearch.TabIndex = 25;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _txtArticle
            // 
            this._txtArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtArticle.Location = new System.Drawing.Point(303, 161);
            this._txtArticle.Margin = new System.Windows.Forms.Padding(4);
            this._txtArticle.Name = "_txtArticle";
            this._txtArticle.Size = new System.Drawing.Size(51, 30);
            this._txtArticle.TabIndex = 24;
            // 
            // _txtGerman
            // 
            this._txtGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtGerman.Location = new System.Drawing.Point(385, 161);
            this._txtGerman.Margin = new System.Windows.Forms.Padding(4);
            this._txtGerman.Name = "_txtGerman";
            this._txtGerman.Size = new System.Drawing.Size(132, 30);
            this._txtGerman.TabIndex = 22;
            // 
            // _txtEnglish
            // 
            this._txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEnglish.Location = new System.Drawing.Point(303, 98);
            this._txtEnglish.Margin = new System.Windows.Forms.Padding(4);
            this._txtEnglish.Name = "_txtEnglish";
            this._txtEnglish.Size = new System.Drawing.Size(132, 30);
            this._txtEnglish.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "German";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "English";
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
            this.menuStrip1.Size = new System.Drawing.Size(783, 28);
            this.menuStrip1.TabIndex = 23;
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
            this._menuAbout.Size = new System.Drawing.Size(125, 26);
            this._menuAbout.Text = "About";
            this._menuAbout.Click += new System.EventHandler(this._menuAbout_Click);
            // 
            // _lblTheme
            // 
            this._lblTheme.AutoSize = true;
            this._lblTheme.Location = new System.Drawing.Point(639, 125);
            this._lblTheme.Name = "_lblTheme";
            this._lblTheme.Size = new System.Drawing.Size(52, 17);
            this._lblTheme.TabIndex = 37;
            this._lblTheme.Text = "Theme";
            this._lblTheme.Visible = false;
            // 
            // _lblUserName
            // 
            this._lblUserName.AutoSize = true;
            this._lblUserName.Location = new System.Drawing.Point(639, 77);
            this._lblUserName.Name = "_lblUserName";
            this._lblUserName.Size = new System.Drawing.Size(75, 17);
            this._lblUserName.TabIndex = 36;
            this._lblUserName.Text = "UserName";
            this._lblUserName.Visible = false;
            // 
            // _lblUserID
            // 
            this._lblUserID.AutoSize = true;
            this._lblUserID.Location = new System.Drawing.Point(656, 45);
            this._lblUserID.Name = "_lblUserID";
            this._lblUserID.Size = new System.Drawing.Size(21, 17);
            this._lblUserID.TabIndex = 35;
            this._lblUserID.Text = "ID";
            this._lblUserID.Visible = false;
            // 
            // _lblScore
            // 
            this._lblScore.AutoSize = true;
            this._lblScore.Location = new System.Drawing.Point(646, 166);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(45, 17);
            this._lblScore.TabIndex = 38;
            this._lblScore.Text = "Score";
            this._lblScore.Visible = false;
            // 
            // _errorMessage
            // 
            this._errorMessage.AutoSize = true;
            this._errorMessage.Location = new System.Drawing.Point(215, 30);
            this._errorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._errorMessage.Name = "_errorMessage";
            this._errorMessage.Size = new System.Drawing.Size(0, 17);
            this._errorMessage.TabIndex = 39;
            // 
            // _lstArticle
            // 
            this._lstArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lstArticle.FormattingEnabled = true;
            this._lstArticle.ItemHeight = 25;
            this._lstArticle.Location = new System.Drawing.Point(261, 320);
            this._lstArticle.Margin = new System.Windows.Forms.Padding(4);
            this._lstArticle.Name = "_lstArticle";
            this._lstArticle.Size = new System.Drawing.Size(233, 129);
            this._lstArticle.TabIndex = 40;
            this._lstArticle.SelectedIndexChanged += new System.EventHandler(this._lstArticle_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "German Article";
            // 
            // _lblErrorMessage
            // 
            this._lblErrorMessage.AutoSize = true;
            this._lblErrorMessage.Location = new System.Drawing.Point(308, 34);
            this._lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblErrorMessage.Name = "_lblErrorMessage";
            this._lblErrorMessage.Size = new System.Drawing.Size(0, 17);
            this._lblErrorMessage.TabIndex = 42;
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 492);
            this.Controls.Add(this._lblErrorMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._lstArticle);
            this.Controls.Add(this._errorMessage);
            this.Controls.Add(this._lblScore);
            this.Controls.Add(this._lblTheme);
            this.Controls.Add(this._lblUserName);
            this.Controls.Add(this._lblUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lstGerman);
            this.Controls.Add(this._lstEnglish);
            this.Controls.Add(this._txtSearch);
            this.Controls.Add(this._btnUpdate);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnSearch);
            this.Controls.Add(this._txtArticle);
            this.Controls.Add(this._txtGerman);
            this.Controls.Add(this._txtEnglish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DictionaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.DictionaryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _lstGerman;
        private System.Windows.Forms.ListBox _lstEnglish;
        private System.Windows.Forms.TextBox _txtSearch;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.TextBox _txtArticle;
        private System.Windows.Forms.TextBox _txtGerman;
        private System.Windows.Forms.TextBox _txtEnglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuFileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem _menuFileLogout;
        private System.Windows.Forms.ToolStripMenuItem _menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _menuAbout;
        private System.Windows.Forms.Label _lblTheme;
        private System.Windows.Forms.Label _lblUserName;
        private System.Windows.Forms.Label _lblUserID;
        public System.Windows.Forms.Label _lblScore;
        private System.Windows.Forms.Label _errorMessage;
        private System.Windows.Forms.ListBox _lstArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lblErrorMessage;
    }
}