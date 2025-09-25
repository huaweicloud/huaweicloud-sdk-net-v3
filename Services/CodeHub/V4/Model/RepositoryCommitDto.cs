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
    public class RepositoryCommitDto 
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 父节点提交ID
        /// </summary>
        [JsonProperty("parent_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParentIds { get; set; }

        /// <summary>
        /// 创建该分支的时间
        /// </summary>
        [JsonProperty("authored_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthoredDate { get; set; }

        /// <summary>
        /// 创建者名称
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 创建者邮箱
        /// </summary>
        [JsonProperty("author_email", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorEmail { get; set; }

        /// <summary>
        /// 代码提交的日期和时间
        /// </summary>
        [JsonProperty("committed_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CommittedDate { get; set; }

        /// <summary>
        /// 提交者名称
        /// </summary>
        [JsonProperty("committer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitterName { get; set; }

        /// <summary>
        /// 提交者邮箱
        /// </summary>
        [JsonProperty("committer_email", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitterEmail { get; set; }

        /// <summary>
        /// 是否打开gpg校验
        /// </summary>
        [JsonProperty("open_gpg_verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenGpgVerified { get; set; }

        /// <summary>
        /// 验证状态
        /// </summary>
        [JsonProperty("verification_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? VerificationStatus { get; set; }

        /// <summary>
        /// GPG公钥的标识符
        /// </summary>
        [JsonProperty("gpg_primary_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgPrimaryKeyId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("gpg_nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgNickName { get; set; }

        /// <summary>
        /// 租户名
        /// </summary>
        [JsonProperty("gpg_tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgTenantName { get; set; }

        /// <summary>
        /// 特定GPG用户相关的信息
        /// </summary>
        [JsonProperty("gpg_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgUserName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryCommitDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  parentIds: ").Append(ParentIds).Append("\n");
            sb.Append("  authoredDate: ").Append(AuthoredDate).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  authorEmail: ").Append(AuthorEmail).Append("\n");
            sb.Append("  committedDate: ").Append(CommittedDate).Append("\n");
            sb.Append("  committerName: ").Append(CommitterName).Append("\n");
            sb.Append("  committerEmail: ").Append(CommitterEmail).Append("\n");
            sb.Append("  openGpgVerified: ").Append(OpenGpgVerified).Append("\n");
            sb.Append("  verificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("  gpgPrimaryKeyId: ").Append(GpgPrimaryKeyId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  gpgNickName: ").Append(GpgNickName).Append("\n");
            sb.Append("  gpgTenantName: ").Append(GpgTenantName).Append("\n");
            sb.Append("  gpgUserName: ").Append(GpgUserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryCommitDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryCommitDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.ParentIds != input.ParentIds || (this.ParentIds != null && input.ParentIds != null && !this.ParentIds.SequenceEqual(input.ParentIds))) return false;
            if (this.AuthoredDate != input.AuthoredDate || (this.AuthoredDate != null && !this.AuthoredDate.Equals(input.AuthoredDate))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.AuthorEmail != input.AuthorEmail || (this.AuthorEmail != null && !this.AuthorEmail.Equals(input.AuthorEmail))) return false;
            if (this.CommittedDate != input.CommittedDate || (this.CommittedDate != null && !this.CommittedDate.Equals(input.CommittedDate))) return false;
            if (this.CommitterName != input.CommitterName || (this.CommitterName != null && !this.CommitterName.Equals(input.CommitterName))) return false;
            if (this.CommitterEmail != input.CommitterEmail || (this.CommitterEmail != null && !this.CommitterEmail.Equals(input.CommitterEmail))) return false;
            if (this.OpenGpgVerified != input.OpenGpgVerified || (this.OpenGpgVerified != null && !this.OpenGpgVerified.Equals(input.OpenGpgVerified))) return false;
            if (this.VerificationStatus != input.VerificationStatus || (this.VerificationStatus != null && !this.VerificationStatus.Equals(input.VerificationStatus))) return false;
            if (this.GpgPrimaryKeyId != input.GpgPrimaryKeyId || (this.GpgPrimaryKeyId != null && !this.GpgPrimaryKeyId.Equals(input.GpgPrimaryKeyId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.GpgNickName != input.GpgNickName || (this.GpgNickName != null && !this.GpgNickName.Equals(input.GpgNickName))) return false;
            if (this.GpgTenantName != input.GpgTenantName || (this.GpgTenantName != null && !this.GpgTenantName.Equals(input.GpgTenantName))) return false;
            if (this.GpgUserName != input.GpgUserName || (this.GpgUserName != null && !this.GpgUserName.Equals(input.GpgUserName))) return false;

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
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ParentIds != null) hashCode = hashCode * 59 + this.ParentIds.GetHashCode();
                if (this.AuthoredDate != null) hashCode = hashCode * 59 + this.AuthoredDate.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.AuthorEmail != null) hashCode = hashCode * 59 + this.AuthorEmail.GetHashCode();
                if (this.CommittedDate != null) hashCode = hashCode * 59 + this.CommittedDate.GetHashCode();
                if (this.CommitterName != null) hashCode = hashCode * 59 + this.CommitterName.GetHashCode();
                if (this.CommitterEmail != null) hashCode = hashCode * 59 + this.CommitterEmail.GetHashCode();
                if (this.OpenGpgVerified != null) hashCode = hashCode * 59 + this.OpenGpgVerified.GetHashCode();
                if (this.VerificationStatus != null) hashCode = hashCode * 59 + this.VerificationStatus.GetHashCode();
                if (this.GpgPrimaryKeyId != null) hashCode = hashCode * 59 + this.GpgPrimaryKeyId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.GpgNickName != null) hashCode = hashCode * 59 + this.GpgNickName.GetHashCode();
                if (this.GpgTenantName != null) hashCode = hashCode * 59 + this.GpgTenantName.GetHashCode();
                if (this.GpgUserName != null) hashCode = hashCode * 59 + this.GpgUserName.GetHashCode();
                return hashCode;
            }
        }
    }
}
