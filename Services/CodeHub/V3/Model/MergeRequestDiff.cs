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
    public class MergeRequestDiff 
    {

        /// <summary>
        /// base提交
        /// </summary>
        [JsonProperty("base_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseCommitSha { get; set; }

        /// <summary>
        /// 提交数
        /// </summary>
        [JsonProperty("commits_count", NullValueHandling = NullValueHandling.Ignore)]
        public double? CommitsCount { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// head提交
        /// </summary>
        [JsonProperty("head_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string HeadCommitSha { get; set; }

        /// <summary>
        /// 合并请求id
        /// </summary>
        [JsonProperty("merge_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public double? MergeRequestId { get; set; }

        /// <summary>
        /// start提交
        /// </summary>
        [JsonProperty("start_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string StartCommitSha { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestDiff {\n");
            sb.Append("  baseCommitSha: ").Append(BaseCommitSha).Append("\n");
            sb.Append("  commitsCount: ").Append(CommitsCount).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  headCommitSha: ").Append(HeadCommitSha).Append("\n");
            sb.Append("  mergeRequestId: ").Append(MergeRequestId).Append("\n");
            sb.Append("  startCommitSha: ").Append(StartCommitSha).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestDiff);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestDiff input)
        {
            if (input == null) return false;
            if (this.BaseCommitSha != input.BaseCommitSha || (this.BaseCommitSha != null && !this.BaseCommitSha.Equals(input.BaseCommitSha))) return false;
            if (this.CommitsCount != input.CommitsCount || (this.CommitsCount != null && !this.CommitsCount.Equals(input.CommitsCount))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.HeadCommitSha != input.HeadCommitSha || (this.HeadCommitSha != null && !this.HeadCommitSha.Equals(input.HeadCommitSha))) return false;
            if (this.MergeRequestId != input.MergeRequestId || (this.MergeRequestId != null && !this.MergeRequestId.Equals(input.MergeRequestId))) return false;
            if (this.StartCommitSha != input.StartCommitSha || (this.StartCommitSha != null && !this.StartCommitSha.Equals(input.StartCommitSha))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.BaseCommitSha != null) hashCode = hashCode * 59 + this.BaseCommitSha.GetHashCode();
                if (this.CommitsCount != null) hashCode = hashCode * 59 + this.CommitsCount.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.HeadCommitSha != null) hashCode = hashCode * 59 + this.HeadCommitSha.GetHashCode();
                if (this.MergeRequestId != null) hashCode = hashCode * 59 + this.MergeRequestId.GetHashCode();
                if (this.StartCommitSha != null) hashCode = hashCode * 59 + this.StartCommitSha.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
