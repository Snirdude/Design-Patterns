using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacebookAppFirstStage
{
    public class AppSettings
    {
        public string AccessToken { get; set; }
        public bool IsChecked { get; set; }
        public Size Size { get; set; }
        public Point Location { get; set; }

        public void SaveToFile()
        {
            if(File.Exists("AppSettings.xml"))
            {
                using (Stream stream = new FileStream("AppSettings.xml", FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream("AppSettings.xml", FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings settings = null;
            if(File.Exists("AppSettings.xml"))
            {
                using (Stream stream = new FileStream("AppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serialzer = new XmlSerializer(typeof(AppSettings));
                    settings = serialzer.Deserialize(stream) as AppSettings;
                }
            }

            return settings;
        }
    }
}
