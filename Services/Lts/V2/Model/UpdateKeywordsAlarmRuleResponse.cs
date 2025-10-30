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
    /// Response Object
    /// </summary>
    public class UpdateKeywordsAlarmRuleResponse : SdkResponse
    {
        /// <summary>
        /// 告警级别
        /// </summary>
        /// <value>告警级别</value>
        [JsonConverter(typeof(EnumClassConverter<KeywordsAlarmLevelEnum>))]
        public class KeywordsAlarmLevelEnum
        {
            /// <summary>
            /// Enum INFO for value: Info
            /// </summary>
            public static readonly KeywordsAlarmLevelEnum INFO = new KeywordsAlarmLevelEnum("Info");

            /// <summary>
            /// Enum MINOR for value: Minor
            /// </summary>
            public static readonly KeywordsAlarmLevelEnum MINOR = new KeywordsAlarmLevelEnum("Minor");

            /// <summary>
            /// Enum MAJOR for value: Major
            /// </summary>
            public static readonly KeywordsAlarmLevelEnum MAJOR = new KeywordsAlarmLevelEnum("Major");

            /// <summary>
            /// Enum CRITICAL for value: Critical
            /// </summary>
            public static readonly KeywordsAlarmLevelEnum CRITICAL = new KeywordsAlarmLevelEnum("Critical");

            private static readonly Dictionary<string, KeywordsAlarmLevelEnum> StaticFields =
            new Dictionary<string, KeywordsAlarmLevelEnum>()
            {
                { "Info", INFO },
                { "Minor", MINOR },
                { "Major", MAJOR },
                { "Critical", CRITICAL },
            };

            private string _value;

            public KeywordsAlarmLevelEnum()
            {

            }

            public KeywordsAlarmLevelEnum(string value)
            {
                _value = value;
            }

            public static KeywordsAlarmLevelEnum FromValue(string value)
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

                if (this.Equals(obj as KeywordsAlarmLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeywordsAlarmLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeywordsAlarmLevelEnum a, KeywordsAlarmLevelEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(KeywordsAlarmLevelEnum a, KeywordsAlarmLevelEnum b)
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
                if (ReferenceEquals(a, b))
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
        /// 关键词告警id
        /// </summary>
        [JsonProperty("keywords_alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordsAlarmRuleId { get; set; }

        /// <summary>
        /// 关键词告警名称
        /// </summary>
        [JsonProperty("keywords_alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordsAlarmRuleName { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("alarm_rule_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleAlias { get; set; }

        /// <summary>
        /// 关键词告警信息描述
        /// </summary>
        [JsonProperty("keywords_alarm_rule_description", NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordsAlarmRuleDescription { get; set; }

        /// <summary>
        /// 关键词详细信息
        /// </summary>
        [JsonProperty("keywords_requests", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeywordsResBody> KeywordsRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public FrequencyRespBody Frequency { get; set; }

        /// <summary>
        /// 告警级别
        /// </summary>
        [JsonProperty("keywords_alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public KeywordsAlarmLevelEnum KeywordsAlarmLevel { get; set; }
        /// <summary>
        /// 是否发送
        /// </summary>
        [JsonProperty("keywords_alarm_send", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KeywordsAlarmSend { get; set; }

        /// <summary>
        /// domainId
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 创建时间(毫秒时间戳)
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间(毫秒时间戳)
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 情况表述
        /// </summary>
        [JsonProperty("condition_expression", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionExpression { get; set; }

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
        /// **参数解释：** 告警恢复策略周期次数。 配置的最近统计周期次数内，如果不满足触发条件且开启恢复时通知开关，则会发送恢复告警通知。 **取值范围：** - 最小值为1 - 最大值为10
        /// </summary>
        [JsonProperty("recovery_policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecoveryPolicy { get; set; }

        /// <summary>
        /// **参数解释：** 告警标签信息。标签是以键值对（key-value）的形式表示，key和value为一一对应关系。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsResBody> Tags { get; set; }

        /// <summary>
        /// **参数解释：** 告警触发条件：满足条件次数。满足条件次数是指设置的关键词。 在统计周期次数内且满足条件次数时，可触发关键词告警。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("trigger_condition_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerConditionCount { get; set; }

        /// <summary>
        /// **参数解释：** 告警触发条件：统计周期次数。统计周期次数指高级设置的统计周期。 当在统计周期次数内且满足条件次数时，可触发关键词告警。 **取值范围：** - 最小值为1 - 最大值为10
        /// </summary>
        [JsonProperty("trigger_condition_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerConditionFrequency { get; set; }

        /// <summary>
        /// **参数解释：** 是否配置告警恢复策略。满足该策略时，会发送告警恢复通知。 **取值范围：** true：配置告警恢复策略。 false：不配置告警恢复策略。
        /// </summary>
        [JsonProperty("whether_recovery_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhetherRecoveryPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateKeywordsAlarmRuleResponse {\n");
            sb.Append("  keywordsAlarmRuleId: ").Append(KeywordsAlarmRuleId).Append("\n");
            sb.Append("  keywordsAlarmRuleName: ").Append(KeywordsAlarmRuleName).Append("\n");
            sb.Append("  alarmRuleAlias: ").Append(AlarmRuleAlias).Append("\n");
            sb.Append("  keywordsAlarmRuleDescription: ").Append(KeywordsAlarmRuleDescription).Append("\n");
            sb.Append("  keywordsRequests: ").Append(KeywordsRequests).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  keywordsAlarmLevel: ").Append(KeywordsAlarmLevel).Append("\n");
            sb.Append("  keywordsAlarmSend: ").Append(KeywordsAlarmSend).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  conditionExpression: ").Append(ConditionExpression).Append("\n");
            sb.Append("  notificationFrequency: ").Append(NotificationFrequency).Append("\n");
            sb.Append("  alarmActionRuleName: ").Append(AlarmActionRuleName).Append("\n");
            sb.Append("  recoveryPolicy: ").Append(RecoveryPolicy).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  triggerConditionCount: ").Append(TriggerConditionCount).Append("\n");
            sb.Append("  triggerConditionFrequency: ").Append(TriggerConditionFrequency).Append("\n");
            sb.Append("  whetherRecoveryPolicy: ").Append(WhetherRecoveryPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateKeywordsAlarmRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateKeywordsAlarmRuleResponse input)
        {
            if (input == null) return false;
            if (this.KeywordsAlarmRuleId != input.KeywordsAlarmRuleId || (this.KeywordsAlarmRuleId != null && !this.KeywordsAlarmRuleId.Equals(input.KeywordsAlarmRuleId))) return false;
            if (this.KeywordsAlarmRuleName != input.KeywordsAlarmRuleName || (this.KeywordsAlarmRuleName != null && !this.KeywordsAlarmRuleName.Equals(input.KeywordsAlarmRuleName))) return false;
            if (this.AlarmRuleAlias != input.AlarmRuleAlias || (this.AlarmRuleAlias != null && !this.AlarmRuleAlias.Equals(input.AlarmRuleAlias))) return false;
            if (this.KeywordsAlarmRuleDescription != input.KeywordsAlarmRuleDescription || (this.KeywordsAlarmRuleDescription != null && !this.KeywordsAlarmRuleDescription.Equals(input.KeywordsAlarmRuleDescription))) return false;
            if (this.KeywordsRequests != input.KeywordsRequests || (this.KeywordsRequests != null && input.KeywordsRequests != null && !this.KeywordsRequests.SequenceEqual(input.KeywordsRequests))) return false;
            if (this.Frequency != input.Frequency || (this.Frequency != null && !this.Frequency.Equals(input.Frequency))) return false;
            if (this.KeywordsAlarmLevel != input.KeywordsAlarmLevel) return false;
            if (this.KeywordsAlarmSend != input.KeywordsAlarmSend || (this.KeywordsAlarmSend != null && !this.KeywordsAlarmSend.Equals(input.KeywordsAlarmSend))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ConditionExpression != input.ConditionExpression || (this.ConditionExpression != null && !this.ConditionExpression.Equals(input.ConditionExpression))) return false;
            if (this.NotificationFrequency != input.NotificationFrequency) return false;
            if (this.AlarmActionRuleName != input.AlarmActionRuleName || (this.AlarmActionRuleName != null && !this.AlarmActionRuleName.Equals(input.AlarmActionRuleName))) return false;
            if (this.RecoveryPolicy != input.RecoveryPolicy || (this.RecoveryPolicy != null && !this.RecoveryPolicy.Equals(input.RecoveryPolicy))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TriggerConditionCount != input.TriggerConditionCount || (this.TriggerConditionCount != null && !this.TriggerConditionCount.Equals(input.TriggerConditionCount))) return false;
            if (this.TriggerConditionFrequency != input.TriggerConditionFrequency || (this.TriggerConditionFrequency != null && !this.TriggerConditionFrequency.Equals(input.TriggerConditionFrequency))) return false;
            if (this.WhetherRecoveryPolicy != input.WhetherRecoveryPolicy || (this.WhetherRecoveryPolicy != null && !this.WhetherRecoveryPolicy.Equals(input.WhetherRecoveryPolicy))) return false;

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
                if (this.KeywordsAlarmRuleId != null) hashCode = hashCode * 59 + this.KeywordsAlarmRuleId.GetHashCode();
                if (this.KeywordsAlarmRuleName != null) hashCode = hashCode * 59 + this.KeywordsAlarmRuleName.GetHashCode();
                if (this.AlarmRuleAlias != null) hashCode = hashCode * 59 + this.AlarmRuleAlias.GetHashCode();
                if (this.KeywordsAlarmRuleDescription != null) hashCode = hashCode * 59 + this.KeywordsAlarmRuleDescription.GetHashCode();
                if (this.KeywordsRequests != null) hashCode = hashCode * 59 + this.KeywordsRequests.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                hashCode = hashCode * 59 + this.KeywordsAlarmLevel.GetHashCode();
                if (this.KeywordsAlarmSend != null) hashCode = hashCode * 59 + this.KeywordsAlarmSend.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ConditionExpression != null) hashCode = hashCode * 59 + this.ConditionExpression.GetHashCode();
                hashCode = hashCode * 59 + this.NotificationFrequency.GetHashCode();
                if (this.AlarmActionRuleName != null) hashCode = hashCode * 59 + this.AlarmActionRuleName.GetHashCode();
                if (this.RecoveryPolicy != null) hashCode = hashCode * 59 + this.RecoveryPolicy.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TriggerConditionCount != null) hashCode = hashCode * 59 + this.TriggerConditionCount.GetHashCode();
                if (this.TriggerConditionFrequency != null) hashCode = hashCode * 59 + this.TriggerConditionFrequency.GetHashCode();
                if (this.WhetherRecoveryPolicy != null) hashCode = hashCode * 59 + this.WhetherRecoveryPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
