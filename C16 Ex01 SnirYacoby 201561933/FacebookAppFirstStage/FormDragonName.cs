using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookAppFirstStage
{
    internal partial class FormDragonName : Form
    {
        public string FatherName { get; private set; }

        public string MotherName { get; private set; }

        public FormDragonName()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            FatherName = textBoxFatherName.Text;
            MotherName = textBoxMotherName.Text;
            if(FatherName.Length >= 2 && MotherName.Length >= 2)
            {
                DialogResult = DialogResult.OK;
            }

            this.Close();
        }
    }
}
