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
    public class CreateDatakeyRequestBody 
    {
        /// <summary>
        /// 指定生成的密钥bit位长度。有效值：AES_256、AES_128、SM4、HMAC_256、HMAC_384、HMAC_512、HMAC_SM3。  - AES_256：表示256比特的对称密钥。  - AES_128：表示128比特的对称密钥。  - SM4：表示SM4密钥。  - HMAC_256：表示HMAC_256密钥。  - HMAC_384：表示HMAC_384密钥。  - HMAC_512：表示HMAC_512密钥。  - HMAC_SM3：表示HMAC_SM3密钥。     说明：  datakey_length和key_spec二选一。   - 若datakey_length和key_spec都为空，默认生成256bit的密钥。   - 若datakey_length和key_spec都指定了值，仅datakey_length生效。
        /// </summary>
        /// <value>指定生成的密钥bit位长度。有效值：AES_256、AES_128、SM4、HMAC_256、HMAC_384、HMAC_512、HMAC_SM3。  - AES_256：表示256比特的对称密钥。  - AES_128：表示128比特的对称密钥。  - SM4：表示SM4密钥。  - HMAC_256：表示HMAC_256密钥。  - HMAC_384：表示HMAC_384密钥。  - HMAC_512：表示HMAC_512密钥。  - HMAC_SM3：表示HMAC_SM3密钥。     说明：  datakey_length和key_spec二选一。   - 若datakey_length和key_spec都为空，默认生成256bit的密钥。   - 若datakey_length和key_spec都指定了值，仅datakey_length生效。</value>
        [JsonConverter(typeof(EnumClassConverter<KeySpecEnum>))]
        public class KeySpecEnum
        {
            /// <summary>
            /// Enum AES_256 for value: AES_256
            /// </summary>
            public static readonly KeySpecEnum AES_256 = new KeySpecEnum("AES_256");

            /// <summary>
            /// Enum AES_128 for value: AES_128
            /// </summary>
            public static readonly KeySpecEnum AES_128 = new KeySpecEnum("AES_128");

            /// <summary>
            /// Enum SM4 for value: SM4
            /// </summary>
            public static readonly KeySpecEnum SM4 = new KeySpecEnum("SM4");

            /// <summary>
            /// Enum HMAC_256 for value: HMAC_256
            /// </summary>
            public static readonly KeySpecEnum HMAC_256 = new KeySpecEnum("HMAC_256");

            /// <summary>
            /// Enum HMAC_384 for value: HMAC_384
            /// </summary>
            public static readonly KeySpecEnum HMAC_384 = new KeySpecEnum("HMAC_384");

            /// <summary>
            /// Enum HMAC_512 for value: HMAC_512
            /// </summary>
            public static readonly KeySpecEnum HMAC_512 = new KeySpecEnum("HMAC_512");

            /// <summary>
            /// Enum HMAC_SM3 for value: HMAC_SM3
            /// </summary>
            public static readonly KeySpecEnum HMAC_SM3 = new KeySpecEnum("HMAC_SM3");

            private static readonly Dictionary<string, KeySpecEnum> StaticFields =
            new Dictionary<string, KeySpecEnum>()
            {
                { "AES_256", AES_256 },
                { "AES_128", AES_128 },
                { "SM4", SM4 },
                { "HMAC_256", HMAC_256 },
                { "HMAC_384", HMAC_384 },
                { "HMAC_512", HMAC_512 },
                { "HMAC_SM3", HMAC_SM3 },
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
        /// pin码的类型，默认为“CipherText”： - PlainText：表示明文pin - CipherText：表示密文pin
        /// </summary>
        /// <value>pin码的类型，默认为“CipherText”： - PlainText：表示明文pin - CipherText：表示密文pin</value>
        [JsonConverter(typeof(EnumClassConverter<PinTypeEnum>))]
        public class PinTypeEnum
        {
            /// <summary>
            /// Enum CIPHERTEXT for value: CipherText
            /// </summary>
            public static readonly PinTypeEnum CIPHERTEXT = new PinTypeEnum("CipherText");

            /// <summary>
            /// Enum PLAINTEXT for value: PlainText
            /// </summary>
            public static readonly PinTypeEnum PLAINTEXT = new PinTypeEnum("PlainText");

            private static readonly Dictionary<string, PinTypeEnum> StaticFields =
            new Dictionary<string, PinTypeEnum>()
            {
                { "CipherText", CIPHERTEXT },
                { "PlainText", PLAINTEXT },
            };

            private string _value;

            public PinTypeEnum()
            {

            }

            public PinTypeEnum(string value)
            {
                _value = value;
            }

            public static PinTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PinTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PinTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PinTypeEnum a, PinTypeEnum b)
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

            public static bool operator !=(PinTypeEnum a, PinTypeEnum b)
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
        /// 指定生成的密钥bit位长度。有效值：AES_256、AES_128、SM4、HMAC_256、HMAC_384、HMAC_512、HMAC_SM3。  - AES_256：表示256比特的对称密钥。  - AES_128：表示128比特的对称密钥。  - SM4：表示SM4密钥。  - HMAC_256：表示HMAC_256密钥。  - HMAC_384：表示HMAC_384密钥。  - HMAC_512：表示HMAC_512密钥。  - HMAC_SM3：表示HMAC_SM3密钥。     说明：  datakey_length和key_spec二选一。   - 若datakey_length和key_spec都为空，默认生成256bit的密钥。   - 若datakey_length和key_spec都指定了值，仅datakey_length生效。
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }
        /// <summary>
        /// 密钥bit位长度。取值为8的倍数，取值范围为8~8192。 说明：  datakey_length和key_spec二选一。   - 若datakey_length和key_spec都为空，默认生成256bit的密钥。   - 若datakey_length和key_spec都指定了值，仅datakey_length生效。
        /// </summary>
        [JsonProperty("datakey_length", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyLength { get; set; }

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
        /// pin码，用于数据密钥的认证，仅四级密评场景生效
        /// </summary>
        [JsonProperty("pin", NullValueHandling = NullValueHandling.Ignore)]
        public string Pin { get; set; }

        /// <summary>
        /// pin码的类型，默认为“CipherText”： - PlainText：表示明文pin - CipherText：表示密文pin
        /// </summary>
        [JsonProperty("pin_type", NullValueHandling = NullValueHandling.Ignore)]
        public PinTypeEnum PinType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDatakeyRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("  datakeyLength: ").Append(DatakeyLength).Append("\n");
            sb.Append("  additionalAuthenticatedData: ").Append(AdditionalAuthenticatedData).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  pin: ").Append(Pin).Append("\n");
            sb.Append("  pinType: ").Append(PinType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDatakeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDatakeyRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.KeySpec != input.KeySpec) return false;
            if (this.DatakeyLength != input.DatakeyLength || (this.DatakeyLength != null && !this.DatakeyLength.Equals(input.DatakeyLength))) return false;
            if (this.AdditionalAuthenticatedData != input.AdditionalAuthenticatedData || (this.AdditionalAuthenticatedData != null && !this.AdditionalAuthenticatedData.Equals(input.AdditionalAuthenticatedData))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.Pin != input.Pin || (this.Pin != null && !this.Pin.Equals(input.Pin))) return false;
            if (this.PinType != input.PinType) return false;

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
                if (this.DatakeyLength != null) hashCode = hashCode * 59 + this.DatakeyLength.GetHashCode();
                if (this.AdditionalAuthenticatedData != null) hashCode = hashCode * 59 + this.AdditionalAuthenticatedData.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Pin != null) hashCode = hashCode * 59 + this.Pin.GetHashCode();
                hashCode = hashCode * 59 + this.PinType.GetHashCode();
                return hashCode;
            }
        }
    }
}
