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
    public class MetricAlarmTemplateSpec 
    {

        /// <summary>
        /// 告警规则类别。
        /// </summary>
        [JsonProperty("alarm_subtype", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmSubtype { get; set; }

        /// <summary>
        /// 告警规则来源云服务：CCE 创建标识。
        /// </summary>
        [JsonProperty("alarm_source", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmSource { get; set; }

        /// <summary>
        /// 监控类型。
        /// </summary>
        [JsonProperty("monitor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MonitorType { get; set; }

        /// <summary>
        /// 触发条件。
        /// </summary>
        [JsonProperty("trigger_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateTriggerCondition> TriggerConditions { get; set; }

        /// <summary>
        /// 数据不足条件。
        /// </summary>
        [JsonProperty("no_data_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NoDataCondition> NoDataConditions { get; set; }

        /// <summary>
        /// 告警标签。
        /// </summary>
        [JsonProperty("alarm_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmTags> AlarmTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("recovery_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public RecoveryCondition RecoveryConditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricAlarmTemplateSpec {\n");
            sb.Append("  alarmSubtype: ").Append(AlarmSubtype).Append("\n");
            sb.Append("  alarmSource: ").Append(AlarmSource).Append("\n");
            sb.Append("  monitorType: ").Append(MonitorType).Append("\n");
            sb.Append("  triggerConditions: ").Append(TriggerConditions).Append("\n");
            sb.Append("  noDataConditions: ").Append(NoDataConditions).Append("\n");
            sb.Append("  alarmTags: ").Append(AlarmTags).Append("\n");
            sb.Append("  recoveryConditions: ").Append(RecoveryConditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricAlarmTemplateSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricAlarmTemplateSpec input)
        {
            if (input == null) return false;
            if (this.AlarmSubtype != input.AlarmSubtype || (this.AlarmSubtype != null && !this.AlarmSubtype.Equals(input.AlarmSubtype))) return false;
            if (this.AlarmSource != input.AlarmSource || (this.AlarmSource != null && !this.AlarmSource.Equals(input.AlarmSource))) return false;
            if (this.MonitorType != input.MonitorType || (this.MonitorType != null && !this.MonitorType.Equals(input.MonitorType))) return false;
            if (this.TriggerConditions != input.TriggerConditions || (this.TriggerConditions != null && input.TriggerConditions != null && !this.TriggerConditions.SequenceEqual(input.TriggerConditions))) return false;
            if (this.NoDataConditions != input.NoDataConditions || (this.NoDataConditions != null && input.NoDataConditions != null && !this.NoDataConditions.SequenceEqual(input.NoDataConditions))) return false;
            if (this.AlarmTags != input.AlarmTags || (this.AlarmTags != null && input.AlarmTags != null && !this.AlarmTags.SequenceEqual(input.AlarmTags))) return false;
            if (this.RecoveryConditions != input.RecoveryConditions || (this.RecoveryConditions != null && !this.RecoveryConditions.Equals(input.RecoveryConditions))) return false;

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
                if (this.AlarmSubtype != null) hashCode = hashCode * 59 + this.AlarmSubtype.GetHashCode();
                if (this.AlarmSource != null) hashCode = hashCode * 59 + this.AlarmSource.GetHashCode();
                if (this.MonitorType != null) hashCode = hashCode * 59 + this.MonitorType.GetHashCode();
                if (this.TriggerConditions != null) hashCode = hashCode * 59 + this.TriggerConditions.GetHashCode();
                if (this.NoDataConditions != null) hashCode = hashCode * 59 + this.NoDataConditions.GetHashCode();
                if (this.AlarmTags != null) hashCode = hashCode * 59 + this.AlarmTags.GetHashCode();
                if (this.RecoveryConditions != null) hashCode = hashCode * 59 + this.RecoveryConditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
