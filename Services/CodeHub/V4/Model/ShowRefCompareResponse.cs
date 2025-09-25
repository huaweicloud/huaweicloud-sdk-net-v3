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
    /// Response Object
    /// </summary>
    public class ShowRefCompareResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("commit", NullValueHandling = NullValueHandling.Ignore)]
        public CommitDto Commit { get; set; }

        /// <summary>
        /// commit相关信息列表
        /// </summary>
        [JsonProperty("commits", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommitDto> Commits { get; set; }

        /// <summary>
        /// 变更文件信息
        /// </summary>
        [JsonProperty("diffs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiffDto> Diffs { get; set; }

        /// <summary>
        /// 变更文件信息
        /// </summary>
        [JsonProperty("diffs_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiffDto> DiffsFiles { get; set; }

        /// <summary>
        /// 是否超时
        /// </summary>
        [JsonProperty("compare_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CompareTimeout { get; set; }

        /// <summary>
        /// 是否相同
        /// </summary>
        [JsonProperty("compare_same_ref", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CompareSameRef { get; set; }

        /// <summary>
        /// 冲突文件
        /// </summary>
        [JsonProperty("conflict_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConflictFileDto> ConflictFiles { get; set; }

        /// <summary>
        /// 增加行数
        /// </summary>
        [JsonProperty("added_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddedLines { get; set; }

        /// <summary>
        /// 删除行数
        /// </summary>
        [JsonProperty("removed_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemovedLines { get; set; }

        /// <summary>
        /// 提交数量
        /// </summary>
        [JsonProperty("commits_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitsCount { get; set; }

        /// <summary>
        /// 文件变更数量
        /// </summary>
        [JsonProperty("diffs_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiffsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Total", IsHeader = true)]
        [JsonProperty("X-Total", NullValueHandling = NullValueHandling.Ignore)]
        public string XTotal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRefCompareResponse {\n");
            sb.Append("  commit: ").Append(Commit).Append("\n");
            sb.Append("  commits: ").Append(Commits).Append("\n");
            sb.Append("  diffs: ").Append(Diffs).Append("\n");
            sb.Append("  diffsFiles: ").Append(DiffsFiles).Append("\n");
            sb.Append("  compareTimeout: ").Append(CompareTimeout).Append("\n");
            sb.Append("  compareSameRef: ").Append(CompareSameRef).Append("\n");
            sb.Append("  conflictFiles: ").Append(ConflictFiles).Append("\n");
            sb.Append("  addedLines: ").Append(AddedLines).Append("\n");
            sb.Append("  removedLines: ").Append(RemovedLines).Append("\n");
            sb.Append("  commitsCount: ").Append(CommitsCount).Append("\n");
            sb.Append("  diffsCount: ").Append(DiffsCount).Append("\n");
            sb.Append("  xTotal: ").Append(XTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRefCompareResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRefCompareResponse input)
        {
            if (input == null) return false;
            if (this.Commit != input.Commit || (this.Commit != null && !this.Commit.Equals(input.Commit))) return false;
            if (this.Commits != input.Commits || (this.Commits != null && input.Commits != null && !this.Commits.SequenceEqual(input.Commits))) return false;
            if (this.Diffs != input.Diffs || (this.Diffs != null && input.Diffs != null && !this.Diffs.SequenceEqual(input.Diffs))) return false;
            if (this.DiffsFiles != input.DiffsFiles || (this.DiffsFiles != null && input.DiffsFiles != null && !this.DiffsFiles.SequenceEqual(input.DiffsFiles))) return false;
            if (this.CompareTimeout != input.CompareTimeout || (this.CompareTimeout != null && !this.CompareTimeout.Equals(input.CompareTimeout))) return false;
            if (this.CompareSameRef != input.CompareSameRef || (this.CompareSameRef != null && !this.CompareSameRef.Equals(input.CompareSameRef))) return false;
            if (this.ConflictFiles != input.ConflictFiles || (this.ConflictFiles != null && input.ConflictFiles != null && !this.ConflictFiles.SequenceEqual(input.ConflictFiles))) return false;
            if (this.AddedLines != input.AddedLines || (this.AddedLines != null && !this.AddedLines.Equals(input.AddedLines))) return false;
            if (this.RemovedLines != input.RemovedLines || (this.RemovedLines != null && !this.RemovedLines.Equals(input.RemovedLines))) return false;
            if (this.CommitsCount != input.CommitsCount || (this.CommitsCount != null && !this.CommitsCount.Equals(input.CommitsCount))) return false;
            if (this.DiffsCount != input.DiffsCount || (this.DiffsCount != null && !this.DiffsCount.Equals(input.DiffsCount))) return false;
            if (this.XTotal != input.XTotal || (this.XTotal != null && !this.XTotal.Equals(input.XTotal))) return false;

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
                if (this.Commit != null) hashCode = hashCode * 59 + this.Commit.GetHashCode();
                if (this.Commits != null) hashCode = hashCode * 59 + this.Commits.GetHashCode();
                if (this.Diffs != null) hashCode = hashCode * 59 + this.Diffs.GetHashCode();
                if (this.DiffsFiles != null) hashCode = hashCode * 59 + this.DiffsFiles.GetHashCode();
                if (this.CompareTimeout != null) hashCode = hashCode * 59 + this.CompareTimeout.GetHashCode();
                if (this.CompareSameRef != null) hashCode = hashCode * 59 + this.CompareSameRef.GetHashCode();
                if (this.ConflictFiles != null) hashCode = hashCode * 59 + this.ConflictFiles.GetHashCode();
                if (this.AddedLines != null) hashCode = hashCode * 59 + this.AddedLines.GetHashCode();
                if (this.RemovedLines != null) hashCode = hashCode * 59 + this.RemovedLines.GetHashCode();
                if (this.CommitsCount != null) hashCode = hashCode * 59 + this.CommitsCount.GetHashCode();
                if (this.DiffsCount != null) hashCode = hashCode * 59 + this.DiffsCount.GetHashCode();
                if (this.XTotal != null) hashCode = hashCode * 59 + this.XTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
