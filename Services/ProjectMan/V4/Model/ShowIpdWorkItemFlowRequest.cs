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
    /// Request Object
    /// </summary>
    public class ShowIpdWorkItemFlowRequest 
    {

        /// <summary>
        /// 项目32位ID，项目唯一标识。通过查询IPD项目列表获取，响应消息体中的id字段的值就是项目ID。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 工作项唯一ID。可以通过查询工作项列表或者查询树状工作项接口获取，响应消息体中的id字段的值就是工作项ID。
        /// </summary>
        [SDKProperty("issue_id", IsPath = true)]
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// **参数解释**： 工作项类型。 **约束限制**： 不涉及。 **取值范围**： 支持多种工作项类型，使用英文逗号分隔，例如：category&#x3D;IR,SR,AR。 - 系统设备类项目：RR、SF、IR、SR、AR、Task、Bug - 独立软件类项目：RR、SF、IR、US、Task、Bug - 云服务类项目：RR、Epic、FE、US、Task、Bug **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("issue_category", IsQuery = true)]
        [JsonProperty("issue_category", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCategory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpdWorkItemFlowRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  issueCategory: ").Append(IssueCategory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpdWorkItemFlowRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpdWorkItemFlowRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.IssueCategory != input.IssueCategory || (this.IssueCategory != null && !this.IssueCategory.Equals(input.IssueCategory))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.IssueCategory != null) hashCode = hashCode * 59 + this.IssueCategory.GetHashCode();
                return hashCode;
            }
        }
    }
}
