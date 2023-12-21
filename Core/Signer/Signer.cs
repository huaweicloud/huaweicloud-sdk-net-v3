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
using System.Text;
using HuaweiCloud.SDK.Core.Auth;
using static System.String;

namespace HuaweiCloud.SDK.Core

{
    public partial class Signer : IAkSkSigner
    {
        protected const string BasicDateFormat = "yyyyMMddTHHmmssZ";
        protected const string HeaderXDate = "X-Sdk-Date";
        protected const string HeaderHost = "host";
        protected const string HeaderAuthorization = "Authorization";

        private static readonly object Lock = new object();

        private readonly HashSet<string> _unsignedHeaders = new HashSet<string>
        {
            "content-type"
        };

        internal string Algorithm { get; set; } = "SDK-HMAC-SHA256";

        internal string HeaderContent { get; set; } = "X-Sdk-Content-Sha256";

        internal string EmptyHash { get; set; } = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";

        internal AbstractHasher Hasher { get; set; } = new Sha256Hasher();

        internal Signer()
        {
        }

        private static Signer _instance;

        public static Signer GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Signer();
                    }
                }
            }
            return _instance;
        }

        public virtual void Sign<T>(HttpRequest request, T credentials) where T : Credentials<T>
        {
            VerifyRequired(credentials);
            ProcessContentHeader(request);
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
            var signingKey = GetSigningKey(credentials);
            var signature = SignStringToSign(stringToSign, signingKey);
            var authValue = ProcessAuthHeader(credentials.Ak, signature, signedHeaders);
            request.Headers.Set(HeaderAuthorization, authValue);
        }

        public virtual ISigningKey GetSigningKey<T>(T credentials) where T : Credentials<T>
        {
            return new HmacSigningKey(Hasher, Encoding.UTF8.GetBytes(credentials.Sk));
        }

        protected void VerifyRequired<T>(T credentials) where T : Credentials<T>
        {
            if (IsNullOrEmpty(credentials.Ak))
            {
                throw new ArgumentException("Ak is required in credentials");
            }
            if (IsNullOrEmpty(credentials.Sk))
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
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(ProcessRequestMethod(request)).Append("\n")
                .Append(ProcessCanonicalUri(request)).Append("\n")
                .Append(ProcessCanonicalQueryString(request)).Append("\n")
                .Append(CanonicalHeaders(request)).Append("\n")
                .Append(Join(";", ProcessSignedHeaders(request))).Append("\n")
                .Append(ProcessRequestPayload(request));
            return stringBuilder.ToString();
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
                var valuesOfKey = request.Headers.GetValues(key);
                if (valuesOfKey == null || valuesOfKey.Length == 0)
                {
                    continue;
                }
                var values = new List<string>(valuesOfKey);
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

        private void ProcessContentHeader(HttpRequest request)
        {
            if (!IsNullOrEmpty(request.ContentType) && !request.ContentType.StartsWith("application/json"))
            {
                request.Headers.Add(HeaderContent, "UNSIGNED-PAYLOAD");
            }
        }

        protected List<string> ProcessSignedHeaders(HttpRequest request)
        {
            var signedHeaders = (from key in request.Headers.AllKeys
                                 let keyLower = key.ToLowerInvariant()
                                 where !_unsignedHeaders.Contains(keyLower)
                                 select key.ToLowerInvariant()).ToList();

            signedHeaders.Sort(CompareOrdinal);
            return signedHeaders;
        }

        private string ProcessRequestPayload(HttpRequest request)
        {
            if (request.Headers.Get(HeaderContent) != null)
            {
                return request.Headers.Get(HeaderContent);
            }

            if (IsNullOrEmpty(request.Body))
            {
                return EmptyHash;
            }

            var data = Encoding.UTF8.GetBytes(request.Body);
            var hexEncode = Hasher.HashHexString(data);
            return hexEncode;
        }

        private string ProcessAuthHeader(string ak, string signature, List<string> signedHeaders)
        {
            return $"{Algorithm} Access={ak}, SignedHeaders={Join(";", signedHeaders)}, Signature={signature}";
        }


        private string StringToSign(string canonicalRequest, DateTime t)
        {
            return $"{Algorithm}\n{t.ToUniversalTime().ToString(BasicDateFormat)}\n{Hasher.HashHexString(Encoding.UTF8.GetBytes(canonicalRequest))}";
        }

        protected static string SignStringToSign(string stringToSign, ISigningKey signingKey)
        {
            var sign = signingKey.Sign(Encoding.UTF8.GetBytes(stringToSign));
            return AbstractHasher.ToHexString(sign);
        }

        protected class HmacSigningKey : ISigningKey
        {

            private readonly AbstractHasher _hasher;
            private readonly byte[] _key;

            internal HmacSigningKey(AbstractHasher hasher, byte[] key)
            {
                _hasher = hasher;
                _key = key;
            }

            public byte[] Sign(byte[] data)
            {
                return _hasher.Hmac(data, _key);
            }

            public bool Verify(byte[] signature, byte[] data)
            {
                var hmac = _hasher.Hmac(data, _key);
                return signature.Equals(hmac);
            }
        }
    }
}
