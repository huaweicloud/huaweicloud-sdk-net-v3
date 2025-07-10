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
    /// 带时间的指标。
    /// </summary>
    public class MetricsWithTime 
    {

        /// <summary>
        /// 时间。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 指标值。
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Metric> Metrics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricsWithTime {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricsWithTime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricsWithTime input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && input.Metrics != null && !this.Metrics.SequenceEqual(input.Metrics))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                return hashCode;
            }
        }
    }
}
