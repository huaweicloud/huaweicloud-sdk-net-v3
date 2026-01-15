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
    /// 
    /// </summary>
    public class AlarmLogResponseAlarmLog 
    {

        /// <summary>
        /// 告警ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 告警状态 - ON：持续中 - OFF：已关闭
        /// </summary>
        [JsonProperty("alarmLife", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmLife { get; set; }

        /// <summary>
        /// 是否发送邮件
        /// </summary>
        [JsonProperty("sendEmail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendEmail { get; set; }

        /// <summary>
        /// 告警发生时间
        /// </summary>
        [JsonProperty("alarm_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTime { get; set; }

        /// <summary>
        /// 告警类型 - RISK_RULE：风险规则 - RISK_CPU：CPU超限 - RISK_MEMORY：内存超限 - RISK_DISK：磁盘超限 - RISK_DISK_CAPACITY：磁盘容量不足六个月 - RISK_BACKUP：备份失败 - AUDIT_QPS_OVERFLOW：流量超限入库延迟告警 - RISK_AGENT：Agent异常 - AUDIT_BACKUP_FAILED：实例备份失败(运维侧)
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmType { get; set; }

        /// <summary>
        /// 告警恢复时间
        /// </summary>
        [JsonProperty("alarm_fix_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmFixTime { get; set; }

        /// <summary>
        /// 告警确认状态 - DONE：已确认 - UNDO：未确认
        /// </summary>
        [JsonProperty("alarm_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmStatus { get; set; }

        /// <summary>
        /// 告警风险等级 - LOW：低 - MEDIUM：中 - HIGH：高
        /// </summary>
        [JsonProperty("alarm_risk", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRisk { get; set; }

        /// <summary>
        /// 告警描述信息
        /// </summary>
        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmLogResponseAlarmLog {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  alarmLife: ").Append(AlarmLife).Append("\n");
            sb.Append("  sendEmail: ").Append(SendEmail).Append("\n");
            sb.Append("  alarmTime: ").Append(AlarmTime).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  alarmFixTime: ").Append(AlarmFixTime).Append("\n");
            sb.Append("  alarmStatus: ").Append(AlarmStatus).Append("\n");
            sb.Append("  alarmRisk: ").Append(AlarmRisk).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmLogResponseAlarmLog);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmLogResponseAlarmLog input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AlarmLife != input.AlarmLife || (this.AlarmLife != null && !this.AlarmLife.Equals(input.AlarmLife))) return false;
            if (this.SendEmail != input.SendEmail || (this.SendEmail != null && !this.SendEmail.Equals(input.SendEmail))) return false;
            if (this.AlarmTime != input.AlarmTime || (this.AlarmTime != null && !this.AlarmTime.Equals(input.AlarmTime))) return false;
            if (this.AlarmType != input.AlarmType || (this.AlarmType != null && !this.AlarmType.Equals(input.AlarmType))) return false;
            if (this.AlarmFixTime != input.AlarmFixTime || (this.AlarmFixTime != null && !this.AlarmFixTime.Equals(input.AlarmFixTime))) return false;
            if (this.AlarmStatus != input.AlarmStatus || (this.AlarmStatus != null && !this.AlarmStatus.Equals(input.AlarmStatus))) return false;
            if (this.AlarmRisk != input.AlarmRisk || (this.AlarmRisk != null && !this.AlarmRisk.Equals(input.AlarmRisk))) return false;
            if (this.AlarmDescription != input.AlarmDescription || (this.AlarmDescription != null && !this.AlarmDescription.Equals(input.AlarmDescription))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AlarmLife != null) hashCode = hashCode * 59 + this.AlarmLife.GetHashCode();
                if (this.SendEmail != null) hashCode = hashCode * 59 + this.SendEmail.GetHashCode();
                if (this.AlarmTime != null) hashCode = hashCode * 59 + this.AlarmTime.GetHashCode();
                if (this.AlarmType != null) hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.AlarmFixTime != null) hashCode = hashCode * 59 + this.AlarmFixTime.GetHashCode();
                if (this.AlarmStatus != null) hashCode = hashCode * 59 + this.AlarmStatus.GetHashCode();
                if (this.AlarmRisk != null) hashCode = hashCode * 59 + this.AlarmRisk.GetHashCode();
                if (this.AlarmDescription != null) hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
