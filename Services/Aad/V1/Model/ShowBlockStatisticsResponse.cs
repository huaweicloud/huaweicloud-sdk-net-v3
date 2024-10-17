using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBlockStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 总解封次数
        /// </summary>
        [JsonProperty("total_unblocking_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalUnblockingTimes { get; set; }

        /// <summary>
        /// 人工解封次数
        /// </summary>
        [JsonProperty("manual_unblocking_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? ManualUnblockingTimes { get; set; }

        /// <summary>
        /// 自动解封次数
        /// </summary>
        [JsonProperty("automatic_unblocking_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomaticUnblockingTimes { get; set; }

        /// <summary>
        /// 当前封堵Ip数
        /// </summary>
        [JsonProperty("current_blocked_ip_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentBlockedIpNumbers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBlockStatisticsResponse {\n");
            sb.Append("  totalUnblockingTimes: ").Append(TotalUnblockingTimes).Append("\n");
            sb.Append("  manualUnblockingTimes: ").Append(ManualUnblockingTimes).Append("\n");
            sb.Append("  automaticUnblockingTimes: ").Append(AutomaticUnblockingTimes).Append("\n");
            sb.Append("  currentBlockedIpNumbers: ").Append(CurrentBlockedIpNumbers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBlockStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBlockStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.TotalUnblockingTimes != input.TotalUnblockingTimes || (this.TotalUnblockingTimes != null && !this.TotalUnblockingTimes.Equals(input.TotalUnblockingTimes))) return false;
            if (this.ManualUnblockingTimes != input.ManualUnblockingTimes || (this.ManualUnblockingTimes != null && !this.ManualUnblockingTimes.Equals(input.ManualUnblockingTimes))) return false;
            if (this.AutomaticUnblockingTimes != input.AutomaticUnblockingTimes || (this.AutomaticUnblockingTimes != null && !this.AutomaticUnblockingTimes.Equals(input.AutomaticUnblockingTimes))) return false;
            if (this.CurrentBlockedIpNumbers != input.CurrentBlockedIpNumbers || (this.CurrentBlockedIpNumbers != null && !this.CurrentBlockedIpNumbers.Equals(input.CurrentBlockedIpNumbers))) return false;

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
                if (this.TotalUnblockingTimes != null) hashCode = hashCode * 59 + this.TotalUnblockingTimes.GetHashCode();
                if (this.ManualUnblockingTimes != null) hashCode = hashCode * 59 + this.ManualUnblockingTimes.GetHashCode();
                if (this.AutomaticUnblockingTimes != null) hashCode = hashCode * 59 + this.AutomaticUnblockingTimes.GetHashCode();
                if (this.CurrentBlockedIpNumbers != null) hashCode = hashCode * 59 + this.CurrentBlockedIpNumbers.GetHashCode();
                return hashCode;
            }
        }
    }
}
