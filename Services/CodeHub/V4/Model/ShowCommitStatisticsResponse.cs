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
    public class ShowCommitStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 提交统计。
        /// </summary>
        [JsonProperty("commits", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommitStatisticsResultCommitDto> Commits { get; set; }

        /// <summary>
        /// **参数解释：** 提交人员统计。
        /// </summary>
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatisticDto> Statistics { get; set; }

        /// <summary>
        /// **参数解释：** 总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

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
            sb.Append("class ShowCommitStatisticsResponse {\n");
            sb.Append("  commits: ").Append(Commits).Append("\n");
            sb.Append("  statistics: ").Append(Statistics).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  xTotal: ").Append(XTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCommitStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCommitStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.Commits != input.Commits || (this.Commits != null && input.Commits != null && !this.Commits.SequenceEqual(input.Commits))) return false;
            if (this.Statistics != input.Statistics || (this.Statistics != null && input.Statistics != null && !this.Statistics.SequenceEqual(input.Statistics))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
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
                if (this.Commits != null) hashCode = hashCode * 59 + this.Commits.GetHashCode();
                if (this.Statistics != null) hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.XTotal != null) hashCode = hashCode * 59 + this.XTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
