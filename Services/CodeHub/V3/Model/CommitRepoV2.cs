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
    public class CommitRepoV2 
    {

        /// <summary>
        /// 提交对应的SHA id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 提交对应的短SHA id
        /// </summary>
        [JsonProperty("short_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 提交标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 父提交id
        /// </summary>
        [JsonProperty("parent_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParentIds { get; set; }

        /// <summary>
        /// 提交信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 提交作者
        /// </summary>
        [JsonProperty("committer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitterName { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        [JsonProperty("committed_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CommittedDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitRepoV2 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  shortId: ").Append(ShortId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  parentIds: ").Append(ParentIds).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  committerName: ").Append(CommitterName).Append("\n");
            sb.Append("  committedDate: ").Append(CommittedDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommitRepoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommitRepoV2 input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ShortId != input.ShortId || (this.ShortId != null && !this.ShortId.Equals(input.ShortId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.ParentIds != input.ParentIds || (this.ParentIds != null && input.ParentIds != null && !this.ParentIds.SequenceEqual(input.ParentIds))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.CommitterName != input.CommitterName || (this.CommitterName != null && !this.CommitterName.Equals(input.CommitterName))) return false;
            if (this.CommittedDate != input.CommittedDate || (this.CommittedDate != null && !this.CommittedDate.Equals(input.CommittedDate))) return false;

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
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ParentIds != null) hashCode = hashCode * 59 + this.ParentIds.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.CommitterName != null) hashCode = hashCode * 59 + this.CommitterName.GetHashCode();
                if (this.CommittedDate != null) hashCode = hashCode * 59 + this.CommittedDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
