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
    public class BatchEnableAlarmPoliciesRequestBody 
    {

        /// <summary>
        /// 需要批量启停的告警规则策略的ID列表
        /// </summary>
        [JsonProperty("alarm_policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmPolicyIds { get; set; }

        /// <summary>
        /// 是否启用告警策略。true:开启，false：关闭。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 告警中的策略全部被停用时是否保留策略信息。true:保留；false:删除。
        /// </summary>
        [JsonProperty("retain_when_all_disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RetainWhenAllDisabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchEnableAlarmPoliciesRequestBody {\n");
            sb.Append("  alarmPolicyIds: ").Append(AlarmPolicyIds).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  retainWhenAllDisabled: ").Append(RetainWhenAllDisabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchEnableAlarmPoliciesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchEnableAlarmPoliciesRequestBody input)
        {
            if (input == null) return false;
            if (this.AlarmPolicyIds != input.AlarmPolicyIds || (this.AlarmPolicyIds != null && input.AlarmPolicyIds != null && !this.AlarmPolicyIds.SequenceEqual(input.AlarmPolicyIds))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.RetainWhenAllDisabled != input.RetainWhenAllDisabled || (this.RetainWhenAllDisabled != null && !this.RetainWhenAllDisabled.Equals(input.RetainWhenAllDisabled))) return false;

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
                if (this.AlarmPolicyIds != null) hashCode = hashCode * 59 + this.AlarmPolicyIds.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RetainWhenAllDisabled != null) hashCode = hashCode * 59 + this.RetainWhenAllDisabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
