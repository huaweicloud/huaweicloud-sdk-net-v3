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
    /// 
    /// </summary>
    public class DeriveSharedSecretRequestBody 
    {
        /// <summary>
        /// 密钥协商算法，仅支持ECDH
        /// </summary>
        /// <value>密钥协商算法，仅支持ECDH</value>
        [JsonConverter(typeof(EnumClassConverter<KeyAgreementAlgorithmEnum>))]
        public class KeyAgreementAlgorithmEnum
        {
            /// <summary>
            /// Enum ECDH for value: ECDH
            /// </summary>
            public static readonly KeyAgreementAlgorithmEnum ECDH = new KeyAgreementAlgorithmEnum("ECDH");

            private static readonly Dictionary<string, KeyAgreementAlgorithmEnum> StaticFields =
            new Dictionary<string, KeyAgreementAlgorithmEnum>()
            {
                { "ECDH", ECDH },
            };

            private string _value;

            public KeyAgreementAlgorithmEnum()
            {

            }

            public KeyAgreementAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static KeyAgreementAlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as KeyAgreementAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeyAgreementAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeyAgreementAlgorithmEnum a, KeyAgreementAlgorithmEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(KeyAgreementAlgorithmEnum a, KeyAgreementAlgorithmEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 密钥ID
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 密钥协商算法，仅支持ECDH
        /// </summary>
        [JsonProperty("key_agreement_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public KeyAgreementAlgorithmEnum KeyAgreementAlgorithm { get; set; }
        /// <summary>
        /// 对端密钥对的的公钥，您需要保证是EC_P256，EC_384，SECP256K1或SM2(仅中国区域支持)密钥对的公钥。公钥的格式必须是DER-encoded X.509类型的Base64的字符串
        /// </summary>
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public Recipient Recipient { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeriveSharedSecretRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  keyAgreementAlgorithm: ").Append(KeyAgreementAlgorithm).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  recipient: ").Append(Recipient).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeriveSharedSecretRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeriveSharedSecretRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.KeyAgreementAlgorithm != input.KeyAgreementAlgorithm) return false;
            if (this.PublicKey != input.PublicKey || (this.PublicKey != null && !this.PublicKey.Equals(input.PublicKey))) return false;
            if (this.Recipient != input.Recipient || (this.Recipient != null && !this.Recipient.Equals(input.Recipient))) return false;

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
                hashCode = hashCode * 59 + this.KeyAgreementAlgorithm.GetHashCode();
                if (this.PublicKey != null) hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.Recipient != null) hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                return hashCode;
            }
        }
    }
}
