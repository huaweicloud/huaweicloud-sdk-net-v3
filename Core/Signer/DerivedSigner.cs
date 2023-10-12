/*
 * Copyright 2023 Huawei Technologies Co.,Ltd.
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
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using HuaweiCloud.SDK.Core.Auth;

namespace HuaweiCloud.SDK.Core
{
    public class DerivedSigner : Signer
    {
        private const string V11HmacSha256 = "V11-HMAC-SHA256";
        
        private static DerivedSigner _instance;
        
        private static readonly object Lock = new object();
        
        public new static DerivedSigner GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DerivedSigner();
                    }
                }
            }
            return _instance;
        }

        public override void Sign<T>(HttpRequest request, T credentials)
        {
            VerifyRequired(credentials);
            if (string.IsNullOrEmpty(credentials.RegionId))
            {
                throw new ArgumentException("regionId is required in credentials when using derived auth");
            }
            if (string.IsNullOrEmpty(credentials.DerivedAuthServiceName))
            {
                throw new ArgumentException("derivedAuthServiceName is required in credentials when using derived auth");
            }
            // Add X-Sdk-Date
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

            // Add Host header
            var host = request.Url.Host;
            if (request.Headers.GetValues(HeaderHost) != null)
            {
                host = request.Headers.GetValues(HeaderHost)?[0];
            }
            request.Headers.Set("host", host);

            // Create the string to sign
            var canonicalRequest = ConstructCanonicalRequest(request);
            var timeStamp = t.ToUniversalTime().ToString(BasicDateFormat);
            var info = timeStamp.Substring(0, 8) + "/" + credentials.RegionId + "/" + credentials.DerivedAuthServiceName;
            var stringToSign = StringToSign(canonicalRequest, timeStamp, info);

            // Calculate the signature
            var signedHeaders = ProcessSignedHeaders(request);
            var derivationKey = Hkdf.GetDerKeySha(credentials.Ak, credentials.Sk, info);
            var signingKey = new HmacSigningKey(Hasher, Encoding.UTF8.GetBytes(derivationKey));
            var signatureString = SignStringToSign(stringToSign, signingKey);
            var authValue = $"{V11HmacSha256} Credential={credentials.Ak}/{info}, SignedHeaders={string.Join(";", signedHeaders)}, Signature={signatureString}";
            request.Headers.Set(HeaderAuthorization, authValue);
        }

        private string StringToSign(string canonicalRequest, string timeStamp, string info)
        {
            SHA256 sha256 = new SHA256Managed();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest));
            sha256.Clear();
            return $"{V11HmacSha256}\n" +
                   $"{timeStamp}\n" +
                   $"{info}\n" +
                   $"{AbstractHasher.ToHexString(bytes)}";
        }

        private static class Hkdf
        {
            private const string HmacSha1 = "HMACSHA1";

            private const string HmacSha256 = "HMACSHA256";

            private static readonly int DERIVATION_KEY_LENGTH = 32;

            private static readonly string HMAC_ALGORITHM = HmacSha256;

            private static readonly int AlgorithmHashLength = GetHashLen(HMAC_ALGORITHM);

            private static readonly int ExpandCeil = (int)Math.Ceiling(DERIVATION_KEY_LENGTH / (double)AlgorithmHashLength);

            public static string GetDerKeySha(string ak, string sk, string info)
            {
                if (string.IsNullOrEmpty(ak) || string.IsNullOrEmpty(sk))
                {
                    return null;
                }

                try
                {
                    var tmpKey = Extract(ak, sk);
                    var derSecretKey = Expend(tmpKey, Encoding.UTF8.GetBytes(info));
                    if (derSecretKey != null)
                    {
                        return AbstractHasher.ToHexString(derSecretKey);
                    }
                }
                catch (Exception exception)
                {
                    throw new ArgumentException("Failed to derive AK " + $"{ak}" + " with info " + $"{info}" + " .\n" + $"{exception.Message}");
                }
                return null;
            }

            private static byte[] Expend(byte[] prk, byte[] info)
            {
                var hMacSha = HMAC.Create(HMAC_ALGORITHM);
                if (hMacSha == null)
                {
                    throw new ArgumentException("unknown in HMAC algorithm");
                }
                hMacSha.Key = prk;

                byte[] rawResult;
                if (ExpandCeil == 1)
                {
                    rawResult = ExpandFirst(info, hMacSha);
                }
                else
                {
                    rawResult = new byte[0];
                    var temp = new byte[0];
                    for (var i = 1; i <= ExpandCeil; ++i)
                    {
                        temp = ExpandOnce(info, hMacSha, temp, i);
                        var combineBytes = new MemoryStream();
                        combineBytes.Write(rawResult, 0, rawResult.Length);
                        combineBytes.Write(temp, 0, temp.Length);
                        rawResult = combineBytes.ToArray();
                    }
                }

                byte[] ret = null;
                if (DERIVATION_KEY_LENGTH <= rawResult.Length)
                {
                    ret = new byte[DERIVATION_KEY_LENGTH];
                    Array.Copy(rawResult, 0, ret, 0, Math.Min(DERIVATION_KEY_LENGTH, rawResult.Length));
                }
                return ret;
            }

            private static byte[] Extract(string ak, string sk)
            {
                var hMacSha = HMAC.Create(HMAC_ALGORITHM);
                if (hMacSha == null)
                {
                    throw new ArgumentException("unknown in HMAC algorithm");
                }
                var akBytes = Encoding.UTF8.GetBytes(ak);
                var skBytes = Encoding.UTF8.GetBytes(sk);
                hMacSha.Key = akBytes;

                return hMacSha.ComputeHash(skBytes);
            }

            private static byte[] ExpandFirst(byte[] info, HMAC mac)
            {
                var result = new byte[info.Length + 1];
                Array.Copy(info, 0, result, 0, info.Length);
                result[info.Length] = 0x01;
                return mac.ComputeHash(result);
            }

            private static byte[] ExpandOnce(byte[] info, HMAC mac, byte[] preTemp, int i)
            {
                var hashBytes = new MemoryStream();
                hashBytes.Write(preTemp, 0, preTemp.Length);
                hashBytes.Write(info, 0, info.Length);
                hashBytes.WriteByte((byte)i);
                return mac.ComputeHash(hashBytes.ToArray());
            }

            private static string ToHexstring(byte[] data)
            {
                var hex = string.Empty;
                foreach (var b in data)
                {
                    hex += b.ToString("x2");
                }
                return hex;
            }

            private static int GetHashLen(string hmacAlgorithm)
            {
                switch (hmacAlgorithm)
                {
                    case HmacSha1:
                        return 20;
                    case HmacSha256:
                    default:
                        return 32;
                }
            }
        }
    }
}
