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
    public class ShowWorkflowExecutionRequest 
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
        /// 获取函数流执行详情完整输出值
        /// </summary>
        [SDKProperty("X-Get-Workflow-Full-History-Data", IsHeader = true)]
        [JsonProperty("X-Get-Workflow-Full-History-Data", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XGetWorkflowFullHistoryData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWorkflowExecutionRequest {\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  xGetWorkflowFullHistoryData: ").Append(XGetWorkflowFullHistoryData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWorkflowExecutionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWorkflowExecutionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.XGetWorkflowFullHistoryData == input.XGetWorkflowFullHistoryData ||
                    (this.XGetWorkflowFullHistoryData != null &&
                    this.XGetWorkflowFullHistoryData.Equals(input.XGetWorkflowFullHistoryData))
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
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.XGetWorkflowFullHistoryData != null)
                    hashCode = hashCode * 59 + this.XGetWorkflowFullHistoryData.GetHashCode();
                return hashCode;
            }
        }
    }
}
