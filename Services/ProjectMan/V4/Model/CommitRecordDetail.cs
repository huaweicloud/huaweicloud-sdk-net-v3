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
    /// 代码提交记录 / 分支创建记录 详细信息
    /// </summary>
    public class CommitRecordDetail 
    {

        /// <summary>
        /// 仓库ID
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryId { get; set; }

        /// <summary>
        /// 分支名称
        /// </summary>
        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// commit id
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// commit short id
        /// </summary>
        [JsonProperty("commit_short_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitShortId { get; set; }

        /// <summary>
        /// commit 信息
        /// </summary>
        [JsonProperty("commit_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMsg { get; set; }

        /// <summary>
        /// commit URL
        /// </summary>
        [JsonProperty("commit_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleUser User { get; set; }

        /// <summary>
        /// 查询的类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateDate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_date", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateDate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitRecordDetail {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  branchName: ").Append(BranchName).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  commitShortId: ").Append(CommitShortId).Append("\n");
            sb.Append("  commitMsg: ").Append(CommitMsg).Append("\n");
            sb.Append("  commitUrl: ").Append(CommitUrl).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  createDate: ").Append(CreateDate).Append("\n");
            sb.Append("  updateDate: ").Append(UpdateDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommitRecordDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommitRecordDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RepositoryId == input.RepositoryId ||
                    (this.RepositoryId != null &&
                    this.RepositoryId.Equals(input.RepositoryId))
                ) && 
                (
                    this.BranchName == input.BranchName ||
                    (this.BranchName != null &&
                    this.BranchName.Equals(input.BranchName))
                ) && 
                (
                    this.CommitId == input.CommitId ||
                    (this.CommitId != null &&
                    this.CommitId.Equals(input.CommitId))
                ) && 
                (
                    this.CommitShortId == input.CommitShortId ||
                    (this.CommitShortId != null &&
                    this.CommitShortId.Equals(input.CommitShortId))
                ) && 
                (
                    this.CommitMsg == input.CommitMsg ||
                    (this.CommitMsg != null &&
                    this.CommitMsg.Equals(input.CommitMsg))
                ) && 
                (
                    this.CommitUrl == input.CommitUrl ||
                    (this.CommitUrl != null &&
                    this.CommitUrl.Equals(input.CommitUrl))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.UpdateDate == input.UpdateDate ||
                    (this.UpdateDate != null &&
                    this.UpdateDate.Equals(input.UpdateDate))
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
                if (this.RepositoryId != null)
                    hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.BranchName != null)
                    hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.CommitId != null)
                    hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.CommitShortId != null)
                    hashCode = hashCode * 59 + this.CommitShortId.GetHashCode();
                if (this.CommitMsg != null)
                    hashCode = hashCode * 59 + this.CommitMsg.GetHashCode();
                if (this.CommitUrl != null)
                    hashCode = hashCode * 59 + this.CommitUrl.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.UpdateDate != null)
                    hashCode = hashCode * 59 + this.UpdateDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
