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
    public class BatchUpdateOneClickAlarmsEnabledStateRequestBody 
    {

        /// <summary>
        /// **参数解释** 需要批量启停的告警规则的ID列表 **约束限制** 包含的告警规则ID个数为1到100 
        /// </summary>
        [JsonProperty("alarm_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmIds { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启告警规则。     **约束限制**： 不涉及。 **取值范围**： 布尔值。 - true:开启。 - false:关闭。 **默认取值**： true 
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }

        /// <summary>
        /// **参数解释** 一键告警中的规则全部被停用时是否保留规则信息 **约束限制** 不涉及 **取值范围** - true:保留规则信息 - false:不保留规则信息 **默认取值** false 
        /// </summary>
        [JsonProperty("retain_when_all_disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RetainWhenAllDisabled { get; set; }

        /// <summary>
        /// **参数解释** 当传此参数时，将会批量停用一键告警规则 **约束限制** 不涉及 **取值范围** - disable: 表示将会批量停用一键告警规则 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateOneClickAlarmsEnabledStateRequestBody {\n");
            sb.Append("  alarmIds: ").Append(AlarmIds).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  retainWhenAllDisabled: ").Append(RetainWhenAllDisabled).Append("\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateOneClickAlarmsEnabledStateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateOneClickAlarmsEnabledStateRequestBody input)
        {
            if (input == null) return false;
            if (this.AlarmIds != input.AlarmIds || (this.AlarmIds != null && input.AlarmIds != null && !this.AlarmIds.SequenceEqual(input.AlarmIds))) return false;
            if (this.AlarmEnabled != input.AlarmEnabled || (this.AlarmEnabled != null && !this.AlarmEnabled.Equals(input.AlarmEnabled))) return false;
            if (this.RetainWhenAllDisabled != input.RetainWhenAllDisabled || (this.RetainWhenAllDisabled != null && !this.RetainWhenAllDisabled.Equals(input.RetainWhenAllDisabled))) return false;
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
                if (this.AlarmIds != null) hashCode = hashCode * 59 + this.AlarmIds.GetHashCode();
                if (this.AlarmEnabled != null) hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.RetainWhenAllDisabled != null) hashCode = hashCode * 59 + this.RetainWhenAllDisabled.GetHashCode();
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
