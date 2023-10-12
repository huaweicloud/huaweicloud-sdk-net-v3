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

using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;


namespace HuaweiCloud.SDK.Core
{
    public class Sm2Sm3Signer : P256Sha256Signer
    {
        protected override ECDomainParameters EcDomainParameters { get; } = new ECDomainParameters(GMNamedCurves.GetByName("sm2p256v1"));
        
        private static Sm2Sm3Signer _instance;
        
        private static readonly object Lock = new object();
        public new static Sm2Sm3Signer GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Sm2Sm3Signer();
                    }
                }
            }
            return _instance;
        }

        public Sm2Sm3Signer()
        {
            Algorithm = "SDK-SM2-SM3";
            HeaderContent = "X-Sdk-Content-Sm3";
            EmptyHash = "1ab21d8355cfa17f8e61194831e81a8f22bec8c728fefb747ed035eb5082aa2b";
            Hasher = new Sm3Hasher();
        }

        protected override ISigningKey GenerateSigningKey(ECPrivateKeyParameters privateKeyParameters, ECPublicKeyParameters publicKeyParameters)
        {
            return new Sm3SigningKey(Hasher, privateKeyParameters, publicKeyParameters);
        }

        protected class Sm3SigningKey : P256SigningKey
        {

            internal Sm3SigningKey(AbstractHasher hasher, ECPrivateKeyParameters privateKeyParameters, ECPublicKeyParameters publicKeyParameters) : base(hasher, privateKeyParameters, publicKeyParameters)
            {
            }

            public override byte[] Sign(byte[] data)
            {
                var signer = new SM2Signer();
                signer.Init(true, PrivateKeyParameters);
                signer.BlockUpdate(data, 0, data.Length);
                return signer.GenerateSignature();
            }

            public override bool Verify(byte[] signature, byte[] data)
            {
                var signer = new SM2Signer();
                signer.Init(false, PublicKeyParameters);
                signer.BlockUpdate(data, 0, data.Length);
                return signer.VerifySignature(signature);
            }
        }
    }
}
