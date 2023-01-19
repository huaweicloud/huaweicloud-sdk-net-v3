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
    public class DecryptDataRequestBody 
    {
        /// <summary>
        /// 数据加密算法，仅使用非对称密钥需要指定该参数，默认值为“SYMMETRIC_DEFAULT”，合法枚举值如下：  - SYMMETRIC_DEFAULT  - RSAES_OAEP_SHA_256  - SM2_ENCRYPT
        /// </summary>
        /// <value>数据加密算法，仅使用非对称密钥需要指定该参数，默认值为“SYMMETRIC_DEFAULT”，合法枚举值如下：  - SYMMETRIC_DEFAULT  - RSAES_OAEP_SHA_256  - SM2_ENCRYPT</value>
        [JsonConverter(typeof(EnumClassConverter<EncryptionAlgorithmEnum>))]
        public class EncryptionAlgorithmEnum
        {
            /// <summary>
            /// Enum SYMMETRIC_DEFAULT for value: SYMMETRIC_DEFAULT
            /// </summary>
            public static readonly EncryptionAlgorithmEnum SYMMETRIC_DEFAULT = new EncryptionAlgorithmEnum("SYMMETRIC_DEFAULT");

            /// <summary>
            /// Enum RSAES_OAEP_SHA_256 for value: RSAES_OAEP_SHA_256
            /// </summary>
            public static readonly EncryptionAlgorithmEnum RSAES_OAEP_SHA_256 = new EncryptionAlgorithmEnum("RSAES_OAEP_SHA_256");

            /// <summary>
            /// Enum SM2_ENCRYPT for value: SM2_ENCRYPT
            /// </summary>
            public static readonly EncryptionAlgorithmEnum SM2_ENCRYPT = new EncryptionAlgorithmEnum("SM2_ENCRYPT");

            private static readonly Dictionary<string, EncryptionAlgorithmEnum> StaticFields =
            new Dictionary<string, EncryptionAlgorithmEnum>()
            {
                { "SYMMETRIC_DEFAULT", SYMMETRIC_DEFAULT },
                { "RSAES_OAEP_SHA_256", RSAES_OAEP_SHA_256 },
                { "SM2_ENCRYPT", SM2_ENCRYPT },
            };

            private string _value;

            public EncryptionAlgorithmEnum()
            {

            }

            public EncryptionAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static EncryptionAlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as EncryptionAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EncryptionAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EncryptionAlgorithmEnum a, EncryptionAlgorithmEnum b)
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

            public static bool operator !=(EncryptionAlgorithmEnum a, EncryptionAlgorithmEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 被加密数据密文。取值为加密数据结果中的cipher_text的值，满足正则匹配“^[0-9a-zA-Z+/&#x3D;]{128,5648}$”。
        /// </summary>
        [JsonProperty("cipher_text", NullValueHandling = NullValueHandling.Ignore)]
        public string CipherText { get; set; }

        /// <summary>
        /// 数据加密算法，仅使用非对称密钥需要指定该参数，默认值为“SYMMETRIC_DEFAULT”，合法枚举值如下：  - SYMMETRIC_DEFAULT  - RSAES_OAEP_SHA_256  - SM2_ENCRYPT
        /// </summary>
        [JsonProperty("encryption_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptionAlgorithmEnum EncryptionAlgorithm { get; set; }
        /// <summary>
        /// 密钥ID，36字节，满足正则匹配“^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$”。仅当密文使用非对称密钥加密时才需要此参数。 例如：0d0466b0-e727-4d9c-b35d-f84bb474a37f。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 请求消息序列号，36字节序列号。 例如：919c82d4-8046-4722-9094-35c3c6524cff
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptDataRequestBody {\n");
            sb.Append("  cipherText: ").Append(CipherText).Append("\n");
            sb.Append("  encryptionAlgorithm: ").Append(EncryptionAlgorithm).Append("\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecryptDataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecryptDataRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CipherText == input.CipherText ||
                    (this.CipherText != null &&
                    this.CipherText.Equals(input.CipherText))
                ) && 
                (
                    this.EncryptionAlgorithm == input.EncryptionAlgorithm ||
                    (this.EncryptionAlgorithm != null &&
                    this.EncryptionAlgorithm.Equals(input.EncryptionAlgorithm))
                ) && 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CipherText != null)
                    hashCode = hashCode * 59 + this.CipherText.GetHashCode();
                if (this.EncryptionAlgorithm != null)
                    hashCode = hashCode * 59 + this.EncryptionAlgorithm.GetHashCode();
                if (this.KeyId != null)
                    hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
