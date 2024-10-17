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
        /// 代理实例名称。用于表示实例的名称，同一租户下，同类型的实例名可重名。  取值范围：最小为4个字符，最大为64个字符且不超过64个字节（注意：一个中文字符占用3个字节），必须以字母或中文开头，区分大小写，可以包含字母、数字、中划线、下划线或中文，不能包含其他特殊字符。
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
        /// 是否开启新增节点自动加入该Proxy。如果需要设置是否开启新增节点自动加入该Proxy，请联系客服人员添加白名单，加入白名单后，方可输入该字段。  取值范围： - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("new_node_auto_add_status", NullValueHandling = NullValueHandling.Ignore)]
        public string NewNodeAutoAddStatus { get; set; }

        /// <summary>
        /// 新增节点的读权重：    - 如果路由模式为0，新增节点自动加入为ON，取值为0~1000。 - 如果路由模式不为0或新增节点自动加入为OFF，则可不输入读权重。
        /// </summary>
        [JsonProperty("new_node_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewNodeWeight { get; set; }



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
            sb.Append("  newNodeAutoAddStatus: ").Append(NewNodeAutoAddStatus).Append("\n");
            sb.Append("  newNodeWeight: ").Append(NewNodeWeight).Append("\n");
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
            if (input == null) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.ProxyName != input.ProxyName || (this.ProxyName != null && !this.ProxyName.Equals(input.ProxyName))) return false;
            if (this.ProxyMode != input.ProxyMode) return false;
            if (this.RouteMode != input.RouteMode || (this.RouteMode != null && !this.RouteMode.Equals(input.RouteMode))) return false;
            if (this.NodesReadWeight != input.NodesReadWeight || (this.NodesReadWeight != null && input.NodesReadWeight != null && !this.NodesReadWeight.SequenceEqual(input.NodesReadWeight))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.NewNodeAutoAddStatus != input.NewNodeAutoAddStatus || (this.NewNodeAutoAddStatus != null && !this.NewNodeAutoAddStatus.Equals(input.NewNodeAutoAddStatus))) return false;
            if (this.NewNodeWeight != input.NewNodeWeight || (this.NewNodeWeight != null && !this.NewNodeWeight.Equals(input.NewNodeWeight))) return false;

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
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.ProxyName != null) hashCode = hashCode * 59 + this.ProxyName.GetHashCode();
                hashCode = hashCode * 59 + this.ProxyMode.GetHashCode();
                if (this.RouteMode != null) hashCode = hashCode * 59 + this.RouteMode.GetHashCode();
                if (this.NodesReadWeight != null) hashCode = hashCode * 59 + this.NodesReadWeight.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.NewNodeAutoAddStatus != null) hashCode = hashCode * 59 + this.NewNodeAutoAddStatus.GetHashCode();
                if (this.NewNodeWeight != null) hashCode = hashCode * 59 + this.NewNodeWeight.GetHashCode();
                return hashCode;
            }
        }
    }
}
