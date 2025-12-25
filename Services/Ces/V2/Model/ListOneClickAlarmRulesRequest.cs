using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListOneClickAlarmRulesRequest 
    {

        /// <summary>
        /// **参数解释** 一键告警ID **约束限制** 不涉及 **取值范围** 长度为1到64字符，只能包含字母数字 **默认取值** 不涉及 
        /// </summary>
        [SDKProperty("one_click_alarm_id", IsPath = true)]
        [JsonProperty("one_click_alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OneClickAlarmId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOneClickAlarmRulesRequest {\n");
            sb.Append("  oneClickAlarmId: ").Append(OneClickAlarmId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOneClickAlarmRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOneClickAlarmRulesRequest input)
        {
            if (input == null) return false;
            if (this.OneClickAlarmId != input.OneClickAlarmId || (this.OneClickAlarmId != null && !this.OneClickAlarmId.Equals(input.OneClickAlarmId))) return false;

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
                if (this.OneClickAlarmId != null) hashCode = hashCode * 59 + this.OneClickAlarmId.GetHashCode();
                return hashCode;
            }
        }
    }
}
