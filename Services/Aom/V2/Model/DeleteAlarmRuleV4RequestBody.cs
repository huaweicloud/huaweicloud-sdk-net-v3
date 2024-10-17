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
    /// 
    /// </summary>
    public class DeleteAlarmRuleV4RequestBody 
    {

        /// <summary>
        /// 告警规则名称列表。
        /// </summary>
        [JsonProperty("alarm_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAlarmRuleV4RequestBody {\n");
            sb.Append("  alarmRules: ").Append(AlarmRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAlarmRuleV4RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAlarmRuleV4RequestBody input)
        {
            if (input == null) return false;
            if (this.AlarmRules != input.AlarmRules || (this.AlarmRules != null && input.AlarmRules != null && !this.AlarmRules.SequenceEqual(input.AlarmRules))) return false;

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
                if (this.AlarmRules != null) hashCode = hashCode * 59 + this.AlarmRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
