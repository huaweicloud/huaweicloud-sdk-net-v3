using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// SLO目标配置
    /// </summary>
    public class SloObjectives 
    {

        /// <summary>
        /// **参数解释：** TTFT指标，单位毫秒。 **取值范围：** 0~10000。 **约束限制：** 不涉及。 **默认取值：** 100。
        /// </summary>
        [JsonProperty("metric_ttft", NullValueHandling = NullValueHandling.Ignore)]
        public int? MetricTtft { get; set; }

        /// <summary>
        /// **参数解释：** TPOT指标，单位毫秒。 **取值范围：** 0~1000。 **约束限制：** 不涉及。 **默认取值：** 50。
        /// </summary>
        [JsonProperty("metric_tpot", NullValueHandling = NullValueHandling.Ignore)]
        public int? MetricTpot { get; set; }

        /// <summary>
        /// **参数解释：** SLO满足百分比。 **取值范围：** 0~100。
        /// </summary>
        [JsonProperty("percental", NullValueHandling = NullValueHandling.Ignore)]
        public int? Percental { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SloObjectives {\n");
            sb.Append("  metricTtft: ").Append(MetricTtft).Append("\n");
            sb.Append("  metricTpot: ").Append(MetricTpot).Append("\n");
            sb.Append("  percental: ").Append(Percental).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SloObjectives);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SloObjectives input)
        {
            if (input == null) return false;
            if (this.MetricTtft != input.MetricTtft || (this.MetricTtft != null && !this.MetricTtft.Equals(input.MetricTtft))) return false;
            if (this.MetricTpot != input.MetricTpot || (this.MetricTpot != null && !this.MetricTpot.Equals(input.MetricTpot))) return false;
            if (this.Percental != input.Percental || (this.Percental != null && !this.Percental.Equals(input.Percental))) return false;

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
                if (this.MetricTtft != null) hashCode = hashCode * 59 + this.MetricTtft.GetHashCode();
                if (this.MetricTpot != null) hashCode = hashCode * 59 + this.MetricTpot.GetHashCode();
                if (this.Percental != null) hashCode = hashCode * 59 + this.Percental.GetHashCode();
                return hashCode;
            }
        }
    }
}
