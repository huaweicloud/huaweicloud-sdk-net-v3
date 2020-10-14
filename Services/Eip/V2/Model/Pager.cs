using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// marker分页结构
    /// </summary>
    public class Pager 
    {
        /// <summary>
        /// next:下一页  previous:前一页
        /// </summary>
        /// <value>next:下一页  previous:前一页</value>
        [JsonConverter(typeof(EnumClassConverter<RelEnum>))]
        public class RelEnum
        {
            /// <summary>
            /// Enum NEXT for value: next
            /// </summary>
            public static readonly RelEnum NEXT = new RelEnum("next");

            /// <summary>
            /// Enum PREVIOUS for value: previous
            /// </summary>
            public static readonly RelEnum PREVIOUS = new RelEnum("previous");

            private static readonly Dictionary<string, RelEnum> StaticFields =
            new Dictionary<string, RelEnum>()
            {
                { "next", NEXT },
                { "previous", PREVIOUS },
            };

            private string Value;

            public RelEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(RelEnum a, RelEnum b)
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

            public static bool operator !=(RelEnum a, RelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 页码url
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        /// <summary>
        /// next:下一页  previous:前一页
        /// </summary>
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public RelEnum Rel { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pager {\n");
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
            return this.Equals(input as Pager);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Pager input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Rel == input.Rel ||
                    (this.Rel != null &&
                    this.Rel.Equals(input.Rel))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Rel != null)
                    hashCode = hashCode * 59 + this.Rel.GetHashCode();
                return hashCode;
            }
        }
    }
}
