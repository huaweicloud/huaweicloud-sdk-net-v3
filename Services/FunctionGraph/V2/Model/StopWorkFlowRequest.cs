using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class StopWorkFlowRequest 
    {

        /// <summary>
        /// 函数工作流ID
        /// </summary>
        [SDKProperty("workflow_id", IsPath = true)]
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// 函数流执行实例ID
        /// </summary>
        [SDKProperty("execution_id", IsPath = true)]
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopWorkFlowRequest {\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StopWorkFlowRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StopWorkFlowRequest input)
        {
            if (input == null) return false;
            if (this.WorkflowId != input.WorkflowId || (this.WorkflowId != null && !this.WorkflowId.Equals(input.WorkflowId))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;

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
                if (this.WorkflowId != null) hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
