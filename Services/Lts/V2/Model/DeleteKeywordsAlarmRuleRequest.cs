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
    /// Request Object
    /// </summary>
    public class DeleteKeywordsAlarmRuleRequest 
    {

        /// <summary>
        /// 关键词告警规则id
        /// </summary>
        [SDKProperty("keywords_alarm_rule_id", IsPath = true)]
        [JsonProperty("keywords_alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordsAlarmRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteKeywordsAlarmRuleRequest {\n");
            sb.Append("  keywordsAlarmRuleId: ").Append(KeywordsAlarmRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteKeywordsAlarmRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteKeywordsAlarmRuleRequest input)
        {
            if (input == null) return false;
            if (this.KeywordsAlarmRuleId != input.KeywordsAlarmRuleId || (this.KeywordsAlarmRuleId != null && !this.KeywordsAlarmRuleId.Equals(input.KeywordsAlarmRuleId))) return false;

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
                if (this.KeywordsAlarmRuleId != null) hashCode = hashCode * 59 + this.KeywordsAlarmRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
