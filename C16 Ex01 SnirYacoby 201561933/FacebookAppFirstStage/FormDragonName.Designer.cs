namespace FacebookAppFirstStage
{
    partial class FormDragonName
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
            this.labelFatherName = new System.Windows.Forms.Label();
            this.textBoxFatherName = new System.Windows.Forms.TextBox();
            this.textBoxMotherName = new System.Windows.Forms.TextBox();
            this.labelMotherName = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Location = new System.Drawing.Point(13, 13);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(103, 13);
            this.labelFatherName.TabIndex = 0;
            this.labelFatherName.Text = "Father\'s First Name?";
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.Location = new System.Drawing.Point(16, 29);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(138, 20);
            this.textBoxFatherName.TabIndex = 1;
            // 
            // textBoxMotherName
            // 
            this.textBoxMotherName.Location = new System.Drawing.Point(16, 68);
            this.textBoxMotherName.Name = "textBoxMotherName";
            this.textBoxMotherName.Size = new System.Drawing.Size(138, 20);
            this.textBoxMotherName.TabIndex = 3;
            // 
            // labelMotherName
            // 
            this.labelMotherName.AutoSize = true;
            this.labelMotherName.Location = new System.Drawing.Point(13, 52);
            this.labelMotherName.Name = "labelMotherName";
            this.labelMotherName.Size = new System.Drawing.Size(106, 13);
            this.labelMotherName.TabIndex = 2;
            this.labelMotherName.Text = "Mother\'s First Name?";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(19, 103);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(135, 29);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormDragonName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 144);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxMotherName);
            this.Controls.Add(this.labelMotherName);
            this.Controls.Add(this.textBoxFatherName);
            this.Controls.Add(this.labelFatherName);
            this.Name = "FormDragonName";
            this.Text = "FormDragonName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.TextBox textBoxFatherName;
        private System.Windows.Forms.TextBox textBoxMotherName;
        private System.Windows.Forms.Label labelMotherName;
        private System.Windows.Forms.Button buttonSubmit;
    }
}