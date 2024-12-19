using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 自定义合规规则
    /// </summary>
    public class CustomPolicy 
    {
        /// <summary>
        /// 自定义合规规则调用function方式
        /// </summary>
        /// <value>自定义合规规则调用function方式</value>
        [JsonConverter(typeof(EnumClassConverter<AuthTypeEnum>))]
        public class AuthTypeEnum
        {
            /// <summary>
            /// Enum AGENCY for value: agency
            /// </summary>
            public static readonly AuthTypeEnum AGENCY = new AuthTypeEnum("agency");

            private static readonly Dictionary<string, AuthTypeEnum> StaticFields =
            new Dictionary<string, AuthTypeEnum>()
            {
                { "agency", AGENCY },
            };

            private string _value;

            public AuthTypeEnum()
            {

            }

            public AuthTypeEnum(string value)
            {
                _value = value;
            }

            public static AuthTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AuthTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AuthTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AuthTypeEnum a, AuthTypeEnum b)
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

            public static bool operator !=(AuthTypeEnum a, AuthTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 自定义函数的urn
        /// </summary>
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }

        /// <summary>
        /// 自定义合规规则调用function方式
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthTypeEnum AuthType { get; set; }
        /// <summary>
        /// method参数值，method为agency时，为{\&quot;agency_name\&quot;:rms_fg_agency}, rms_fg_agency为授权Config调用FunctionGraph接口的委托名称
        /// </summary>
        [JsonProperty("auth_value", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> AuthValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomPolicy {\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  authValue: ").Append(AuthValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomPolicy input)
        {
            if (input == null) return false;
            if (this.FunctionUrn != input.FunctionUrn || (this.FunctionUrn != null && !this.FunctionUrn.Equals(input.FunctionUrn))) return false;
            if (this.AuthType != input.AuthType) return false;
            if (this.AuthValue != input.AuthValue || (this.AuthValue != null && input.AuthValue != null && !this.AuthValue.SequenceEqual(input.AuthValue))) return false;

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
                if (this.FunctionUrn != null) hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AuthValue != null) hashCode = hashCode * 59 + this.AuthValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
