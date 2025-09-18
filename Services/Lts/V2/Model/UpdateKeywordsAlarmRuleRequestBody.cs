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
    public class UpdateKeywordsAlarmRuleRequestBody 
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
        /// 发送主题 0:不变 1:新增 2:修改 3:删除
        /// </summary>
        /// <value>发送主题 0:不变 1:新增 2:修改 3:删除</value>
        [JsonConverter(typeof(EnumClassConverter<KeywordsAlarmSendCodeEnum>))]
        public class KeywordsAlarmSendCodeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly KeywordsAlarmSendCodeEnum NUMBER_0 = new KeywordsAlarmSendCodeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly KeywordsAlarmSendCodeEnum NUMBER_1 = new KeywordsAlarmSendCodeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly KeywordsAlarmSendCodeEnum NUMBER_2 = new KeywordsAlarmSendCodeEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly KeywordsAlarmSendCodeEnum NUMBER_3 = new KeywordsAlarmSendCodeEnum(3);

            private static readonly Dictionary<int?, KeywordsAlarmSendCodeEnum> StaticFields =
            new Dictionary<int?, KeywordsAlarmSendCodeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
            };

            private int? _value;

            public KeywordsAlarmSendCodeEnum()
            {

            }

            public KeywordsAlarmSendCodeEnum(int? value)
            {
                _value = value;
            }

            public static KeywordsAlarmSendCodeEnum FromValue(int? value)
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

                if (this.Equals(obj as KeywordsAlarmSendCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeywordsAlarmSendCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeywordsAlarmSendCodeEnum a, KeywordsAlarmSendCodeEnum b)
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

            public static bool operator !=(KeywordsAlarmSendCodeEnum a, KeywordsAlarmSendCodeEnum b)
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
        /// 关键词告警规则id
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
        public List<KeywordsRequest> KeywordsRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Frequency Frequency { get; set; }

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
        /// 发送主题 0:不变 1:新增 2:修改 3:删除
        /// </summary>
        [JsonProperty("keywords_alarm_send_code", NullValueHandling = NullValueHandling.Ignore)]
        public KeywordsAlarmSendCodeEnum KeywordsAlarmSendCode { get; set; }
        /// <summary>
        /// domainId
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 
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
            sb.Append("class UpdateKeywordsAlarmRuleRequestBody {\n");
            sb.Append("  keywordsAlarmRuleId: ").Append(KeywordsAlarmRuleId).Append("\n");
            sb.Append("  keywordsAlarmRuleName: ").Append(KeywordsAlarmRuleName).Append("\n");
            sb.Append("  alarmRuleAlias: ").Append(AlarmRuleAlias).Append("\n");
            sb.Append("  keywordsAlarmRuleDescription: ").Append(KeywordsAlarmRuleDescription).Append("\n");
            sb.Append("  keywordsRequests: ").Append(KeywordsRequests).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  keywordsAlarmLevel: ").Append(KeywordsAlarmLevel).Append("\n");
            sb.Append("  keywordsAlarmSend: ").Append(KeywordsAlarmSend).Append("\n");
            sb.Append("  keywordsAlarmSendCode: ").Append(KeywordsAlarmSendCode).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  notificationSaveRule: ").Append(NotificationSaveRule).Append("\n");
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
            return this.Equals(input as UpdateKeywordsAlarmRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateKeywordsAlarmRuleRequestBody input)
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
            if (this.KeywordsAlarmSendCode != input.KeywordsAlarmSendCode) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.NotificationSaveRule != input.NotificationSaveRule || (this.NotificationSaveRule != null && !this.NotificationSaveRule.Equals(input.NotificationSaveRule))) return false;
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
                if (this.KeywordsAlarmRuleId != null) hashCode = hashCode * 59 + this.KeywordsAlarmRuleId.GetHashCode();
                if (this.KeywordsAlarmRuleName != null) hashCode = hashCode * 59 + this.KeywordsAlarmRuleName.GetHashCode();
                if (this.AlarmRuleAlias != null) hashCode = hashCode * 59 + this.AlarmRuleAlias.GetHashCode();
                if (this.KeywordsAlarmRuleDescription != null) hashCode = hashCode * 59 + this.KeywordsAlarmRuleDescription.GetHashCode();
                if (this.KeywordsRequests != null) hashCode = hashCode * 59 + this.KeywordsRequests.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                hashCode = hashCode * 59 + this.KeywordsAlarmLevel.GetHashCode();
                if (this.KeywordsAlarmSend != null) hashCode = hashCode * 59 + this.KeywordsAlarmSend.GetHashCode();
                hashCode = hashCode * 59 + this.KeywordsAlarmSendCode.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.NotificationSaveRule != null) hashCode = hashCode * 59 + this.NotificationSaveRule.GetHashCode();
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
