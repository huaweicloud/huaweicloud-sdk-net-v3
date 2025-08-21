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
    public class FlowTrendVO 
    {

        /// <summary>
        /// **参数解释**： 聚合时间点 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("agg_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggTime { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowTrendVO {\n");
            sb.Append("  aggTime: ").Append(AggTime).Append("\n");
            sb.Append("  inBps: ").Append(InBps).Append("\n");
            sb.Append("  outBps: ").Append(OutBps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowTrendVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowTrendVO input)
        {
            if (input == null) return false;
            if (this.AggTime != input.AggTime || (this.AggTime != null && !this.AggTime.Equals(input.AggTime))) return false;
            if (this.InBps != input.InBps || (this.InBps != null && !this.InBps.Equals(input.InBps))) return false;
            if (this.OutBps != input.OutBps || (this.OutBps != null && !this.OutBps.Equals(input.OutBps))) return false;

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
                if (this.InBps != null) hashCode = hashCode * 59 + this.InBps.GetHashCode();
                if (this.OutBps != null) hashCode = hashCode * 59 + this.OutBps.GetHashCode();
                return hashCode;
            }
        }
    }
}
