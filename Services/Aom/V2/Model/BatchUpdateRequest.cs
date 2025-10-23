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
    public class BatchUpdateRequest 
    {

        /// <summary>
        /// 批量启停的告警规则列表。批量启停告警规则时，该参数必填。
        /// </summary>
        [JsonProperty("alarm_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchAlarmRulesBody> AlarmRules { get; set; }

        /// <summary>
        /// 批量修改告警行动规则的告警规则列表。批量修改告警行动规则时，该参数必填。
        /// </summary>
        [JsonProperty("update_action_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchUpdateActionRules> UpdateActionRules { get; set; }

        /// <summary>
        /// 更新类型：BATCH_UPDATE_ACTION_RULE。批量修改告警行动规则时，该参数必填。
        /// </summary>
        [JsonProperty("update_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateRequest {\n");
            sb.Append("  alarmRules: ").Append(AlarmRules).Append("\n");
            sb.Append("  updateActionRules: ").Append(UpdateActionRules).Append("\n");
            sb.Append("  updateType: ").Append(UpdateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateRequest input)
        {
            if (input == null) return false;
            if (this.AlarmRules != input.AlarmRules || (this.AlarmRules != null && input.AlarmRules != null && !this.AlarmRules.SequenceEqual(input.AlarmRules))) return false;
            if (this.UpdateActionRules != input.UpdateActionRules || (this.UpdateActionRules != null && input.UpdateActionRules != null && !this.UpdateActionRules.SequenceEqual(input.UpdateActionRules))) return false;
            if (this.UpdateType != input.UpdateType || (this.UpdateType != null && !this.UpdateType.Equals(input.UpdateType))) return false;

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
                if (this.UpdateActionRules != null) hashCode = hashCode * 59 + this.UpdateActionRules.GetHashCode();
                if (this.UpdateType != null) hashCode = hashCode * 59 + this.UpdateType.GetHashCode();
                return hashCode;
            }
        }
    }
}
