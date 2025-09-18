using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// 门户登录选项
    /// </summary>
    public class SignInOptionsDto 
    {
        /// <summary>
        /// IAM身份中心跳转应用程序的方式
        /// </summary>
        /// <value>IAM身份中心跳转应用程序的方式</value>
        [JsonConverter(typeof(EnumClassConverter<OriginEnum>))]
        public class OriginEnum
        {
            /// <summary>
            /// Enum IDENTITY_CENTER for value: IDENTITY_CENTER
            /// </summary>
            public static readonly OriginEnum IDENTITY_CENTER = new OriginEnum("IDENTITY_CENTER");

            /// <summary>
            /// Enum APPLICATION for value: APPLICATION
            /// </summary>
            public static readonly OriginEnum APPLICATION = new OriginEnum("APPLICATION");

            private static readonly Dictionary<string, OriginEnum> StaticFields =
            new Dictionary<string, OriginEnum>()
            {
                { "IDENTITY_CENTER", IDENTITY_CENTER },
                { "APPLICATION", APPLICATION },
            };

            private string _value;

            public OriginEnum()
            {

            }

            public OriginEnum(string value)
            {
                _value = value;
            }

            public static OriginEnum FromValue(string value)
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

                if (this.Equals(obj as OriginEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OriginEnum a, OriginEnum b)
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

            public static bool operator !=(OriginEnum a, OriginEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// IAM身份中心跳转应用程序的方式
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// 接受应用程序身份验证请求的Url
        /// </summary>
        [JsonProperty("application_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignInOptionsDto {\n");
            sb.Append("  origin: ").Append(Origin).Append("\n");
            sb.Append("  applicationUrl: ").Append(ApplicationUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SignInOptionsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SignInOptionsDto input)
        {
            if (input == null) return false;
            if (this.Origin != input.Origin) return false;
            if (this.ApplicationUrl != input.ApplicationUrl || (this.ApplicationUrl != null && !this.ApplicationUrl.Equals(input.ApplicationUrl))) return false;

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
                hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.ApplicationUrl != null) hashCode = hashCode * 59 + this.ApplicationUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
