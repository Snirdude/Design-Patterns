namespace FacebookApp
{
    public partial class FormMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(string.Empty);
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
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelFriendFilter = new System.Windows.Forms.Label();
            this.gMapControlFriendCheckins = new GMap.NET.WindowsForms.GMapControl();
            this.numericUpDownLikeScore = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCommentScore = new System.Windows.Forms.NumericUpDown();
            this.labelLikeScore = new System.Windows.Forms.Label();
            this.labelCommentScore = new System.Windows.Forms.Label();
            this.labelStatusScore = new System.Windows.Forms.Label();
            this.numericUpDownStatusScore = new System.Windows.Forms.NumericUpDown();
            this.labelPostScore = new System.Windows.Forms.Label();
            this.numericUpDownPostScore = new System.Windows.Forms.NumericUpDown();
            this.labelTaggedUsersScore = new System.Windows.Forms.Label();
            this.numericUpDownTaggedUsersScore = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxUsers = new System.Windows.Forms.CheckedListBox();
            this.buttonGetCheckins = new System.Windows.Forms.Button();
            this.labelUsers = new System.Windows.Forms.Label();
            this.buttonNameGenerator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikeScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommentScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatusScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaggedUsersScore)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(95, 48);
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
            this.buttonLogout.Size = new System.Drawing.Size(95, 44);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(667, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(68, 74);
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 165);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(117, 134);
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
            listViewItem1});
            this.listViewMostActiveFriends.Location = new System.Drawing.Point(456, 165);
            this.listViewMostActiveFriends.Name = "listViewMostActiveFriends";
            this.listViewMostActiveFriends.Size = new System.Drawing.Size(279, 251);
            this.listViewMostActiveFriends.TabIndex = 7;
            this.listViewMostActiveFriends.UseCompatibleStateImageBehavior = false;
            this.listViewMostActiveFriends.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 130;
            // 
            // columnHeaderPercent
            // 
            this.columnHeaderPercent.Text = "Activity In Your Profile";
            this.columnHeaderPercent.Width = 142;
            // 
            // buttonGetFriends
            // 
            this.buttonGetFriends.Location = new System.Drawing.Point(12, 136);
            this.buttonGetFriends.Name = "buttonGetFriends";
            this.buttonGetFriends.Size = new System.Drawing.Size(117, 23);
            this.buttonGetFriends.TabIndex = 8;
            this.buttonGetFriends.Text = "Get Friends";
            this.buttonGetFriends.UseVisualStyleBackColor = true;
            this.buttonGetFriends.Click += new System.EventHandler(this.buttonGetFriends_Click);
            // 
            // buttonGetFriendsByActivity
            // 
            this.buttonGetFriendsByActivity.Location = new System.Drawing.Point(456, 136);
            this.buttonGetFriendsByActivity.Name = "buttonGetFriendsByActivity";
            this.buttonGetFriendsByActivity.Size = new System.Drawing.Size(279, 23);
            this.buttonGetFriendsByActivity.TabIndex = 9;
            this.buttonGetFriendsByActivity.Text = "Get Friends\' Activity";
            this.buttonGetFriendsByActivity.UseVisualStyleBackColor = true;
            this.buttonGetFriendsByActivity.Click += new System.EventHandler(this.buttonGetFriendsByActivity_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(12, 344);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(117, 33);
            this.buttonEvents.TabIndex = 14;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(12, 383);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(117, 34);
            this.buttonPost.TabIndex = 15;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelFriendFilter
            // 
            this.labelFriendFilter.AutoSize = true;
            this.labelFriendFilter.Location = new System.Drawing.Point(202, 47);
            this.labelFriendFilter.Name = "labelFriendFilter";
            this.labelFriendFilter.Size = new System.Drawing.Size(64, 13);
            this.labelFriendFilter.TabIndex = 13;
            this.labelFriendFilter.Text = "Friend Filter:";
            // 
            // gMapControlFriendCheckins
            // 
            this.gMapControlFriendCheckins.Bearing = 0F;
            this.gMapControlFriendCheckins.CanDragMap = true;
            this.gMapControlFriendCheckins.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlFriendCheckins.GrayScaleMode = false;
            this.gMapControlFriendCheckins.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlFriendCheckins.LevelsKeepInMemmory = 5;
            this.gMapControlFriendCheckins.Location = new System.Drawing.Point(135, 165);
            this.gMapControlFriendCheckins.MarkersEnabled = true;
            this.gMapControlFriendCheckins.MaxZoom = 17;
            this.gMapControlFriendCheckins.MinZoom = 0;
            this.gMapControlFriendCheckins.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlFriendCheckins.Name = "gMapControlFriendCheckins";
            this.gMapControlFriendCheckins.NegativeMode = false;
            this.gMapControlFriendCheckins.PolygonsEnabled = true;
            this.gMapControlFriendCheckins.RetryLoadTile = 0;
            this.gMapControlFriendCheckins.RoutesEnabled = true;
            this.gMapControlFriendCheckins.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlFriendCheckins.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlFriendCheckins.ShowTileGridLines = false;
            this.gMapControlFriendCheckins.Size = new System.Drawing.Size(315, 250);
            this.gMapControlFriendCheckins.TabIndex = 17;
            this.gMapControlFriendCheckins.Zoom = 6D;
            // 
            // numericUpDownLikeScore
            // 
            this.numericUpDownLikeScore.Location = new System.Drawing.Point(456, 28);
            this.numericUpDownLikeScore.Name = "numericUpDownLikeScore";
            this.numericUpDownLikeScore.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownLikeScore.TabIndex = 18;
            this.numericUpDownLikeScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCommentScore
            // 
            this.numericUpDownCommentScore.Location = new System.Drawing.Point(456, 66);
            this.numericUpDownCommentScore.Name = "numericUpDownCommentScore";
            this.numericUpDownCommentScore.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownCommentScore.TabIndex = 19;
            this.numericUpDownCommentScore.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelLikeScore
            // 
            this.labelLikeScore.AutoSize = true;
            this.labelLikeScore.Location = new System.Drawing.Point(453, 12);
            this.labelLikeScore.Name = "labelLikeScore";
            this.labelLikeScore.Size = new System.Drawing.Size(61, 13);
            this.labelLikeScore.TabIndex = 20;
            this.labelLikeScore.Text = "Like Score:";
            // 
            // labelCommentScore
            // 
            this.labelCommentScore.AutoSize = true;
            this.labelCommentScore.Location = new System.Drawing.Point(453, 51);
            this.labelCommentScore.Name = "labelCommentScore";
            this.labelCommentScore.Size = new System.Drawing.Size(85, 13);
            this.labelCommentScore.TabIndex = 21;
            this.labelCommentScore.Text = "Comment Score:";
            // 
            // labelStatusScore
            // 
            this.labelStatusScore.AutoSize = true;
            this.labelStatusScore.Location = new System.Drawing.Point(453, 89);
            this.labelStatusScore.Name = "labelStatusScore";
            this.labelStatusScore.Size = new System.Drawing.Size(71, 13);
            this.labelStatusScore.TabIndex = 22;
            this.labelStatusScore.Text = "Status Score:";
            // 
            // numericUpDownStatusScore
            // 
            this.numericUpDownStatusScore.Location = new System.Drawing.Point(456, 105);
            this.numericUpDownStatusScore.Name = "numericUpDownStatusScore";
            this.numericUpDownStatusScore.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownStatusScore.TabIndex = 23;
            this.numericUpDownStatusScore.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelPostScore
            // 
            this.labelPostScore.AutoSize = true;
            this.labelPostScore.Location = new System.Drawing.Point(553, 12);
            this.labelPostScore.Name = "labelPostScore";
            this.labelPostScore.Size = new System.Drawing.Size(62, 13);
            this.labelPostScore.TabIndex = 24;
            this.labelPostScore.Text = "Post Score:";
            // 
            // numericUpDownPostScore
            // 
            this.numericUpDownPostScore.Location = new System.Drawing.Point(556, 28);
            this.numericUpDownPostScore.Name = "numericUpDownPostScore";
            this.numericUpDownPostScore.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownPostScore.TabIndex = 25;
            this.numericUpDownPostScore.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelTaggedUsersScore
            // 
            this.labelTaggedUsersScore.AutoSize = true;
            this.labelTaggedUsersScore.Location = new System.Drawing.Point(553, 51);
            this.labelTaggedUsersScore.Name = "labelTaggedUsersScore";
            this.labelTaggedUsersScore.Size = new System.Drawing.Size(108, 13);
            this.labelTaggedUsersScore.TabIndex = 26;
            this.labelTaggedUsersScore.Text = "Tagged Users Score:";
            // 
            // numericUpDownTaggedUsersScore
            // 
            this.numericUpDownTaggedUsersScore.Location = new System.Drawing.Point(556, 66);
            this.numericUpDownTaggedUsersScore.Name = "numericUpDownTaggedUsersScore";
            this.numericUpDownTaggedUsersScore.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownTaggedUsersScore.TabIndex = 27;
            this.numericUpDownTaggedUsersScore.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkedListBoxUsers
            // 
            this.checkedListBoxUsers.FormattingEnabled = true;
            this.checkedListBoxUsers.Location = new System.Drawing.Point(135, 36);
            this.checkedListBoxUsers.Name = "checkedListBoxUsers";
            this.checkedListBoxUsers.Size = new System.Drawing.Size(206, 94);
            this.checkedListBoxUsers.TabIndex = 28;
            // 
            // buttonGetCheckins
            // 
            this.buttonGetCheckins.Location = new System.Drawing.Point(135, 136);
            this.buttonGetCheckins.Name = "buttonGetCheckins";
            this.buttonGetCheckins.Size = new System.Drawing.Size(315, 23);
            this.buttonGetCheckins.TabIndex = 29;
            this.buttonGetCheckins.Text = "Get Checkins";
            this.buttonGetCheckins.UseVisualStyleBackColor = true;
            this.buttonGetCheckins.Click += new System.EventHandler(this.buttonGetCheckins_Click);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Location = new System.Drawing.Point(132, 16);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(37, 13);
            this.labelUsers.TabIndex = 30;
            this.labelUsers.Text = "Users:";
            // 
            // buttonNameGenerator
            // 
            this.buttonNameGenerator.Location = new System.Drawing.Point(13, 306);
            this.buttonNameGenerator.Name = "buttonNameGenerator";
            this.buttonNameGenerator.Size = new System.Drawing.Size(116, 32);
            this.buttonNameGenerator.TabIndex = 31;
            this.buttonNameGenerator.Text = "Name Generator";
            this.buttonNameGenerator.UseVisualStyleBackColor = true;
            this.buttonNameGenerator.Click += new System.EventHandler(this.buttonNameGenerator_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 425);
            this.Controls.Add(this.buttonNameGenerator);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.buttonGetCheckins);
            this.Controls.Add(this.checkedListBoxUsers);
            this.Controls.Add(this.numericUpDownTaggedUsersScore);
            this.Controls.Add(this.labelTaggedUsersScore);
            this.Controls.Add(this.numericUpDownPostScore);
            this.Controls.Add(this.labelPostScore);
            this.Controls.Add(this.numericUpDownStatusScore);
            this.Controls.Add(this.labelStatusScore);
            this.Controls.Add(this.labelCommentScore);
            this.Controls.Add(this.labelLikeScore);
            this.Controls.Add(this.numericUpDownCommentScore);
            this.Controls.Add(this.numericUpDownLikeScore);
            this.Controls.Add(this.gMapControlFriendCheckins);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.labelFriendFilter);
            this.Controls.Add(this.buttonGetFriendsByActivity);
            this.Controls.Add(this.buttonGetFriends);
            this.Controls.Add(this.listViewMostActiveFriends);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikeScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommentScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatusScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaggedUsersScore)).EndInit();
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
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelFriendFilter;
        private GMap.NET.WindowsForms.GMapControl gMapControlFriendCheckins;
        private System.Windows.Forms.NumericUpDown numericUpDownLikeScore;
        private System.Windows.Forms.NumericUpDown numericUpDownCommentScore;
        private System.Windows.Forms.Label labelLikeScore;
        private System.Windows.Forms.Label labelCommentScore;
        private System.Windows.Forms.Label labelStatusScore;
        private System.Windows.Forms.NumericUpDown numericUpDownStatusScore;
        private System.Windows.Forms.Label labelPostScore;
        private System.Windows.Forms.NumericUpDown numericUpDownPostScore;
        private System.Windows.Forms.Label labelTaggedUsersScore;
        private System.Windows.Forms.NumericUpDown numericUpDownTaggedUsersScore;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsers;
        private System.Windows.Forms.Button buttonGetCheckins;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button buttonNameGenerator;
    }
}