using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    ///  
    /// </summary>
    public class NovaLink 
    {
        /// <summary>
        /// 有三种取值。self：自助链接包含版本链接的资源。立即链接后使用这些链接。bookmark：书签链接提供了一个永久资源的永久链接，该链接适合于长期存储。alternate：备用链接可以包含资源的替换表示形式。例如，OpenStack计算映像可能在OpenStack映像服务中有一个替代表示。
        /// </summary>
        /// <value>有三种取值。self：自助链接包含版本链接的资源。立即链接后使用这些链接。bookmark：书签链接提供了一个永久资源的永久链接，该链接适合于长期存储。alternate：备用链接可以包含资源的替换表示形式。例如，OpenStack计算映像可能在OpenStack映像服务中有一个替代表示。</value>
        [JsonConverter(typeof(EnumClassConverter<RelEnum>))]
        public class RelEnum
        {
            /// <summary>
            /// Enum SELF for value: self
            /// </summary>
            public static readonly RelEnum SELF = new RelEnum("self");

            /// <summary>
            /// Enum BOOKMARK for value: bookmark
            /// </summary>
            public static readonly RelEnum BOOKMARK = new RelEnum("bookmark");

            /// <summary>
            /// Enum ALTERNATE for value: alternate
            /// </summary>
            public static readonly RelEnum ALTERNATE = new RelEnum("alternate");

            /// <summary>
            /// Enum DESCRIBEDBY for value: describedby
            /// </summary>
            public static readonly RelEnum DESCRIBEDBY = new RelEnum("describedby");

            private static readonly Dictionary<string, RelEnum> StaticFields =
            new Dictionary<string, RelEnum>()
            {
                { "self", SELF },
                { "bookmark", BOOKMARK },
                { "alternate", ALTERNATE },
                { "describedby", DESCRIBEDBY },
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
        /// 相应资源的链接。
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        /// <summary>
        /// 有三种取值。self：自助链接包含版本链接的资源。立即链接后使用这些链接。bookmark：书签链接提供了一个永久资源的永久链接，该链接适合于长期存储。alternate：备用链接可以包含资源的替换表示形式。例如，OpenStack计算映像可能在OpenStack映像服务中有一个替代表示。
        /// </summary>
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public RelEnum Rel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaLink {\n");
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
            return this.Equals(input as NovaLink);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaLink input)
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
