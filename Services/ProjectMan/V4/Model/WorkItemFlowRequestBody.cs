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
    /// 工作项流程流转请求参数
    /// </summary>
    public class WorkItemFlowRequestBody 
    {

        /// <summary>
        /// 工作项唯一Id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 工作项类型
        /// </summary>
        [JsonProperty("issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCategory { get; set; }

        /// <summary>
        /// 工作项流转code
        /// </summary>
        [JsonProperty("flow_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowRequestBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  issueCategory: ").Append(IssueCategory).Append("\n");
            sb.Append("  flowCode: ").Append(FlowCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowRequestBody input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IssueCategory != input.IssueCategory || (this.IssueCategory != null && !this.IssueCategory.Equals(input.IssueCategory))) return false;
            if (this.FlowCode != input.FlowCode || (this.FlowCode != null && !this.FlowCode.Equals(input.FlowCode))) return false;

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
                if (this.IssueCategory != null) hashCode = hashCode * 59 + this.IssueCategory.GetHashCode();
                if (this.FlowCode != null) hashCode = hashCode * 59 + this.FlowCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
