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
    public partial class FormEvents : Form
    {
        public FormEvents(FacebookObjectCollection<Event> i_Events)
        {
            InitializeComponent();
            eventBindingSource.DataSource = i_Events;
            imageLargePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
