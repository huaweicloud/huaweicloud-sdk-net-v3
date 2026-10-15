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
    /// 关联SMN主题请求体
    /// </summary>
    public class AssociateSmnTopicReqV5 
    {

        /// <summary>
        /// 主题资源标识
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 增量时延阈值, 单位：秒（s）
        /// </summary>
        [JsonProperty("increment_delay_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? IncrementDelayThreshold { get; set; }

        /// <summary>
        /// RTO时延阈值，灾备场景下可配置，单位：秒（s）
        /// </summary>
        [JsonProperty("rto_delay_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? RtoDelayThreshold { get; set; }

        /// <summary>
        /// RPO时延阈值，灾备场景下可配置，单位：秒（s）
        /// </summary>
        [JsonProperty("rpo_delay_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public long? RpoDelayThreshold { get; set; }

        /// <summary>
        /// 异常告警是否通知用户，取值范围[true,false]
        /// </summary>
        [JsonProperty("is_alarm_to_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAlarmToUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateSmnTopicReqV5 {\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  incrementDelayThreshold: ").Append(IncrementDelayThreshold).Append("\n");
            sb.Append("  rtoDelayThreshold: ").Append(RtoDelayThreshold).Append("\n");
            sb.Append("  rpoDelayThreshold: ").Append(RpoDelayThreshold).Append("\n");
            sb.Append("  isAlarmToUser: ").Append(IsAlarmToUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateSmnTopicReqV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateSmnTopicReqV5 input)
        {
            if (input == null) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.IncrementDelayThreshold != input.IncrementDelayThreshold || (this.IncrementDelayThreshold != null && !this.IncrementDelayThreshold.Equals(input.IncrementDelayThreshold))) return false;
            if (this.RtoDelayThreshold != input.RtoDelayThreshold || (this.RtoDelayThreshold != null && !this.RtoDelayThreshold.Equals(input.RtoDelayThreshold))) return false;
            if (this.RpoDelayThreshold != input.RpoDelayThreshold || (this.RpoDelayThreshold != null && !this.RpoDelayThreshold.Equals(input.RpoDelayThreshold))) return false;
            if (this.IsAlarmToUser != input.IsAlarmToUser || (this.IsAlarmToUser != null && !this.IsAlarmToUser.Equals(input.IsAlarmToUser))) return false;

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
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.IncrementDelayThreshold != null) hashCode = hashCode * 59 + this.IncrementDelayThreshold.GetHashCode();
                if (this.RtoDelayThreshold != null) hashCode = hashCode * 59 + this.RtoDelayThreshold.GetHashCode();
                if (this.RpoDelayThreshold != null) hashCode = hashCode * 59 + this.RpoDelayThreshold.GetHashCode();
                if (this.IsAlarmToUser != null) hashCode = hashCode * 59 + this.IsAlarmToUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
