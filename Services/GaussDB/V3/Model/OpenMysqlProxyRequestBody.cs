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
    /// 
    /// </summary>
    public class OpenMysqlProxyRequestBody 
    {
        /// <summary>
        /// 代理实例类型。默认类型为readwrite。
        /// </summary>
        /// <value>代理实例类型。默认类型为readwrite。</value>
        [JsonConverter(typeof(EnumClassConverter<ProxyModeEnum>))]
        public class ProxyModeEnum
        {
            /// <summary>
            /// Enum READWRITE for value: readwrite
            /// </summary>
            public static readonly ProxyModeEnum READWRITE = new ProxyModeEnum("readwrite");

            /// <summary>
            /// Enum READONLY for value: readonly
            /// </summary>
            public static readonly ProxyModeEnum READONLY = new ProxyModeEnum("readonly");

            private static readonly Dictionary<string, ProxyModeEnum> StaticFields =
            new Dictionary<string, ProxyModeEnum>()
            {
                { "readwrite", READWRITE },
                { "readonly", READONLY },
            };

            private string _value;

            public ProxyModeEnum()
            {

            }

            public ProxyModeEnum(string value)
            {
                _value = value;
            }

            public static ProxyModeEnum FromValue(string value)
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

                if (this.Equals(obj as ProxyModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProxyModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProxyModeEnum a, ProxyModeEnum b)
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

            public static bool operator !=(ProxyModeEnum a, ProxyModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 代理规格码。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 代理实例节点数，取值整数2-32。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 代理实例名称。用于表示实例的名称，同一租户下，同类型的实例名可重名。  取值范围：4~64个字符之间，必须以字母开头，区分大小写，可以包含字母、数字、中划线或者下划线，不能包含其他的特殊字符。
        /// </summary>
        [JsonProperty("proxy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyName { get; set; }

        /// <summary>
        /// 代理实例类型。默认类型为readwrite。
        /// </summary>
        [JsonProperty("proxy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ProxyModeEnum ProxyMode { get; set; }
        /// <summary>
        /// 数据库代理路由模式，默认为权重负载模式。  取值范围: - 0，表示权重负载模式; - 1，表示负载均衡模式（数据库主节点不接受读请求）； - 2，表示负载均衡模式（数据库主节点接受读请求）。
        /// </summary>
        [JsonProperty("route_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteMode { get; set; }

        /// <summary>
        /// 数据库节点的读权重设置。  在proxy_mode为readonly时，只能为只读节点选择权重。
        /// </summary>
        [JsonProperty("nodes_read_weight", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodesWeight> NodesReadWeight { get; set; }

        /// <summary>
        /// 数据库VPC下的子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenMysqlProxyRequestBody {\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  proxyName: ").Append(ProxyName).Append("\n");
            sb.Append("  proxyMode: ").Append(ProxyMode).Append("\n");
            sb.Append("  routeMode: ").Append(RouteMode).Append("\n");
            sb.Append("  nodesReadWeight: ").Append(NodesReadWeight).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenMysqlProxyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenMysqlProxyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlavorRef == input.FlavorRef ||
                    (this.FlavorRef != null &&
                    this.FlavorRef.Equals(input.FlavorRef))
                ) && 
                (
                    this.NodeNum == input.NodeNum ||
                    (this.NodeNum != null &&
                    this.NodeNum.Equals(input.NodeNum))
                ) && 
                (
                    this.ProxyName == input.ProxyName ||
                    (this.ProxyName != null &&
                    this.ProxyName.Equals(input.ProxyName))
                ) && 
                (
                    this.ProxyMode == input.ProxyMode ||
                    (this.ProxyMode != null &&
                    this.ProxyMode.Equals(input.ProxyMode))
                ) && 
                (
                    this.RouteMode == input.RouteMode ||
                    (this.RouteMode != null &&
                    this.RouteMode.Equals(input.RouteMode))
                ) && 
                (
                    this.NodesReadWeight == input.NodesReadWeight ||
                    this.NodesReadWeight != null &&
                    input.NodesReadWeight != null &&
                    this.NodesReadWeight.SequenceEqual(input.NodesReadWeight)
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
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
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.NodeNum != null)
                    hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.ProxyName != null)
                    hashCode = hashCode * 59 + this.ProxyName.GetHashCode();
                if (this.ProxyMode != null)
                    hashCode = hashCode * 59 + this.ProxyMode.GetHashCode();
                if (this.RouteMode != null)
                    hashCode = hashCode * 59 + this.RouteMode.GetHashCode();
                if (this.NodesReadWeight != null)
                    hashCode = hashCode * 59 + this.NodesReadWeight.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
