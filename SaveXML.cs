using System;
using System.IO;
using System.Xml.Serialization;

namespace Kaziklikker {

    public class SaveXML {

        public static void SaveData(Object obj, string filename) {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }
    }
}