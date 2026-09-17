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
    /// 工作项流程流转请求参数。
    /// </summary>
    public class WorkItemFlowVO 
    {

        /// <summary>
        /// **参数解释**： 工作项唯一ID。可以通过[查询工作项列表](ListIpdProjectIssues.xml)或者[查询树状工作项](ShowIpdIssueTree.xml)接口获取，响应消息体中的**id**字段的值就是工作项ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 工作项类型。 **约束限制**： 不涉及。 **取值范围**： RR、IR、AR、SR、Bug、FE、Task、US、Epic、SF **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCategory { get; set; }

        /// <summary>
        /// **参数解释**： 工作项流转code。可以通过[查询工作项流程信息](ShowIssueWorkItemFlowDetail.xml)接口获取。 响应消息体中的**next_flow**数组为工作流流转线，根据**from_code**当前状态和**to_code**目标状态找到匹配的流转线，流转线的**code**字段的值就是工作项流转code。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("flow_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowCode { get; set; }

        /// <summary>
        /// **参数解释**： 工作项唯一Id数组。可以通过[查询工作项列表](ListIpdProjectIssues.xml)或者[查询树状工作项](ShowIpdIssueTree.xml)接口获取，响应消息体中的**id**字段的值就是工作项ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("issue_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IssueIds { get; set; }

        /// <summary>
        /// **参数解释**： 流转中配置上下文信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("process_context", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ProcessContext { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  issueCategory: ").Append(IssueCategory).Append("\n");
            sb.Append("  flowCode: ").Append(FlowCode).Append("\n");
            sb.Append("  issueIds: ").Append(IssueIds).Append("\n");
            sb.Append("  processContext: ").Append(ProcessContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IssueCategory != input.IssueCategory || (this.IssueCategory != null && !this.IssueCategory.Equals(input.IssueCategory))) return false;
            if (this.FlowCode != input.FlowCode || (this.FlowCode != null && !this.FlowCode.Equals(input.FlowCode))) return false;
            if (this.IssueIds != input.IssueIds || (this.IssueIds != null && input.IssueIds != null && !this.IssueIds.SequenceEqual(input.IssueIds))) return false;
            if (this.ProcessContext != input.ProcessContext || (this.ProcessContext != null && input.ProcessContext != null && !this.ProcessContext.SequenceEqual(input.ProcessContext))) return false;

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
                if (this.IssueIds != null) hashCode = hashCode * 59 + this.IssueIds.GetHashCode();
                if (this.ProcessContext != null) hashCode = hashCode * 59 + this.ProcessContext.GetHashCode();
                return hashCode;
            }
        }
    }
}
