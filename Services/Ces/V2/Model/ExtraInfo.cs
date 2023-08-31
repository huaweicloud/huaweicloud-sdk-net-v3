using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtraInfo 
    {

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("origin_metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginMetricName { get; set; }

        /// <summary>
        /// 指标名称前缀
        /// </summary>
        [JsonProperty("metric_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricPrefix { get; set; }

        /// <summary>
        /// 指标类型
        /// </summary>
        [JsonProperty("metric_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricType { get; set; }

        /// <summary>
        /// 自定义进程名称
        /// </summary>
        [JsonProperty("custom_proc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomProcName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtraInfo {\n");
            sb.Append("  originMetricName: ").Append(OriginMetricName).Append("\n");
            sb.Append("  metricPrefix: ").Append(MetricPrefix).Append("\n");
            sb.Append("  metricType: ").Append(MetricType).Append("\n");
            sb.Append("  customProcName: ").Append(CustomProcName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtraInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtraInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OriginMetricName == input.OriginMetricName ||
                    (this.OriginMetricName != null &&
                    this.OriginMetricName.Equals(input.OriginMetricName))
                ) && 
                (
                    this.MetricPrefix == input.MetricPrefix ||
                    (this.MetricPrefix != null &&
                    this.MetricPrefix.Equals(input.MetricPrefix))
                ) && 
                (
                    this.MetricType == input.MetricType ||
                    (this.MetricType != null &&
                    this.MetricType.Equals(input.MetricType))
                ) && 
                (
                    this.CustomProcName == input.CustomProcName ||
                    (this.CustomProcName != null &&
                    this.CustomProcName.Equals(input.CustomProcName))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OriginMetricName != null)
                    hashCode = hashCode * 59 + this.OriginMetricName.GetHashCode();
                if (this.MetricPrefix != null)
                    hashCode = hashCode * 59 + this.MetricPrefix.GetHashCode();
                if (this.MetricType != null)
                    hashCode = hashCode * 59 + this.MetricType.GetHashCode();
                if (this.CustomProcName != null)
                    hashCode = hashCode * 59 + this.CustomProcName.GetHashCode();
                return hashCode;
            }
        }
    }
}
