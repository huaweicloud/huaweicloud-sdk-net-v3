using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 仓库成员组详情
    /// </summary>
    public class RepositoryUserGroupDto 
    {

        /// <summary>
        /// **参数解释：** 成员组名称 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("user_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGroupName { get; set; }

        /// <summary>
        /// **参数解释：** 成员组id。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("user_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// **参数解释：** 项目id。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 成员组用户数量。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("user_count", NullValueHandling = NullValueHandling.Ignore)]
        public string UserCount { get; set; }

        /// <summary>
        /// **参数解释：** 成员组描述。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryUserGroupDto {\n");
            sb.Append("  userGroupName: ").Append(UserGroupName).Append("\n");
            sb.Append("  userGroupId: ").Append(UserGroupId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  userCount: ").Append(UserCount).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryUserGroupDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryUserGroupDto input)
        {
            if (input == null) return false;
            if (this.UserGroupName != input.UserGroupName || (this.UserGroupName != null && !this.UserGroupName.Equals(input.UserGroupName))) return false;
            if (this.UserGroupId != input.UserGroupId || (this.UserGroupId != null && !this.UserGroupId.Equals(input.UserGroupId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.UserCount != input.UserCount || (this.UserCount != null && !this.UserCount.Equals(input.UserCount))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.UserGroupName != null) hashCode = hashCode * 59 + this.UserGroupName.GetHashCode();
                if (this.UserGroupId != null) hashCode = hashCode * 59 + this.UserGroupId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.UserCount != null) hashCode = hashCode * 59 + this.UserCount.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
