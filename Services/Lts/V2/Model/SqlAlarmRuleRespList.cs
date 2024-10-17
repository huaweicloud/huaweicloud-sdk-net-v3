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
    public class SqlAlarmRuleRespList 
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
        /// 告警状态
        /// </summary>
        /// <value>告警状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum RUNNING_ for value: RUNNING 启用
            /// </summary>
            public static readonly StatusEnum RUNNING_ = new StatusEnum("RUNNING 启用");

            /// <summary>
            /// Enum STOPPING_ for value: STOPPING 停止
            /// </summary>
            public static readonly StatusEnum STOPPING_ = new StatusEnum("STOPPING 停止");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "RUNNING 启用", RUNNING_ },
                { "STOPPING 停止", STOPPING_ },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 通知频率,单位(分钟)
        /// </summary>
        /// <value>通知频率,单位(分钟)</value>
        [JsonConverter(typeof(EnumClassConverter<NotificationFrequencyEnum>))]
        public class NotificationFrequencyEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly NotificationFrequencyEnum NUMBER_0 = new NotificationFrequencyEnum(0);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly NotificationFrequencyEnum NUMBER_5 = new NotificationFrequencyEnum(5);

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            public static readonly NotificationFrequencyEnum NUMBER_10 = new NotificationFrequencyEnum(10);

            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            public static readonly NotificationFrequencyEnum NUMBER_15 = new NotificationFrequencyEnum(15);

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            public static readonly NotificationFrequencyEnum NUMBER_30 = new NotificationFrequencyEnum(30);

            /// <summary>
            /// Enum NUMBER_60 for value: 60
            /// </summary>
            public static readonly NotificationFrequencyEnum NUMBER_60 = new NotificationFrequencyEnum(60);

            /// <summary>
            /// Enum NUMBER_180 for value: 180
            /// </summary>
            public static readonly NotificationFrequencyEnum NUMBER_180 = new NotificationFrequencyEnum(180);

            /// <summary>
            /// Enum NUMBER_360 for value: 360
            /// </summary>
            public static readonly NotificationFrequencyEnum NUMBER_360 = new NotificationFrequencyEnum(360);

            private static readonly Dictionary<int?, NotificationFrequencyEnum> StaticFields =
            new Dictionary<int?, NotificationFrequencyEnum>()
            {
                { 0, NUMBER_0 },
                { 5, NUMBER_5 },
                { 10, NUMBER_10 },
                { 15, NUMBER_15 },
                { 30, NUMBER_30 },
                { 60, NUMBER_60 },
                { 180, NUMBER_180 },
                { 360, NUMBER_360 },
            };

            private int? _value;

            public NotificationFrequencyEnum()
            {

            }

            public NotificationFrequencyEnum(int? value)
            {
                _value = value;
            }

            public static NotificationFrequencyEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as NotificationFrequencyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotificationFrequencyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotificationFrequencyEnum a, NotificationFrequencyEnum b)
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

            public static bool operator !=(NotificationFrequencyEnum a, NotificationFrequencyEnum b)
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
        /// 是否管道符sql查询
        /// </summary>
        [JsonProperty("is_css_sql", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCssSql { get; set; }

        /// <summary>
        /// SQL告警规则id
        /// </summary>
        [JsonProperty("sql_alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlAlarmRuleId { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public FrequencyRespBody Frequency { get; set; }

        /// <summary>
        /// 条件表达式
        /// </summary>
        [JsonProperty("condition_expression", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionExpression { get; set; }

        /// <summary>
        /// 主题信息
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Topics> Topics { get; set; }

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
        /// 创建时间（毫秒时间戳）
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间（毫秒时间戳）
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 消息模板名称
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 告警状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 触发条件：触发周期;默认为1
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
        /// 通知频率,单位(分钟)
        /// </summary>
        [JsonProperty("notification_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public NotificationFrequencyEnum NotificationFrequency { get; set; }
        /// <summary>
        /// 告警行动规则名称 &gt;alarm_action_rule_name和notification_save_rule可以选填一个，如果都填，优先选择alarm_action_rule_name
        /// </summary>
        [JsonProperty("alarm_action_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmActionRuleName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlAlarmRuleRespList {\n");
            sb.Append("  sqlAlarmRuleName: ").Append(SqlAlarmRuleName).Append("\n");
            sb.Append("  isCssSql: ").Append(IsCssSql).Append("\n");
            sb.Append("  sqlAlarmRuleId: ").Append(SqlAlarmRuleId).Append("\n");
            sb.Append("  sqlAlarmRuleDescription: ").Append(SqlAlarmRuleDescription).Append("\n");
            sb.Append("  sqlRequests: ").Append(SqlRequests).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  conditionExpression: ").Append(ConditionExpression).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  sqlAlarmLevel: ").Append(SqlAlarmLevel).Append("\n");
            sb.Append("  sqlAlarmSend: ").Append(SqlAlarmSend).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  triggerConditionCount: ").Append(TriggerConditionCount).Append("\n");
            sb.Append("  triggerConditionFrequency: ").Append(TriggerConditionFrequency).Append("\n");
            sb.Append("  whetherRecoveryPolicy: ").Append(WhetherRecoveryPolicy).Append("\n");
            sb.Append("  recoveryPolicy: ").Append(RecoveryPolicy).Append("\n");
            sb.Append("  notificationFrequency: ").Append(NotificationFrequency).Append("\n");
            sb.Append("  alarmActionRuleName: ").Append(AlarmActionRuleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlAlarmRuleRespList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlAlarmRuleRespList input)
        {
            if (input == null) return false;
            if (this.SqlAlarmRuleName != input.SqlAlarmRuleName || (this.SqlAlarmRuleName != null && !this.SqlAlarmRuleName.Equals(input.SqlAlarmRuleName))) return false;
            if (this.IsCssSql != input.IsCssSql || (this.IsCssSql != null && !this.IsCssSql.Equals(input.IsCssSql))) return false;
            if (this.SqlAlarmRuleId != input.SqlAlarmRuleId || (this.SqlAlarmRuleId != null && !this.SqlAlarmRuleId.Equals(input.SqlAlarmRuleId))) return false;
            if (this.SqlAlarmRuleDescription != input.SqlAlarmRuleDescription || (this.SqlAlarmRuleDescription != null && !this.SqlAlarmRuleDescription.Equals(input.SqlAlarmRuleDescription))) return false;
            if (this.SqlRequests != input.SqlRequests || (this.SqlRequests != null && input.SqlRequests != null && !this.SqlRequests.SequenceEqual(input.SqlRequests))) return false;
            if (this.Frequency != input.Frequency || (this.Frequency != null && !this.Frequency.Equals(input.Frequency))) return false;
            if (this.ConditionExpression != input.ConditionExpression || (this.ConditionExpression != null && !this.ConditionExpression.Equals(input.ConditionExpression))) return false;
            if (this.Topics != input.Topics || (this.Topics != null && input.Topics != null && !this.Topics.SequenceEqual(input.Topics))) return false;
            if (this.SqlAlarmLevel != input.SqlAlarmLevel) return false;
            if (this.SqlAlarmSend != input.SqlAlarmSend || (this.SqlAlarmSend != null && !this.SqlAlarmSend.Equals(input.SqlAlarmSend))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.Status != input.Status) return false;
            if (this.TriggerConditionCount != input.TriggerConditionCount || (this.TriggerConditionCount != null && !this.TriggerConditionCount.Equals(input.TriggerConditionCount))) return false;
            if (this.TriggerConditionFrequency != input.TriggerConditionFrequency || (this.TriggerConditionFrequency != null && !this.TriggerConditionFrequency.Equals(input.TriggerConditionFrequency))) return false;
            if (this.WhetherRecoveryPolicy != input.WhetherRecoveryPolicy || (this.WhetherRecoveryPolicy != null && !this.WhetherRecoveryPolicy.Equals(input.WhetherRecoveryPolicy))) return false;
            if (this.RecoveryPolicy != input.RecoveryPolicy || (this.RecoveryPolicy != null && !this.RecoveryPolicy.Equals(input.RecoveryPolicy))) return false;
            if (this.NotificationFrequency != input.NotificationFrequency) return false;
            if (this.AlarmActionRuleName != input.AlarmActionRuleName || (this.AlarmActionRuleName != null && !this.AlarmActionRuleName.Equals(input.AlarmActionRuleName))) return false;

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
                if (this.SqlAlarmRuleName != null) hashCode = hashCode * 59 + this.SqlAlarmRuleName.GetHashCode();
                if (this.IsCssSql != null) hashCode = hashCode * 59 + this.IsCssSql.GetHashCode();
                if (this.SqlAlarmRuleId != null) hashCode = hashCode * 59 + this.SqlAlarmRuleId.GetHashCode();
                if (this.SqlAlarmRuleDescription != null) hashCode = hashCode * 59 + this.SqlAlarmRuleDescription.GetHashCode();
                if (this.SqlRequests != null) hashCode = hashCode * 59 + this.SqlRequests.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.ConditionExpression != null) hashCode = hashCode * 59 + this.ConditionExpression.GetHashCode();
                if (this.Topics != null) hashCode = hashCode * 59 + this.Topics.GetHashCode();
                hashCode = hashCode * 59 + this.SqlAlarmLevel.GetHashCode();
                if (this.SqlAlarmSend != null) hashCode = hashCode * 59 + this.SqlAlarmSend.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TriggerConditionCount != null) hashCode = hashCode * 59 + this.TriggerConditionCount.GetHashCode();
                if (this.TriggerConditionFrequency != null) hashCode = hashCode * 59 + this.TriggerConditionFrequency.GetHashCode();
                if (this.WhetherRecoveryPolicy != null) hashCode = hashCode * 59 + this.WhetherRecoveryPolicy.GetHashCode();
                if (this.RecoveryPolicy != null) hashCode = hashCode * 59 + this.RecoveryPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.NotificationFrequency.GetHashCode();
                if (this.AlarmActionRuleName != null) hashCode = hashCode * 59 + this.AlarmActionRuleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
