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
    /// 
    /// </summary>
    public class RepositoryProtectedActionBasicBodyDto 
    {

        /// <summary>
        /// **参数解释：** 是否启用。 **约束限制：** 不涉及。 **取值范围：** - true，开启规则限制 - false，关闭规则限制 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// **参数解释：** 用户ID列表。 **约束限制：** 不涉及。 **取值范围：** Integer **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> UserIds { get; set; }

        /// <summary>
        /// **参数解释：** 成员组ID列表。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("user_team_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> UserTeamIds { get; set; }

        /// <summary>
        /// **参数解释：** 关联角色ID列表。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("related_role_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelatedRoleIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryProtectedActionBasicBodyDto {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  userIds: ").Append(UserIds).Append("\n");
            sb.Append("  userTeamIds: ").Append(UserTeamIds).Append("\n");
            sb.Append("  relatedRoleIds: ").Append(RelatedRoleIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryProtectedActionBasicBodyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryProtectedActionBasicBodyDto input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.UserIds != input.UserIds || (this.UserIds != null && input.UserIds != null && !this.UserIds.SequenceEqual(input.UserIds))) return false;
            if (this.UserTeamIds != input.UserTeamIds || (this.UserTeamIds != null && input.UserTeamIds != null && !this.UserTeamIds.SequenceEqual(input.UserTeamIds))) return false;
            if (this.RelatedRoleIds != input.RelatedRoleIds || (this.RelatedRoleIds != null && input.RelatedRoleIds != null && !this.RelatedRoleIds.SequenceEqual(input.RelatedRoleIds))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.UserIds != null) hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                if (this.UserTeamIds != null) hashCode = hashCode * 59 + this.UserTeamIds.GetHashCode();
                if (this.RelatedRoleIds != null) hashCode = hashCode * 59 + this.RelatedRoleIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
