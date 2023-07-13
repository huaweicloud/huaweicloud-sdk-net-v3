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
    public class ListScrumProjectStatusesResponse : SdkResponse
    {

        /// <summary>
        /// 状态总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 状态列表
        /// </summary>
        [JsonProperty("issue_statuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueStatus> IssueStatuses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScrumProjectStatusesResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  issueStatuses: ").Append(IssueStatuses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScrumProjectStatusesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScrumProjectStatusesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.IssueStatuses == input.IssueStatuses ||
                    this.IssueStatuses != null &&
                    input.IssueStatuses != null &&
                    this.IssueStatuses.SequenceEqual(input.IssueStatuses)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.IssueStatuses != null)
                    hashCode = hashCode * 59 + this.IssueStatuses.GetHashCode();
                return hashCode;
            }
        }
    }
}
