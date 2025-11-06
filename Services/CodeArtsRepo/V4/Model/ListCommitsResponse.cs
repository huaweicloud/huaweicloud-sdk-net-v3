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
    /// Response Object
    /// </summary>
    public class ListCommitsResponse : SdkResponse
    {

        /// <summary>
        /// 提交列表
        /// </summary>
        [JsonProperty("commits", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommitDto> Commits { get; set; }

        /// <summary>
        /// 按天统计信息
        /// </summary>
        [JsonProperty("date_title", NullValueHandling = NullValueHandling.Ignore)]
        public List<DateTitleDto> DateTitle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCommitsResponse {\n");
            sb.Append("  commits: ").Append(Commits).Append("\n");
            sb.Append("  dateTitle: ").Append(DateTitle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCommitsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCommitsResponse input)
        {
            if (input == null) return false;
            if (this.Commits != input.Commits || (this.Commits != null && input.Commits != null && !this.Commits.SequenceEqual(input.Commits))) return false;
            if (this.DateTitle != input.DateTitle || (this.DateTitle != null && input.DateTitle != null && !this.DateTitle.SequenceEqual(input.DateTitle))) return false;

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
                if (this.Commits != null) hashCode = hashCode * 59 + this.Commits.GetHashCode();
                if (this.DateTitle != null) hashCode = hashCode * 59 + this.DateTitle.GetHashCode();
                return hashCode;
            }
        }
    }
}
