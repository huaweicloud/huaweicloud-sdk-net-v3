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
    /// 
    /// </summary>
    public class BatchUpdateRequest 
    {

        /// <summary>
        /// **参数解释：** 模块的负责人数字id，通过[获取指定项目的成员用户列表](ListProjectMembersV4.xml)接口获取，响应消息体中的**user_num_id**字段的值就是模块的负责人数字id。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("assigned_to_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignedToId { get; set; }

        /// <summary>
        /// **参数解释：** 工作项id，可通过[高级查询工作项](ListIssuesV4.xml)接口获取，响应消息体中的**id**字段的值就是工作项id。 **约束限制：** 长度在1位到10位之间的纯数字。 **取值范围：** 最小长度：1，最大长度：10。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("issue_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueIds { get; set; }

        /// <summary>
        /// **参数解释**： 项目的32位uuid，项目唯一标识，通过[查询项目列表](ListProjectsV4.xml)接口获取，响应消息体中的**project_id**字段的值就是项目ID。 **约束限制**： 32位的数字和字母组成的字符串。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateRequest {\n");
            sb.Append("  assignedToId: ").Append(AssignedToId).Append("\n");
            sb.Append("  issueIds: ").Append(IssueIds).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateRequest input)
        {
            if (input == null) return false;
            if (this.AssignedToId != input.AssignedToId || (this.AssignedToId != null && !this.AssignedToId.Equals(input.AssignedToId))) return false;
            if (this.IssueIds != input.IssueIds || (this.IssueIds != null && !this.IssueIds.Equals(input.IssueIds))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;

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
                if (this.AssignedToId != null) hashCode = hashCode * 59 + this.AssignedToId.GetHashCode();
                if (this.IssueIds != null) hashCode = hashCode * 59 + this.IssueIds.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
