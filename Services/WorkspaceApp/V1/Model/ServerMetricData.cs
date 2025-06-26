using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 监控信息。
    /// </summary>
    public class ServerMetricData 
    {

        /// <summary>
        /// 监控指标名称。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标数据列表。
        /// </summary>
        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerDataPoints> Datapoints { get; set; }

        /// <summary>
        /// 维度值，仅查询GPU监控信息时有值。
        /// </summary>
        [JsonProperty("dimension_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerMetricData {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("  dimensionValue: ").Append(DimensionValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerMetricData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerMetricData input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Datapoints != input.Datapoints || (this.Datapoints != null && input.Datapoints != null && !this.Datapoints.SequenceEqual(input.Datapoints))) return false;
            if (this.DimensionValue != input.DimensionValue || (this.DimensionValue != null && !this.DimensionValue.Equals(input.DimensionValue))) return false;

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
                if (this.Datapoints != null) hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                if (this.DimensionValue != null) hashCode = hashCode * 59 + this.DimensionValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
