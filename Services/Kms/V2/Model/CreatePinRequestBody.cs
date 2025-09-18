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
    public class CreatePinRequestBody 
    {
        /// <summary>
        /// pin码的类型，默认为“CipherText”： - PlainText - CipherText
        /// </summary>
        /// <value>pin码的类型，默认为“CipherText”： - PlainText - CipherText</value>
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
        /// pin码的类型，默认为“CipherText”： - PlainText - CipherText
        /// </summary>
        [JsonProperty("pin_type", NullValueHandling = NullValueHandling.Ignore)]
        public PinTypeEnum PinType { get; set; }
        /// <summary>
        /// 密钥库ID，指定密文pin时必选： 1：管理面manage_az集群（共享卡集群） 2：数据面共享集群(pod区) 其它：租户专属
        /// </summary>
        [JsonProperty("keystore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePinRequestBody {\n");
            sb.Append("  pinType: ").Append(PinType).Append("\n");
            sb.Append("  keystoreId: ").Append(KeystoreId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePinRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePinRequestBody input)
        {
            if (input == null) return false;
            if (this.PinType != input.PinType) return false;
            if (this.KeystoreId != input.KeystoreId || (this.KeystoreId != null && !this.KeystoreId.Equals(input.KeystoreId))) return false;

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
                hashCode = hashCode * 59 + this.PinType.GetHashCode();
                if (this.KeystoreId != null) hashCode = hashCode * 59 + this.KeystoreId.GetHashCode();
                return hashCode;
            }
        }
    }
}
