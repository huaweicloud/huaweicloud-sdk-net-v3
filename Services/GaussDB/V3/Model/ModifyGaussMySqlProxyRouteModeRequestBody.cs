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
    /// proxy实例修改路由模式请求体
    /// </summary>
    public class ModifyGaussMySqlProxyRouteModeRequestBody 
    {

        /// <summary>
        /// 数据库代理路由模式。  取值范围： - 0，表示权重负载模式。 - 1，表示负载均衡模式（数据库主节点不接受读请求）。 - 2，表示负载均衡模式（数据库主节点接受读请求）。
        /// </summary>
        [JsonProperty("route_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteMode { get; set; }

        /// <summary>
        /// 主节点权重： - 如果路由模式为0，取值为0~1000。 - 如果路由模式为1，取值为0。 - 如果路由模式为2，取值为1。
        /// </summary>
        [JsonProperty("master_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? MasterWeight { get; set; }

        /// <summary>
        /// 只读节点权重配置信息。
        /// </summary>
        [JsonProperty("readonly_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyProxyRouteWeightReadonlyNode> ReadonlyNodes { get; set; }

        /// <summary>
        /// 是否开启新增节点自动加入该Proxy。如果需要设置是否开启新增节点自动加入该Proxy，请联系客服人员添加白名单，加入白名单后，方可输入该字段。  取值范围： - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("new_node_auto_add_status", NullValueHandling = NullValueHandling.Ignore)]
        public string NewNodeAutoAddStatus { get; set; }

        /// <summary>
        /// 新增节点的读权重：    - 如果路由模式为0，新增节点自动加入为ON，取值为0~1000。 - 如果路由模式不为0或新增节点自动加入为OFF，则可不输入读权重。 - 如果路由模式不为0或新增节点自动加入为OFF，则可不输入读权重。
        /// </summary>
        [JsonProperty("new_node_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewNodeWeight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyGaussMySqlProxyRouteModeRequestBody {\n");
            sb.Append("  routeMode: ").Append(RouteMode).Append("\n");
            sb.Append("  masterWeight: ").Append(MasterWeight).Append("\n");
            sb.Append("  readonlyNodes: ").Append(ReadonlyNodes).Append("\n");
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
            return this.Equals(input as ModifyGaussMySqlProxyRouteModeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyGaussMySqlProxyRouteModeRequestBody input)
        {
            if (input == null) return false;
            if (this.RouteMode != input.RouteMode || (this.RouteMode != null && !this.RouteMode.Equals(input.RouteMode))) return false;
            if (this.MasterWeight != input.MasterWeight || (this.MasterWeight != null && !this.MasterWeight.Equals(input.MasterWeight))) return false;
            if (this.ReadonlyNodes != input.ReadonlyNodes || (this.ReadonlyNodes != null && input.ReadonlyNodes != null && !this.ReadonlyNodes.SequenceEqual(input.ReadonlyNodes))) return false;
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
                if (this.RouteMode != null) hashCode = hashCode * 59 + this.RouteMode.GetHashCode();
                if (this.MasterWeight != null) hashCode = hashCode * 59 + this.MasterWeight.GetHashCode();
                if (this.ReadonlyNodes != null) hashCode = hashCode * 59 + this.ReadonlyNodes.GetHashCode();
                if (this.NewNodeAutoAddStatus != null) hashCode = hashCode * 59 + this.NewNodeAutoAddStatus.GetHashCode();
                if (this.NewNodeWeight != null) hashCode = hashCode * 59 + this.NewNodeWeight.GetHashCode();
                return hashCode;
            }
        }
    }
}
