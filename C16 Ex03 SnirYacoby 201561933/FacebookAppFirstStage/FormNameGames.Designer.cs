namespace FacebookApp
{
    internal partial class FormNameGames
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
            this.buttonBandName = new System.Windows.Forms.Button();
            this.buttonJapaneseName = new System.Windows.Forms.Button();
            this.buttonSuperheroName = new System.Windows.Forms.Button();
            this.buttonWerewolfName = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.richTextBoxGeneration = new System.Windows.Forms.RichTextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBandName
            // 
            this.buttonBandName.Location = new System.Drawing.Point(13, 13);
            this.buttonBandName.Name = "buttonBandName";
            this.buttonBandName.Size = new System.Drawing.Size(141, 34);
            this.buttonBandName.TabIndex = 0;
            this.buttonBandName.Text = "My Heavy Metal Band Name";
            this.buttonBandName.UseVisualStyleBackColor = true;
            this.buttonBandName.Click += new System.EventHandler(this.buttonBandName_Click);
            // 
            // buttonJapaneseName
            // 
            this.buttonJapaneseName.Location = new System.Drawing.Point(13, 53);
            this.buttonJapaneseName.Name = "buttonJapaneseName";
            this.buttonJapaneseName.Size = new System.Drawing.Size(141, 34);
            this.buttonJapaneseName.TabIndex = 1;
            this.buttonJapaneseName.Text = "My Japanese Name";
            this.buttonJapaneseName.UseVisualStyleBackColor = true;
            this.buttonJapaneseName.Click += new System.EventHandler(this.buttonJapaneseName_Click);
            // 
            // buttonSuperheroName
            // 
            this.buttonSuperheroName.Location = new System.Drawing.Point(12, 93);
            this.buttonSuperheroName.Name = "buttonSuperheroName";
            this.buttonSuperheroName.Size = new System.Drawing.Size(142, 34);
            this.buttonSuperheroName.TabIndex = 2;
            this.buttonSuperheroName.Text = "My Superhero Name";
            this.buttonSuperheroName.UseVisualStyleBackColor = true;
            this.buttonSuperheroName.Click += new System.EventHandler(this.buttonSuperheroName_Click);
            // 
            // buttonWerewolfName
            // 
            this.buttonWerewolfName.Location = new System.Drawing.Point(12, 133);
            this.buttonWerewolfName.Name = "buttonWerewolfName";
            this.buttonWerewolfName.Size = new System.Drawing.Size(142, 34);
            this.buttonWerewolfName.TabIndex = 3;
            this.buttonWerewolfName.Text = "My Werewolf Name";
            this.buttonWerewolfName.UseVisualStyleBackColor = true;
            this.buttonWerewolfName.Click += new System.EventHandler(this.buttonWerewolfName_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 173);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(142, 34);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // richTextBoxGeneration
            // 
            this.richTextBoxGeneration.Location = new System.Drawing.Point(161, 13);
            this.richTextBoxGeneration.Name = "richTextBoxGeneration";
            this.richTextBoxGeneration.ReadOnly = true;
            this.richTextBoxGeneration.Size = new System.Drawing.Size(188, 154);
            this.richTextBoxGeneration.TabIndex = 5;
            this.richTextBoxGeneration.Text = string.Empty;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(161, 174);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(95, 33);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "Post This";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(263, 174);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(95, 33);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormNameGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 214);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.richTextBoxGeneration);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonWerewolfName);
            this.Controls.Add(this.buttonSuperheroName);
            this.Controls.Add(this.buttonJapaneseName);
            this.Controls.Add(this.buttonBandName);
            this.Name = "FormNameGames";
            this.Text = "FormMiniGames";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBandName;
        private System.Windows.Forms.Button buttonJapaneseName;
        private System.Windows.Forms.Button buttonSuperheroName;
        private System.Windows.Forms.Button buttonWerewolfName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RichTextBox richTextBoxGeneration;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonClear;
    }
}