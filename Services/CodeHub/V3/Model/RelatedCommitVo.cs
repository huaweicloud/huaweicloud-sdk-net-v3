using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RelatedCommitVo 
    {

        /// <summary>
        /// 主键ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("iamId", NullValueHandling = NullValueHandling.Ignore)]
        public string IamId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 仓库ID
        /// </summary>
        [JsonProperty("repositoryId", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 分支名称
        /// </summary>
        [JsonProperty("branchName", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// Commit ID
        /// </summary>
        [JsonProperty("commitId", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// Commit 短ID
        /// </summary>
        [JsonProperty("commitShortId", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitShortId { get; set; }

        /// <summary>
        /// 提交信息
        /// </summary>
        [JsonProperty("commitMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMsg { get; set; }

        /// <summary>
        /// 提交URL
        /// </summary>
        [JsonProperty("commitUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitUrl { get; set; }

        /// <summary>
        /// 提交类型
        /// </summary>
        [JsonProperty("commitType", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relatedId", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("createAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updateAt", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relatedUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedUrl { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelatedCommitVo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iamId: ").Append(IamId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  commitShortId: ").Append(CommitShortId).Append("\n");
            sb.Append("  commitMsg: ").Append(CommitMsg).Append("\n");
            sb.Append("  commitUrl: ").Append(CommitUrl).Append("\n");
            sb.Append("  commitType: ").Append(CommitType).Append("\n");
            sb.Append("  relatedId: ").Append(RelatedId).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  relatedUrl: ").Append(RelatedUrl).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelatedCommitVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelatedCommitVo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IamId != input.IamId || (this.IamId != null && !this.IamId.Equals(input.IamId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.BranchName != input.BranchName || (this.BranchName != null && !this.BranchName.Equals(input.BranchName))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.CommitShortId != input.CommitShortId || (this.CommitShortId != null && !this.CommitShortId.Equals(input.CommitShortId))) return false;
            if (this.CommitMsg != input.CommitMsg || (this.CommitMsg != null && !this.CommitMsg.Equals(input.CommitMsg))) return false;
            if (this.CommitUrl != input.CommitUrl || (this.CommitUrl != null && !this.CommitUrl.Equals(input.CommitUrl))) return false;
            if (this.CommitType != input.CommitType || (this.CommitType != null && !this.CommitType.Equals(input.CommitType))) return false;
            if (this.RelatedId != input.RelatedId || (this.RelatedId != null && !this.RelatedId.Equals(input.RelatedId))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.RelatedUrl != input.RelatedUrl || (this.RelatedUrl != null && !this.RelatedUrl.Equals(input.RelatedUrl))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.IamId != null) hashCode = hashCode * 59 + this.IamId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.BranchName != null) hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.CommitShortId != null) hashCode = hashCode * 59 + this.CommitShortId.GetHashCode();
                if (this.CommitMsg != null) hashCode = hashCode * 59 + this.CommitMsg.GetHashCode();
                if (this.CommitUrl != null) hashCode = hashCode * 59 + this.CommitUrl.GetHashCode();
                if (this.CommitType != null) hashCode = hashCode * 59 + this.CommitType.GetHashCode();
                if (this.RelatedId != null) hashCode = hashCode * 59 + this.RelatedId.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.RelatedUrl != null) hashCode = hashCode * 59 + this.RelatedUrl.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
