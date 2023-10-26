using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListWorkflowExecutionsRequest 
    {

        /// <summary>
        /// 任务id，从工作流命令列表中获取的工作流id。
        /// </summary>
        [SDKProperty("workflow_id", IsPath = true)]
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// 所属的企业项目id。
        /// </summary>
        [SDKProperty("x_enterprise_project_id", IsQuery = true)]
        [JsonProperty("x_enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XEnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkflowExecutionsRequest {\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  xEnterpriseProjectId: ").Append(XEnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkflowExecutionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkflowExecutionsRequest input)
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
                    this.XEnterpriseProjectId == input.XEnterpriseProjectId ||
                    (this.XEnterpriseProjectId != null &&
                    this.XEnterpriseProjectId.Equals(input.XEnterpriseProjectId))
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
                if (this.XEnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.XEnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
