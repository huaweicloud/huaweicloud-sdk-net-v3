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
    public class ShowGlobalSlowSqlDetailResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 慢SQL详情列表。
        /// </summary>
        [JsonProperty("slow_sql_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlowSqlDetailResult> SlowSqlDetails { get; set; }

        /// <summary>
        /// **参数解释**: 返回的慢SQL数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGlobalSlowSqlDetailResponse {\n");
            sb.Append("  slowSqlDetails: ").Append(SlowSqlDetails).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGlobalSlowSqlDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGlobalSlowSqlDetailResponse input)
        {
            if (input == null) return false;
            if (this.SlowSqlDetails != input.SlowSqlDetails || (this.SlowSqlDetails != null && input.SlowSqlDetails != null && !this.SlowSqlDetails.SequenceEqual(input.SlowSqlDetails))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.SlowSqlDetails != null) hashCode = hashCode * 59 + this.SlowSqlDetails.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
