using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppFirstStage
{
    public partial class Form : System.Windows.Forms.Form
    {
        private User m_LoggedInUser;
        private AppSettings m_AppSettings;

        public Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            m_AppSettings = AppSettings.LoadFromFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if(m_AppSettings != null && m_AppSettings.IsChecked)
            {
                LoginResult result = FacebookService.Connect(m_AppSettings.AccessToken);
                doWhenLogin(result);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if(m_AppSettings != null)
            {
                m_AppSettings.SaveToFile();
            }
        }

        private void doWhenLogin(LoginResult i_Result)
        {
            m_LoggedInUser = i_Result.LoggedInUser;
            pictureBoxProfile.Image = m_LoggedInUser.ImageNormal;
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonLogin.Text = m_LoggedInUser.Name;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            checkBoxRememberMe.Enabled = true;
            if(m_AppSettings == null)
            {
                m_AppSettings = new AppSettings() { AccessToken = i_Result.AccessToken, IsChecked = checkBoxRememberMe.Checked, Location = this.Location, Size = this.Size };
            }
            else
            {
                checkBoxRememberMe.Checked = m_AppSettings.IsChecked;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult result = FacebookService.Login("220724224990682", "public_profile", "user_friends");
            doWhenLogin(result);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(new Action(doWhenLogout));
        }

        private void doWhenLogout()
        {
            m_AppSettings.SaveToFile();
            m_LoggedInUser = null;
            buttonLogin.Text = "Login";
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            checkBoxRememberMe.Enabled = false;
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.IsChecked = checkBoxRememberMe.Checked;
        }
    }
}
