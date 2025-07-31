using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessTopStatisticsVO 
    {

        /// <summary>
        /// **参数解释**： 聚合时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("agg_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggTime { get; set; }

        /// <summary>
        /// **参数解释**： 阻断数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny_access_top_counts", NullValueHandling = NullValueHandling.Ignore)]
        public long? DenyAccessTopCounts { get; set; }

        /// <summary>
        /// **参数解释**： 放行数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("permit_access_top_counts", NullValueHandling = NullValueHandling.Ignore)]
        public long? PermitAccessTopCounts { get; set; }

        /// <summary>
        /// **参数解释**： 命中次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("total_access_top_counts", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalAccessTopCounts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessTopStatisticsVO {\n");
            sb.Append("  aggTime: ").Append(AggTime).Append("\n");
            sb.Append("  denyAccessTopCounts: ").Append(DenyAccessTopCounts).Append("\n");
            sb.Append("  permitAccessTopCounts: ").Append(PermitAccessTopCounts).Append("\n");
            sb.Append("  totalAccessTopCounts: ").Append(TotalAccessTopCounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessTopStatisticsVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessTopStatisticsVO input)
        {
            if (input == null) return false;
            if (this.AggTime != input.AggTime || (this.AggTime != null && !this.AggTime.Equals(input.AggTime))) return false;
            if (this.DenyAccessTopCounts != input.DenyAccessTopCounts || (this.DenyAccessTopCounts != null && !this.DenyAccessTopCounts.Equals(input.DenyAccessTopCounts))) return false;
            if (this.PermitAccessTopCounts != input.PermitAccessTopCounts || (this.PermitAccessTopCounts != null && !this.PermitAccessTopCounts.Equals(input.PermitAccessTopCounts))) return false;
            if (this.TotalAccessTopCounts != input.TotalAccessTopCounts || (this.TotalAccessTopCounts != null && !this.TotalAccessTopCounts.Equals(input.TotalAccessTopCounts))) return false;

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
                if (this.AggTime != null) hashCode = hashCode * 59 + this.AggTime.GetHashCode();
                if (this.DenyAccessTopCounts != null) hashCode = hashCode * 59 + this.DenyAccessTopCounts.GetHashCode();
                if (this.PermitAccessTopCounts != null) hashCode = hashCode * 59 + this.PermitAccessTopCounts.GetHashCode();
                if (this.TotalAccessTopCounts != null) hashCode = hashCode * 59 + this.TotalAccessTopCounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
