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
    /// **参数解释**： 告警策略附加信息。     **约束限制**： 不涉及。 
    /// </summary>
    public class MetricExtraInfo 
    {

        /// <summary>
        /// **参数解释**： 原始指标名称。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,4096]个字符。          **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("origin_metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginMetricName { get; set; }

        /// <summary>
        /// **参数解释**： 指标名称前缀。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,4096]个字符。          **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("metric_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricPrefix { get; set; }

        /// <summary>
        /// **参数解释**： 用户进程名称。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,250]个字符。          **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("custom_proc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomProcName { get; set; }

        /// <summary>
        /// **参数解释**： 指标类型。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,32]个字符。          **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("metric_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricExtraInfo {\n");
            sb.Append("  originMetricName: ").Append(OriginMetricName).Append("\n");
            sb.Append("  metricPrefix: ").Append(MetricPrefix).Append("\n");
            sb.Append("  customProcName: ").Append(CustomProcName).Append("\n");
            sb.Append("  metricType: ").Append(MetricType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricExtraInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricExtraInfo input)
        {
            if (input == null) return false;
            if (this.OriginMetricName != input.OriginMetricName || (this.OriginMetricName != null && !this.OriginMetricName.Equals(input.OriginMetricName))) return false;
            if (this.MetricPrefix != input.MetricPrefix || (this.MetricPrefix != null && !this.MetricPrefix.Equals(input.MetricPrefix))) return false;
            if (this.CustomProcName != input.CustomProcName || (this.CustomProcName != null && !this.CustomProcName.Equals(input.CustomProcName))) return false;
            if (this.MetricType != input.MetricType || (this.MetricType != null && !this.MetricType.Equals(input.MetricType))) return false;

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
                if (this.OriginMetricName != null) hashCode = hashCode * 59 + this.OriginMetricName.GetHashCode();
                if (this.MetricPrefix != null) hashCode = hashCode * 59 + this.MetricPrefix.GetHashCode();
                if (this.CustomProcName != null) hashCode = hashCode * 59 + this.CustomProcName.GetHashCode();
                if (this.MetricType != null) hashCode = hashCode * 59 + this.MetricType.GetHashCode();
                return hashCode;
            }
        }
    }
}
