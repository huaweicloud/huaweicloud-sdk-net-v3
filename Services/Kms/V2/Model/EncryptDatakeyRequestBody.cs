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
    public class EncryptDatakeyRequestBody 
    {
        /// <summary>
        /// 指定待加密数据密钥的类型，仅四级密评场景生效。有效值： SM2、RSA。
        /// </summary>
        /// <value>指定待加密数据密钥的类型，仅四级密评场景生效。有效值： SM2、RSA。</value>
        [JsonConverter(typeof(EnumClassConverter<KeySpecEnum>))]
        public class KeySpecEnum
        {
            /// <summary>
            /// Enum SM2 for value: SM2
            /// </summary>
            public static readonly KeySpecEnum SM2 = new KeySpecEnum("SM2");

            /// <summary>
            /// Enum RSA for value: RSA
            /// </summary>
            public static readonly KeySpecEnum RSA = new KeySpecEnum("RSA");

            private static readonly Dictionary<string, KeySpecEnum> StaticFields =
            new Dictionary<string, KeySpecEnum>()
            {
                { "SM2", SM2 },
                { "RSA", RSA },
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
        /// CMK为AES时，DEK明文和DEK明文的SHA256（32字节）；CMK为SM4时，DEK明文和DEK明文的SM3（32字节），均为16进制字符串表示。
        /// </summary>
        [JsonProperty("plain_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PlainText { get; set; }

        /// <summary>
        /// DEK明文字节长度，取值范围为1~1024。 DEK明文字节长度，取值为“64”。
        /// </summary>
        [JsonProperty("datakey_plain_length", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyPlainLength { get; set; }

        /// <summary>
        /// 身份验证的非敏感额外数据。任意字符串，长度不超过128字节。
        /// </summary>
        [JsonProperty("additional_authenticated_data", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// 请求消息序列号，36字节序列号。 例如：919c82d4-8046-4722-9094-35c3c6524cff
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }

        /// <summary>
        /// 指定PIN码保护。仅四级密评场景支持该参数。
        /// </summary>
        [JsonProperty("pin", NullValueHandling = NullValueHandling.Ignore)]
        public string Pin { get; set; }

        /// <summary>
        /// pin码的类型，默认为“CipherText”，可选“PlainText”。仅四级密评场景支持该参数。
        /// </summary>
        [JsonProperty("pin_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PinType { get; set; }

        /// <summary>
        /// 指定待加密数据密钥的类型，仅四级密评场景生效。有效值： SM2、RSA。
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptDatakeyRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  plainText: ").Append(PlainText).Append("\n");
            sb.Append("  datakeyPlainLength: ").Append(DatakeyPlainLength).Append("\n");
            sb.Append("  additionalAuthenticatedData: ").Append(AdditionalAuthenticatedData).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  pin: ").Append(Pin).Append("\n");
            sb.Append("  pinType: ").Append(PinType).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncryptDatakeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncryptDatakeyRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.PlainText != input.PlainText || (this.PlainText != null && !this.PlainText.Equals(input.PlainText))) return false;
            if (this.DatakeyPlainLength != input.DatakeyPlainLength || (this.DatakeyPlainLength != null && !this.DatakeyPlainLength.Equals(input.DatakeyPlainLength))) return false;
            if (this.AdditionalAuthenticatedData != input.AdditionalAuthenticatedData || (this.AdditionalAuthenticatedData != null && !this.AdditionalAuthenticatedData.Equals(input.AdditionalAuthenticatedData))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.Pin != input.Pin || (this.Pin != null && !this.Pin.Equals(input.Pin))) return false;
            if (this.PinType != input.PinType || (this.PinType != null && !this.PinType.Equals(input.PinType))) return false;
            if (this.KeySpec != input.KeySpec) return false;

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
                if (this.PlainText != null) hashCode = hashCode * 59 + this.PlainText.GetHashCode();
                if (this.DatakeyPlainLength != null) hashCode = hashCode * 59 + this.DatakeyPlainLength.GetHashCode();
                if (this.AdditionalAuthenticatedData != null) hashCode = hashCode * 59 + this.AdditionalAuthenticatedData.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Pin != null) hashCode = hashCode * 59 + this.Pin.GetHashCode();
                if (this.PinType != null) hashCode = hashCode * 59 + this.PinType.GetHashCode();
                hashCode = hashCode * 59 + this.KeySpec.GetHashCode();
                return hashCode;
            }
        }
    }
}
