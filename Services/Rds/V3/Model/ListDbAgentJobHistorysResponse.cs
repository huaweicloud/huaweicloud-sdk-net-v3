using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDbAgentJobHistorysResponse : SdkResponse
    {

        /// <summary>
        /// 执行历史列表。
        /// </summary>
        [JsonProperty("histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListDbAgentJobHistorysResult> Histories { get; set; }

        /// <summary>
        /// 执行历史总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDbAgentJobHistorysResponse {\n");
            sb.Append("  histories: ").Append(Histories).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDbAgentJobHistorysResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDbAgentJobHistorysResponse input)
        {
            if (input == null) return false;
            if (this.Histories != input.Histories || (this.Histories != null && input.Histories != null && !this.Histories.SequenceEqual(input.Histories))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.Histories != null) hashCode = hashCode * 59 + this.Histories.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
