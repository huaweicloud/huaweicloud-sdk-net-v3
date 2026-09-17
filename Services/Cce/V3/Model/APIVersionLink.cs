using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释：** API版本的URL链接信息。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class APIVersionLink 
    {
        /// <summary>
        /// **参数解释：** 链接属性。 **约束限制：** 不涉及 **取值范围：** - self：自助链接包含版本链接的资源。立即链接后使用这些链接。  **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 链接属性。 **约束限制：** 不涉及 **取值范围：** - self：自助链接包含版本链接的资源。立即链接后使用这些链接。  **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<RelEnum>))]
        public class RelEnum
        {
            /// <summary>
            /// Enum SELF for value: self
            /// </summary>
            public static readonly RelEnum SELF = new RelEnum("self");

            private static readonly Dictionary<string, RelEnum> StaticFields =
            new Dictionary<string, RelEnum>()
            {
                { "self", SELF },
            };

            private string _value;

            public RelEnum()
            {

            }

            public RelEnum(string value)
            {
                _value = value;
            }

            public static RelEnum FromValue(string value)
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

                if (this.Equals(obj as RelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RelEnum a, RelEnum b)
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

            public static bool operator !=(RelEnum a, RelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** API版本信息的链接。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        /// <summary>
        /// **参数解释：** 链接属性。 **约束限制：** 不涉及 **取值范围：** - self：自助链接包含版本链接的资源。立即链接后使用这些链接。  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public RelEnum Rel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIVersionLink {\n");
            sb.Append("  href: ").Append(Href).Append("\n");
            sb.Append("  rel: ").Append(Rel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as APIVersionLink);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(APIVersionLink input)
        {
            if (input == null) return false;
            if (this.Href != input.Href || (this.Href != null && !this.Href.Equals(input.Href))) return false;
            if (this.Rel != input.Rel) return false;

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
                if (this.Href != null) hashCode = hashCode * 59 + this.Href.GetHashCode();
                hashCode = hashCode * 59 + this.Rel.GetHashCode();
                return hashCode;
            }
        }
    }
}
