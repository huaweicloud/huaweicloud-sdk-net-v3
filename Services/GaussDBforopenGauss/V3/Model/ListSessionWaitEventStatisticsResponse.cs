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
    public class ListSessionWaitEventStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 统计总条数。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**: 统计数据。 
        /// </summary>
        [JsonProperty("wait_event_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<SessionWaitEventStatisticInfo> WaitEventInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSessionWaitEventStatisticsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  waitEventInfo: ").Append(WaitEventInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSessionWaitEventStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSessionWaitEventStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.WaitEventInfo != input.WaitEventInfo || (this.WaitEventInfo != null && input.WaitEventInfo != null && !this.WaitEventInfo.SequenceEqual(input.WaitEventInfo))) return false;

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
                if (this.WaitEventInfo != null) hashCode = hashCode * 59 + this.WaitEventInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
