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
    /// 门户选项设置
    /// </summary>
    public class PortalOptionsDto 
    {
        /// <summary>
        /// 应用程序在门户可见性
        /// </summary>
        /// <value>应用程序在门户可见性</value>
        [JsonConverter(typeof(EnumClassConverter<VisibilityEnum>))]
        public class VisibilityEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly VisibilityEnum ENABLED = new VisibilityEnum("ENABLED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly VisibilityEnum DISABLED = new VisibilityEnum("DISABLED");

            private static readonly Dictionary<string, VisibilityEnum> StaticFields =
            new Dictionary<string, VisibilityEnum>()
            {
                { "ENABLED", ENABLED },
                { "DISABLED", DISABLED },
            };

            private string _value;

            public VisibilityEnum()
            {

            }

            public VisibilityEnum(string value)
            {
                _value = value;
            }

            public static VisibilityEnum FromValue(string value)
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

                if (this.Equals(obj as VisibilityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VisibilityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VisibilityEnum a, VisibilityEnum b)
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

            public static bool operator !=(VisibilityEnum a, VisibilityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用程序在门户是否可见
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        /// <summary>
        /// 应用程序在门户可见性
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public VisibilityEnum Visibility { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sign_in_options", NullValueHandling = NullValueHandling.Ignore)]
        public SignInOptionsDto SignInOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortalOptionsDto {\n");
            sb.Append("  visible: ").Append(Visible).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  signInOptions: ").Append(SignInOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PortalOptionsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PortalOptionsDto input)
        {
            if (input == null) return false;
            if (this.Visible != input.Visible || (this.Visible != null && !this.Visible.Equals(input.Visible))) return false;
            if (this.Visibility != input.Visibility) return false;
            if (this.SignInOptions != input.SignInOptions || (this.SignInOptions != null && !this.SignInOptions.Equals(input.SignInOptions))) return false;

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
                if (this.Visible != null) hashCode = hashCode * 59 + this.Visible.GetHashCode();
                hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.SignInOptions != null) hashCode = hashCode * 59 + this.SignInOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
