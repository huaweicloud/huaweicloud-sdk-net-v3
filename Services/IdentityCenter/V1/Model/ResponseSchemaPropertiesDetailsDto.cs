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
    /// 联邦Schema配置额外属性详细信息
    /// </summary>
    public class ResponseSchemaPropertiesDetailsDto 
    {
        /// <summary>
        /// 是否包含额外属性
        /// </summary>
        /// <value>是否包含额外属性</value>
        [JsonConverter(typeof(EnumClassConverter<IncludeEnum>))]
        public class IncludeEnum
        {
            /// <summary>
            /// Enum YES for value: YES
            /// </summary>
            public static readonly IncludeEnum YES = new IncludeEnum("YES");

            private static readonly Dictionary<string, IncludeEnum> StaticFields =
            new Dictionary<string, IncludeEnum>()
            {
                { "YES", YES },
            };

            private string _value;

            public IncludeEnum()
            {

            }

            public IncludeEnum(string value)
            {
                _value = value;
            }

            public static IncludeEnum FromValue(string value)
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

                if (this.Equals(obj as IncludeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IncludeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IncludeEnum a, IncludeEnum b)
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

            public static bool operator !=(IncludeEnum a, IncludeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 额外添加的属性的格式
        /// </summary>
        [JsonProperty("attr_name_format", NullValueHandling = NullValueHandling.Ignore)]
        public string AttrNameFormat { get; set; }

        /// <summary>
        /// 是否包含额外属性
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public IncludeEnum Include { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseSchemaPropertiesDetailsDto {\n");
            sb.Append("  attrNameFormat: ").Append(AttrNameFormat).Append("\n");
            sb.Append("  include: ").Append(Include).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseSchemaPropertiesDetailsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResponseSchemaPropertiesDetailsDto input)
        {
            if (input == null) return false;
            if (this.AttrNameFormat != input.AttrNameFormat || (this.AttrNameFormat != null && !this.AttrNameFormat.Equals(input.AttrNameFormat))) return false;
            if (this.Include != input.Include) return false;

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
                if (this.AttrNameFormat != null) hashCode = hashCode * 59 + this.AttrNameFormat.GetHashCode();
                hashCode = hashCode * 59 + this.Include.GetHashCode();
                return hashCode;
            }
        }
    }
}
