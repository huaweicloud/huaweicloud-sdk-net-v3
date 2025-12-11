using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowGaussMySqlProxyFlavorsRequest 
    {
        /// <summary>
        /// 查询的场景
        /// </summary>
        /// <value>查询的场景</value>
        [JsonConverter(typeof(EnumClassConverter<QueryTypeEnum>))]
        public class QueryTypeEnum
        {
            /// <summary>
            /// Enum CREATE for value: create
            /// </summary>
            public static readonly QueryTypeEnum CREATE = new QueryTypeEnum("create");

            /// <summary>
            /// Enum SCALE for value: scale
            /// </summary>
            public static readonly QueryTypeEnum SCALE = new QueryTypeEnum("scale");

            private static readonly Dictionary<string, QueryTypeEnum> StaticFields =
            new Dictionary<string, QueryTypeEnum>()
            {
                { "create", CREATE },
                { "scale", SCALE },
            };

            private string _value;

            public QueryTypeEnum()
            {

            }

            public QueryTypeEnum(string value)
            {
                _value = value;
            }

            public static QueryTypeEnum FromValue(string value)
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

                if (this.Equals(obj as QueryTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QueryTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QueryTypeEnum a, QueryTypeEnum b)
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

            public static bool operator !=(QueryTypeEnum a, QueryTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 查询的场景
        /// </summary>
        [SDKProperty("query_type", IsQuery = true)]
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public QueryTypeEnum QueryType { get; set; }
        /// <summary>
        /// 数据代理的ID, 规格变更场景需要传该参数，过滤掉无法变更的目标规格
        /// </summary>
        [SDKProperty("proxy_id", IsQuery = true)]
        [JsonProperty("proxy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGaussMySqlProxyFlavorsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("  proxyId: ").Append(ProxyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGaussMySqlProxyFlavorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGaussMySqlProxyFlavorsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.QueryType != input.QueryType) return false;
            if (this.ProxyId != input.ProxyId || (this.ProxyId != null && !this.ProxyId.Equals(input.ProxyId))) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.ProxyId != null) hashCode = hashCode * 59 + this.ProxyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
