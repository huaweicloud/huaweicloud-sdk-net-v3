using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// The email address associated with the user.
    /// </summary>
    public class EmailDto 
    {
        /// <summary>
        /// 电子邮箱地址的验证状态
        /// </summary>
        /// <value>电子邮箱地址的验证状态</value>
        [JsonConverter(typeof(EnumClassConverter<VerificationStatusEnum>))]
        public class VerificationStatusEnum
        {
            /// <summary>
            /// Enum NOT_VERIFIED for value: NOT_VERIFIED
            /// </summary>
            public static readonly VerificationStatusEnum NOT_VERIFIED = new VerificationStatusEnum("NOT_VERIFIED");

            /// <summary>
            /// Enum VERIFIED for value: VERIFIED
            /// </summary>
            public static readonly VerificationStatusEnum VERIFIED = new VerificationStatusEnum("VERIFIED");

            private static readonly Dictionary<string, VerificationStatusEnum> StaticFields =
            new Dictionary<string, VerificationStatusEnum>()
            {
                { "NOT_VERIFIED", NOT_VERIFIED },
                { "VERIFIED", VERIFIED },
            };

            private string _value;

            public VerificationStatusEnum()
            {

            }

            public VerificationStatusEnum(string value)
            {
                _value = value;
            }

            public static VerificationStatusEnum FromValue(string value)
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

                if (this.Equals(obj as VerificationStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VerificationStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VerificationStatusEnum a, VerificationStatusEnum b)
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

            public static bool operator !=(VerificationStatusEnum a, VerificationStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 一个布尔值，表示这是否是用户的主电子邮箱
        /// </summary>
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        /// <summary>
        /// 表示电子邮箱类型的字符串
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 包含电子邮箱地址的字符串
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 电子邮箱地址的验证状态
        /// </summary>
        [JsonProperty("verification_status", NullValueHandling = NullValueHandling.Ignore)]
        public VerificationStatusEnum VerificationStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailDto {\n");
            sb.Append("  primary: ").Append(Primary).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  verificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmailDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EmailDto input)
        {
            if (input == null) return false;
            if (this.Primary != input.Primary || (this.Primary != null && !this.Primary.Equals(input.Primary))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.VerificationStatus != input.VerificationStatus) return false;

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
                if (this.Primary != null) hashCode = hashCode * 59 + this.Primary.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.VerificationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
