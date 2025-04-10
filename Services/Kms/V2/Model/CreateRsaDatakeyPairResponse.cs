using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateRsaDatakeyPairResponse : SdkResponse
    {
        /// <summary>
        /// 需要包含算法、长度、曲线信息。可选值有RSA_2048 | RSA_3072 | RSA_4096 | ECC_NIST_P256 | ECC_NIST_P384 | ECC_NIST_P521 | ECC_SECG_P256K1 | SM2
        /// </summary>
        /// <value>需要包含算法、长度、曲线信息。可选值有RSA_2048 | RSA_3072 | RSA_4096 | ECC_NIST_P256 | ECC_NIST_P384 | ECC_NIST_P521 | ECC_SECG_P256K1 | SM2</value>
        [JsonConverter(typeof(EnumClassConverter<KeySpecEnum>))]
        public class KeySpecEnum
        {
            /// <summary>
            /// Enum RSA_2048 for value: RSA_2048
            /// </summary>
            public static readonly KeySpecEnum RSA_2048 = new KeySpecEnum("RSA_2048");

            /// <summary>
            /// Enum RSA_3072 for value: RSA_3072
            /// </summary>
            public static readonly KeySpecEnum RSA_3072 = new KeySpecEnum("RSA_3072");

            /// <summary>
            /// Enum RSA_4096 for value: RSA_4096
            /// </summary>
            public static readonly KeySpecEnum RSA_4096 = new KeySpecEnum("RSA_4096");

            /// <summary>
            /// Enum ECC_NIST_P256 for value: ECC_NIST_P256
            /// </summary>
            public static readonly KeySpecEnum ECC_NIST_P256 = new KeySpecEnum("ECC_NIST_P256");

            /// <summary>
            /// Enum ECC_NIST_P384 for value: ECC_NIST_P384
            /// </summary>
            public static readonly KeySpecEnum ECC_NIST_P384 = new KeySpecEnum("ECC_NIST_P384");

            /// <summary>
            /// Enum ECC_NIST_P521 for value: ECC_NIST_P521
            /// </summary>
            public static readonly KeySpecEnum ECC_NIST_P521 = new KeySpecEnum("ECC_NIST_P521");

            /// <summary>
            /// Enum ECC_SECG_P256K1 for value: ECC_SECG_P256K1
            /// </summary>
            public static readonly KeySpecEnum ECC_SECG_P256K1 = new KeySpecEnum("ECC_SECG_P256K1");

            /// <summary>
            /// Enum SM2 for value: SM2
            /// </summary>
            public static readonly KeySpecEnum SM2 = new KeySpecEnum("SM2");

            private static readonly Dictionary<string, KeySpecEnum> StaticFields =
            new Dictionary<string, KeySpecEnum>()
            {
                { "RSA_2048", RSA_2048 },
                { "RSA_3072", RSA_3072 },
                { "RSA_4096", RSA_4096 },
                { "ECC_NIST_P256", ECC_NIST_P256 },
                { "ECC_NIST_P384", ECC_NIST_P384 },
                { "ECC_NIST_P521", ECC_NIST_P521 },
                { "ECC_SECG_P256K1", ECC_SECG_P256K1 },
                { "SM2", SM2 },
            };

            private string _value;

            public KeySpecEnum()
            {

            }

            public KeySpecEnum(string value)
            {
                _value = value;
            }

            public static KeySpecEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as KeySpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeySpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeySpecEnum a, KeySpecEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(KeySpecEnum a, KeySpecEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 密钥ID。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 需要包含算法、长度、曲线信息。可选值有RSA_2048 | RSA_3072 | RSA_4096 | ECC_NIST_P256 | ECC_NIST_P384 | ECC_NIST_P521 | ECC_SECG_P256K1 | SM2
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }
        /// <summary>
        /// 明文公钥信息
        /// </summary>
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        /// 密文私钥
        /// </summary>
        [JsonProperty("private_key_cipher_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKeyCipherText { get; set; }

        /// <summary>
        /// 明文私钥。private_key_plain_text、wrapped_private_key和ciphertext_recipient只能有一个有值
        /// </summary>
        [JsonProperty("private_key_plain_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKeyPlainText { get; set; }

        /// <summary>
        /// 由自定义私钥加密的密文私钥。private_key_plain_text、wrapped_private_key和ciphertext_recipient只能有一个有值
        /// </summary>
        [JsonProperty("wrapped_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string WrappedPrivateKey { get; set; }

        /// <summary>
        /// 由擎天公钥信息加密的密文私钥。private_key_plain_text、wrapped_private_key和ciphertext_recipient只能有一个有值
        /// </summary>
        [JsonProperty("ciphertext_recipient", NullValueHandling = NullValueHandling.Ignore)]
        public string CiphertextRecipient { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRsaDatakeyPairResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  privateKeyCipherText: ").Append(PrivateKeyCipherText).Append("\n");
            sb.Append("  privateKeyPlainText: ").Append(PrivateKeyPlainText).Append("\n");
            sb.Append("  wrappedPrivateKey: ").Append(WrappedPrivateKey).Append("\n");
            sb.Append("  ciphertextRecipient: ").Append(CiphertextRecipient).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRsaDatakeyPairResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRsaDatakeyPairResponse input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.KeySpec != input.KeySpec) return false;
            if (this.PublicKey != input.PublicKey || (this.PublicKey != null && !this.PublicKey.Equals(input.PublicKey))) return false;
            if (this.PrivateKeyCipherText != input.PrivateKeyCipherText || (this.PrivateKeyCipherText != null && !this.PrivateKeyCipherText.Equals(input.PrivateKeyCipherText))) return false;
            if (this.PrivateKeyPlainText != input.PrivateKeyPlainText || (this.PrivateKeyPlainText != null && !this.PrivateKeyPlainText.Equals(input.PrivateKeyPlainText))) return false;
            if (this.WrappedPrivateKey != input.WrappedPrivateKey || (this.WrappedPrivateKey != null && !this.WrappedPrivateKey.Equals(input.WrappedPrivateKey))) return false;
            if (this.CiphertextRecipient != input.CiphertextRecipient || (this.CiphertextRecipient != null && !this.CiphertextRecipient.Equals(input.CiphertextRecipient))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                hashCode = hashCode * 59 + this.KeySpec.GetHashCode();
                if (this.PublicKey != null) hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.PrivateKeyCipherText != null) hashCode = hashCode * 59 + this.PrivateKeyCipherText.GetHashCode();
                if (this.PrivateKeyPlainText != null) hashCode = hashCode * 59 + this.PrivateKeyPlainText.GetHashCode();
                if (this.WrappedPrivateKey != null) hashCode = hashCode * 59 + this.WrappedPrivateKey.GetHashCode();
                if (this.CiphertextRecipient != null) hashCode = hashCode * 59 + this.CiphertextRecipient.GetHashCode();
                return hashCode;
            }
        }
    }
}
