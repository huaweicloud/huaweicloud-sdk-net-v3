using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 工作流实例信息
    /// </summary>
    public class WorkItemFlowProcessInstanceVO 
    {

        /// <summary>
        /// **参数解释**： 工作项工作流实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 工作流实例是否挂起。 **取值范围**：  1: 运行  2: 挂起
        /// </summary>
        [JsonProperty("flow_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlowState { get; set; }

        /// <summary>
        /// **参数解释**： 工作流入口ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("workflow_entry_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowEntryId { get; set; }

        /// <summary>
        /// **参数解释**： 工作流分类。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowProcessInstanceVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  flowState: ").Append(FlowState).Append("\n");
            sb.Append("  workflowEntryId: ").Append(WorkflowEntryId).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowProcessInstanceVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowProcessInstanceVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.FlowState != input.FlowState || (this.FlowState != null && !this.FlowState.Equals(input.FlowState))) return false;
            if (this.WorkflowEntryId != input.WorkflowEntryId || (this.WorkflowEntryId != null && !this.WorkflowEntryId.Equals(input.WorkflowEntryId))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FlowState != null) hashCode = hashCode * 59 + this.FlowState.GetHashCode();
                if (this.WorkflowEntryId != null) hashCode = hashCode * 59 + this.WorkflowEntryId.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }
    }
}
