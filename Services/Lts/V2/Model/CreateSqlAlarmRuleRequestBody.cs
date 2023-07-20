using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSqlAlarmRuleRequestBody 
    {
        /// <summary>
        /// 告警级别
        /// </summary>
        /// <value>告警级别</value>
        [JsonConverter(typeof(EnumClassConverter<SqlAlarmLevelEnum>))]
        public class SqlAlarmLevelEnum
        {
            /// <summary>
            /// Enum INFO for value: Info
            /// </summary>
            public static readonly SqlAlarmLevelEnum INFO = new SqlAlarmLevelEnum("Info");

            /// <summary>
            /// Enum MINOR for value: Minor
            /// </summary>
            public static readonly SqlAlarmLevelEnum MINOR = new SqlAlarmLevelEnum("Minor");

            /// <summary>
            /// Enum MAJOR for value: Major
            /// </summary>
            public static readonly SqlAlarmLevelEnum MAJOR = new SqlAlarmLevelEnum("Major");

            /// <summary>
            /// Enum CRITICAL for value: Critical
            /// </summary>
            public static readonly SqlAlarmLevelEnum CRITICAL = new SqlAlarmLevelEnum("Critical");

            private static readonly Dictionary<string, SqlAlarmLevelEnum> StaticFields =
            new Dictionary<string, SqlAlarmLevelEnum>()
            {
                { "Info", INFO },
                { "Minor", MINOR },
                { "Major", MAJOR },
                { "Critical", CRITICAL },
            };

            private string _value;

            public SqlAlarmLevelEnum()
            {

            }

            public SqlAlarmLevelEnum(string value)
            {
                _value = value;
            }

            public static SqlAlarmLevelEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as SqlAlarmLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SqlAlarmLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SqlAlarmLevelEnum a, SqlAlarmLevelEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SqlAlarmLevelEnum a, SqlAlarmLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// SQL告警名称
        /// </summary>
        [JsonProperty("sql_alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlAlarmRuleName { get; set; }

        /// <summary>
        /// SQL告警信息描述
        /// </summary>
        [JsonProperty("sql_alarm_rule_description", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlAlarmRuleDescription { get; set; }

        /// <summary>
        /// SQL详细信息
        /// </summary>
        [JsonProperty("sql_requests", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlRequest> SqlRequests { get; set; }

        /// <summary>
        /// 告警统计周期
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Frequency Frequency { get; set; }

        /// <summary>
        /// 条件表达式
        /// </summary>
        [JsonProperty("condition_expression", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionExpression { get; set; }

        /// <summary>
        /// 告警级别
        /// </summary>
        [JsonProperty("sql_alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public SqlAlarmLevelEnum SqlAlarmLevel { get; set; }
        /// <summary>
        /// 是否发送
        /// </summary>
        [JsonProperty("sql_alarm_send", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SqlAlarmSend { get; set; }

        /// <summary>
        /// domainId
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 通知主题
        /// </summary>
        [JsonProperty("notification_save_rule", NullValueHandling = NullValueHandling.Ignore)]
        public SqlNotificationSaveRule NotificationSaveRule { get; set; }

        /// <summary>
        /// 触发条件：触发次数;默认为1
        /// </summary>
        [JsonProperty("trigger_condition_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerConditionCount { get; set; }

        /// <summary>
        /// 触发条件：触发周期;默认为1
        /// </summary>
        [JsonProperty("trigger_condition_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerConditionFrequency { get; set; }

        /// <summary>
        /// 是否打开恢复通知;默认false
        /// </summary>
        [JsonProperty("whether_recovery_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhetherRecoveryPolicy { get; set; }

        /// <summary>
        /// 恢复策略周期;默认为3
        /// </summary>
        [JsonProperty("recovery_policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecoveryPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSqlAlarmRuleRequestBody {\n");
            sb.Append("  sqlAlarmRuleName: ").Append(SqlAlarmRuleName).Append("\n");
            sb.Append("  sqlAlarmRuleDescription: ").Append(SqlAlarmRuleDescription).Append("\n");
            sb.Append("  sqlRequests: ").Append(SqlRequests).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  conditionExpression: ").Append(ConditionExpression).Append("\n");
            sb.Append("  sqlAlarmLevel: ").Append(SqlAlarmLevel).Append("\n");
            sb.Append("  sqlAlarmSend: ").Append(SqlAlarmSend).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  notificationSaveRule: ").Append(NotificationSaveRule).Append("\n");
            sb.Append("  triggerConditionCount: ").Append(TriggerConditionCount).Append("\n");
            sb.Append("  triggerConditionFrequency: ").Append(TriggerConditionFrequency).Append("\n");
            sb.Append("  whetherRecoveryPolicy: ").Append(WhetherRecoveryPolicy).Append("\n");
            sb.Append("  recoveryPolicy: ").Append(RecoveryPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSqlAlarmRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSqlAlarmRuleRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SqlAlarmRuleName == input.SqlAlarmRuleName ||
                    (this.SqlAlarmRuleName != null &&
                    this.SqlAlarmRuleName.Equals(input.SqlAlarmRuleName))
                ) && 
                (
                    this.SqlAlarmRuleDescription == input.SqlAlarmRuleDescription ||
                    (this.SqlAlarmRuleDescription != null &&
                    this.SqlAlarmRuleDescription.Equals(input.SqlAlarmRuleDescription))
                ) && 
                (
                    this.SqlRequests == input.SqlRequests ||
                    this.SqlRequests != null &&
                    input.SqlRequests != null &&
                    this.SqlRequests.SequenceEqual(input.SqlRequests)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.ConditionExpression == input.ConditionExpression ||
                    (this.ConditionExpression != null &&
                    this.ConditionExpression.Equals(input.ConditionExpression))
                ) && 
                (
                    this.SqlAlarmLevel == input.SqlAlarmLevel ||
                    (this.SqlAlarmLevel != null &&
                    this.SqlAlarmLevel.Equals(input.SqlAlarmLevel))
                ) && 
                (
                    this.SqlAlarmSend == input.SqlAlarmSend ||
                    (this.SqlAlarmSend != null &&
                    this.SqlAlarmSend.Equals(input.SqlAlarmSend))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.NotificationSaveRule == input.NotificationSaveRule ||
                    (this.NotificationSaveRule != null &&
                    this.NotificationSaveRule.Equals(input.NotificationSaveRule))
                ) && 
                (
                    this.TriggerConditionCount == input.TriggerConditionCount ||
                    (this.TriggerConditionCount != null &&
                    this.TriggerConditionCount.Equals(input.TriggerConditionCount))
                ) && 
                (
                    this.TriggerConditionFrequency == input.TriggerConditionFrequency ||
                    (this.TriggerConditionFrequency != null &&
                    this.TriggerConditionFrequency.Equals(input.TriggerConditionFrequency))
                ) && 
                (
                    this.WhetherRecoveryPolicy == input.WhetherRecoveryPolicy ||
                    (this.WhetherRecoveryPolicy != null &&
                    this.WhetherRecoveryPolicy.Equals(input.WhetherRecoveryPolicy))
                ) && 
                (
                    this.RecoveryPolicy == input.RecoveryPolicy ||
                    (this.RecoveryPolicy != null &&
                    this.RecoveryPolicy.Equals(input.RecoveryPolicy))
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
                if (this.SqlAlarmRuleName != null)
                    hashCode = hashCode * 59 + this.SqlAlarmRuleName.GetHashCode();
                if (this.SqlAlarmRuleDescription != null)
                    hashCode = hashCode * 59 + this.SqlAlarmRuleDescription.GetHashCode();
                if (this.SqlRequests != null)
                    hashCode = hashCode * 59 + this.SqlRequests.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.ConditionExpression != null)
                    hashCode = hashCode * 59 + this.ConditionExpression.GetHashCode();
                if (this.SqlAlarmLevel != null)
                    hashCode = hashCode * 59 + this.SqlAlarmLevel.GetHashCode();
                if (this.SqlAlarmSend != null)
                    hashCode = hashCode * 59 + this.SqlAlarmSend.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.NotificationSaveRule != null)
                    hashCode = hashCode * 59 + this.NotificationSaveRule.GetHashCode();
                if (this.TriggerConditionCount != null)
                    hashCode = hashCode * 59 + this.TriggerConditionCount.GetHashCode();
                if (this.TriggerConditionFrequency != null)
                    hashCode = hashCode * 59 + this.TriggerConditionFrequency.GetHashCode();
                if (this.WhetherRecoveryPolicy != null)
                    hashCode = hashCode * 59 + this.WhetherRecoveryPolicy.GetHashCode();
                if (this.RecoveryPolicy != null)
                    hashCode = hashCode * 59 + this.RecoveryPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
