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
    public class AlarmTemplateSpecItem 
    {

        /// <summary>
        /// 告警模板下单个告警规则名称。
        /// </summary>
        [JsonProperty("alarm_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTemplateName { get; set; }

        /// <summary>
        /// 告警模板下单个告警规则英文名称。
        /// </summary>
        [JsonProperty("alarm_template_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTemplateNameEn { get; set; }

        /// <summary>
        /// 告警模板下单个告警规则描述。
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 告警模板下单个告警规则英文描述。
        /// </summary>
        [JsonProperty("desc_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DescEn { get; set; }

        /// <summary>
        /// 告警模板下单个告警规则类型。 “metric”：指标告警 “event”：事件告警
        /// </summary>
        [JsonProperty("alarm_template_spec_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTemplateSpecType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric_alarm_template_spec", NullValueHandling = NullValueHandling.Ignore)]
        public MetricAlarmTemplateSpec MetricAlarmTemplateSpec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event_alarm_template_spec", NullValueHandling = NullValueHandling.Ignore)]
        public EventAlarmTemplateSpec EventAlarmTemplateSpec { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmTemplateSpecItem {\n");
            sb.Append("  alarmTemplateName: ").Append(AlarmTemplateName).Append("\n");
            sb.Append("  alarmTemplateNameEn: ").Append(AlarmTemplateNameEn).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  descEn: ").Append(DescEn).Append("\n");
            sb.Append("  alarmTemplateSpecType: ").Append(AlarmTemplateSpecType).Append("\n");
            sb.Append("  metricAlarmTemplateSpec: ").Append(MetricAlarmTemplateSpec).Append("\n");
            sb.Append("  eventAlarmTemplateSpec: ").Append(EventAlarmTemplateSpec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmTemplateSpecItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmTemplateSpecItem input)
        {
            if (input == null) return false;
            if (this.AlarmTemplateName != input.AlarmTemplateName || (this.AlarmTemplateName != null && !this.AlarmTemplateName.Equals(input.AlarmTemplateName))) return false;
            if (this.AlarmTemplateNameEn != input.AlarmTemplateNameEn || (this.AlarmTemplateNameEn != null && !this.AlarmTemplateNameEn.Equals(input.AlarmTemplateNameEn))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.DescEn != input.DescEn || (this.DescEn != null && !this.DescEn.Equals(input.DescEn))) return false;
            if (this.AlarmTemplateSpecType != input.AlarmTemplateSpecType || (this.AlarmTemplateSpecType != null && !this.AlarmTemplateSpecType.Equals(input.AlarmTemplateSpecType))) return false;
            if (this.MetricAlarmTemplateSpec != input.MetricAlarmTemplateSpec || (this.MetricAlarmTemplateSpec != null && !this.MetricAlarmTemplateSpec.Equals(input.MetricAlarmTemplateSpec))) return false;
            if (this.EventAlarmTemplateSpec != input.EventAlarmTemplateSpec || (this.EventAlarmTemplateSpec != null && !this.EventAlarmTemplateSpec.Equals(input.EventAlarmTemplateSpec))) return false;

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
                if (this.AlarmTemplateName != null) hashCode = hashCode * 59 + this.AlarmTemplateName.GetHashCode();
                if (this.AlarmTemplateNameEn != null) hashCode = hashCode * 59 + this.AlarmTemplateNameEn.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.DescEn != null) hashCode = hashCode * 59 + this.DescEn.GetHashCode();
                if (this.AlarmTemplateSpecType != null) hashCode = hashCode * 59 + this.AlarmTemplateSpecType.GetHashCode();
                if (this.MetricAlarmTemplateSpec != null) hashCode = hashCode * 59 + this.MetricAlarmTemplateSpec.GetHashCode();
                if (this.EventAlarmTemplateSpec != null) hashCode = hashCode * 59 + this.EventAlarmTemplateSpec.GetHashCode();
                return hashCode;
            }
        }
    }
}
