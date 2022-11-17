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
    public class StartWorkflowExecutionRequest 
    {

        /// <summary>
        /// 函数流定义ID
        /// </summary>
        [SDKProperty("workflow_id", IsPath = true)]
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// workflowRun task create time
        /// </summary>
        [SDKProperty("X-Create-Time", IsHeader = true)]
        [JsonProperty("X-Create-Time", NullValueHandling = NullValueHandling.Ignore)]
        public string XCreateTime { get; set; }

        /// <summary>
        /// workflowRun id
        /// </summary>
        [SDKProperty("X-WorkflowRun-ID", IsHeader = true)]
        [JsonProperty("X-WorkflowRun-ID", NullValueHandling = NullValueHandling.Ignore)]
        public string XWorkflowRunID { get; set; }

        /// <summary>
        /// Combines the output of the previous node with the input of the next node into an input.
        /// </summary>
        [SDKProperty("X-WorkflowRun-MergeFnParameters", IsHeader = true)]
        [JsonProperty("X-WorkflowRun-MergeFnParameters", NullValueHandling = NullValueHandling.Ignore)]
        public string XWorkflowRunMergeFnParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public FlowExecuteBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartWorkflowExecutionRequest {\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  xCreateTime: ").Append(XCreateTime).Append("\n");
            sb.Append("  xWorkflowRunID: ").Append(XWorkflowRunID).Append("\n");
            sb.Append("  xWorkflowRunMergeFnParameters: ").Append(XWorkflowRunMergeFnParameters).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartWorkflowExecutionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartWorkflowExecutionRequest input)
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
                    this.XCreateTime == input.XCreateTime ||
                    (this.XCreateTime != null &&
                    this.XCreateTime.Equals(input.XCreateTime))
                ) && 
                (
                    this.XWorkflowRunID == input.XWorkflowRunID ||
                    (this.XWorkflowRunID != null &&
                    this.XWorkflowRunID.Equals(input.XWorkflowRunID))
                ) && 
                (
                    this.XWorkflowRunMergeFnParameters == input.XWorkflowRunMergeFnParameters ||
                    (this.XWorkflowRunMergeFnParameters != null &&
                    this.XWorkflowRunMergeFnParameters.Equals(input.XWorkflowRunMergeFnParameters))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.XCreateTime != null)
                    hashCode = hashCode * 59 + this.XCreateTime.GetHashCode();
                if (this.XWorkflowRunID != null)
                    hashCode = hashCode * 59 + this.XWorkflowRunID.GetHashCode();
                if (this.XWorkflowRunMergeFnParameters != null)
                    hashCode = hashCode * 59 + this.XWorkflowRunMergeFnParameters.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
