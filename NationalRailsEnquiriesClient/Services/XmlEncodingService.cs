using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NationalRailEnquiriesDarwin.Services
{
    public class XmlEncodingService
    {
        public static string Encode(Object obj)
        {
            XmlSerializer x = new XmlSerializer(obj.GetType());
            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true
            };
            using (var swriter = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(swriter, settings))
                {
                    x.Serialize(writer, obj);
                    return swriter.ToString();
                }
            }
        }
    }
}
