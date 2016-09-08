using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    internal partial class FormPost : Form
    {
        private User m_LoggedInUser;

        public FormPost(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if(richTextBoxPost.TextLength > 0)
            {
                m_LoggedInUser.PostStatus(richTextBoxPost.Text);
                richTextBoxPost.Clear();
                MessageBox.Show("Status post successful!");
            }
            else
            {
                MessageBox.Show("Nothing to post");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxPost.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
