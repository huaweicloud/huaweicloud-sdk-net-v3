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
using System.Linq;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Math;

namespace HuaweiCloud.SDK.Core
{
    public class P256Sha256Signer : Signer
    {

        protected virtual ECDomainParameters EcDomainParameters { get; } = new ECDomainParameters(SecNamedCurves.GetByName("secp256r1"));

        private static P256Sha256Signer _instance;

        private static readonly object Lock = new object();

        public new static P256Sha256Signer GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new P256Sha256Signer();
                    }
                }
            }
            return _instance;
        }

        public P256Sha256Signer()
        {
            Algorithm = "SDK-ECDSA-P256-SHA256";
        }

        public override ISigningKey GetSigningKey<T>(T credentials)
        {
            var candidate = DerivePrivateInt(credentials.Ak, credentials.Sk);
            var privateKeyParameters = new ECPrivateKeyParameters("ECDSA", candidate, EcDomainParameters);

            var ecPoint = EcDomainParameters.Curve.GetMultiplier().Multiply(EcDomainParameters.G, candidate);
            var publicKeyParameters = new ECPublicKeyParameters(ecPoint, EcDomainParameters);

            return GenerateSigningKey(privateKeyParameters, publicKeyParameters);
        }

        protected virtual ISigningKey GenerateSigningKey(ECPrivateKeyParameters privateKeyParameters, ECPublicKeyParameters publicKeyParameters)
        {
            return new P256SigningKey(Hasher, privateKeyParameters, publicKeyParameters);
        }

        private BigInteger DerivePrivateInt(string key, string secret)
        {
            for (var counter = 0; counter < 0xff; counter++)
            {
                var context = Encoding.UTF8.GetBytes(key).Append(Convert.ToByte(counter)).ToArray();
                var data = new byte[]
                    {
                        0x00,
                        0x00,
                        0x00,
                        0x01
                    }
                    .Concat(Encoding.UTF8.GetBytes(Algorithm))
                    .Concat(new byte[]
                    {
                        0x00
                    })
                    .Concat(context)
                    .Concat(new byte[]
                    {
                        0x00,
                        0x00,
                        0x01,
                        0x00
                    })
                    .ToArray();

                var hmac = Hasher.Hmac(data, Encoding.UTF8.GetBytes(secret));

                var candidate = new BigInteger(1, hmac);
                if (candidate.CompareTo(EcDomainParameters.N) <= 2)
                {
                    var secretKey = candidate.Add(BigInteger.One);
                    return secretKey;
                }
            }

            throw new SdkException("derive hmac key failed, counter out of range");
        }

        protected class P256SigningKey : ISigningKey
        {
            private readonly AbstractHasher _hasher;

            protected readonly ECPrivateKeyParameters PrivateKeyParameters;

            protected readonly ECPublicKeyParameters PublicKeyParameters;

            internal P256SigningKey(AbstractHasher hasher, ECPrivateKeyParameters privateKeyParameters, ECPublicKeyParameters publicKeyParameters)
            {
                _hasher = hasher;
                PrivateKeyParameters = privateKeyParameters;
                PublicKeyParameters = publicKeyParameters;
            }

            public virtual byte[] Sign(byte[] data)
            {
                var signer = new ECDsaSigner(new HMacDsaKCalculator(new Sha256Digest()));
                signer.Init(true, PrivateKeyParameters);
                var hashed = _hasher.Hash(data);
                var integers = signer.GenerateSignature(hashed);
                // Create a sequence containing the two big integers
                var vector = new Asn1EncodableVector
                {
                    new DerInteger(integers[0]),
                    new DerInteger(integers[1])
                };
                var sequence = new DerSequence(vector);
                // Encode the sequence to DER format
                return sequence.GetEncoded();
            }

            public virtual bool Verify(byte[] signature, byte[] data)
            {
                var derSequence = (DerSequence)Asn1Object.FromByteArray(signature);
                var r = ((DerInteger)derSequence[0]).Value;
                var s = ((DerInteger)derSequence[1]).Value;

                var signer = new ECDsaSigner(new HMacDsaKCalculator(new Sha256Digest()));
                signer.Init(false, PublicKeyParameters);
                var hashed = _hasher.Hash(data);
                return signer.VerifySignature(hashed, r, s);
            }
        }
    }
}
