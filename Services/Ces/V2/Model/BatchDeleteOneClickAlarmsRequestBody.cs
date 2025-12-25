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
    /// 
    /// </summary>
    public class BatchDeleteOneClickAlarmsRequestBody 
    {

        /// <summary>
        /// **参数解释**： 需要批量删除的一键告警ID列表。 **约束限制**： 一键告警ID数量最多为100个，至少1个。 
        /// </summary>
        [JsonProperty("one_click_alarm_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OneClickAlarmIds { get; set; }

        /// <summary>
        /// **参数解释**： 操作类型。 **约束限制**： 不涉及。 **取值范围**： 枚举值。取值为disable - disable: 关闭一键告警 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteOneClickAlarmsRequestBody {\n");
            sb.Append("  oneClickAlarmIds: ").Append(OneClickAlarmIds).Append("\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteOneClickAlarmsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteOneClickAlarmsRequestBody input)
        {
            if (input == null) return false;
            if (this.OneClickAlarmIds != input.OneClickAlarmIds || (this.OneClickAlarmIds != null && input.OneClickAlarmIds != null && !this.OneClickAlarmIds.SequenceEqual(input.OneClickAlarmIds))) return false;
            if (this.ActionType != input.ActionType || (this.ActionType != null && !this.ActionType.Equals(input.ActionType))) return false;

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
                if (this.OneClickAlarmIds != null) hashCode = hashCode * 59 + this.OneClickAlarmIds.GetHashCode();
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
