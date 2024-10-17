using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MfaIdentity 
    {
        /// <summary>
        /// Defines methods
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<MethodsEnum>))]
        public class MethodsEnum
        {
            /// <summary>
            /// Enum PASSWORD for value: password
            /// </summary>
            public static readonly MethodsEnum PASSWORD = new MethodsEnum("password");

            /// <summary>
            /// Enum _TOTP for value:  totp
            /// </summary>
            public static readonly MethodsEnum _TOTP = new MethodsEnum(" totp");

            private static readonly Dictionary<string, MethodsEnum> StaticFields =
            new Dictionary<string, MethodsEnum>()
            {
                { "password", PASSWORD },
                { " totp", _TOTP },
            };

            private string _value;

            public MethodsEnum()
            {

            }

            public MethodsEnum(string value)
            {
                _value = value;
            }

            public static MethodsEnum FromValue(string value)
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

                if (this.Equals(obj as MethodsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MethodsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MethodsEnum a, MethodsEnum b)
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

            public static bool operator !=(MethodsEnum a, MethodsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 认证方法，该字段内容为[\&quot;password\&quot;, \&quot;totp\&quot;]。
        /// </summary>
        [JsonProperty("methods", NullValueHandling = NullValueHandling.Ignore)]
        public List<MethodsEnum> Methods { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public PwdPassword Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("totp", NullValueHandling = NullValueHandling.Ignore)]
        public MfaTotp Totp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MfaIdentity {\n");
            sb.Append("  methods: ").Append(Methods).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  totp: ").Append(Totp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MfaIdentity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MfaIdentity input)
        {
            if (input == null) return false;
            if (this.Methods != input.Methods || (this.Methods != null && input.Methods != null && !this.Methods.SequenceEqual(input.Methods))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.Totp != input.Totp || (this.Totp != null && !this.Totp.Equals(input.Totp))) return false;

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
                hashCode = hashCode * 59 + this.Methods.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Totp != null) hashCode = hashCode * 59 + this.Totp.GetHashCode();
                return hashCode;
            }
        }
    }
}
