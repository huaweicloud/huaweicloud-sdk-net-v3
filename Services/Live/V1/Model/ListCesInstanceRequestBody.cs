using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 查询medialive维度(medialive_mpc、medialive_cdn、medialive_package、medialive_connect、medialive_tailor) medialive_mpc维度可以查询实例下的pipeline实例及pipeline下的音频实例
    /// </summary>
    public class ListCesInstanceRequestBody 
    {
        /// <summary>
        /// 命名空间
        /// </summary>
        /// <value>命名空间</value>
        [JsonConverter(typeof(EnumClassConverter<NamespaceEnum>))]
        public class NamespaceEnum
        {
            /// <summary>
            /// Enum SYS_LIVE for value: SYS.LIVE
            /// </summary>
            public static readonly NamespaceEnum SYS_LIVE = new NamespaceEnum("SYS.LIVE");

            private static readonly Dictionary<string, NamespaceEnum> StaticFields =
            new Dictionary<string, NamespaceEnum>()
            {
                { "SYS.LIVE", SYS_LIVE },
            };

            private string _value;

            public NamespaceEnum()
            {

            }

            public NamespaceEnum(string value)
            {
                _value = value;
            }

            public static NamespaceEnum FromValue(string value)
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

                if (this.Equals(obj as NamespaceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NamespaceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NamespaceEnum a, NamespaceEnum b)
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

            public static bool operator !=(NamespaceEnum a, NamespaceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public NamespaceEnum Namespace { get; set; }
        /// <summary>
        /// 查询信息
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListCesInstanceRequestBodyQuery> Query { get; set; }

        /// <summary>
        /// 查询开始偏移
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public int? Start { get; set; }

        /// <summary>
        /// 查询限制
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCesInstanceRequestBody {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCesInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCesInstanceRequestBody input)
        {
            if (input == null) return false;
            if (this.Namespace != input.Namespace) return false;
            if (this.Query != input.Query || (this.Query != null && input.Query != null && !this.Query.SequenceEqual(input.Query))) return false;
            if (this.Start != input.Start || (this.Start != null && !this.Start.Equals(input.Start))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Start != null) hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
