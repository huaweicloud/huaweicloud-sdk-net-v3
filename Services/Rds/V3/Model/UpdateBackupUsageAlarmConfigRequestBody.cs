using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 修改备份空间告警配置请求体
    /// </summary>
    public class UpdateBackupUsageAlarmConfigRequestBody 
    {

        /// <summary>
        /// **参数解释**：  告警开关。  **约束限制**：  不涉及。  **取值范围**：  - ON - OFF  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmEnabled { get; set; }

        /// <summary>
        /// **参数解释**：  阈值百分比，占免费备份空间大小的百分比。  **约束限制**：  不涉及。  **取值范围**：  1-100。  **默认取值**：  90
        /// </summary>
        [JsonProperty("threshold_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThresholdPercent { get; set; }

        /// <summary>
        /// **参数解释**：  增量百分比，占免费备份空间大小的百分比。  **约束限制**：  不涉及。  **取值范围**：  1-100。  **默认取值**：  10
        /// </summary>
        [JsonProperty("increment_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? IncrementPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBackupUsageAlarmConfigRequestBody {\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  thresholdPercent: ").Append(ThresholdPercent).Append("\n");
            sb.Append("  incrementPercent: ").Append(IncrementPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBackupUsageAlarmConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBackupUsageAlarmConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.AlarmEnabled != input.AlarmEnabled || (this.AlarmEnabled != null && !this.AlarmEnabled.Equals(input.AlarmEnabled))) return false;
            if (this.ThresholdPercent != input.ThresholdPercent || (this.ThresholdPercent != null && !this.ThresholdPercent.Equals(input.ThresholdPercent))) return false;
            if (this.IncrementPercent != input.IncrementPercent || (this.IncrementPercent != null && !this.IncrementPercent.Equals(input.IncrementPercent))) return false;

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
                if (this.AlarmEnabled != null) hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.ThresholdPercent != null) hashCode = hashCode * 59 + this.ThresholdPercent.GetHashCode();
                if (this.IncrementPercent != null) hashCode = hashCode * 59 + this.IncrementPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
