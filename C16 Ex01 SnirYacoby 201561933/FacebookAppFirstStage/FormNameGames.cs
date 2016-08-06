using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookAppFirstStage
{
    internal partial class FormNameGames : Form
    {
        private User m_LoggedInUser;
        private NameGenerator m_NameGenerator;

        public FormNameGames(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_NameGenerator = new NameGenerator(m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
        }

        private void buttonDragonName_Click(object sender, EventArgs e)
        {
            FormDragonName dragonNameForm = new FormDragonName();
            StringBuilder sb = new StringBuilder();

            dragonNameForm.ShowDialog();
            if (dragonNameForm.DialogResult == DialogResult.OK)
            {
                sb.Append(string.Format("Your dragon name is: {0}{0}", Environment.NewLine));
                sb.Append(m_NameGenerator.GenerateDragonName(dragonNameForm.FatherName, dragonNameForm.MotherName));
                richTextBoxGeneration.Clear();
                richTextBoxGeneration.Text = sb.ToString();
            }
        }

        private void buttonJapaneseName_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("Your Japanese name is: {0}{0}", Environment.NewLine));
            sb.Append(m_NameGenerator.GenerateJapaneseName());
            richTextBoxGeneration.Clear();
            richTextBoxGeneration.Text = sb.ToString();
        }

        private void buttonSuperheroName_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("Your superhero name is: {0}{0}", Environment.NewLine));
            sb.Append(m_NameGenerator.GenerateSuperheroName());
            richTextBoxGeneration.Clear();
            richTextBoxGeneration.Text = sb.ToString();
        }

        private void buttonWerewolfName_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("Your werewolf name is: {0}{0}", Environment.NewLine));
            sb.Append(m_NameGenerator.GenerateWerewolfName());
            richTextBoxGeneration.Clear();
            richTextBoxGeneration.Text = sb.ToString();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if(richTextBoxGeneration.TextLength > 0)
            {
                m_LoggedInUser.PostStatus(richTextBoxGeneration.Text);
                richTextBoxGeneration.Clear();
                MessageBox.Show("Post successful");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxGeneration.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
