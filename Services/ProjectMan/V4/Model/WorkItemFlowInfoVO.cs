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
    /// 工作项流转信息
    /// </summary>
    public class WorkItemFlowInfoVO 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("process_instance", NullValueHandling = NullValueHandling.Ignore)]
        public WorkItemFlowProcessInstanceVO ProcessInstance { get; set; }

        /// <summary>
        /// **参数解释**： 工作项关联的全部工作流节点列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("process_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkItemFlowProcessNodeVO> ProcessNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("current_process_node", NullValueHandling = NullValueHandling.Ignore)]
        public WorkItemFlowProcessNodeVO CurrentProcessNode { get; set; }

        /// <summary>
        /// **参数解释**： 可以流转的流转线信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("next_flow", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowsInfoVO> NextFlow { get; set; }

        /// <summary>
        /// **参数解释**： 流转失败时的失败原因。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("fail_result", NullValueHandling = NullValueHandling.Ignore)]
        public string FailResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowInfoVO {\n");
            sb.Append("  processInstance: ").Append(ProcessInstance).Append("\n");
            sb.Append("  processNodes: ").Append(ProcessNodes).Append("\n");
            sb.Append("  currentProcessNode: ").Append(CurrentProcessNode).Append("\n");
            sb.Append("  nextFlow: ").Append(NextFlow).Append("\n");
            sb.Append("  failResult: ").Append(FailResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowInfoVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowInfoVO input)
        {
            if (input == null) return false;
            if (this.ProcessInstance != input.ProcessInstance || (this.ProcessInstance != null && !this.ProcessInstance.Equals(input.ProcessInstance))) return false;
            if (this.ProcessNodes != input.ProcessNodes || (this.ProcessNodes != null && input.ProcessNodes != null && !this.ProcessNodes.SequenceEqual(input.ProcessNodes))) return false;
            if (this.CurrentProcessNode != input.CurrentProcessNode || (this.CurrentProcessNode != null && !this.CurrentProcessNode.Equals(input.CurrentProcessNode))) return false;
            if (this.NextFlow != input.NextFlow || (this.NextFlow != null && input.NextFlow != null && !this.NextFlow.SequenceEqual(input.NextFlow))) return false;
            if (this.FailResult != input.FailResult || (this.FailResult != null && !this.FailResult.Equals(input.FailResult))) return false;

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
                if (this.ProcessInstance != null) hashCode = hashCode * 59 + this.ProcessInstance.GetHashCode();
                if (this.ProcessNodes != null) hashCode = hashCode * 59 + this.ProcessNodes.GetHashCode();
                if (this.CurrentProcessNode != null) hashCode = hashCode * 59 + this.CurrentProcessNode.GetHashCode();
                if (this.NextFlow != null) hashCode = hashCode * 59 + this.NextFlow.GetHashCode();
                if (this.FailResult != null) hashCode = hashCode * 59 + this.FailResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
