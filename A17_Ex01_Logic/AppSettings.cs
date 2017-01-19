
using System;
using System.IO;
using System.Xml.Serialization;

namespace A17_Ex01_Logic
{
    public class AppSettings
    {
        public string               LastAccessToken { get; set; }
        private static AppSettings  s_Settings = LoadToFile();

        public static AppSettings GetSettings()
        {
            if(s_Settings == null)
            {
                s_Settings = new AppSettings();
            }

            return s_Settings;
        }

        public static void SaveToFile()
        {
            XmlSerializer SerializerObj = new XmlSerializer(s_Settings.GetType());
            try
            {
                using (FileStream WriteFileStream = new FileStream(@"UserSetting.xml", FileMode.Create))
                {
                    SerializerObj.Serialize(WriteFileStream, s_Settings);
                    WriteFileStream.Close();
                }
            }
            finally
            {

            }

        }

        public static AppSettings LoadToFile()
        {
            XmlSerializer ser = new XmlSerializer(typeof(AppSettings));
            try
            {
                using (FileStream reader = new FileStream(@"UserSetting.xml", FileMode.Open))
                {
                    return (AppSettings)ser.Deserialize(reader);

                } 
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.ToString());
                return null;
            }

        }
    }
}
