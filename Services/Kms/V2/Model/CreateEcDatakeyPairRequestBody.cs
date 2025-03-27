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
    public class CreateEcDatakeyPairRequestBody 
    {
        /// <summary>
        /// 需要包含算法、长度、曲线信息。可选值有ECC_NIST_P256 | ECC_NIST_P384 | ECC_NIST_P521 | ECC_SECG_P256K1 | SM2
        /// </summary>
        /// <value>需要包含算法、长度、曲线信息。可选值有ECC_NIST_P256 | ECC_NIST_P384 | ECC_NIST_P521 | ECC_SECG_P256K1 | SM2</value>
        [JsonConverter(typeof(EnumClassConverter<KeySpecEnum>))]
        public class KeySpecEnum
        {
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
        /// 密钥ID，36字节，满足正则匹配“^[0-9a-z]{8}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{12}$”。 例如：0d0466b0-e727-4d9c-b35d-f84bb474a37f。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 需要包含算法、长度、曲线信息。可选值有ECC_NIST_P256 | ECC_NIST_P384 | ECC_NIST_P521 | ECC_SECG_P256K1 | SM2
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }
        /// <summary>
        /// 是否返回明文私钥，默认为true
        /// </summary>
        [JsonProperty("with_plain_text", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithPlainText { get; set; }

        /// <summary>
        /// 认证加密的额外信息，请不要填写敏感信息
        /// </summary>
        [JsonProperty("additional_authenticated_data", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalAuthenticatedData { get; set; }

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
            sb.Append("class CreateEcDatakeyPairRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("  withPlainText: ").Append(WithPlainText).Append("\n");
            sb.Append("  additionalAuthenticatedData: ").Append(AdditionalAuthenticatedData).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEcDatakeyPairRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEcDatakeyPairRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.KeySpec != input.KeySpec) return false;
            if (this.WithPlainText != input.WithPlainText || (this.WithPlainText != null && !this.WithPlainText.Equals(input.WithPlainText))) return false;
            if (this.AdditionalAuthenticatedData != input.AdditionalAuthenticatedData || (this.AdditionalAuthenticatedData != null && !this.AdditionalAuthenticatedData.Equals(input.AdditionalAuthenticatedData))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;

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
                if (this.WithPlainText != null) hashCode = hashCode * 59 + this.WithPlainText.GetHashCode();
                if (this.AdditionalAuthenticatedData != null) hashCode = hashCode * 59 + this.AdditionalAuthenticatedData.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
