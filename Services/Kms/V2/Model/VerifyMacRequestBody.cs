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
    public class VerifyMacRequestBody 
    {
        /// <summary>
        /// Mac算法，HMAC_SM3只有中国区支持。枚举如下： - HMAC_SHA_256 - HMAC_SHA_384 - HMAC_SHA_512 - HMAC_SM3
        /// </summary>
        /// <value>Mac算法，HMAC_SM3只有中国区支持。枚举如下： - HMAC_SHA_256 - HMAC_SHA_384 - HMAC_SHA_512 - HMAC_SM3</value>
        [JsonConverter(typeof(EnumClassConverter<MacAlgorithmEnum>))]
        public class MacAlgorithmEnum
        {
            /// <summary>
            /// Enum HMAC_SHA_256 for value: HMAC_SHA_256
            /// </summary>
            public static readonly MacAlgorithmEnum HMAC_SHA_256 = new MacAlgorithmEnum("HMAC_SHA_256");

            /// <summary>
            /// Enum HMAC_SHA_384 for value: HMAC_SHA_384
            /// </summary>
            public static readonly MacAlgorithmEnum HMAC_SHA_384 = new MacAlgorithmEnum("HMAC_SHA_384");

            /// <summary>
            /// Enum HMAC_SHA_512 for value: HMAC_SHA_512
            /// </summary>
            public static readonly MacAlgorithmEnum HMAC_SHA_512 = new MacAlgorithmEnum("HMAC_SHA_512");

            /// <summary>
            /// Enum HMAC_SM3 for value: HMAC_SM3
            /// </summary>
            public static readonly MacAlgorithmEnum HMAC_SM3 = new MacAlgorithmEnum("HMAC_SM3");

            private static readonly Dictionary<string, MacAlgorithmEnum> StaticFields =
            new Dictionary<string, MacAlgorithmEnum>()
            {
                { "HMAC_SHA_256", HMAC_SHA_256 },
                { "HMAC_SHA_384", HMAC_SHA_384 },
                { "HMAC_SHA_512", HMAC_SHA_512 },
                { "HMAC_SM3", HMAC_SM3 },
            };

            private string _value;

            public MacAlgorithmEnum()
            {

            }

            public MacAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static MacAlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as MacAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MacAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MacAlgorithmEnum a, MacAlgorithmEnum b)
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

            public static bool operator !=(MacAlgorithmEnum a, MacAlgorithmEnum b)
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
        /// Mac算法，HMAC_SM3只有中国区支持。枚举如下： - HMAC_SHA_256 - HMAC_SHA_384 - HMAC_SHA_512 - HMAC_SM3
        /// </summary>
        [JsonProperty("mac_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public MacAlgorithmEnum MacAlgorithm { get; set; }
        /// <summary>
        /// 待处理消息。原消息最小长度1、最大长度4096。请将原消息转为Base64格式后传入
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 待校验的消息验证码
        /// </summary>
        [JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public string Mac { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyMacRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  macAlgorithm: ").Append(MacAlgorithm).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  mac: ").Append(Mac).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyMacRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyMacRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.MacAlgorithm != input.MacAlgorithm) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Mac != input.Mac || (this.Mac != null && !this.Mac.Equals(input.Mac))) return false;

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
                hashCode = hashCode * 59 + this.MacAlgorithm.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Mac != null) hashCode = hashCode * 59 + this.Mac.GetHashCode();
                return hashCode;
            }
        }
    }
}
