using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSmnSubscriptionDetailResponse : SdkResponse
    {

        /// <summary>
        /// SMN主题名称
        /// </summary>
        [JsonProperty("topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicName { get; set; }

        /// <summary>
        /// SMN主题的唯一资源标识
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 延迟时间，单位秒
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// RPO延迟时间，单位秒
        /// </summary>
        [JsonProperty("rpo_delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? RpoDelay { get; set; }

        /// <summary>
        /// RTO延迟时间，单位秒
        /// </summary>
        [JsonProperty("rto_delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? RtoDelay { get; set; }

        /// <summary>
        /// 是否发送告警给订阅用户
        /// </summary>
        [JsonProperty("is_alarm_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAlarmUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSmnSubscriptionDetailResponse {\n");
            sb.Append("  topicName: ").Append(TopicName).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  delayTime: ").Append(DelayTime).Append("\n");
            sb.Append("  rpoDelay: ").Append(RpoDelay).Append("\n");
            sb.Append("  rtoDelay: ").Append(RtoDelay).Append("\n");
            sb.Append("  isAlarmUser: ").Append(IsAlarmUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSmnSubscriptionDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSmnSubscriptionDetailResponse input)
        {
            if (input == null) return false;
            if (this.TopicName != input.TopicName || (this.TopicName != null && !this.TopicName.Equals(input.TopicName))) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.DelayTime != input.DelayTime || (this.DelayTime != null && !this.DelayTime.Equals(input.DelayTime))) return false;
            if (this.RpoDelay != input.RpoDelay || (this.RpoDelay != null && !this.RpoDelay.Equals(input.RpoDelay))) return false;
            if (this.RtoDelay != input.RtoDelay || (this.RtoDelay != null && !this.RtoDelay.Equals(input.RtoDelay))) return false;
            if (this.IsAlarmUser != input.IsAlarmUser || (this.IsAlarmUser != null && !this.IsAlarmUser.Equals(input.IsAlarmUser))) return false;

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
                if (this.TopicName != null) hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.DelayTime != null) hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.RpoDelay != null) hashCode = hashCode * 59 + this.RpoDelay.GetHashCode();
                if (this.RtoDelay != null) hashCode = hashCode * 59 + this.RtoDelay.GetHashCode();
                if (this.IsAlarmUser != null) hashCode = hashCode * 59 + this.IsAlarmUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
