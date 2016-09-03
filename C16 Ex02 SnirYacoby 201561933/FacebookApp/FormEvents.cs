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
        private FacebookObjectCollection<Event> m_Events;

        public FormEvents(FacebookObjectCollection<Event> i_Events)
        {
            InitializeComponent();
            m_Events = i_Events;
            listBoxEvents.DataSource = i_Events.Select(x => x.Name).ToList();
            pictureBoxEvent.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string eventName = listBoxEvents.SelectedItem.ToString();
            Event selectedEvent = null;

            foreach(Event @event in m_Events)
            {
                if(@event.Name == eventName)
                {
                    selectedEvent = @event;
                    break;
                }
            }

            if(selectedEvent.Description != null)
            {
                richTextBoxDescription.Text = selectedEvent.Description;
            }
            else
            {
                richTextBoxDescription.Text = string.Empty;
            }

            try
            {
                pictureBoxEvent.Image = selectedEvent.ImageLarge;
            }
            catch
            {
                pictureBoxEvent.Image = null;
            }
        }
    }
}
