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

        public FormNameGames(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }

        private void doWhenNameGeneratorButtonClicked(eNameGenerator i_TypeOfName)
        {
            StringBuilder sb = new StringBuilder();
            INameGenerator nameGenerator = NameGeneratorFactory.CreateNameGenerator(i_TypeOfName);

            sb.Append(string.Format("Your {1} name is: {0}{0}", Environment.NewLine, Enum.GetName(typeof(eNameGenerator), i_TypeOfName)));
            sb.Append(nameGenerator.GenerateName(m_LoggedInUser.FirstName, m_LoggedInUser.LastName));
            richTextBoxGeneration.Clear();
            richTextBoxGeneration.Text = sb.ToString();
        }

        private void buttonJapaneseName_Click(object sender, EventArgs e)
        {
            doWhenNameGeneratorButtonClicked(eNameGenerator.Japanese);
        }

        private void buttonSuperheroName_Click(object sender, EventArgs e)
        {
            doWhenNameGeneratorButtonClicked(eNameGenerator.Superhero);
        }

        private void buttonWerewolfName_Click(object sender, EventArgs e)
        {
            doWhenNameGeneratorButtonClicked(eNameGenerator.Werewolf);
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

        private void buttonBandName_Click(object sender, EventArgs e)
        {
            doWhenNameGeneratorButtonClicked(eNameGenerator.HeavyMetalBand);
        }
    }
}
