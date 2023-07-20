using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 改变告警规则状态
    /// </summary>
    public class ChangeAlarmRuleStatus 
    {

        /// <summary>
        /// 告警规则ID
        /// </summary>
        [JsonProperty("alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleId { get; set; }

        /// <summary>
        /// 状态（RUNNING/STOPPING）
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeAlarmRuleStatus {\n");
            sb.Append("  alarmRuleId: ").Append(AlarmRuleId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeAlarmRuleStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeAlarmRuleStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmRuleId == input.AlarmRuleId ||
                    (this.AlarmRuleId != null &&
                    this.AlarmRuleId.Equals(input.AlarmRuleId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AlarmRuleId != null)
                    hashCode = hashCode * 59 + this.AlarmRuleId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
