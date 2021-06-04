using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSlowLogsRequest 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [SDKProperty("start_date", IsQuery = true)]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。只能查询当前时间前一个月内的慢日志。注：结束时间不能晚于当前时间。
        /// </summary>
        [SDKProperty("end_date", IsQuery = true)]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// 节点ID，取空值，表示查询实例下所有允许查询的节点。 使用请参考《DDS API参考》的“查询实例列表”响应消息表“nodes 数据结构说明”的“id”。允许查询的节点如下： - 集群实例下面的 shard节点 - 副本集、单节点实例下面的所有节点
        /// </summary>
        [SDKProperty("node_id", IsQuery = true)]
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 语句类型，取空值，表示查询所有语句类型，也可指定如下日志类型： - SELECT
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 索引位置，偏移量。取值范围为 [0, 1999]。 从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。取值范围[1, 100]，默认10 （表示默认返回10条数据）。 注意： limit 与 offset 的和需要满足 &lt;&#x3D; 2000的条件。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSlowLogsRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSlowLogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSlowLogsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
