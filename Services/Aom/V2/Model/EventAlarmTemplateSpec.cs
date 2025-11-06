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
    public class EventAlarmTemplateSpec 
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
        /// 告警来源。
        /// </summary>
        [JsonProperty("event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSource { get; set; }

        /// <summary>
        /// 监控对象模板（创建告警时需要补齐里面的内容）。
        /// </summary>
        [JsonProperty("monitor_object_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MonitorObjectTemplates { get; set; }

        /// <summary>
        /// 监控对象列表。键值对形式，键值为： - “event_type”：通知类型 - “event_severity”：告警级别 - “event_name”：事件名称 - “namespace”：命名空间 - “clusterId”：集群id - “customField”：用户自定义字段
        /// </summary>
        [JsonProperty("monitor_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, string>> MonitorObjects { get; set; }

        /// <summary>
        /// 触发条件。
        /// </summary>
        [JsonProperty("trigger_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventTriggerCondition> TriggerConditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventAlarmTemplateSpec {\n");
            sb.Append("  alarmSubtype: ").Append(AlarmSubtype).Append("\n");
            sb.Append("  alarmSource: ").Append(AlarmSource).Append("\n");
            sb.Append("  eventSource: ").Append(EventSource).Append("\n");
            sb.Append("  monitorObjectTemplates: ").Append(MonitorObjectTemplates).Append("\n");
            sb.Append("  monitorObjects: ").Append(MonitorObjects).Append("\n");
            sb.Append("  triggerConditions: ").Append(TriggerConditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventAlarmTemplateSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventAlarmTemplateSpec input)
        {
            if (input == null) return false;
            if (this.AlarmSubtype != input.AlarmSubtype || (this.AlarmSubtype != null && !this.AlarmSubtype.Equals(input.AlarmSubtype))) return false;
            if (this.AlarmSource != input.AlarmSource || (this.AlarmSource != null && !this.AlarmSource.Equals(input.AlarmSource))) return false;
            if (this.EventSource != input.EventSource || (this.EventSource != null && !this.EventSource.Equals(input.EventSource))) return false;
            if (this.MonitorObjectTemplates != input.MonitorObjectTemplates || (this.MonitorObjectTemplates != null && input.MonitorObjectTemplates != null && !this.MonitorObjectTemplates.SequenceEqual(input.MonitorObjectTemplates))) return false;
            if (this.MonitorObjects != input.MonitorObjects || (this.MonitorObjects != null && input.MonitorObjects != null && !this.MonitorObjects.SequenceEqual(input.MonitorObjects))) return false;
            if (this.TriggerConditions != input.TriggerConditions || (this.TriggerConditions != null && input.TriggerConditions != null && !this.TriggerConditions.SequenceEqual(input.TriggerConditions))) return false;

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
                if (this.EventSource != null) hashCode = hashCode * 59 + this.EventSource.GetHashCode();
                if (this.MonitorObjectTemplates != null) hashCode = hashCode * 59 + this.MonitorObjectTemplates.GetHashCode();
                if (this.MonitorObjects != null) hashCode = hashCode * 59 + this.MonitorObjects.GetHashCode();
                if (this.TriggerConditions != null) hashCode = hashCode * 59 + this.TriggerConditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
