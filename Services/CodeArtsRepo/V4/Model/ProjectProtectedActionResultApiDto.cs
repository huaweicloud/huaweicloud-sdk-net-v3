using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectProtectedActionResultApiDto 
    {

        /// <summary>
        /// **参数解释：** 事件名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// **参数解释：** 用户列表。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> Users { get; set; }

        /// <summary>
        /// **参数解释：** 成员组列表。
        /// </summary>
        [JsonProperty("user_teams", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTeamBasicDto> UserTeams { get; set; }

        /// <summary>
        /// **参数解释：** 角色列表。
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleBasicDto> Roles { get; set; }

        /// <summary>
        /// **参数解释：** 操作选择列表。
        /// </summary>
        [JsonProperty("addition_switchers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ForceActionEnableDto> AdditionSwitchers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectProtectedActionResultApiDto {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("  userTeams: ").Append(UserTeams).Append("\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("  additionSwitchers: ").Append(AdditionSwitchers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectProtectedActionResultApiDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectProtectedActionResultApiDto input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Users != input.Users || (this.Users != null && input.Users != null && !this.Users.SequenceEqual(input.Users))) return false;
            if (this.UserTeams != input.UserTeams || (this.UserTeams != null && input.UserTeams != null && !this.UserTeams.SequenceEqual(input.UserTeams))) return false;
            if (this.Roles != input.Roles || (this.Roles != null && input.Roles != null && !this.Roles.SequenceEqual(input.Roles))) return false;
            if (this.AdditionSwitchers != input.AdditionSwitchers || (this.AdditionSwitchers != null && input.AdditionSwitchers != null && !this.AdditionSwitchers.SequenceEqual(input.AdditionSwitchers))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.UserTeams != null) hashCode = hashCode * 59 + this.UserTeams.GetHashCode();
                if (this.Roles != null) hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.AdditionSwitchers != null) hashCode = hashCode * 59 + this.AdditionSwitchers.GetHashCode();
                return hashCode;
            }
        }
    }
}
