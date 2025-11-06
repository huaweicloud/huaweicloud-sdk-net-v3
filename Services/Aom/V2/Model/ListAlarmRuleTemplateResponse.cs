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
    /// Response Object
    /// </summary>
    public class ListAlarmRuleTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 告警模板列表。
        /// </summary>
        [JsonProperty("alarm_rule_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmRuleTemplateBody> AlarmRuleTemplates { get; set; }

        /// <summary>
        /// 告警模板总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmRuleTemplateResponse {\n");
            sb.Append("  alarmRuleTemplates: ").Append(AlarmRuleTemplates).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmRuleTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmRuleTemplateResponse input)
        {
            if (input == null) return false;
            if (this.AlarmRuleTemplates != input.AlarmRuleTemplates || (this.AlarmRuleTemplates != null && input.AlarmRuleTemplates != null && !this.AlarmRuleTemplates.SequenceEqual(input.AlarmRuleTemplates))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
