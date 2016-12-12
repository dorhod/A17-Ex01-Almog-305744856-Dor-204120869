using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace A17_Ex01_UI
{
     public class AppSettings
    {
        public string m_lastAccessToken { get; set; }

        public void Save()
        {
            try
            {
                XmlSerializer SerializerObj = new XmlSerializer(this.GetType());

                // Create a new file stream to write the serialized object to a file
                TextWriter WriteFileStream = new StreamWriter(@"UserSetting.xml");
                SerializerObj.Serialize(WriteFileStream, this);

                // Cleanup
                WriteFileStream.Close();
            }
            catch (Exception expt)
            {
                Console.WriteLine(expt.ToString());
            }
        }
    }
}
