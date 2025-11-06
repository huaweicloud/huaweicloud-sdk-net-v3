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
    public class MergeRequestDiffExternalDto 
    {

        /// <summary>
        /// 合并请求diff id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 合并请求id
        /// </summary>
        [JsonProperty("merge_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// base commit节点
        /// </summary>
        [JsonProperty("base_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseCommitSha { get; set; }

        /// <summary>
        /// diff文件数量
        /// </summary>
        [JsonProperty("real_size", NullValueHandling = NullValueHandling.Ignore)]
        public string RealSize { get; set; }

        /// <summary>
        /// head commit节点
        /// </summary>
        [JsonProperty("head_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string HeadCommitSha { get; set; }

        /// <summary>
        /// start commit节点
        /// </summary>
        [JsonProperty("start_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string StartCommitSha { get; set; }

        /// <summary>
        /// commit数量
        /// </summary>
        [JsonProperty("commits_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitsCount { get; set; }

        /// <summary>
        /// 外部diff文件
        /// </summary>
        [JsonProperty("external_diff", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalDiff { get; set; }

        /// <summary>
        /// 外部差异存储
        /// </summary>
        [JsonProperty("external_diff_store", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExternalDiffStore { get; set; }

        /// <summary>
        /// 是否外部存储
        /// </summary>
        [JsonProperty("stored_externally", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoredExternally { get; set; }

        /// <summary>
        /// 新增行数
        /// </summary>
        [JsonProperty("added_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddedLines { get; set; }

        /// <summary>
        /// 删除行数
        /// </summary>
        [JsonProperty("removed_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemovedLines { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestDiffExternalDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  mergeRequestId: ").Append(MergeRequestId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  baseCommitSha: ").Append(BaseCommitSha).Append("\n");
            sb.Append("  realSize: ").Append(RealSize).Append("\n");
            sb.Append("  headCommitSha: ").Append(HeadCommitSha).Append("\n");
            sb.Append("  startCommitSha: ").Append(StartCommitSha).Append("\n");
            sb.Append("  commitsCount: ").Append(CommitsCount).Append("\n");
            sb.Append("  externalDiff: ").Append(ExternalDiff).Append("\n");
            sb.Append("  externalDiffStore: ").Append(ExternalDiffStore).Append("\n");
            sb.Append("  storedExternally: ").Append(StoredExternally).Append("\n");
            sb.Append("  addedLines: ").Append(AddedLines).Append("\n");
            sb.Append("  removedLines: ").Append(RemovedLines).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestDiffExternalDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestDiffExternalDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.MergeRequestId != input.MergeRequestId || (this.MergeRequestId != null && !this.MergeRequestId.Equals(input.MergeRequestId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.BaseCommitSha != input.BaseCommitSha || (this.BaseCommitSha != null && !this.BaseCommitSha.Equals(input.BaseCommitSha))) return false;
            if (this.RealSize != input.RealSize || (this.RealSize != null && !this.RealSize.Equals(input.RealSize))) return false;
            if (this.HeadCommitSha != input.HeadCommitSha || (this.HeadCommitSha != null && !this.HeadCommitSha.Equals(input.HeadCommitSha))) return false;
            if (this.StartCommitSha != input.StartCommitSha || (this.StartCommitSha != null && !this.StartCommitSha.Equals(input.StartCommitSha))) return false;
            if (this.CommitsCount != input.CommitsCount || (this.CommitsCount != null && !this.CommitsCount.Equals(input.CommitsCount))) return false;
            if (this.ExternalDiff != input.ExternalDiff || (this.ExternalDiff != null && !this.ExternalDiff.Equals(input.ExternalDiff))) return false;
            if (this.ExternalDiffStore != input.ExternalDiffStore || (this.ExternalDiffStore != null && !this.ExternalDiffStore.Equals(input.ExternalDiffStore))) return false;
            if (this.StoredExternally != input.StoredExternally || (this.StoredExternally != null && !this.StoredExternally.Equals(input.StoredExternally))) return false;
            if (this.AddedLines != input.AddedLines || (this.AddedLines != null && !this.AddedLines.Equals(input.AddedLines))) return false;
            if (this.RemovedLines != input.RemovedLines || (this.RemovedLines != null && !this.RemovedLines.Equals(input.RemovedLines))) return false;

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
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.MergeRequestId != null) hashCode = hashCode * 59 + this.MergeRequestId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.BaseCommitSha != null) hashCode = hashCode * 59 + this.BaseCommitSha.GetHashCode();
                if (this.RealSize != null) hashCode = hashCode * 59 + this.RealSize.GetHashCode();
                if (this.HeadCommitSha != null) hashCode = hashCode * 59 + this.HeadCommitSha.GetHashCode();
                if (this.StartCommitSha != null) hashCode = hashCode * 59 + this.StartCommitSha.GetHashCode();
                if (this.CommitsCount != null) hashCode = hashCode * 59 + this.CommitsCount.GetHashCode();
                if (this.ExternalDiff != null) hashCode = hashCode * 59 + this.ExternalDiff.GetHashCode();
                if (this.ExternalDiffStore != null) hashCode = hashCode * 59 + this.ExternalDiffStore.GetHashCode();
                if (this.StoredExternally != null) hashCode = hashCode * 59 + this.StoredExternally.GetHashCode();
                if (this.AddedLines != null) hashCode = hashCode * 59 + this.AddedLines.GetHashCode();
                if (this.RemovedLines != null) hashCode = hashCode * 59 + this.RemovedLines.GetHashCode();
                return hashCode;
            }
        }
    }
}
