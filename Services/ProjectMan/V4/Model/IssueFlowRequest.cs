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
    public class IssueFlowRequest 
    {

        /// <summary>
        /// **参数解释**： 状态id。 **约束限制**： 不涉及。 **取值范围**： 1（新建） 2（进行中） 3（已解决） 4（测试中） 5（已关闭） 6（已拒绝）。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        /// <summary>
        /// **参数解释：** 模块的负责人id，通过[获取指定项目的成员用户列表](ListProjectMembersV4.xml)接口获取，响应消息体中的**user_id**字段的值就是模块的负责人id。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("assigned_to_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssignedToId { get; set; }

        /// <summary>
        /// **参数解释：** 与日志记录相关的备注或注释。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// **参数解释**： 项目的32位uuid，项目唯一标识，通过[查询项目列表](ListProjectsV4.xml)接口获取，响应消息体中的**project_id**字段的值就是项目ID。 **约束限制**： 32位的数字和字母组成的字符串。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("projectUUId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUUId { get; set; }

        /// <summary>
        /// **参数解释：** 工作项id，可通过[高级查询工作项](ListIssuesV4.xml)接口获取，响应消息体中的**id**字段的值就是工作项id。 **约束限制：** 长度在1位到10位之间的纯数字。 **取值范围：** 最小长度：1，最大长度：10。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 项目状态。 **约束限制**： 不涉及。 **取值范围**： scrum。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueFlowRequest {\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  assignedToId: ").Append(AssignedToId).Append("\n");
            sb.Append("  notes: ").Append(Notes).Append("\n");
            sb.Append("  projectUUId: ").Append(ProjectUUId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueFlowRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueFlowRequest input)
        {
            if (input == null) return false;
            if (this.StatusId != input.StatusId || (this.StatusId != null && !this.StatusId.Equals(input.StatusId))) return false;
            if (this.AssignedToId != input.AssignedToId || (this.AssignedToId != null && !this.AssignedToId.Equals(input.AssignedToId))) return false;
            if (this.Notes != input.Notes || (this.Notes != null && !this.Notes.Equals(input.Notes))) return false;
            if (this.ProjectUUId != input.ProjectUUId || (this.ProjectUUId != null && !this.ProjectUUId.Equals(input.ProjectUUId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.StatusId != null) hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.AssignedToId != null) hashCode = hashCode * 59 + this.AssignedToId.GetHashCode();
                if (this.Notes != null) hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ProjectUUId != null) hashCode = hashCode * 59 + this.ProjectUUId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
