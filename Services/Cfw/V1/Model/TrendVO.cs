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
    public class TrendVO 
    {

        /// <summary>
        /// **参数解释**： 聚合时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("agg_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggTime { get; set; }

        /// <summary>
        /// **参数解释**： 带宽 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("bps", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bps { get; set; }

        /// <summary>
        /// **参数解释**： 阻断数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny", NullValueHandling = NullValueHandling.Ignore)]
        public long? Deny { get; set; }

        /// <summary>
        /// **参数解释**： 入方向bps **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("in_bps", NullValueHandling = NullValueHandling.Ignore)]
        public double? InBps { get; set; }

        /// <summary>
        /// **参数解释**： 出方向bps **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("out_bps", NullValueHandling = NullValueHandling.Ignore)]
        public double? OutBps { get; set; }

        /// <summary>
        /// **参数解释**： 允许数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("permit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Permit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrendVO {\n");
            sb.Append("  aggTime: ").Append(AggTime).Append("\n");
            sb.Append("  bps: ").Append(Bps).Append("\n");
            sb.Append("  deny: ").Append(Deny).Append("\n");
            sb.Append("  inBps: ").Append(InBps).Append("\n");
            sb.Append("  outBps: ").Append(OutBps).Append("\n");
            sb.Append("  permit: ").Append(Permit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrendVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrendVO input)
        {
            if (input == null) return false;
            if (this.AggTime != input.AggTime || (this.AggTime != null && !this.AggTime.Equals(input.AggTime))) return false;
            if (this.Bps != input.Bps || (this.Bps != null && !this.Bps.Equals(input.Bps))) return false;
            if (this.Deny != input.Deny || (this.Deny != null && !this.Deny.Equals(input.Deny))) return false;
            if (this.InBps != input.InBps || (this.InBps != null && !this.InBps.Equals(input.InBps))) return false;
            if (this.OutBps != input.OutBps || (this.OutBps != null && !this.OutBps.Equals(input.OutBps))) return false;
            if (this.Permit != input.Permit || (this.Permit != null && !this.Permit.Equals(input.Permit))) return false;

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
                if (this.Bps != null) hashCode = hashCode * 59 + this.Bps.GetHashCode();
                if (this.Deny != null) hashCode = hashCode * 59 + this.Deny.GetHashCode();
                if (this.InBps != null) hashCode = hashCode * 59 + this.InBps.GetHashCode();
                if (this.OutBps != null) hashCode = hashCode * 59 + this.OutBps.GetHashCode();
                if (this.Permit != null) hashCode = hashCode * 59 + this.Permit.GetHashCode();
                return hashCode;
            }
        }
    }
}
