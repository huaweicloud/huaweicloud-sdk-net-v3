using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowVmMonitorResponse : SdkResponse
    {

        /// <summary>
        /// 指标的时间序列
        /// </summary>
        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Datapoint> Datapoints { get; set; }

        /// <summary>
        /// 指标名称，比如:cpu_util
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVmMonitorResponse {\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVmMonitorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVmMonitorResponse input)
        {
            if (input == null) return false;
            if (this.Datapoints != input.Datapoints || (this.Datapoints != null && input.Datapoints != null && !this.Datapoints.SequenceEqual(input.Datapoints))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;

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
                if (this.Datapoints != null) hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                return hashCode;
            }
        }
    }
}
