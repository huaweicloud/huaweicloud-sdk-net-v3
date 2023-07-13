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
    public class SearchIssuesResponse : SdkResponse
    {

        /// <summary>
        /// 工作项信息列表
        /// </summary>
        [JsonProperty("issue_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkTableIssuseListResponseBodyIssueList> IssueList { get; set; }

        /// <summary>
        /// 工作项总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchIssuesResponse {\n");
            sb.Append("  issueList: ").Append(IssueList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchIssuesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchIssuesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssueList == input.IssueList ||
                    this.IssueList != null &&
                    input.IssueList != null &&
                    this.IssueList.SequenceEqual(input.IssueList)
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
                if (this.IssueList != null)
                    hashCode = hashCode * 59 + this.IssueList.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
