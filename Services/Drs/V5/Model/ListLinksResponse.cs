using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListLinksResponse : SdkResponse
    {

        /// <summary>
        /// 可用链路信息。
        /// </summary>
        [JsonProperty("job_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobLinkResp> JobLinks { get; set; }

        /// <summary>
        /// 可用链路总条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLinksResponse {\n");
            sb.Append("  jobLinks: ").Append(JobLinks).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLinksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLinksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobLinks == input.JobLinks ||
                    this.JobLinks != null &&
                    input.JobLinks != null &&
                    this.JobLinks.SequenceEqual(input.JobLinks)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.JobLinks != null)
                    hashCode = hashCode * 59 + this.JobLinks.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
