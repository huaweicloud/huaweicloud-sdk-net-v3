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
    public class CreateCallbackWorkflowRequest 
    {

        /// <summary>
        /// 函数工作流ID
        /// </summary>
        [SDKProperty("workflow_id", IsPath = true)]
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// workflow run id
        /// </summary>
        [SDKProperty("X-Workflow-Run-Id", IsHeader = true)]
        [JsonProperty("X-Workflow-Run-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XWorkflowRunId { get; set; }

        /// <summary>
        /// workflow state id
        /// </summary>
        [SDKProperty("X-Workflow-State-Id", IsHeader = true)]
        [JsonProperty("X-Workflow-State-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XWorkflowStateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CallbackWorkflowRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCallbackWorkflowRequest {\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  xWorkflowRunId: ").Append(XWorkflowRunId).Append("\n");
            sb.Append("  xWorkflowStateId: ").Append(XWorkflowStateId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCallbackWorkflowRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCallbackWorkflowRequest input)
        {
            if (input == null) return false;
            if (this.WorkflowId != input.WorkflowId || (this.WorkflowId != null && !this.WorkflowId.Equals(input.WorkflowId))) return false;
            if (this.XWorkflowRunId != input.XWorkflowRunId || (this.XWorkflowRunId != null && !this.XWorkflowRunId.Equals(input.XWorkflowRunId))) return false;
            if (this.XWorkflowStateId != input.XWorkflowStateId || (this.XWorkflowStateId != null && !this.XWorkflowStateId.Equals(input.XWorkflowStateId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.XWorkflowRunId != null) hashCode = hashCode * 59 + this.XWorkflowRunId.GetHashCode();
                if (this.XWorkflowStateId != null) hashCode = hashCode * 59 + this.XWorkflowStateId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
