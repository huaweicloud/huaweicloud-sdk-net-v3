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
    /// 告警历史详细信息
    /// </summary>
    public class AlarmHistoryInfo 
    {

        /// <summary>
        /// 告警规则的ID，如：al1603131199286dzxpqK3Ez。
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 告警规则的名称，如：alarm-test01。
        /// </summary>
        [JsonProperty("alarm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmName { get; set; }

        /// <summary>
        /// 告警规则的描述。
        /// </summary>
        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public MetricInfo Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Condition Condition { get; set; }

        /// <summary>
        /// 告警历史的告警级别，值为1,2,3,4；1为紧急，2为重要，3为次要，4为提示。
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }

        /// <summary>
        /// 告警类型； 仅针对事件告警的参数，枚举类型：值为EVENT.SYS或者EVENT.CUSTOM
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmType { get; set; }

        /// <summary>
        /// 告警规则是否被启用，值为true或者false。
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }

        /// <summary>
        /// 告警规则的告警触发动作是否被启用，值为true或者false。
        /// </summary>
        [JsonProperty("alarm_action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmActionEnabled { get; set; }

        /// <summary>
        /// 告警触发的动作。  结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  }  type取值： notification：通知。 autoscaling：弹性伸缩。 notificationList：告警状态发生变化时，被通知对象的列表。
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> AlarmActions { get; set; }

        /// <summary>
        /// 告警恢复触发的动作。  结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  } type取值：  notification：通知。  notificationList：告警状态发生变化时，被通知对象的列表。
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> OkActions { get; set; }

        /// <summary>
        /// 数据不足触发的动作。  结构如下：  {  \&quot;type\&quot;: \&quot;notification\&quot;, \&quot;notificationList\&quot;: [\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;]  }  type取值： 数据不足触发告警通知类型，取值为notification。 notificationList：数据不足触发告警通知时，被通知对象的ID列表。
        /// </summary>
        [JsonProperty("insufficientdata_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> InsufficientdataActions { get; set; }

        /// <summary>
        /// 告警状态变更的时间，UNIX时间戳，单位毫秒，如：1603131199000。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 企业项目ID。 值为all_granted_eps时，表示所有企业项目；值为0时，表示默认的企业项目default。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 计算出该条告警历史的时间，UNIX时间戳，单位毫秒，如：1603131199469。
        /// </summary>
        [JsonProperty("trigger_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TriggerTime { get; set; }

        /// <summary>
        /// 告警历史的状态，取值为ok，alarm，insufficient_data； ok为正常，alarm为告警，insufficient_data为数据不足。
        /// </summary>
        [JsonProperty("alarm_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmStatus { get; set; }

        /// <summary>
        /// 计算出该条告警历史的资源监控数据的一组数据上报时间和监控数值。
        /// </summary>
        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPointForAlarmHistory> Datapoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalInfo AdditionalInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmHistoryInfo {\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  alarmName: ").Append(AlarmName).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  alarmActionEnabled: ").Append(AlarmActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  insufficientdataActions: ").Append(InsufficientdataActions).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  triggerTime: ").Append(TriggerTime).Append("\n");
            sb.Append("  alarmStatus: ").Append(AlarmStatus).Append("\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("  additionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmHistoryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmHistoryInfo input)
        {
            if (input == null) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.AlarmName != input.AlarmName || (this.AlarmName != null && !this.AlarmName.Equals(input.AlarmName))) return false;
            if (this.AlarmDescription != input.AlarmDescription || (this.AlarmDescription != null && !this.AlarmDescription.Equals(input.AlarmDescription))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.AlarmLevel != input.AlarmLevel || (this.AlarmLevel != null && !this.AlarmLevel.Equals(input.AlarmLevel))) return false;
            if (this.AlarmType != input.AlarmType || (this.AlarmType != null && !this.AlarmType.Equals(input.AlarmType))) return false;
            if (this.AlarmEnabled != input.AlarmEnabled || (this.AlarmEnabled != null && !this.AlarmEnabled.Equals(input.AlarmEnabled))) return false;
            if (this.AlarmActionEnabled != input.AlarmActionEnabled || (this.AlarmActionEnabled != null && !this.AlarmActionEnabled.Equals(input.AlarmActionEnabled))) return false;
            if (this.AlarmActions != input.AlarmActions || (this.AlarmActions != null && input.AlarmActions != null && !this.AlarmActions.SequenceEqual(input.AlarmActions))) return false;
            if (this.OkActions != input.OkActions || (this.OkActions != null && input.OkActions != null && !this.OkActions.SequenceEqual(input.OkActions))) return false;
            if (this.InsufficientdataActions != input.InsufficientdataActions || (this.InsufficientdataActions != null && input.InsufficientdataActions != null && !this.InsufficientdataActions.SequenceEqual(input.InsufficientdataActions))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.TriggerTime != input.TriggerTime || (this.TriggerTime != null && !this.TriggerTime.Equals(input.TriggerTime))) return false;
            if (this.AlarmStatus != input.AlarmStatus || (this.AlarmStatus != null && !this.AlarmStatus.Equals(input.AlarmStatus))) return false;
            if (this.Datapoints != input.Datapoints || (this.Datapoints != null && input.Datapoints != null && !this.Datapoints.SequenceEqual(input.Datapoints))) return false;
            if (this.AdditionalInfo != input.AdditionalInfo || (this.AdditionalInfo != null && !this.AdditionalInfo.Equals(input.AdditionalInfo))) return false;

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
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.AlarmName != null) hashCode = hashCode * 59 + this.AlarmName.GetHashCode();
                if (this.AlarmDescription != null) hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmLevel != null) hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmType != null) hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.AlarmEnabled != null) hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.AlarmActionEnabled != null) hashCode = hashCode * 59 + this.AlarmActionEnabled.GetHashCode();
                if (this.AlarmActions != null) hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null) hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.InsufficientdataActions != null) hashCode = hashCode * 59 + this.InsufficientdataActions.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.TriggerTime != null) hashCode = hashCode * 59 + this.TriggerTime.GetHashCode();
                if (this.AlarmStatus != null) hashCode = hashCode * 59 + this.AlarmStatus.GetHashCode();
                if (this.Datapoints != null) hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                if (this.AdditionalInfo != null) hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
