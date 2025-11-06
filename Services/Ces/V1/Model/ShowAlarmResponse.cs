using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAlarmResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 告警对象列表。 
        /// </summary>
        [JsonProperty("metric_alarms", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricAlarmsResp> MetricAlarms { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAlarmResponse {\n");
            sb.Append("  metricAlarms: ").Append(MetricAlarms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAlarmResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAlarmResponse input)
        {
            if (input == null) return false;
            if (this.MetricAlarms != input.MetricAlarms || (this.MetricAlarms != null && input.MetricAlarms != null && !this.MetricAlarms.SequenceEqual(input.MetricAlarms))) return false;

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
                if (this.MetricAlarms != null) hashCode = hashCode * 59 + this.MetricAlarms.GetHashCode();
                return hashCode;
            }
        }
    }
}
