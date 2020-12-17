using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace NationalRailEnquiriesDarwin.Services
{
    public class XmlDecodingService
    {
        public static dynamic Decode<T>(string xml) where T : class, new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                return serializer.Deserialize(reader) as T;
            }
        }
    }
}
