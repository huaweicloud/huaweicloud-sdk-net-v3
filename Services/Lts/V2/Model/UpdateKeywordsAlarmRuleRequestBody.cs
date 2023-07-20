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

            public static bool operator !=(KeywordsAlarmSendCodeEnum a, KeywordsAlarmSendCodeEnum b)
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
        /// 告警统计周期
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
            sb.Append("class UpdateKeywordsAlarmRuleRequestBody {\n");
            sb.Append("  keywordsAlarmRuleId: ").Append(KeywordsAlarmRuleId).Append("\n");
            sb.Append("  keywordsAlarmRuleName: ").Append(KeywordsAlarmRuleName).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.KeywordsAlarmRuleId == input.KeywordsAlarmRuleId ||
                    (this.KeywordsAlarmRuleId != null &&
                    this.KeywordsAlarmRuleId.Equals(input.KeywordsAlarmRuleId))
                ) && 
                (
                    this.KeywordsAlarmRuleName == input.KeywordsAlarmRuleName ||
                    (this.KeywordsAlarmRuleName != null &&
                    this.KeywordsAlarmRuleName.Equals(input.KeywordsAlarmRuleName))
                ) && 
                (
                    this.KeywordsAlarmRuleDescription == input.KeywordsAlarmRuleDescription ||
                    (this.KeywordsAlarmRuleDescription != null &&
                    this.KeywordsAlarmRuleDescription.Equals(input.KeywordsAlarmRuleDescription))
                ) && 
                (
                    this.KeywordsRequests == input.KeywordsRequests ||
                    this.KeywordsRequests != null &&
                    input.KeywordsRequests != null &&
                    this.KeywordsRequests.SequenceEqual(input.KeywordsRequests)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.KeywordsAlarmLevel == input.KeywordsAlarmLevel ||
                    (this.KeywordsAlarmLevel != null &&
                    this.KeywordsAlarmLevel.Equals(input.KeywordsAlarmLevel))
                ) && 
                (
                    this.KeywordsAlarmSend == input.KeywordsAlarmSend ||
                    (this.KeywordsAlarmSend != null &&
                    this.KeywordsAlarmSend.Equals(input.KeywordsAlarmSend))
                ) && 
                (
                    this.KeywordsAlarmSendCode == input.KeywordsAlarmSendCode ||
                    (this.KeywordsAlarmSendCode != null &&
                    this.KeywordsAlarmSendCode.Equals(input.KeywordsAlarmSendCode))
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
                if (this.KeywordsAlarmRuleId != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmRuleId.GetHashCode();
                if (this.KeywordsAlarmRuleName != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmRuleName.GetHashCode();
                if (this.KeywordsAlarmRuleDescription != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmRuleDescription.GetHashCode();
                if (this.KeywordsRequests != null)
                    hashCode = hashCode * 59 + this.KeywordsRequests.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.KeywordsAlarmLevel != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmLevel.GetHashCode();
                if (this.KeywordsAlarmSend != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmSend.GetHashCode();
                if (this.KeywordsAlarmSendCode != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmSendCode.GetHashCode();
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
