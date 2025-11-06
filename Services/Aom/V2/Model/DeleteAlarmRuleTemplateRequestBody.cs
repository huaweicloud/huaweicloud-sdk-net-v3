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
    public class DeleteAlarmRuleTemplateRequestBody 
    {

        /// <summary>
        /// 告警模板id列表。
        /// </summary>
        [JsonProperty("alarm_rule_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmRuleTemplates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAlarmRuleTemplateRequestBody {\n");
            sb.Append("  alarmRuleTemplates: ").Append(AlarmRuleTemplates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAlarmRuleTemplateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAlarmRuleTemplateRequestBody input)
        {
            if (input == null) return false;
            if (this.AlarmRuleTemplates != input.AlarmRuleTemplates || (this.AlarmRuleTemplates != null && input.AlarmRuleTemplates != null && !this.AlarmRuleTemplates.SequenceEqual(input.AlarmRuleTemplates))) return false;

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
                if (this.AlarmRuleTemplates != null) hashCode = hashCode * 59 + this.AlarmRuleTemplates.GetHashCode();
                return hashCode;
            }
        }
    }
}
