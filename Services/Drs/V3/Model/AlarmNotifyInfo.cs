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
    /// 异常通知信息
    /// </summary>
    public class AlarmNotifyInfo 
    {

        /// <summary>
        /// 订阅延迟时间(单位为s)
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DelayTime { get; set; }

        /// <summary>
        /// rto延迟时间
        /// </summary>
        [JsonProperty("rto_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? RtoDelay { get; set; }

        /// <summary>
        /// rpo延迟时间
        /// </summary>
        [JsonProperty("rpo_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? RpoDelay { get; set; }

        /// <summary>
        /// 异常告警是否通知用户
        /// </summary>
        [JsonProperty("alarm_to_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmToUser { get; set; }

        /// <summary>
        /// 收件方式与信息体
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
            if (input == null)
                return false;

            return 
                (
                    this.DelayTime == input.DelayTime ||
                    (this.DelayTime != null &&
                    this.DelayTime.Equals(input.DelayTime))
                ) && 
                (
                    this.RtoDelay == input.RtoDelay ||
                    (this.RtoDelay != null &&
                    this.RtoDelay.Equals(input.RtoDelay))
                ) && 
                (
                    this.RpoDelay == input.RpoDelay ||
                    (this.RpoDelay != null &&
                    this.RpoDelay.Equals(input.RpoDelay))
                ) && 
                (
                    this.AlarmToUser == input.AlarmToUser ||
                    (this.AlarmToUser != null &&
                    this.AlarmToUser.Equals(input.AlarmToUser))
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    input.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DelayTime != null)
                    hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.RtoDelay != null)
                    hashCode = hashCode * 59 + this.RtoDelay.GetHashCode();
                if (this.RpoDelay != null)
                    hashCode = hashCode * 59 + this.RpoDelay.GetHashCode();
                if (this.AlarmToUser != null)
                    hashCode = hashCode * 59 + this.AlarmToUser.GetHashCode();
                if (this.Subscriptions != null)
                    hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
