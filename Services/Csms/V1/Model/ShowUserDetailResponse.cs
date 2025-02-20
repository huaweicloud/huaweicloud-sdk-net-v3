using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowUserDetailResponse : SdkResponse
    {

        /// <summary>
        /// 用户id。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户所属组织。
        /// </summary>
        [JsonProperty("org_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgId { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 姓名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 手机号。
        /// </summary>
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        /// <summary>
        /// 邮箱。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 首次登录是否强制修改密码。
        /// </summary>
        [JsonProperty("pwd_must_modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PwdMustModify { get; set; }

        /// <summary>
        /// 密码修改时间
        /// </summary>
        [JsonProperty("pwd_change_at", NullValueHandling = NullValueHandling.Ignore)]
        public string PwdChangeAt { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 最后一次修改时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 是否禁用。
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 可信等级。
        /// </summary>
        [JsonProperty("grade", NullValueHandling = NullValueHandling.Ignore)]
        public int? Grade { get; set; }

        /// <summary>
        /// 是否锁定。
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public string Locked { get; set; }

        /// <summary>
        /// 自定义扩展属性。
        /// </summary>
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public Object Extension { get; set; }

        /// <summary>
        /// 用户组织关系集合。
        /// </summary>
        [JsonProperty("user_org_relation_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserOrgRelationListResult> UserOrgRelationList { get; set; }

        /// <summary>
        /// 所属租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserDetailResponse {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  orgId: ").Append(OrgId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  mobile: ").Append(Mobile).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  pwdMustModify: ").Append(PwdMustModify).Append("\n");
            sb.Append("  pwdChangeAt: ").Append(PwdChangeAt).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  grade: ").Append(Grade).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  extension: ").Append(Extension).Append("\n");
            sb.Append("  userOrgRelationList: ").Append(UserOrgRelationList).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserDetailResponse input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.OrgId != input.OrgId || (this.OrgId != null && !this.OrgId.Equals(input.OrgId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Mobile != input.Mobile || (this.Mobile != null && !this.Mobile.Equals(input.Mobile))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.PwdMustModify != input.PwdMustModify || (this.PwdMustModify != null && !this.PwdMustModify.Equals(input.PwdMustModify))) return false;
            if (this.PwdChangeAt != input.PwdChangeAt || (this.PwdChangeAt != null && !this.PwdChangeAt.Equals(input.PwdChangeAt))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.Grade != input.Grade || (this.Grade != null && !this.Grade.Equals(input.Grade))) return false;
            if (this.Locked != input.Locked || (this.Locked != null && !this.Locked.Equals(input.Locked))) return false;
            if (this.Extension != input.Extension || (this.Extension != null && !this.Extension.Equals(input.Extension))) return false;
            if (this.UserOrgRelationList != input.UserOrgRelationList || (this.UserOrgRelationList != null && input.UserOrgRelationList != null && !this.UserOrgRelationList.SequenceEqual(input.UserOrgRelationList))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.OrgId != null) hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Mobile != null) hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.PwdMustModify != null) hashCode = hashCode * 59 + this.PwdMustModify.GetHashCode();
                if (this.PwdChangeAt != null) hashCode = hashCode * 59 + this.PwdChangeAt.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Grade != null) hashCode = hashCode * 59 + this.Grade.GetHashCode();
                if (this.Locked != null) hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Extension != null) hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.UserOrgRelationList != null) hashCode = hashCode * 59 + this.UserOrgRelationList.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
