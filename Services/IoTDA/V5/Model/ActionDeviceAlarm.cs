using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 上报设备告警消息结构
    /// </summary>
    public class ActionDeviceAlarm 
    {

        /// <summary>
        /// **参数说明**：告警名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数说明**：告警状态。 **取值范围**： - fault：上报告警。 - recovery：恢复告警。
        /// </summary>
        [JsonProperty("alarm_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmStatus { get; set; }

        /// <summary>
        /// **参数说明**：告警级别。 **取值范围**：warning（警告）、minor（一般）、major（严重）和critical（致命）。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// **参数说明**：告警维度，与告警名称和告警级别组合起来共同标识一条告警，默认不携带该字段为用户维度告警，支持设备维度和资源空间维度告警。 **取值范围**： - device：设备维度。 - app：资源空间维度。
        /// </summary>
        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string Dimension { get; set; }

        /// <summary>
        /// **参数说明**：告警的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionDeviceAlarm {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  alarmStatus: ").Append(AlarmStatus).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  dimension: ").Append(Dimension).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionDeviceAlarm);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionDeviceAlarm input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AlarmStatus != input.AlarmStatus || (this.AlarmStatus != null && !this.AlarmStatus.Equals(input.AlarmStatus))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Dimension != input.Dimension || (this.Dimension != null && !this.Dimension.Equals(input.Dimension))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AlarmStatus != null) hashCode = hashCode * 59 + this.AlarmStatus.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Dimension != null) hashCode = hashCode * 59 + this.Dimension.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
