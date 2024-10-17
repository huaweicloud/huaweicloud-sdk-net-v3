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
    /// 修改数据库代理路由模式请求体。
    /// </summary>
    public class ModifyMySqlProxyRouteModeRequest 
    {

        /// <summary>
        /// 数据库主实例读权重。     - 当route_mode选择0（权重负载）时，该字段取值范围为0~1000。     - 当route_mode选择1或2（负载均衡）时，该字段不生效。
        /// </summary>
        [JsonProperty("master_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? MasterWeight { get; set; }

        /// <summary>
        /// 数据库节点的读权重设置。      - 只能为只读实例选择权重。     - 该列表可以为空列表。
        /// </summary>
        [JsonProperty("readonly_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstancesWeight> ReadonlyInstances { get; set; }

        /// <summary>
        /// 数据库代理路由模式。 取值范围:     0：表示权重负载模式。     1：表示负载均衡模式（数据库主实例不接受读请求）。     2：表示负载均衡模式（数据库主实例接受读请求）。      - 如需使用负载均衡模式，请联系客服申请
        /// </summary>
        [JsonProperty("route_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyMySqlProxyRouteModeRequest {\n");
            sb.Append("  masterWeight: ").Append(MasterWeight).Append("\n");
            sb.Append("  readonlyInstances: ").Append(ReadonlyInstances).Append("\n");
            sb.Append("  routeMode: ").Append(RouteMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyMySqlProxyRouteModeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyMySqlProxyRouteModeRequest input)
        {
            if (input == null) return false;
            if (this.MasterWeight != input.MasterWeight || (this.MasterWeight != null && !this.MasterWeight.Equals(input.MasterWeight))) return false;
            if (this.ReadonlyInstances != input.ReadonlyInstances || (this.ReadonlyInstances != null && input.ReadonlyInstances != null && !this.ReadonlyInstances.SequenceEqual(input.ReadonlyInstances))) return false;
            if (this.RouteMode != input.RouteMode || (this.RouteMode != null && !this.RouteMode.Equals(input.RouteMode))) return false;

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
                if (this.MasterWeight != null) hashCode = hashCode * 59 + this.MasterWeight.GetHashCode();
                if (this.ReadonlyInstances != null) hashCode = hashCode * 59 + this.ReadonlyInstances.GetHashCode();
                if (this.RouteMode != null) hashCode = hashCode * 59 + this.RouteMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
