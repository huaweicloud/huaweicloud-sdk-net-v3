using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 开启数据库代理请求体。
    /// </summary>
    public class CreateMysqlMultiProxyRequest 
    {

        /// <summary>
        /// 数据库代理规格码。      - 当局点支持主备模式数据库代理时，该字段不生效。     - 当局点支持集群模式数据库代理时，该字段请参考查询数据库代理规格信息接口返回体中，[规格信息]中的code字段。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 数据库代理节点数量。      - 当局点支持主备模式数据库代理时，请设置该字段为固定值2。     - 当局点支持集群模式数据库代理时，该字段最小值为2，最大值请参考查询数据库代理信息列表接口返回体中，[数据库代理信息列表]中的max_proxy_node_num字段值。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 数据库代理名称。用于表示实例的名称，同一租户下，同类型的实例名可重名。  取值范围：最小长度为4个字符，最大不超过64个字节，以字母或中文字符开头，只能包含字母、数字、中划线、下划线、英文句号和中文。  当不选择该参数或局点仅支持主备模式数据库代理时，将随机生成名称。
        /// </summary>
        [JsonProperty("proxy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyName { get; set; }

        /// <summary>
        /// 数据库代理读写模式。 取值范围:     readwrite：读写模式。     readonly：只读模式。
        /// </summary>
        [JsonProperty("proxy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// 数据库代理路由模式。 取值范围:     0：表示权重负载模式。     1：表示负载均衡模式（数据库主节点不接受读请求）。     2：表示负载均衡模式（数据库主节点接受读请求）。      - 如需使用负载均衡模式，请联系客服申请
        /// </summary>
        [JsonProperty("route_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteMode { get; set; }

        /// <summary>
        /// 数据库节点的读权重设置。      - 在proxy_mode（数据库代理读写模式）为readonly（只读模式）或者在route_mode（路由模式）&gt;0时，只能为只读节点选择权重。     - 在proxy_mode（数据库代理读写模式）为readonly（只读模式）时，需要至少为一个只读实例配置权重。     - 在route_mode（路由模式）&gt;0时，为主实例配置的权重将不生效。     - 该列表可以为空列表。
        /// </summary>
        [JsonProperty("nodes_read_weight", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstancesWeight> NodesReadWeight { get; set; }

        /// <summary>
        /// 数据库VPC下的子网ID。 取值范围为该实例所在VPC下的所有子网ID。      - 如需使用该参数，请联系客服申请。     - 获取子网ID请参考[创建VPC和子网](https://support.huaweicloud.com/api-cce/cce_02_0100.html)
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMysqlMultiProxyRequest {\n");
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
            return this.Equals(input as CreateMysqlMultiProxyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMysqlMultiProxyRequest input)
        {
            if (input == null) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.ProxyName != input.ProxyName || (this.ProxyName != null && !this.ProxyName.Equals(input.ProxyName))) return false;
            if (this.ProxyMode != input.ProxyMode || (this.ProxyMode != null && !this.ProxyMode.Equals(input.ProxyMode))) return false;
            if (this.RouteMode != input.RouteMode || (this.RouteMode != null && !this.RouteMode.Equals(input.RouteMode))) return false;
            if (this.NodesReadWeight != input.NodesReadWeight || (this.NodesReadWeight != null && input.NodesReadWeight != null && !this.NodesReadWeight.SequenceEqual(input.NodesReadWeight))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;

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
                if (this.ProxyMode != null) hashCode = hashCode * 59 + this.ProxyMode.GetHashCode();
                if (this.RouteMode != null) hashCode = hashCode * 59 + this.RouteMode.GetHashCode();
                if (this.NodesReadWeight != null) hashCode = hashCode * 59 + this.NodesReadWeight.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
