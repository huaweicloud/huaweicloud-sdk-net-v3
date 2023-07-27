/*
 * Copyright 2020 Huawei Technologies Co.,Ltd.
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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static System.String;

namespace HuaweiCloud.SDK.Core

{
    public partial class Signer
    {
        protected const string BasicDateFormat = "yyyyMMddTHHmmssZ";
        private const string Algorithm = "SDK-HMAC-SHA256";
        protected const string HeaderXDate = "X-Sdk-Date";
        protected const string HeaderHost = "host";
        protected const string HeaderAuthorization = "Authorization";
        private const string HeaderContentSha256 = "X-Sdk-Content-Sha256";

        private readonly HashSet<string> _unsignedHeaders = new HashSet<string>
        {
            "content-type"
        };

        public string Key { get; set; }
        public string Secret { get; set; }

        public void Sign(HttpRequest request)
        {
            verifyAkSk();
            var time = request.Headers.GetValues(HeaderXDate);
            DateTime t;
            if (time == null)
            {
                t = DateTime.Now;
                request.Headers.Add(HeaderXDate, t.ToUniversalTime().ToString(BasicDateFormat));
            }
            else
            {
                t = DateTime.ParseExact(time[0], BasicDateFormat, CultureInfo.CurrentCulture);
            }

            var host = request.Url.Host;
            if (request.Headers.GetValues(HeaderHost) != null)
            {
                host = request.Headers.GetValues(HeaderHost)?[0];
            }

            request.Headers.Set("host", host);

            var signedHeaders = ProcessSignedHeaders(request);
            var canonicalRequest = ConstructCanonicalRequest(request);
            var stringToSign = StringToSign(canonicalRequest, t);
            var signature = SignStringToSign(stringToSign, Encoding.UTF8.GetBytes(Secret));
            var authValue = ProcessAuthHeader(signature, signedHeaders);
            request.Headers.Set(HeaderAuthorization, authValue);
        }

        protected void verifyAkSk()
        {
            if (IsNullOrEmpty(Key))
            {
                throw new ArgumentException("Ak is required in credentials");
            }
            if (IsNullOrEmpty(Secret))
            {
                throw new ArgumentException("Sk is required in credentials");
            }
        }

        /// <summary>
        ///     Build a CanonicalRequest from a regular request string
        ///     CanonicalRequest consists of several parts:
        ///     Part 1. HTTPRequestMethod
        ///     Part 2. CanonicalURI
        ///     Part 3. CanonicalQueryString
        ///     Part 4. CanonicalHeaders
        ///     Part 5 SignedHeaders
        ///     Part 6 HexEncode(Hash(RequestPayload))
        /// </summary>
        protected string ConstructCanonicalRequest(HttpRequest request)
        {
            return $"{ProcessRequestMethod(request)}\n" +
                   $"{ProcessCanonicalUri(request)}\n" +
                   $"{ProcessCanonicalQueryString(request)}\n" +
                   $"{CanonicalHeaders(request)}\n" +
                   $"{Join(";", ProcessSignedHeaders(request))}\n" +
                   $"{ProcessRequestPayload(request)}";
        }

        private string ProcessRequestMethod(HttpRequest request)
        {
            return request.Method;
        }

        private string ProcessCanonicalUri(HttpRequest request)
        {
            var uri = request.Url.GetComponents(UriComponents.Path | UriComponents.KeepDelimiter, UriFormat.Unescaped);
            uri = Join("/", uri.Split('/').Select(UrlEncode).ToList());
            uri = uri.EndsWith("/") ? uri : uri + "/";
            return uri;
        }

        private string ProcessCanonicalQueryString(HttpRequest request)
        {
            var keys = request.QueryParam.Select(pair => pair.Key).ToList();
            keys.Sort(CompareOrdinal);

            var queryStrings = new List<string>();
            foreach (var key in keys)
            {
                var k = UrlEncode(key);
                var values = request.QueryParam[key];
                values.Sort(CompareOrdinal);
                queryStrings.AddRange(values.Select(value => k + "=" + UrlEncode(value)));
            }

            return Join("&", queryStrings);
        }

        private string CanonicalHeaders(HttpRequest request)
        {
            var headers = new List<string>();
            var signedHeaders = ProcessSignedHeaders(request);
            foreach (var key in signedHeaders)
            {
                var values = new List<string>(request.Headers.GetValues(key));
                values.Sort(CompareOrdinal);
                foreach (var value in values)
                {
                    headers.Add(key + ":" + value.Trim());
                    request.Headers.Set(key,
                        Encoding.GetEncoding("iso-8859-1").GetString(Encoding.UTF8.GetBytes(value)));
                }
            }

            return Join("\n", headers) + "\n";
        }

        protected List<string> ProcessSignedHeaders(HttpRequest request)
        {
            var signedHeaders = (from key in request.Headers.AllKeys
                                 let keyLower = key.ToLower()
                                 where !_unsignedHeaders.Contains(keyLower)
                                 select key.ToLower()).ToList();

            signedHeaders.Sort(CompareOrdinal);
            return signedHeaders;
        }

        private string ProcessRequestPayload(HttpRequest request)
        {
            string hexEncodePayload;
            if (request.Headers.Get(HeaderContentSha256) != null)
            {
                hexEncodePayload = request.Headers.Get(HeaderContentSha256);
            }
            else
            {
                var data = Encoding.UTF8.GetBytes(request.Body);
                hexEncodePayload = HexEncodeSha256Hash(data);
            }

            return hexEncodePayload;
        }

        private string ProcessAuthHeader(string signature, List<string> signedHeaders)
        {
            return $"{Algorithm} Access={Key}, SignedHeaders={Join(";", signedHeaders)}, Signature={signature}";
        }

        private static string HexEncodeSha256Hash(byte[] body)
        {
            SHA256 sha256 = new SHA256Managed();
            var bytes = sha256.ComputeHash(body);
            sha256.Clear();
            return ToHexString(bytes);
        }

        protected static string ToHexString(byte[] value)
        {
            var num = value.Length * 2;
            var array = new char[num];
            var num2 = 0;
            for (var i = 0; i < num; i += 2)
            {
                var b = value[num2++];
                array[i] = GetHexValue(b / 16);
                array[i + 1] = GetHexValue(b % 16);
            }

            return new string(array, 0, num);
        }

        private static char GetHexValue(int i)
        {
            if (i < 10)
            {
                return (char)(i + '0');
            }

            return (char)(i - 10 + 'a');
        }

        protected string StringToSign(string canonicalRequest, DateTime t)
        {
            SHA256 sha256 = new SHA256Managed();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest));
            sha256.Clear();
            return $"{Algorithm}\n" +
                   $"{t.ToUniversalTime().ToString(BasicDateFormat)}\n" +
                   $"{ToHexString(bytes)}";
        }

        protected string SignStringToSign(string stringToSign, byte[] signingKey)
        {
            var hm = HMacSha256(signingKey, stringToSign);
            return ToHexString(hm);
        }

        private byte[] HMacSha256(byte[] keyByte, string message)
        {
            var messageBytes = Encoding.UTF8.GetBytes(message);
            using (var hMacSha256 = new HMACSHA256(keyByte))
            {
                return hMacSha256.ComputeHash(messageBytes);
            }
        }
    }
}
