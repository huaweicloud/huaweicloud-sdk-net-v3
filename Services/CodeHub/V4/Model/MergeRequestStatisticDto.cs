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
    /// 合并请求统计数据
    /// </summary>
    public class MergeRequestStatisticDto 
    {

        /// <summary>
        /// 合并请求ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 合并请求序号
        /// </summary>
        [JsonProperty("iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iid { get; set; }

        /// <summary>
        /// 合并请求标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 合并请求状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 合并请求提交数
        /// </summary>
        [JsonProperty("commits_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitsCount { get; set; }

        /// <summary>
        /// 合并请求文件变数
        /// </summary>
        [JsonProperty("changed_files_count", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangedFilesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("notes_count", NullValueHandling = NullValueHandling.Ignore)]
        public NotesCountDto NotesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("changed_lines_count", NullValueHandling = NullValueHandling.Ignore)]
        public MergeRequestLineChange ChangedLinesCount { get; set; }

        /// <summary>
        /// 合并请求合入异常信息
        /// </summary>
        [JsonProperty("merge_error", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeError { get; set; }

        /// <summary>
        /// 合并请求合入异常信息
        /// </summary>
        [JsonProperty("json_merge_error", NullValueHandling = NullValueHandling.Ignore)]
        public Object JsonMergeError { get; set; }

        /// <summary>
        /// 合并请求评分数
        /// </summary>
        [JsonProperty("votes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Votes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestStatisticDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iid: ").Append(Iid).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  commitsCount: ").Append(CommitsCount).Append("\n");
            sb.Append("  changedFilesCount: ").Append(ChangedFilesCount).Append("\n");
            sb.Append("  notesCount: ").Append(NotesCount).Append("\n");
            sb.Append("  changedLinesCount: ").Append(ChangedLinesCount).Append("\n");
            sb.Append("  mergeError: ").Append(MergeError).Append("\n");
            sb.Append("  jsonMergeError: ").Append(JsonMergeError).Append("\n");
            sb.Append("  votes: ").Append(Votes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestStatisticDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestStatisticDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Iid != input.Iid || (this.Iid != null && !this.Iid.Equals(input.Iid))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CommitsCount != input.CommitsCount || (this.CommitsCount != null && !this.CommitsCount.Equals(input.CommitsCount))) return false;
            if (this.ChangedFilesCount != input.ChangedFilesCount || (this.ChangedFilesCount != null && !this.ChangedFilesCount.Equals(input.ChangedFilesCount))) return false;
            if (this.NotesCount != input.NotesCount || (this.NotesCount != null && !this.NotesCount.Equals(input.NotesCount))) return false;
            if (this.ChangedLinesCount != input.ChangedLinesCount || (this.ChangedLinesCount != null && !this.ChangedLinesCount.Equals(input.ChangedLinesCount))) return false;
            if (this.MergeError != input.MergeError || (this.MergeError != null && !this.MergeError.Equals(input.MergeError))) return false;
            if (this.JsonMergeError != input.JsonMergeError || (this.JsonMergeError != null && !this.JsonMergeError.Equals(input.JsonMergeError))) return false;
            if (this.Votes != input.Votes || (this.Votes != null && !this.Votes.Equals(input.Votes))) return false;

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
                if (this.Iid != null) hashCode = hashCode * 59 + this.Iid.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CommitsCount != null) hashCode = hashCode * 59 + this.CommitsCount.GetHashCode();
                if (this.ChangedFilesCount != null) hashCode = hashCode * 59 + this.ChangedFilesCount.GetHashCode();
                if (this.NotesCount != null) hashCode = hashCode * 59 + this.NotesCount.GetHashCode();
                if (this.ChangedLinesCount != null) hashCode = hashCode * 59 + this.ChangedLinesCount.GetHashCode();
                if (this.MergeError != null) hashCode = hashCode * 59 + this.MergeError.GetHashCode();
                if (this.JsonMergeError != null) hashCode = hashCode * 59 + this.JsonMergeError.GetHashCode();
                if (this.Votes != null) hashCode = hashCode * 59 + this.Votes.GetHashCode();
                return hashCode;
            }
        }
    }
}
