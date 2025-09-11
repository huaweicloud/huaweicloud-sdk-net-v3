using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAlarmTopicConfigInfoNewResponse : SdkResponse
    {

        /// <summary>
        /// CPU告警阈值(%)
        /// </summary>
        [JsonProperty("alarm_cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmCpu { get; set; }

        /// <summary>
        /// 磁盘告警阈值(%)
        /// </summary>
        [JsonProperty("alarm_disk", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDisk { get; set; }

        /// <summary>
        /// 内存告警阈值(%)
        /// </summary>
        [JsonProperty("alarm_memory", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmMemory { get; set; }

        /// <summary>
        /// 每天发送告警总条数
        /// </summary>
        [JsonProperty("alarm_num", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmNum { get; set; }

        /// <summary>
        /// 告警等级 - high：高  - medium：中  - low：低
        /// </summary>
        [JsonProperty("alarm_risk", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmRisk { get; set; }

        /// <summary>
        /// 通知开关 - ON：开启 - OFF：关闭
        /// </summary>
        [JsonProperty("alarm_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmSwitch { get; set; }

        /// <summary>
        /// 通知消息主题URN,调用SMN服务接口获取
        /// </summary>
        [JsonProperty("alarm_topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTopicUrn { get; set; }

        /// <summary>
        /// 是否支持SMN订阅  - true: 支持  - false: 不支持
        /// </summary>
        [JsonProperty("smn_effective", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnEffective { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmTopicConfigInfoNewResponse {\n");
            sb.Append("  alarmCpu: ").Append(AlarmCpu).Append("\n");
            sb.Append("  alarmDisk: ").Append(AlarmDisk).Append("\n");
            sb.Append("  alarmMemory: ").Append(AlarmMemory).Append("\n");
            sb.Append("  alarmNum: ").Append(AlarmNum).Append("\n");
            sb.Append("  alarmRisk: ").Append(AlarmRisk).Append("\n");
            sb.Append("  alarmSwitch: ").Append(AlarmSwitch).Append("\n");
            sb.Append("  alarmTopicUrn: ").Append(AlarmTopicUrn).Append("\n");
            sb.Append("  smnEffective: ").Append(SmnEffective).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmTopicConfigInfoNewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmTopicConfigInfoNewResponse input)
        {
            if (input == null) return false;
            if (this.AlarmCpu != input.AlarmCpu || (this.AlarmCpu != null && !this.AlarmCpu.Equals(input.AlarmCpu))) return false;
            if (this.AlarmDisk != input.AlarmDisk || (this.AlarmDisk != null && !this.AlarmDisk.Equals(input.AlarmDisk))) return false;
            if (this.AlarmMemory != input.AlarmMemory || (this.AlarmMemory != null && !this.AlarmMemory.Equals(input.AlarmMemory))) return false;
            if (this.AlarmNum != input.AlarmNum || (this.AlarmNum != null && !this.AlarmNum.Equals(input.AlarmNum))) return false;
            if (this.AlarmRisk != input.AlarmRisk || (this.AlarmRisk != null && input.AlarmRisk != null && !this.AlarmRisk.SequenceEqual(input.AlarmRisk))) return false;
            if (this.AlarmSwitch != input.AlarmSwitch || (this.AlarmSwitch != null && !this.AlarmSwitch.Equals(input.AlarmSwitch))) return false;
            if (this.AlarmTopicUrn != input.AlarmTopicUrn || (this.AlarmTopicUrn != null && !this.AlarmTopicUrn.Equals(input.AlarmTopicUrn))) return false;
            if (this.SmnEffective != input.SmnEffective || (this.SmnEffective != null && !this.SmnEffective.Equals(input.SmnEffective))) return false;

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
                if (this.AlarmCpu != null) hashCode = hashCode * 59 + this.AlarmCpu.GetHashCode();
                if (this.AlarmDisk != null) hashCode = hashCode * 59 + this.AlarmDisk.GetHashCode();
                if (this.AlarmMemory != null) hashCode = hashCode * 59 + this.AlarmMemory.GetHashCode();
                if (this.AlarmNum != null) hashCode = hashCode * 59 + this.AlarmNum.GetHashCode();
                if (this.AlarmRisk != null) hashCode = hashCode * 59 + this.AlarmRisk.GetHashCode();
                if (this.AlarmSwitch != null) hashCode = hashCode * 59 + this.AlarmSwitch.GetHashCode();
                if (this.AlarmTopicUrn != null) hashCode = hashCode * 59 + this.AlarmTopicUrn.GetHashCode();
                if (this.SmnEffective != null) hashCode = hashCode * 59 + this.SmnEffective.GetHashCode();
                return hashCode;
            }
        }
    }
}
