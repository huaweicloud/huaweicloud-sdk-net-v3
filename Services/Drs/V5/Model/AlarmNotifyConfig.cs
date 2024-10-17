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
    /// 异常通知信息设置信息体。配置该参数时，代表当任务状态异常时，系统将发送通知给指定的SMN Topic。
    /// </summary>
    public class AlarmNotifyConfig 
    {

        /// <summary>
        /// 异常告警是否通知用户。
        /// </summary>
        [JsonProperty("alarm_to_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmToUser { get; set; }

        /// <summary>
        /// SMN主题URN。
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 时延阈值(单位为s)。取值： - 最小值：1 - 最大值：3600 - 缺省值：0 - 说明： 1.源数据库和目标数据库之间的同步有时会存在一个时间差，称为时延，单位为秒。 2.时延阈值设置是指时延超过一定的值并持续6分钟后，DRS可以发送通知给指定收件人。（初次进入增量迁移阶段，会有较多数据等待同步，存在较大的时延，属于正常情况，不在此功能的监控范围之内。） 3.只有全量+增量的任务支持此选项。
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DelayTime { get; set; }

        /// <summary>
        /// RPO时延阈值(单位为s)。取值： - 最小值：1 - 最大值：3600 - 缺省值：0 - 说明： RPO时延阈值设置是业务数据库与DRS实例间同步的时延超过一定的值并持续6分钟后，DRS可以发送通知给指定收件人。（初次进入增量灾备阶段，会有较多数据等待同步，存在较大的时延，属于正常情况，不在此功能的监控范围之内。）
        /// </summary>
        [JsonProperty("rpo_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? RpoDelay { get; set; }

        /// <summary>
        /// RTO时延阈值(s)。取值： - 最小值：1 - 最大值：3600 - 缺省值：0 - 说明： RTO时延阈值设置是DRS实例与灾备数据库间同步的时延超过一定的值并持续6分钟后，DRS可以发送通知给指定收件人。
        /// </summary>
        [JsonProperty("rto_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? RtoDelay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmNotifyConfig {\n");
            sb.Append("  alarmToUser: ").Append(AlarmToUser).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  delayTime: ").Append(DelayTime).Append("\n");
            sb.Append("  rpoDelay: ").Append(RpoDelay).Append("\n");
            sb.Append("  rtoDelay: ").Append(RtoDelay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmNotifyConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmNotifyConfig input)
        {
            if (input == null) return false;
            if (this.AlarmToUser != input.AlarmToUser || (this.AlarmToUser != null && !this.AlarmToUser.Equals(input.AlarmToUser))) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.DelayTime != input.DelayTime || (this.DelayTime != null && !this.DelayTime.Equals(input.DelayTime))) return false;
            if (this.RpoDelay != input.RpoDelay || (this.RpoDelay != null && !this.RpoDelay.Equals(input.RpoDelay))) return false;
            if (this.RtoDelay != input.RtoDelay || (this.RtoDelay != null && !this.RtoDelay.Equals(input.RtoDelay))) return false;

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
                if (this.AlarmToUser != null) hashCode = hashCode * 59 + this.AlarmToUser.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.DelayTime != null) hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.RpoDelay != null) hashCode = hashCode * 59 + this.RpoDelay.GetHashCode();
                if (this.RtoDelay != null) hashCode = hashCode * 59 + this.RtoDelay.GetHashCode();
                return hashCode;
            }
        }
    }
}
