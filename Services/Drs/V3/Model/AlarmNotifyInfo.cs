using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 异常通知信息。
    /// </summary>
    public class AlarmNotifyInfo 
    {

        /// <summary>
        /// **参数解释**：  订阅延迟时间，即异常告警通知的延迟时间，单位为秒。  **约束限制**：  不涉及。  **取值范围**：  1-3600。  **默认取值**：  0
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DelayTime { get; set; }

        /// <summary>
        /// **参数解释**：  RTO（Recovery Time Objective，恢复时间目标）延迟时间，即容灾恢复时间目标的延迟阈值，单位为秒。  **约束限制**：  不涉及。  **取值范围**：  1-3600。  **默认取值**：  0
        /// </summary>
        [JsonProperty("rto_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? RtoDelay { get; set; }

        /// <summary>
        /// **参数解释**：  RPO（Recovery Point Objective，恢复点目标）延迟时间，即容灾恢复点目标的延迟阈值，单位为秒。  **约束限制**：  不涉及。  **取值范围**：  1-3600。  **默认取值**：  0
        /// </summary>
        [JsonProperty("rpo_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? RpoDelay { get; set; }

        /// <summary>
        /// **参数解释**：  异常告警是否通知用户。  **约束限制**：  不涉及。  **取值范围**：  - true：通知用户 - false：不通知用户  **默认取值**：  false
        /// </summary>
        [JsonProperty("alarm_to_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmToUser { get; set; }

        /// <summary>
        /// **参数解释**：  收件方式与信息体列表，用于配置异常告警的通知渠道，最多填写两个，详情请参见SubscriptionInfo对象定义。  **约束限制**：  - 最多填写两个。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubscriptionInfo> Subscriptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmNotifyInfo {\n");
            sb.Append("  delayTime: ").Append(DelayTime).Append("\n");
            sb.Append("  rtoDelay: ").Append(RtoDelay).Append("\n");
            sb.Append("  rpoDelay: ").Append(RpoDelay).Append("\n");
            sb.Append("  alarmToUser: ").Append(AlarmToUser).Append("\n");
            sb.Append("  subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmNotifyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmNotifyInfo input)
        {
            if (input == null) return false;
            if (this.DelayTime != input.DelayTime || (this.DelayTime != null && !this.DelayTime.Equals(input.DelayTime))) return false;
            if (this.RtoDelay != input.RtoDelay || (this.RtoDelay != null && !this.RtoDelay.Equals(input.RtoDelay))) return false;
            if (this.RpoDelay != input.RpoDelay || (this.RpoDelay != null && !this.RpoDelay.Equals(input.RpoDelay))) return false;
            if (this.AlarmToUser != input.AlarmToUser || (this.AlarmToUser != null && !this.AlarmToUser.Equals(input.AlarmToUser))) return false;
            if (this.Subscriptions != input.Subscriptions || (this.Subscriptions != null && input.Subscriptions != null && !this.Subscriptions.SequenceEqual(input.Subscriptions))) return false;

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
                if (this.DelayTime != null) hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.RtoDelay != null) hashCode = hashCode * 59 + this.RtoDelay.GetHashCode();
                if (this.RpoDelay != null) hashCode = hashCode * 59 + this.RpoDelay.GetHashCode();
                if (this.AlarmToUser != null) hashCode = hashCode * 59 + this.AlarmToUser.GetHashCode();
                if (this.Subscriptions != null) hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
