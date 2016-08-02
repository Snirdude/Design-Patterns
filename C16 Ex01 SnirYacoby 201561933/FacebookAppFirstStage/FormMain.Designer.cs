namespace FacebookAppFirstStage
{
    partial class FormMain
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.listViewMostActiveFriends = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonGetFriends = new System.Windows.Forms.Button();
            this.buttonGetFriendsByActivity = new System.Windows.Forms.Button();
            this.listBoxPicturesWithFriend = new System.Windows.Forms.ListBox();
            this.buttonGetPicturesWithFriend = new System.Windows.Forms.Button();
            this.comboBoxChooseFriend = new System.Windows.Forms.ComboBox();
            this.labelFriendFilter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(135, 48);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(12, 66);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(135, 44);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(508, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(101, 98);
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 165);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(135, 251);
            this.listBoxFriends.TabIndex = 3;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Enabled = false;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(12, 116);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 6;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // listViewMostActiveFriends
            // 
            this.listViewMostActiveFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPercent});
            this.listViewMostActiveFriends.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listViewMostActiveFriends.Location = new System.Drawing.Point(153, 165);
            this.listViewMostActiveFriends.Name = "listViewMostActiveFriends";
            this.listViewMostActiveFriends.Size = new System.Drawing.Size(234, 251);
            this.listViewMostActiveFriends.TabIndex = 7;
            this.listViewMostActiveFriends.UseCompatibleStateImageBehavior = false;
            this.listViewMostActiveFriends.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 113;
            // 
            // columnHeaderPercent
            // 
            this.columnHeaderPercent.Text = "Activity In Your Profile";
            this.columnHeaderPercent.Width = 116;
            // 
            // buttonGetFriends
            // 
            this.buttonGetFriends.Location = new System.Drawing.Point(12, 136);
            this.buttonGetFriends.Name = "buttonGetFriends";
            this.buttonGetFriends.Size = new System.Drawing.Size(135, 23);
            this.buttonGetFriends.TabIndex = 8;
            this.buttonGetFriends.Text = "Get Friends";
            this.buttonGetFriends.UseVisualStyleBackColor = true;
            this.buttonGetFriends.Click += new System.EventHandler(this.buttonGetFriends_Click);
            // 
            // buttonGetFriendsByActivity
            // 
            this.buttonGetFriendsByActivity.Location = new System.Drawing.Point(153, 136);
            this.buttonGetFriendsByActivity.Name = "buttonGetFriendsByActivity";
            this.buttonGetFriendsByActivity.Size = new System.Drawing.Size(234, 23);
            this.buttonGetFriendsByActivity.TabIndex = 9;
            this.buttonGetFriendsByActivity.Text = "Get Most Active Friends";
            this.buttonGetFriendsByActivity.UseVisualStyleBackColor = true;
            this.buttonGetFriendsByActivity.Click += new System.EventHandler(this.buttonGetFriendsByActivity_Click);
            // 
            // listBoxPicturesWithFriend
            // 
            this.listBoxPicturesWithFriend.FormattingEnabled = true;
            this.listBoxPicturesWithFriend.Location = new System.Drawing.Point(394, 191);
            this.listBoxPicturesWithFriend.Name = "listBoxPicturesWithFriend";
            this.listBoxPicturesWithFriend.Size = new System.Drawing.Size(214, 225);
            this.listBoxPicturesWithFriend.TabIndex = 10;
            this.listBoxPicturesWithFriend.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPicturesWithFriend_MouseDoubleClick);
            // 
            // buttonGetPicturesWithFriend
            // 
            this.buttonGetPicturesWithFriend.Location = new System.Drawing.Point(393, 165);
            this.buttonGetPicturesWithFriend.Name = "buttonGetPicturesWithFriend";
            this.buttonGetPicturesWithFriend.Size = new System.Drawing.Size(214, 23);
            this.buttonGetPicturesWithFriend.TabIndex = 11;
            this.buttonGetPicturesWithFriend.Text = "Get Pictures With Friend";
            this.buttonGetPicturesWithFriend.UseVisualStyleBackColor = true;
            this.buttonGetPicturesWithFriend.Click += new System.EventHandler(this.buttonGetPicturesWithFriend_Click);
            // 
            // comboBoxChooseFriend
            // 
            this.comboBoxChooseFriend.FormattingEnabled = true;
            this.comboBoxChooseFriend.Location = new System.Drawing.Point(393, 138);
            this.comboBoxChooseFriend.Name = "comboBoxChooseFriend";
            this.comboBoxChooseFriend.Size = new System.Drawing.Size(214, 21);
            this.comboBoxChooseFriend.TabIndex = 12;
            // 
            // labelFriendFilter
            // 
            this.labelFriendFilter.AutoSize = true;
            this.labelFriendFilter.Location = new System.Drawing.Point(391, 120);
            this.labelFriendFilter.Name = "labelFriendFilter";
            this.labelFriendFilter.Size = new System.Drawing.Size(64, 13);
            this.labelFriendFilter.TabIndex = 13;
            this.labelFriendFilter.Text = "Friend Filter:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Events";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Post";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacebookAppFirstStage.Properties.Resources.Facebook_create;
            this.pictureBox1.Location = new System.Drawing.Point(153, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFriendFilter);
            this.Controls.Add(this.comboBoxChooseFriend);
            this.Controls.Add(this.buttonGetPicturesWithFriend);
            this.Controls.Add(this.listBoxPicturesWithFriend);
            this.Controls.Add(this.buttonGetFriendsByActivity);
            this.Controls.Add(this.buttonGetFriends);
            this.Controls.Add(this.listViewMostActiveFriends);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.ListView listViewMostActiveFriends;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPercent;
        private System.Windows.Forms.Button buttonGetFriends;
        private System.Windows.Forms.Button buttonGetFriendsByActivity;
        private System.Windows.Forms.ListBox listBoxPicturesWithFriend;
        private System.Windows.Forms.Button buttonGetPicturesWithFriend;
        private System.Windows.Forms.ComboBox comboBoxChooseFriend;
        private System.Windows.Forms.Label labelFriendFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

