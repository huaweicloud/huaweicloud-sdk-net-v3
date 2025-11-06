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
    public class DeleteAlarmRuleTemplateItemResult 
    {

        /// <summary>
        /// 告警模板id。
        /// </summary>
        [JsonProperty("alarm_rule_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleTemplateName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAlarmRuleTemplateItemResult {\n");
            sb.Append("  alarmRuleTemplateName: ").Append(AlarmRuleTemplateName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAlarmRuleTemplateItemResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAlarmRuleTemplateItemResult input)
        {
            if (input == null) return false;
            if (this.AlarmRuleTemplateName != input.AlarmRuleTemplateName || (this.AlarmRuleTemplateName != null && !this.AlarmRuleTemplateName.Equals(input.AlarmRuleTemplateName))) return false;

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
                if (this.AlarmRuleTemplateName != null) hashCode = hashCode * 59 + this.AlarmRuleTemplateName.GetHashCode();
                return hashCode;
            }
        }
    }
}
