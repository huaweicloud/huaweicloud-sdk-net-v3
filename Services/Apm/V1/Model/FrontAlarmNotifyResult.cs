using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 告警通知内容。
    /// </summary>
    public class FrontAlarmNotifyResult 
    {

        /// <summary>
        /// 告警通知id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 通知类型。
        /// </summary>
        [JsonProperty("notify_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyType { get; set; }

        /// <summary>
        /// 告警规则id。
        /// </summary>
        [JsonProperty("alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmRuleId { get; set; }

        /// <summary>
        /// 模板id。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// 关联事件id。
        /// </summary>
        [JsonProperty("alarm_data_event_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmDataEventId { get; set; }

        /// <summary>
        /// 通知结果。
        /// </summary>
        [JsonProperty("notify_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyStatus { get; set; }

        /// <summary>
        /// 通知内容。
        /// </summary>
        [JsonProperty("alarm_content", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrontAlarmNotifyResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  notifyType: ").Append(NotifyType).Append("\n");
            sb.Append("  alarmRuleId: ").Append(AlarmRuleId).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  alarmDataEventId: ").Append(AlarmDataEventId).Append("\n");
            sb.Append("  notifyStatus: ").Append(NotifyStatus).Append("\n");
            sb.Append("  alarmContent: ").Append(AlarmContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FrontAlarmNotifyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrontAlarmNotifyResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GmtCreate != input.GmtCreate || (this.GmtCreate != null && !this.GmtCreate.Equals(input.GmtCreate))) return false;
            if (this.NotifyType != input.NotifyType || (this.NotifyType != null && !this.NotifyType.Equals(input.NotifyType))) return false;
            if (this.AlarmRuleId != input.AlarmRuleId || (this.AlarmRuleId != null && !this.AlarmRuleId.Equals(input.AlarmRuleId))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.AlarmDataEventId != input.AlarmDataEventId || (this.AlarmDataEventId != null && !this.AlarmDataEventId.Equals(input.AlarmDataEventId))) return false;
            if (this.NotifyStatus != input.NotifyStatus || (this.NotifyStatus != null && !this.NotifyStatus.Equals(input.NotifyStatus))) return false;
            if (this.AlarmContent != input.AlarmContent || (this.AlarmContent != null && !this.AlarmContent.Equals(input.AlarmContent))) return false;

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
                if (this.GmtCreate != null) hashCode = hashCode * 59 + this.GmtCreate.GetHashCode();
                if (this.NotifyType != null) hashCode = hashCode * 59 + this.NotifyType.GetHashCode();
                if (this.AlarmRuleId != null) hashCode = hashCode * 59 + this.AlarmRuleId.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.AlarmDataEventId != null) hashCode = hashCode * 59 + this.AlarmDataEventId.GetHashCode();
                if (this.NotifyStatus != null) hashCode = hashCode * 59 + this.NotifyStatus.GetHashCode();
                if (this.AlarmContent != null) hashCode = hashCode * 59 + this.AlarmContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
