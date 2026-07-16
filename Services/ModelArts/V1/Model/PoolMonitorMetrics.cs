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
    /// 
    /// </summary>
    public class PoolMonitorMetrics 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public PoolMonitorMetric Metric { get; set; }

        /// <summary>
        /// **参数解释**：监控指标数据。
        /// </summary>
        [JsonProperty("dataPoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolMonitorDataPoints> DataPoints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolMonitorMetrics {\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  dataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolMonitorMetrics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolMonitorMetrics input)
        {
            if (input == null) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;
            if (this.DataPoints != input.DataPoints || (this.DataPoints != null && input.DataPoints != null && !this.DataPoints.SequenceEqual(input.DataPoints))) return false;

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
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.DataPoints != null) hashCode = hashCode * 59 + this.DataPoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
