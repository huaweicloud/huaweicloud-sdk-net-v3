using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteAlarmRuleRequest 
    {

        /// <summary>
        /// 阈值规则ID。
        /// </summary>
        [SDKProperty("alarm_rule_id", IsPath = true)]
        [JsonProperty("alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAlarmRuleRequest {\n");
            sb.Append("  alarmRuleId: ").Append(AlarmRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAlarmRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAlarmRuleRequest input)
        {
            if (input == null) return false;
            if (this.AlarmRuleId != input.AlarmRuleId || (this.AlarmRuleId != null && !this.AlarmRuleId.Equals(input.AlarmRuleId))) return false;

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
                if (this.AlarmRuleId != null) hashCode = hashCode * 59 + this.AlarmRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
