using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSessionsRequest 
    {

        /// <summary>
        /// 节点ID。允许查询的节点如下： 集群下面的 mongos节点以及 副本集、单节点实例下面的所有节点。
        /// </summary>
        [SDKProperty("node_id", IsPath = true)]
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 索引位置，偏移量。 从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。取值范围[1, 20]，默认10 （表示返回10条数据）。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 执行计划描述。取空值表示查询所有语句类型，也可指定执行计划，例如： COLLSCAN IXSCAN FETCH SORT LIMIT SKIP COUNT COUNT_SCAN TEXT PROJECTION 等
        /// </summary>
        [SDKProperty("plan_summary", IsQuery = true)]
        [JsonProperty("plan_summary", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanSummary { get; set; }

        /// <summary>
        /// 操作类型。取空值表示查询所有操作类型。也可指定操作类型，例如： none update insert query command getmore remove killcursors等
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 命名空间。取空值表示查询所有命名空间。也可根据当前业务进行指定。
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 运行时间，单位为 ms。取空值表示查询所有的运行时间。也可根据当前业务需要进行配置，表示查询超出 cost_time 的会话。
        /// </summary>
        [SDKProperty("cost_time", IsQuery = true)]
        [JsonProperty("cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CostTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSessionsRequest {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  planSummary: ").Append(PlanSummary).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  costTime: ").Append(CostTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSessionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSessionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.PlanSummary == input.PlanSummary ||
                    (this.PlanSummary != null &&
                    this.PlanSummary.Equals(input.PlanSummary))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.CostTime == input.CostTime ||
                    (this.CostTime != null &&
                    this.CostTime.Equals(input.CostTime))
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
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PlanSummary != null)
                    hashCode = hashCode * 59 + this.PlanSummary.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.CostTime != null)
                    hashCode = hashCode * 59 + this.CostTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
