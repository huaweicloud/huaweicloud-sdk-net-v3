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
    public class ListWorkflowRequest 
    {

        /// <summary>
        /// 函数流名称
        /// </summary>
        [SDKProperty("workflow_name", IsQuery = true)]
        [JsonProperty("workflow_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// 分页查询，每页显示的条目数量，默认值为200 limit大于200时，按照200处理
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页查询，分页的偏移量，默认值为0 offset小于0时，按照0处理
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [SDKProperty("enterprise_project", IsQuery = true)]
        [JsonProperty("enterprise_project", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProject { get; set; }

        /// <summary>
        /// 函数流模式 \&quot;NORMAL\&quot;标准函数流 \&quot;EXPRESS\&quot;快速函数流
        /// </summary>
        [SDKProperty("mode", IsQuery = true)]
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkflowRequest {\n");
            sb.Append("  workflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  enterpriseProject: ").Append(EnterpriseProject).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkflowRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkflowRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkflowName == input.WorkflowName ||
                    (this.WorkflowName != null &&
                    this.WorkflowName.Equals(input.WorkflowName))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.EnterpriseProject == input.EnterpriseProject ||
                    (this.EnterpriseProject != null &&
                    this.EnterpriseProject.Equals(input.EnterpriseProject))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.WorkflowName != null)
                    hashCode = hashCode * 59 + this.WorkflowName.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.EnterpriseProject != null)
                    hashCode = hashCode * 59 + this.EnterpriseProject.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
