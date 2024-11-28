using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSlowLogStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 慢日志统计信息列表。
        /// </summary>
        [JsonProperty("slow_log_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowSlowLogStatisticsItem> SlowLogList { get; set; }

        /// <summary>
        /// 总条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSlowLogStatisticsResponse {\n");
            sb.Append("  slowLogList: ").Append(SlowLogList).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSlowLogStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSlowLogStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.SlowLogList != input.SlowLogList || (this.SlowLogList != null && input.SlowLogList != null && !this.SlowLogList.SequenceEqual(input.SlowLogList))) return false;
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
                if (this.SlowLogList != null) hashCode = hashCode * 59 + this.SlowLogList.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
