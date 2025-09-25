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
    public class GroupBatchAddMemberDto 
    {

        /// <summary>
        /// **参数解释：** 用户iam_id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("iam_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IamId { get; set; }

        /// <summary>
        /// **参数解释：** 用户userId。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释：** 用户名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 用户昵称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// **参数解释：** 租户名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数解释：** 租户id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释：** 角色id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("repo_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoRoleId { get; set; }

        /// <summary>
        /// **参数解释：** 项目角色id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("req_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReqRoleId { get; set; }

        /// <summary>
        /// **参数解释：** 角色名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("repo_role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoRoleName { get; set; }

        /// <summary>
        /// **参数解释：** 项目角色名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("req_role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReqRoleName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupBatchAddMemberDto {\n");
            sb.Append("  iamId: ").Append(IamId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  repoRoleId: ").Append(RepoRoleId).Append("\n");
            sb.Append("  reqRoleId: ").Append(ReqRoleId).Append("\n");
            sb.Append("  repoRoleName: ").Append(RepoRoleName).Append("\n");
            sb.Append("  reqRoleName: ").Append(ReqRoleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupBatchAddMemberDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupBatchAddMemberDto input)
        {
            if (input == null) return false;
            if (this.IamId != input.IamId || (this.IamId != null && !this.IamId.Equals(input.IamId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.RepoRoleId != input.RepoRoleId || (this.RepoRoleId != null && !this.RepoRoleId.Equals(input.RepoRoleId))) return false;
            if (this.ReqRoleId != input.ReqRoleId || (this.ReqRoleId != null && !this.ReqRoleId.Equals(input.ReqRoleId))) return false;
            if (this.RepoRoleName != input.RepoRoleName || (this.RepoRoleName != null && !this.RepoRoleName.Equals(input.RepoRoleName))) return false;
            if (this.ReqRoleName != input.ReqRoleName || (this.ReqRoleName != null && !this.ReqRoleName.Equals(input.ReqRoleName))) return false;

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
                if (this.IamId != null) hashCode = hashCode * 59 + this.IamId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.RepoRoleId != null) hashCode = hashCode * 59 + this.RepoRoleId.GetHashCode();
                if (this.ReqRoleId != null) hashCode = hashCode * 59 + this.ReqRoleId.GetHashCode();
                if (this.RepoRoleName != null) hashCode = hashCode * 59 + this.RepoRoleName.GetHashCode();
                if (this.ReqRoleName != null) hashCode = hashCode * 59 + this.ReqRoleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
