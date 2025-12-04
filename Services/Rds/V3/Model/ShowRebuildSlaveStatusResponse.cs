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
    /// Response Object
    /// </summary>
    public class ShowRebuildSlaveStatusResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  实例ID  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  任务流ID  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// **参数解释**：  上一次重建的时间  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("last_rebuild_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRebuildTime { get; set; }

        /// <summary>
        /// **参数解释**：  下次允许重建的时间  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("next_rebuild_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NextRebuildTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRebuildSlaveStatusResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  lastRebuildTime: ").Append(LastRebuildTime).Append("\n");
            sb.Append("  nextRebuildTime: ").Append(NextRebuildTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRebuildSlaveStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRebuildSlaveStatusResponse input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.WorkflowId != input.WorkflowId || (this.WorkflowId != null && !this.WorkflowId.Equals(input.WorkflowId))) return false;
            if (this.LastRebuildTime != input.LastRebuildTime || (this.LastRebuildTime != null && !this.LastRebuildTime.Equals(input.LastRebuildTime))) return false;
            if (this.NextRebuildTime != input.NextRebuildTime || (this.NextRebuildTime != null && !this.NextRebuildTime.Equals(input.NextRebuildTime))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.WorkflowId != null) hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.LastRebuildTime != null) hashCode = hashCode * 59 + this.LastRebuildTime.GetHashCode();
                if (this.NextRebuildTime != null) hashCode = hashCode * 59 + this.NextRebuildTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
