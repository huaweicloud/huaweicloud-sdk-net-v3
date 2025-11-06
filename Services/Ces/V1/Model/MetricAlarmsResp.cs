using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MetricAlarmsResp 
    {

        /// <summary>
        /// **参数解释**： 告警名称。 **取值范围**： 只能包含0-9/a-z/A-Z/_/-或汉字，字符长度为[1,128]。 
        /// </summary>
        [JsonProperty("alarm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmName { get; set; }

        /// <summary>
        /// **参数解释**： 告警描述。 **取值范围**： 长度[0,256]个字符。 
        /// </summary>
        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public ListAlarmMetricResp Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionResp Condition { get; set; }

        /// <summary>
        /// **参数解释**： 是否启用该条告警。 **取值范围**： 布尔值。 true:开启。 false:关闭。 
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 告警级别。 **取值范围**： 级别为1、2、3、4。分别对应紧急、重要、次要、提示。 
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }

        /// <summary>
        /// **参数解释**： 告警类型。 **取值范围**： 针对事件类型的告警时，告警类型为EVENT.SYS（系统事件）或EVENT.CUSTOM（自定义事件）。 针对资源分组的告警时，告警类型为RESOURCE_GROUP。 针对指定资源的告警时，告警类型为MULTI_INSTANCE。 - EVENT.SYS：针对系统事件的告警类型 - EVENT.CUSTOM：针对自定义事件的告警类型 - RESOURCE_GROUP：针对资源分组的告警类型 - MULTI_INSTANCE：指定资源的告警类型 
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmType { get; set; }

        /// <summary>
        /// **参数解释**： 该条告警触发时，是否开启告警通知。 **取值范围**： 布尔值。 - true：开启告警通知。 - false：不开启告警通知。 
        /// </summary>
        [JsonProperty("alarm_action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmActionEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 告警触发时，通知组/主题订阅的信息。 
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotificationResp> AlarmActions { get; set; }

        /// <summary>
        /// **参数解释**： 告警触发时，通知组/主题订阅的信息。 
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotificationResp> OkActions { get; set; }

        /// <summary>
        /// **参数解释**： 告警触发时，通知组/主题订阅的信息。 
        /// </summary>
        [JsonProperty("insufficientdata_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotificationResp> InsufficientdataActions { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则生效的开始时间，告警规则仅在生效时间内发送通知消息。例如alarm_action_begin_time为8:00，alarm_action_end_time为20:00时，则对应的告警规则仅在08:00-20:00发送通知消息。 **取值范围**： 只能包含数字、“:”，长度为[1,64]个字符。 
        /// </summary>
        [JsonProperty("alarm_action_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmActionBeginTime { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则生效的结束时间，告警规则仅在生效时间内发送通知消息。例如alarm_action_begin_time为8:00，alarm_action_end_time为20:00时，则对应的告警规则仅在08:00-20:00发送通知消息。 **取值范围**： 只能包含数字、“:”，长度为[1,64]个字符。 
        /// </summary>
        [JsonProperty("alarm_action_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmActionEndTime { get; set; }

        /// <summary>
        /// **参数解释**： 时区，形如：\&quot;GMT-08:00\&quot;、\&quot;GMT+08:00\&quot;、\&quot;GMT+0:00\&quot; **取值范围**： 长度为[1,16]个字符。 
        /// </summary>
        [JsonProperty("effective_timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTimezone { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则的ID。 **取值范围**： 以al开头，后跟22个数字或字母。字符长度为24 
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// **参数解释**： 告警状态变更的时间，UNIX时间戳，单位毫秒。 **取值范围** 0 - 9999999999999 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 告警状态。 **取值范围**： 只能为ok、alarm、insufficient_data。字符长度为[0,17] - ok：正常 - alarm：告警 - insufficient_data：数据不足 
        /// </summary>
        [JsonProperty("alarm_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmState { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID。 **取值范围**： 只能包含小写字母、数字、“-”、“_”，长度为36个字符。也可取值0或all_granted_eps。0：代表默认企业项目ID，all_granted_eps：代表所有企业项目ID。 
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricAlarmsResp {\n");
            sb.Append("  alarmName: ").Append(AlarmName).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  alarmActionEnabled: ").Append(AlarmActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  insufficientdataActions: ").Append(InsufficientdataActions).Append("\n");
            sb.Append("  alarmActionBeginTime: ").Append(AlarmActionBeginTime).Append("\n");
            sb.Append("  alarmActionEndTime: ").Append(AlarmActionEndTime).Append("\n");
            sb.Append("  effectiveTimezone: ").Append(EffectiveTimezone).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  alarmState: ").Append(AlarmState).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricAlarmsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricAlarmsResp input)
        {
            if (input == null) return false;
            if (this.AlarmName != input.AlarmName || (this.AlarmName != null && !this.AlarmName.Equals(input.AlarmName))) return false;
            if (this.AlarmDescription != input.AlarmDescription || (this.AlarmDescription != null && !this.AlarmDescription.Equals(input.AlarmDescription))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.AlarmEnabled != input.AlarmEnabled || (this.AlarmEnabled != null && !this.AlarmEnabled.Equals(input.AlarmEnabled))) return false;
            if (this.AlarmLevel != input.AlarmLevel || (this.AlarmLevel != null && !this.AlarmLevel.Equals(input.AlarmLevel))) return false;
            if (this.AlarmType != input.AlarmType || (this.AlarmType != null && !this.AlarmType.Equals(input.AlarmType))) return false;
            if (this.AlarmActionEnabled != input.AlarmActionEnabled || (this.AlarmActionEnabled != null && !this.AlarmActionEnabled.Equals(input.AlarmActionEnabled))) return false;
            if (this.AlarmActions != input.AlarmActions || (this.AlarmActions != null && input.AlarmActions != null && !this.AlarmActions.SequenceEqual(input.AlarmActions))) return false;
            if (this.OkActions != input.OkActions || (this.OkActions != null && input.OkActions != null && !this.OkActions.SequenceEqual(input.OkActions))) return false;
            if (this.InsufficientdataActions != input.InsufficientdataActions || (this.InsufficientdataActions != null && input.InsufficientdataActions != null && !this.InsufficientdataActions.SequenceEqual(input.InsufficientdataActions))) return false;
            if (this.AlarmActionBeginTime != input.AlarmActionBeginTime || (this.AlarmActionBeginTime != null && !this.AlarmActionBeginTime.Equals(input.AlarmActionBeginTime))) return false;
            if (this.AlarmActionEndTime != input.AlarmActionEndTime || (this.AlarmActionEndTime != null && !this.AlarmActionEndTime.Equals(input.AlarmActionEndTime))) return false;
            if (this.EffectiveTimezone != input.EffectiveTimezone || (this.EffectiveTimezone != null && !this.EffectiveTimezone.Equals(input.EffectiveTimezone))) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.AlarmState != input.AlarmState || (this.AlarmState != null && !this.AlarmState.Equals(input.AlarmState))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.AlarmName != null) hashCode = hashCode * 59 + this.AlarmName.GetHashCode();
                if (this.AlarmDescription != null) hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmEnabled != null) hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.AlarmLevel != null) hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmType != null) hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.AlarmActionEnabled != null) hashCode = hashCode * 59 + this.AlarmActionEnabled.GetHashCode();
                if (this.AlarmActions != null) hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null) hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.InsufficientdataActions != null) hashCode = hashCode * 59 + this.InsufficientdataActions.GetHashCode();
                if (this.AlarmActionBeginTime != null) hashCode = hashCode * 59 + this.AlarmActionBeginTime.GetHashCode();
                if (this.AlarmActionEndTime != null) hashCode = hashCode * 59 + this.AlarmActionEndTime.GetHashCode();
                if (this.EffectiveTimezone != null) hashCode = hashCode * 59 + this.EffectiveTimezone.GetHashCode();
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.AlarmState != null) hashCode = hashCode * 59 + this.AlarmState.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
