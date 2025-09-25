using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSessionStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 总数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**: 会话统计列表。
        /// </summary>
        [JsonProperty("statistics_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DimensionListResult> StatisticsList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSessionStatisticsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  statisticsList: ").Append(StatisticsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSessionStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSessionStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.StatisticsList != input.StatisticsList || (this.StatisticsList != null && input.StatisticsList != null && !this.StatisticsList.SequenceEqual(input.StatisticsList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.StatisticsList != null) hashCode = hashCode * 59 + this.StatisticsList.GetHashCode();
                return hashCode;
            }
        }
    }
}
