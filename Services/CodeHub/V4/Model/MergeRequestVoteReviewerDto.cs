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
    /// 合并请求打分模式评审人
    /// </summary>
    public class MergeRequestVoteReviewerDto 
    {

        /// <summary>
        /// **参数解释：** 用户id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 用户名。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 服务级权限状态 0：停用 1：启用
        /// </summary>
        [JsonProperty("service_license_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceLicenseStatus { get; set; }

        /// <summary>
        /// 用户头像url
        /// </summary>
        [JsonProperty("avatar_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 用户头像路径
        /// </summary>
        [JsonProperty("avatar_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AvatarPath { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 用户中文名称
        /// </summary>
        [JsonProperty("name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameCn { get; set; }

        /// <summary>
        /// 用户个人首页
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 租户名称
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// **参数解释：** 部分查询接口校验到传参里的用户权限不足或不存在时，返回该用户但该字段不为空用于提示。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// **参数解释：** 是否为committer。
        /// </summary>
        [JsonProperty("is_committer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCommitter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestVoteReviewerDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  serviceLicenseStatus: ").Append(ServiceLicenseStatus).Append("\n");
            sb.Append("  avatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  avatarPath: ").Append(AvatarPath).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  nameCn: ").Append(NameCn).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  isCommitter: ").Append(IsCommitter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestVoteReviewerDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestVoteReviewerDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.ServiceLicenseStatus != input.ServiceLicenseStatus || (this.ServiceLicenseStatus != null && !this.ServiceLicenseStatus.Equals(input.ServiceLicenseStatus))) return false;
            if (this.AvatarUrl != input.AvatarUrl || (this.AvatarUrl != null && !this.AvatarUrl.Equals(input.AvatarUrl))) return false;
            if (this.AvatarPath != input.AvatarPath || (this.AvatarPath != null && !this.AvatarPath.Equals(input.AvatarPath))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.NameCn != input.NameCn || (this.NameCn != null && !this.NameCn.Equals(input.NameCn))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.IsCommitter != input.IsCommitter || (this.IsCommitter != null && !this.IsCommitter.Equals(input.IsCommitter))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ServiceLicenseStatus != null) hashCode = hashCode * 59 + this.ServiceLicenseStatus.GetHashCode();
                if (this.AvatarUrl != null) hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.AvatarPath != null) hashCode = hashCode * 59 + this.AvatarPath.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.NameCn != null) hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.IsCommitter != null) hashCode = hashCode * 59 + this.IsCommitter.GetHashCode();
                return hashCode;
            }
        }
    }
}
