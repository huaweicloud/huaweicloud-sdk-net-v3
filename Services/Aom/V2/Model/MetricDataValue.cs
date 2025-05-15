using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 查询结果详细。
    /// </summary>
    public class MetricDataValue 
    {

        /// <summary>
        /// 重点指标。
        /// </summary>
        [JsonProperty("dataPoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricDataPoints> DataPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public MetricQueryMetricParam Metric { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricDataValue {\n");
            sb.Append("  dataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricDataValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricDataValue input)
        {
            if (input == null) return false;
            if (this.DataPoints != input.DataPoints || (this.DataPoints != null && input.DataPoints != null && !this.DataPoints.SequenceEqual(input.DataPoints))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;

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
                if (this.DataPoints != null) hashCode = hashCode * 59 + this.DataPoints.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                return hashCode;
            }
        }
    }
}
