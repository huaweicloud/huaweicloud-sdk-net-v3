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
    /// 工作流节点信息
    /// </summary>
    public class WorkItemFlowProcessNodeVO 
    {

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 节点类别
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 工作流实例ID
        /// </summary>
        [JsonProperty("process_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 工作流活动ID
        /// </summary>
        [JsonProperty("workflow_activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowActivityId { get; set; }

        /// <summary>
        /// 节点编码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public WorkItemFlowNodeConfigVO Config { get; set; }

        /// <summary>
        /// 是否允许挂起
        /// </summary>
        [JsonProperty("enable_suspend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSuspend { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowProcessNodeVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  processInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  workflowActivityId: ").Append(WorkflowActivityId).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("  enableSuspend: ").Append(EnableSuspend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowProcessNodeVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowProcessNodeVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.ProcessInstanceId != input.ProcessInstanceId || (this.ProcessInstanceId != null && !this.ProcessInstanceId.Equals(input.ProcessInstanceId))) return false;
            if (this.WorkflowActivityId != input.WorkflowActivityId || (this.WorkflowActivityId != null && !this.WorkflowActivityId.Equals(input.WorkflowActivityId))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Config != input.Config || (this.Config != null && !this.Config.Equals(input.Config))) return false;
            if (this.EnableSuspend != input.EnableSuspend || (this.EnableSuspend != null && !this.EnableSuspend.Equals(input.EnableSuspend))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ProcessInstanceId != null) hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.WorkflowActivityId != null) hashCode = hashCode * 59 + this.WorkflowActivityId.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Config != null) hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.EnableSuspend != null) hashCode = hashCode * 59 + this.EnableSuspend.GetHashCode();
                return hashCode;
            }
        }
    }
}
