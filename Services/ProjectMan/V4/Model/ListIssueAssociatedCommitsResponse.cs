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
    /// Response Object
    /// </summary>
    public class ListIssueAssociatedCommitsResponse : SdkResponse
    {

        /// <summary>
        /// 提交记录列表
        /// </summary>
        [JsonProperty("commits", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommitRecordDetail> Commits { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIssueAssociatedCommitsResponse {\n");
            sb.Append("  commits: ").Append(Commits).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIssueAssociatedCommitsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIssueAssociatedCommitsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Commits == input.Commits ||
                    this.Commits != null &&
                    input.Commits != null &&
                    this.Commits.SequenceEqual(input.Commits)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Commits != null)
                    hashCode = hashCode * 59 + this.Commits.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
