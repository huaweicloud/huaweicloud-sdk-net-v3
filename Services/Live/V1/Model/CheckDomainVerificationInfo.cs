using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckDomainVerificationInfo 
    {
        /// <summary>
        /// 验证方式，DNS：DNS解析验证；FILE：文件验证
        /// </summary>
        /// <value>验证方式，DNS：DNS解析验证；FILE：文件验证</value>
        [JsonConverter(typeof(EnumClassConverter<VerifyTypeEnum>))]
        public class VerifyTypeEnum
        {
            /// <summary>
            /// Enum DNS for value: DNS
            /// </summary>
            public static readonly VerifyTypeEnum DNS = new VerifyTypeEnum("DNS");

            /// <summary>
            /// Enum FILE for value: FILE
            /// </summary>
            public static readonly VerifyTypeEnum FILE = new VerifyTypeEnum("FILE");

            private static readonly Dictionary<string, VerifyTypeEnum> StaticFields =
            new Dictionary<string, VerifyTypeEnum>()
            {
                { "DNS", DNS },
                { "FILE", FILE },
            };

            private string _value;

            public VerifyTypeEnum()
            {

            }

            public VerifyTypeEnum(string value)
            {
                _value = value;
            }

            public static VerifyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VerifyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VerifyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VerifyTypeEnum a, VerifyTypeEnum b)
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

            public static bool operator !=(VerifyTypeEnum a, VerifyTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 直播域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 验证方式，DNS：DNS解析验证；FILE：文件验证
        /// </summary>
        [JsonProperty("verify_type", NullValueHandling = NullValueHandling.Ignore)]
        public VerifyTypeEnum VerifyType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDomainVerificationInfo {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  verifyType: ").Append(VerifyType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckDomainVerificationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckDomainVerificationInfo input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.VerifyType != input.VerifyType) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                hashCode = hashCode * 59 + this.VerifyType.GetHashCode();
                return hashCode;
            }
        }
    }
}
