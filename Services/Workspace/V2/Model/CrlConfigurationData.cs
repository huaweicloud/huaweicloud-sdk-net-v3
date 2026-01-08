using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 证书crl配置。
    /// </summary>
    public class CrlConfigurationData 
    {
        /// <summary>
        /// 系统生成SYSTEM, 用户自定义CUSTOMIZE。
        /// </summary>
        /// <value>系统生成SYSTEM, 用户自定义CUSTOMIZE。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SYSTEM for value: SYSTEM
            /// </summary>
            public static readonly TypeEnum SYSTEM = new TypeEnum("SYSTEM");

            /// <summary>
            /// Enum CUSTOMIZE for value: CUSTOMIZE
            /// </summary>
            public static readonly TypeEnum CUSTOMIZE = new TypeEnum("CUSTOMIZE");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "SYSTEM", SYSTEM },
                { "CUSTOMIZE", CUSTOMIZE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启crl配置。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 系统生成SYSTEM, 用户自定义CUSTOMIZE。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 当用户自定义时手动输入。
        /// </summary>
        [JsonProperty("crl_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CrlUrl { get; set; }

        /// <summary>
        /// 更新周期。
        /// </summary>
        [JsonProperty("valid_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? ValidDay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrlConfigurationData {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  crlUrl: ").Append(CrlUrl).Append("\n");
            sb.Append("  validDay: ").Append(ValidDay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CrlConfigurationData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CrlConfigurationData input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Type != input.Type) return false;
            if (this.CrlUrl != input.CrlUrl || (this.CrlUrl != null && !this.CrlUrl.Equals(input.CrlUrl))) return false;
            if (this.ValidDay != input.ValidDay || (this.ValidDay != null && !this.ValidDay.Equals(input.ValidDay))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CrlUrl != null) hashCode = hashCode * 59 + this.CrlUrl.GetHashCode();
                if (this.ValidDay != null) hashCode = hashCode * 59 + this.ValidDay.GetHashCode();
                return hashCode;
            }
        }
    }
}
