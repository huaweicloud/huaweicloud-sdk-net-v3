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
    public class ListSlowLogStatisticsForLtsResponse : SdkResponse
    {

        /// <summary>
        /// 数据集合。
        /// </summary>
        [JsonProperty("slow_log_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlSlowLogStatisticsItem> SlowLogList { get; set; }

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
            sb.Append("class ListSlowLogStatisticsForLtsResponse {\n");
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
            return this.Equals(input as ListSlowLogStatisticsForLtsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSlowLogStatisticsForLtsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SlowLogList == input.SlowLogList ||
                    this.SlowLogList != null &&
                    input.SlowLogList != null &&
                    this.SlowLogList.SequenceEqual(input.SlowLogList)
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
                if (this.SlowLogList != null)
                    hashCode = hashCode * 59 + this.SlowLogList.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
