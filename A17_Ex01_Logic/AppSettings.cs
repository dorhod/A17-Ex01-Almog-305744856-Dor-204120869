using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace A17_Ex01_Logic
{
    public class AppSettings
    {
        public string m_lastAccessToken { get; set; }
        private static AppSettings Settings = LoadToFile();

        public static AppSettings GetSettings()
        {
            if(Settings == null)
            {
                Settings = new AppSettings();
            }

            return Settings;
        }

        public static void SaveToFile()
        {
            XmlSerializer SerializerObj = new XmlSerializer(Settings.GetType());
            using (FileStream WriteFileStream = new FileStream(@"UserSetting.xml", FileMode.Create))
            {
                SerializerObj.Serialize(WriteFileStream, Settings);
                // Cleanup
                WriteFileStream.Close();
            }
        }

        public static AppSettings LoadToFile()
        {
            XmlSerializer ser = new XmlSerializer(typeof(AppSettings));
            using (FileStream reader = new FileStream(@"UserSetting.xml", FileMode.Open))
            {
                try
                {
                    return (AppSettings)ser.Deserialize(reader);
                } catch (Exception exp)
                {
                    return null;
                }

            }
        }
    }
}
