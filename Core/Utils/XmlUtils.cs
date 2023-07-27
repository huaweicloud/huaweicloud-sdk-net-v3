using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace HuaweiCloud.SDK.Core
{
    public class XmlUtils
    {
        public static T DeSerialize<T>(HttpResponseMessage message) where T : SdkResponse
        {
            var body = Encoding.UTF8.GetString(message.Content.ReadAsByteArrayAsync().Result);
            var response = SetResponseBody<T>(body);

            HttpUtils.SetAdditionalAttrs(message, response, body);
            HttpUtils.SetResponseHeaders(message, response);

            return response;
        }

        public static T DeSerialize<T>(SdkResponse response) where T : SdkResponse
        {
            T tResponse;
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(RemoveXmlns(response.HttpBody)))
            {
                tResponse = (T)xmlSerializer.Deserialize(reader);
            }

            if (tResponse == null)
            {
                tResponse = Activator.CreateInstance<T>();
            }

            tResponse.HttpStatusCode = response.HttpStatusCode;
            tResponse.HttpHeaders = response.HttpHeaders;
            tResponse.HttpBody = response.HttpBody;

            return tResponse;
        }

        private static T SetResponseBody<T>(string body) where T : SdkResponse
        {
            T response;
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(RemoveXmlns(body)))
            {
                response = (T)xmlSerializer.Deserialize(reader);
            }

            if (response == null)
            {
                response = Activator.CreateInstance<T>();
            }

            return response;
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
            using (StringWriter stringWriter = new Utf8StringWriter())
            {
                var xmlSerializer = new XmlSerializer(obj.GetType());
                var xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add("", "");
                xmlSerializer.Serialize(stringWriter, obj, xmlSerializerNamespaces);
                return stringWriter.ToString();
            }
        }

        private class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }
    }
}
