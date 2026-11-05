using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释**：事件关联节点信息列表详情。 **取值范围**：不涉及。
    /// </summary>
    public class NodeEvent 
    {

        /// <summary>
        /// **参数解释**：Iaas计划事件Id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("eventId", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// **参数解释**：是否故障节点。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("isFaultNode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFaultNode { get; set; }

        /// <summary>
        /// **参数解释**：节点名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("nodeName", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// **参数解释**：节点ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("instanceId", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：实例类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("instanceType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// **参数解释**：底层实例Id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("underLyingInstanceId", NullValueHandling = NullValueHandling.Ignore)]
        public string UnderLyingInstanceId { get; set; }

        /// <summary>
        /// **参数解释**：节点规格是否支持重部署。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("flavorSupportRedeploy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FlavorSupportRedeploy { get; set; }

        /// <summary>
        /// **参数解释**：资源池名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("poolName", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }

        /// <summary>
        /// **参数解释**：资源池显示名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("poolDisplayName", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolDisplayName { get; set; }

        /// <summary>
        /// **参数解释**：Iaas计划事件状态。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**：Iaas事件发布时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("publishTime", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishTime { get; set; }

        /// <summary>
        /// **参数解释**：Iaas事件开始时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**：Iaas事件完成时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("finishTime", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// **参数解释**：重部署进度。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("jobProgress", NullValueHandling = NullValueHandling.Ignore)]
        public string JobProgress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeEvent {\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  isFaultNode: ").Append(IsFaultNode).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  underLyingInstanceId: ").Append(UnderLyingInstanceId).Append("\n");
            sb.Append("  flavorSupportRedeploy: ").Append(FlavorSupportRedeploy).Append("\n");
            sb.Append("  poolName: ").Append(PoolName).Append("\n");
            sb.Append("  poolDisplayName: ").Append(PoolDisplayName).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  publishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  jobProgress: ").Append(JobProgress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeEvent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeEvent input)
        {
            if (input == null) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;
            if (this.IsFaultNode != input.IsFaultNode || (this.IsFaultNode != null && !this.IsFaultNode.Equals(input.IsFaultNode))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceType != input.InstanceType || (this.InstanceType != null && !this.InstanceType.Equals(input.InstanceType))) return false;
            if (this.UnderLyingInstanceId != input.UnderLyingInstanceId || (this.UnderLyingInstanceId != null && !this.UnderLyingInstanceId.Equals(input.UnderLyingInstanceId))) return false;
            if (this.FlavorSupportRedeploy != input.FlavorSupportRedeploy || (this.FlavorSupportRedeploy != null && !this.FlavorSupportRedeploy.Equals(input.FlavorSupportRedeploy))) return false;
            if (this.PoolName != input.PoolName || (this.PoolName != null && !this.PoolName.Equals(input.PoolName))) return false;
            if (this.PoolDisplayName != input.PoolDisplayName || (this.PoolDisplayName != null && !this.PoolDisplayName.Equals(input.PoolDisplayName))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.PublishTime != input.PublishTime || (this.PublishTime != null && !this.PublishTime.Equals(input.PublishTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.JobProgress != input.JobProgress || (this.JobProgress != null && !this.JobProgress.Equals(input.JobProgress))) return false;

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
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.IsFaultNode != null) hashCode = hashCode * 59 + this.IsFaultNode.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null) hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.UnderLyingInstanceId != null) hashCode = hashCode * 59 + this.UnderLyingInstanceId.GetHashCode();
                if (this.FlavorSupportRedeploy != null) hashCode = hashCode * 59 + this.FlavorSupportRedeploy.GetHashCode();
                if (this.PoolName != null) hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.PoolDisplayName != null) hashCode = hashCode * 59 + this.PoolDisplayName.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PublishTime != null) hashCode = hashCode * 59 + this.PublishTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.JobProgress != null) hashCode = hashCode * 59 + this.JobProgress.GetHashCode();
                return hashCode;
            }
        }
    }
}
