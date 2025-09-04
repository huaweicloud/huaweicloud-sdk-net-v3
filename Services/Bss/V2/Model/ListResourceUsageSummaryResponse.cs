using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListResourceUsageSummaryResponse : SdkResponse
    {

        /// <summary>
        /// 总条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 统计值，按照资源ID维度返回的月度统计结果。具体请参见表3。  说明： 每月2日20点后可查询上月数据；若查询当月数据，则只返回资源ID。
        /// </summary>
        [JsonProperty("summary_usage_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatUsageSummaryInfo> SummaryUsageInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceUsageSummaryResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  summaryUsageInfoList: ").Append(SummaryUsageInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceUsageSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceUsageSummaryResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.SummaryUsageInfoList != input.SummaryUsageInfoList || (this.SummaryUsageInfoList != null && input.SummaryUsageInfoList != null && !this.SummaryUsageInfoList.SequenceEqual(input.SummaryUsageInfoList))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.SummaryUsageInfoList != null) hashCode = hashCode * 59 + this.SummaryUsageInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
