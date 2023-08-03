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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyGaussMySqlProxyRouteModeRequestBody {\n");
            sb.Append("  routeMode: ").Append(RouteMode).Append("\n");
            sb.Append("  masterWeight: ").Append(MasterWeight).Append("\n");
            sb.Append("  readonlyNodes: ").Append(ReadonlyNodes).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.RouteMode == input.RouteMode ||
                    (this.RouteMode != null &&
                    this.RouteMode.Equals(input.RouteMode))
                ) && 
                (
                    this.MasterWeight == input.MasterWeight ||
                    (this.MasterWeight != null &&
                    this.MasterWeight.Equals(input.MasterWeight))
                ) && 
                (
                    this.ReadonlyNodes == input.ReadonlyNodes ||
                    this.ReadonlyNodes != null &&
                    input.ReadonlyNodes != null &&
                    this.ReadonlyNodes.SequenceEqual(input.ReadonlyNodes)
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
                if (this.RouteMode != null)
                    hashCode = hashCode * 59 + this.RouteMode.GetHashCode();
                if (this.MasterWeight != null)
                    hashCode = hashCode * 59 + this.MasterWeight.GetHashCode();
                if (this.ReadonlyNodes != null)
                    hashCode = hashCode * 59 + this.ReadonlyNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
