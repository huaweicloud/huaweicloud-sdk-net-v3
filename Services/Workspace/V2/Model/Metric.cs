using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 指标。
    /// </summary>
    public class Metric 
    {

        /// <summary>
        /// 指标名称。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标值。
        /// </summary>
        [JsonProperty("metric_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? MetricValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metric {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  metricValue: ").Append(MetricValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Metric);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Metric input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.MetricValue != input.MetricValue || (this.MetricValue != null && !this.MetricValue.Equals(input.MetricValue))) return false;

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
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.MetricValue != null) hashCode = hashCode * 59 + this.MetricValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
