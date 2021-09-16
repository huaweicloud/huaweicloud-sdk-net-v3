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
    public class MemberListV4Members 
    {

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 租户名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 创建人numId
        /// </summary>
        [JsonProperty("user_num_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserNumId { get; set; }

        /// <summary>
        /// 成员角色, -1 项目创建者, 3 项目经理, 4 开发人员, 5 测试经理, 6 测试人员, 7 参与者, 8 浏览者, 9 运维经理
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleId { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// 用户类型, User iam用户, Federation 联邦账号,
        /// </summary>
        [JsonProperty("user_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserType { get; set; }

        /// <summary>
        /// 是否是禁用账号，1 禁用账号， 0非禁用账号
        /// </summary>
        [JsonProperty("forbidden", NullValueHandling = NullValueHandling.Ignore)]
        public int? Forbidden { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberListV4Members {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userNumId: ").Append(UserNumId).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  userType: ").Append(UserType).Append("\n");
            sb.Append("  forbidden: ").Append(Forbidden).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberListV4Members);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MemberListV4Members input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UserNumId == input.UserNumId ||
                    (this.UserNumId != null &&
                    this.UserNumId.Equals(input.UserNumId))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.UserType == input.UserType ||
                    (this.UserType != null &&
                    this.UserType.Equals(input.UserType))
                ) && 
                (
                    this.Forbidden == input.Forbidden ||
                    (this.Forbidden != null &&
                    this.Forbidden.Equals(input.Forbidden))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserNumId != null)
                    hashCode = hashCode * 59 + this.UserNumId.GetHashCode();
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.NickName != null)
                    hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.RoleName != null)
                    hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.UserType != null)
                    hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.Forbidden != null)
                    hashCode = hashCode * 59 + this.Forbidden.GetHashCode();
                return hashCode;
            }
        }
    }
}
