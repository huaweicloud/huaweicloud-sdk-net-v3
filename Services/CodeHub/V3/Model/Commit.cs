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
    public class Commit 
    {

        /// <summary>
        /// 作者邮箱
        /// </summary>
        [JsonProperty("author_email", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorEmail { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 作者提交时间
        /// </summary>
        [JsonProperty("authored_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AuthoredDate { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        [JsonProperty("committed_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CommittedDate { get; set; }

        /// <summary>
        /// 提交作者邮箱
        /// </summary>
        [JsonProperty("committer_email", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitterEmail { get; set; }

        /// <summary>
        /// 提交作者
        /// </summary>
        [JsonProperty("committer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitterName { get; set; }

        /// <summary>
        /// 文件变更的详情信息，其格式由请求查询参数 stat_format 决定
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public Object Format { get; set; }

        /// <summary>
        /// 提交对应的SHA id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 提交的信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 父提交id
        /// </summary>
        [JsonProperty("parent_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParentIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Commit {\n");
            sb.Append("  authorEmail: ").Append(AuthorEmail).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  authoredDate: ").Append(AuthoredDate).Append("\n");
            sb.Append("  committedDate: ").Append(CommittedDate).Append("\n");
            sb.Append("  committerEmail: ").Append(CommitterEmail).Append("\n");
            sb.Append("  committerName: ").Append(CommitterName).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  parentIds: ").Append(ParentIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Commit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Commit input)
        {
            if (input == null) return false;
            if (this.AuthorEmail != input.AuthorEmail || (this.AuthorEmail != null && !this.AuthorEmail.Equals(input.AuthorEmail))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.AuthoredDate != input.AuthoredDate || (this.AuthoredDate != null && !this.AuthoredDate.Equals(input.AuthoredDate))) return false;
            if (this.CommittedDate != input.CommittedDate || (this.CommittedDate != null && !this.CommittedDate.Equals(input.CommittedDate))) return false;
            if (this.CommitterEmail != input.CommitterEmail || (this.CommitterEmail != null && !this.CommitterEmail.Equals(input.CommitterEmail))) return false;
            if (this.CommitterName != input.CommitterName || (this.CommitterName != null && !this.CommitterName.Equals(input.CommitterName))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.ParentIds != input.ParentIds || (this.ParentIds != null && input.ParentIds != null && !this.ParentIds.SequenceEqual(input.ParentIds))) return false;

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
                if (this.AuthorEmail != null) hashCode = hashCode * 59 + this.AuthorEmail.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.AuthoredDate != null) hashCode = hashCode * 59 + this.AuthoredDate.GetHashCode();
                if (this.CommittedDate != null) hashCode = hashCode * 59 + this.CommittedDate.GetHashCode();
                if (this.CommitterEmail != null) hashCode = hashCode * 59 + this.CommitterEmail.GetHashCode();
                if (this.CommitterName != null) hashCode = hashCode * 59 + this.CommitterName.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ParentIds != null) hashCode = hashCode * 59 + this.ParentIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
