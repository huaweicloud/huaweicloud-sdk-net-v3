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
    /// 合并请求commit列表详情
    /// </summary>
    public class MergeRequestCommitDto 
    {

        /// <summary>
        /// commit id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// commit 短id
        /// </summary>
        [JsonProperty("short_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortId { get; set; }

        /// <summary>
        /// 提交标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 提交信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// commit 作者名称
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 租户名
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 最初commit 提交日期（本地提交日期）
        /// </summary>
        [JsonProperty("authored_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthoredDate { get; set; }

        /// <summary>
        /// commit提交日期（推送至仓库日期）
        /// </summary>
        [JsonProperty("committed_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CommittedDate { get; set; }

        /// <summary>
        /// commit 提交者名称
        /// </summary>
        [JsonProperty("committer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitterName { get; set; }

        /// <summary>
        /// pgp key id
        /// </summary>
        [JsonProperty("gpg_primary_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GpgPrimaryKeyId { get; set; }

        /// <summary>
        /// gpg公钥验证是否开启
        /// </summary>
        [JsonProperty("open_gpg_verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenGpgVerified { get; set; }

        /// <summary>
        /// gpg公钥验证是否通过
        /// </summary>
        [JsonProperty("verification_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VerificationStatus { get; set; }

        /// <summary>
        /// 提交父commit节点
        /// </summary>
        [JsonProperty("parent_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParentIds { get; set; }

        /// <summary>
        /// commit 数据库记录创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestCommitDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  shortId: ").Append(ShortId).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  authoredDate: ").Append(AuthoredDate).Append("\n");
            sb.Append("  committedDate: ").Append(CommittedDate).Append("\n");
            sb.Append("  committerName: ").Append(CommitterName).Append("\n");
            sb.Append("  gpgPrimaryKeyId: ").Append(GpgPrimaryKeyId).Append("\n");
            sb.Append("  openGpgVerified: ").Append(OpenGpgVerified).Append("\n");
            sb.Append("  verificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("  parentIds: ").Append(ParentIds).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestCommitDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestCommitDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ShortId != input.ShortId || (this.ShortId != null && !this.ShortId.Equals(input.ShortId))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.AuthoredDate != input.AuthoredDate || (this.AuthoredDate != null && !this.AuthoredDate.Equals(input.AuthoredDate))) return false;
            if (this.CommittedDate != input.CommittedDate || (this.CommittedDate != null && !this.CommittedDate.Equals(input.CommittedDate))) return false;
            if (this.CommitterName != input.CommitterName || (this.CommitterName != null && !this.CommitterName.Equals(input.CommitterName))) return false;
            if (this.GpgPrimaryKeyId != input.GpgPrimaryKeyId || (this.GpgPrimaryKeyId != null && !this.GpgPrimaryKeyId.Equals(input.GpgPrimaryKeyId))) return false;
            if (this.OpenGpgVerified != input.OpenGpgVerified || (this.OpenGpgVerified != null && !this.OpenGpgVerified.Equals(input.OpenGpgVerified))) return false;
            if (this.VerificationStatus != input.VerificationStatus || (this.VerificationStatus != null && !this.VerificationStatus.Equals(input.VerificationStatus))) return false;
            if (this.ParentIds != input.ParentIds || (this.ParentIds != null && input.ParentIds != null && !this.ParentIds.SequenceEqual(input.ParentIds))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;

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
                if (this.ShortId != null) hashCode = hashCode * 59 + this.ShortId.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.AuthoredDate != null) hashCode = hashCode * 59 + this.AuthoredDate.GetHashCode();
                if (this.CommittedDate != null) hashCode = hashCode * 59 + this.CommittedDate.GetHashCode();
                if (this.CommitterName != null) hashCode = hashCode * 59 + this.CommitterName.GetHashCode();
                if (this.GpgPrimaryKeyId != null) hashCode = hashCode * 59 + this.GpgPrimaryKeyId.GetHashCode();
                if (this.OpenGpgVerified != null) hashCode = hashCode * 59 + this.OpenGpgVerified.GetHashCode();
                if (this.VerificationStatus != null) hashCode = hashCode * 59 + this.VerificationStatus.GetHashCode();
                if (this.ParentIds != null) hashCode = hashCode * 59 + this.ParentIds.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
