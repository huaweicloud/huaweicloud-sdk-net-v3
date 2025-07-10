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
    /// 工作流信息
    /// </summary>
    public class WorkflowTemplateVO 
    {

        /// <summary>
        /// 状态流中的状态信息
        /// </summary>
        [JsonProperty("processNodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowTemplateNodesVO> ProcessNodes { get; set; }

        /// <summary>
        /// 状态流中的流转线信息
        /// </summary>
        [JsonProperty("processFlows", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowTemplateFlowsVO> ProcessFlows { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowTemplateVO {\n");
            sb.Append("  processNodes: ").Append(ProcessNodes).Append("\n");
            sb.Append("  processFlows: ").Append(ProcessFlows).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowTemplateVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowTemplateVO input)
        {
            if (input == null) return false;
            if (this.ProcessNodes != input.ProcessNodes || (this.ProcessNodes != null && input.ProcessNodes != null && !this.ProcessNodes.SequenceEqual(input.ProcessNodes))) return false;
            if (this.ProcessFlows != input.ProcessFlows || (this.ProcessFlows != null && input.ProcessFlows != null && !this.ProcessFlows.SequenceEqual(input.ProcessFlows))) return false;

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
                if (this.ProcessNodes != null) hashCode = hashCode * 59 + this.ProcessNodes.GetHashCode();
                if (this.ProcessFlows != null) hashCode = hashCode * 59 + this.ProcessFlows.GetHashCode();
                return hashCode;
            }
        }
    }
}
