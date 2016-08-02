using FacebookWrapper.ObjectModel;
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
    public partial class FormPictureWithFriend : Form
    {
        public FormPictureWithFriend(Photo i_MainPhoto)
        {
            InitializeComponent();
            pictureBoxMain.Image = i_MainPhoto.ImageNormal;
            pictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
            Text = i_MainPhoto.Name;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
