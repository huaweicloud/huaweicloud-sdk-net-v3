using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 含阈值告警的QoS数据元素，包括时间，QoS取值，告警状态，产生告警时的阈值。
    /// </summary>
    public class QosDataElement 
    {

        /// <summary>
        /// QoS时间点, UTC时间，格式：yyyy-MM-ddTHH:mm:ss.SSSZ。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// QoS值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public int? Value { get; set; }

        /// <summary>
        /// 该时间点是否有阈值告警。 * true: 阈值告警 * false: 无阈值告警 
        /// </summary>
        [JsonProperty("alarm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alarm { get; set; }

        /// <summary>
        /// 该时间点的阈值。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QosDataElement {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  alarm: ").Append(Alarm).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QosDataElement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QosDataElement input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Alarm != input.Alarm || (this.Alarm != null && !this.Alarm.Equals(input.Alarm))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;

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
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Alarm != null) hashCode = hashCode * 59 + this.Alarm.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
