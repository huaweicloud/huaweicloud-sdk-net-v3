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
    /// 阈值规则查询参数。
    /// </summary>
    public class QueryAlarmResult 
    {

        /// <summary>
        /// 是否启用通知。
        /// </summary>
        [JsonProperty("action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionEnabled { get; set; }

        /// <summary>
        /// 告警状态通知列表。
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmActions { get; set; }

        /// <summary>
        /// 告警清除建议。
        /// </summary>
        [JsonProperty("alarm_advice", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmAdvice { get; set; }

        /// <summary>
        /// 阈值规则描述。
        /// </summary>
        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        /// <summary>
        /// 告警级别。
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmLevel { get; set; }

        /// <summary>
        /// 阈值规则ID。
        /// </summary>
        [JsonProperty("alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleId { get; set; }

        /// <summary>
        /// 阈值规则名称。
        /// </summary>
        [JsonProperty("alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleName { get; set; }

        /// <summary>
        /// 极限条件。
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// 时间序列维度。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// 间隔周期。
        /// </summary>
        [JsonProperty("evaluation_periods", NullValueHandling = NullValueHandling.Ignore)]
        public int? EvaluationPeriods { get; set; }

        /// <summary>
        /// 阈值规则是否启用。
        /// </summary>
        [JsonProperty("id_turn_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IdTurnOn { get; set; }

        /// <summary>
        /// 数据不足通知列表。
        /// </summary>
        [JsonProperty("insufficient_data_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InsufficientDataActions { get; set; }

        /// <summary>
        /// 时间序列名称。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 时间序列命名空间。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 正常状态通知列表。
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OkActions { get; set; }

        /// <summary>
        /// 统计周期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 阈值规则模板名称。
        /// </summary>
        [JsonProperty("policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyName { get; set; }

        /// <summary>
        /// 资源信息(已废弃)。
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// 原因描述。
        /// </summary>
        [JsonProperty("state_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StateReason { get; set; }

        /// <summary>
        /// 状态更新时间戳。
        /// </summary>
        [JsonProperty("state_updated_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string StateUpdatedTimestamp { get; set; }

        /// <summary>
        /// 服务状态。
        /// </summary>
        [JsonProperty("state_value", NullValueHandling = NullValueHandling.Ignore)]
        public string StateValue { get; set; }

        /// <summary>
        /// 统计方式。
        /// </summary>
        [JsonProperty("statistic", NullValueHandling = NullValueHandling.Ignore)]
        public string Statistic { get; set; }

        /// <summary>
        /// 临界值。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string Threshold { get; set; }

        /// <summary>
        /// 阈值规则类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 阈值单元。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAlarmResult {\n");
            sb.Append("  actionEnabled: ").Append(ActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  alarmAdvice: ").Append(AlarmAdvice).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmRuleId: ").Append(AlarmRuleId).Append("\n");
            sb.Append("  alarmRuleName: ").Append(AlarmRuleName).Append("\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  evaluationPeriods: ").Append(EvaluationPeriods).Append("\n");
            sb.Append("  idTurnOn: ").Append(IdTurnOn).Append("\n");
            sb.Append("  insufficientDataActions: ").Append(InsufficientDataActions).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  policyName: ").Append(PolicyName).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  stateReason: ").Append(StateReason).Append("\n");
            sb.Append("  stateUpdatedTimestamp: ").Append(StateUpdatedTimestamp).Append("\n");
            sb.Append("  stateValue: ").Append(StateValue).Append("\n");
            sb.Append("  statistic: ").Append(Statistic).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryAlarmResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryAlarmResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionEnabled == input.ActionEnabled ||
                    (this.ActionEnabled != null &&
                    this.ActionEnabled.Equals(input.ActionEnabled))
                ) && 
                (
                    this.AlarmActions == input.AlarmActions ||
                    this.AlarmActions != null &&
                    input.AlarmActions != null &&
                    this.AlarmActions.SequenceEqual(input.AlarmActions)
                ) && 
                (
                    this.AlarmAdvice == input.AlarmAdvice ||
                    (this.AlarmAdvice != null &&
                    this.AlarmAdvice.Equals(input.AlarmAdvice))
                ) && 
                (
                    this.AlarmDescription == input.AlarmDescription ||
                    (this.AlarmDescription != null &&
                    this.AlarmDescription.Equals(input.AlarmDescription))
                ) && 
                (
                    this.AlarmLevel == input.AlarmLevel ||
                    (this.AlarmLevel != null &&
                    this.AlarmLevel.Equals(input.AlarmLevel))
                ) && 
                (
                    this.AlarmRuleId == input.AlarmRuleId ||
                    (this.AlarmRuleId != null &&
                    this.AlarmRuleId.Equals(input.AlarmRuleId))
                ) && 
                (
                    this.AlarmRuleName == input.AlarmRuleName ||
                    (this.AlarmRuleName != null &&
                    this.AlarmRuleName.Equals(input.AlarmRuleName))
                ) && 
                (
                    this.ComparisonOperator == input.ComparisonOperator ||
                    (this.ComparisonOperator != null &&
                    this.ComparisonOperator.Equals(input.ComparisonOperator))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                ) && 
                (
                    this.EvaluationPeriods == input.EvaluationPeriods ||
                    (this.EvaluationPeriods != null &&
                    this.EvaluationPeriods.Equals(input.EvaluationPeriods))
                ) && 
                (
                    this.IdTurnOn == input.IdTurnOn ||
                    (this.IdTurnOn != null &&
                    this.IdTurnOn.Equals(input.IdTurnOn))
                ) && 
                (
                    this.InsufficientDataActions == input.InsufficientDataActions ||
                    this.InsufficientDataActions != null &&
                    input.InsufficientDataActions != null &&
                    this.InsufficientDataActions.SequenceEqual(input.InsufficientDataActions)
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.OkActions == input.OkActions ||
                    this.OkActions != null &&
                    input.OkActions != null &&
                    this.OkActions.SequenceEqual(input.OkActions)
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.StateReason == input.StateReason ||
                    (this.StateReason != null &&
                    this.StateReason.Equals(input.StateReason))
                ) && 
                (
                    this.StateUpdatedTimestamp == input.StateUpdatedTimestamp ||
                    (this.StateUpdatedTimestamp != null &&
                    this.StateUpdatedTimestamp.Equals(input.StateUpdatedTimestamp))
                ) && 
                (
                    this.StateValue == input.StateValue ||
                    (this.StateValue != null &&
                    this.StateValue.Equals(input.StateValue))
                ) && 
                (
                    this.Statistic == input.Statistic ||
                    (this.Statistic != null &&
                    this.Statistic.Equals(input.Statistic))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActionEnabled != null)
                    hashCode = hashCode * 59 + this.ActionEnabled.GetHashCode();
                if (this.AlarmActions != null)
                    hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.AlarmAdvice != null)
                    hashCode = hashCode * 59 + this.AlarmAdvice.GetHashCode();
                if (this.AlarmDescription != null)
                    hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.AlarmLevel != null)
                    hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmRuleId != null)
                    hashCode = hashCode * 59 + this.AlarmRuleId.GetHashCode();
                if (this.AlarmRuleName != null)
                    hashCode = hashCode * 59 + this.AlarmRuleName.GetHashCode();
                if (this.ComparisonOperator != null)
                    hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.EvaluationPeriods != null)
                    hashCode = hashCode * 59 + this.EvaluationPeriods.GetHashCode();
                if (this.IdTurnOn != null)
                    hashCode = hashCode * 59 + this.IdTurnOn.GetHashCode();
                if (this.InsufficientDataActions != null)
                    hashCode = hashCode * 59 + this.InsufficientDataActions.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.OkActions != null)
                    hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.StateReason != null)
                    hashCode = hashCode * 59 + this.StateReason.GetHashCode();
                if (this.StateUpdatedTimestamp != null)
                    hashCode = hashCode * 59 + this.StateUpdatedTimestamp.GetHashCode();
                if (this.StateValue != null)
                    hashCode = hashCode * 59 + this.StateValue.GetHashCode();
                if (this.Statistic != null)
                    hashCode = hashCode * 59 + this.Statistic.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
