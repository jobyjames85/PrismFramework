using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CaseInstaller
{
    class GenericXmlOps<T>
    {
        /// <summary>
        /// Serialize the content to xml
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string Serialize(T obj)
        {
            string result = string.Empty;
            System.IO.StringWriter textwriter = new System.IO.StringWriter();
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            serializer.Serialize(textwriter, obj);
            result = textwriter.ToString();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(result);
            xmldoc.Save("D:\\DotNET\\test\\CaseInstaller.xml");
            return result;
        }


        /// <summary>
        ///  Deserializes the XML content to a specified object
        /// </summary>
        /// <param name="xml">
        /// <returns></returns>
        public T Deserialize()

        {
           string xml = String.Empty;
           
           var fileStream = new FileStream(@"D:\\DotNET\\test\\CaseInstaller.xml", FileMode.Open, FileAccess.Read);

           using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
           {
              xml = streamReader.ReadToEnd();
           }
           
           T result = default(T);

           if (!string.IsNullOrEmpty(xml))
           {
                System.IO.TextReader textreader = new System.IO.StringReader(xml);
                System.Xml.XmlReader xmlreader = System.Xml.XmlReader.Create(textreader);
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

                if (serializer.CanDeserialize(xmlreader))
                {
                         result = (T)serializer.Deserialize(xmlreader);
                }
           }

           return result;        
        }
    }
}

