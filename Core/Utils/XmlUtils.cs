using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace HuaweiCloud.SDK.Core
{
    public class XmlUtils
    {

        class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }
        public static T DeSerialize<T>(HttpResponseMessage message)
        {
            
            var body = Encoding.UTF8.GetString(message.Content.ReadAsByteArrayAsync().Result);
            var xmlObject = SetResponseBody<T>(body);
            
            HttpUtils.SetAdditionalAttrs(message, xmlObject, body);
            HttpUtils.SetResponseHeaders(message, xmlObject);

            return xmlObject;
        }

        public static T DeSerialize<T>(SdkResponse response) where T : SdkResponse
        {
            T xmlObject;
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(RemoveXmlns(response.HttpBody)))
            {
                xmlObject = (T)xmlSerializer.Deserialize(reader);
            }

            if (xmlObject == null)
            {
                xmlObject = Activator.CreateInstance<T>();
            }

            xmlObject.HttpStatusCode = response.HttpStatusCode;
            xmlObject.HttpHeaders = response.HttpHeaders;
            xmlObject.HttpBody = response.HttpBody;

            return xmlObject;
        }

        private static T SetResponseBody<T>(string body)
        {
            T xmlObject;
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(RemoveXmlns(body)))
            {
                xmlObject = (T)xmlSerializer.Deserialize(reader);
            }

            if (xmlObject == null)
            {
                xmlObject = Activator.CreateInstance<T>();
            }

            return xmlObject;
        }

        private static string RemoveXmlns(string xml)
        {
            var match = Regex.Match(xml, " xmlns=\"http.*\">");
            if (match.Success)
            {
                return xml.Replace(match.Value.TrimEnd('>'), "");
            }
            return xml;
        }

        public static string Serialize(object obj)
        {
            using (StringWriter stringWriter = new Utf8StringWriter()) {
                XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
                XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add("", "");
                xmlSerializer.Serialize(stringWriter, obj, xmlSerializerNamespaces);
                return stringWriter.ToString();
            }
        }
    }
}
