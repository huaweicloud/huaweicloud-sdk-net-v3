/*
 * Copyright 2022 Huawei Technologies Co.,Ltd.
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

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
                return xml.Replace(match.Value.TrimEnd('>'), string.Empty);
            }
            return xml;
        }

        public static string Serialize(object obj)
        {
            using (StringWriter stringWriter = new Utf8StringWriter())
            {
                var xmlSerializer = new XmlSerializer(obj.GetType());
                var xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add(string.Empty, string.Empty);
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
