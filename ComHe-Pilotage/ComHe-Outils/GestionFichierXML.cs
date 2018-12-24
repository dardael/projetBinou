using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ComHe_Outils {
    public class GestionFichierXML {
        public static void SaveToXml(object o, System.Type type, string filename) {
            XmlSerializer s = new XmlSerializer(type);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;
            settings.IndentChars = ("\t");
            using (XmlWriter w = XmlWriter.Create(filename, settings)) {
                s.Serialize(w, o);
                w.Flush();
            }
        }

        public static object LoadFromXML(System.Type type, string filename) {
            if (File.Exists(filename)) {
                object result;
                XmlReader r = XmlReader.Create(new StreamReader(filename));
                XmlSerializer s = new XmlSerializer(type);
                result = s.Deserialize(r);
                r.Close();
                return result;
            }
            return null;
        }
    }
}
