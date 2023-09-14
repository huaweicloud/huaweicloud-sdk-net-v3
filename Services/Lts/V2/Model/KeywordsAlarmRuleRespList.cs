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
    public class KeywordsAlarmRuleRespList 
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
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("RUNNING");

            /// <summary>
            /// Enum STOPPING for value: STOPPING
            /// </summary>
            public static readonly StatusEnum STOPPING = new StatusEnum("STOPPING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "RUNNING", RUNNING },
                { "STOPPING", STOPPING },
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
        /// 项目id
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

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
        /// 关键词告警信息描述
        /// </summary>
        [JsonProperty("keywords_alarm_rule_description", NullValueHandling = NullValueHandling.Ignore)]
        public string KeywordsAlarmRuleDescription { get; set; }

        /// <summary>
        /// 条件
        /// </summary>
        [JsonProperty("condition_expression", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionExpression { get; set; }

        /// <summary>
        /// 关键词详细信息
        /// </summary>
        [JsonProperty("keywords_requests", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeywordsRequest> KeywordsRequests { get; set; }

        /// <summary>
        /// 告警统计周期
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Object Frequency { get; set; }

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
        /// 主题
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Topics> Topics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
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
            sb.Append("class KeywordsAlarmRuleRespList {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  keywordsAlarmRuleId: ").Append(KeywordsAlarmRuleId).Append("\n");
            sb.Append("  keywordsAlarmRuleName: ").Append(KeywordsAlarmRuleName).Append("\n");
            sb.Append("  keywordsAlarmRuleDescription: ").Append(KeywordsAlarmRuleDescription).Append("\n");
            sb.Append("  conditionExpression: ").Append(ConditionExpression).Append("\n");
            sb.Append("  keywordsRequests: ").Append(KeywordsRequests).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  keywordsAlarmLevel: ").Append(KeywordsAlarmLevel).Append("\n");
            sb.Append("  keywordsAlarmSend: ").Append(KeywordsAlarmSend).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
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
            return this.Equals(input as KeywordsAlarmRuleRespList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeywordsAlarmRuleRespList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
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
                    this.ConditionExpression == input.ConditionExpression ||
                    (this.ConditionExpression != null &&
                    this.ConditionExpression.Equals(input.ConditionExpression))
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
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.KeywordsAlarmRuleId != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmRuleId.GetHashCode();
                if (this.KeywordsAlarmRuleName != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmRuleName.GetHashCode();
                if (this.KeywordsAlarmRuleDescription != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmRuleDescription.GetHashCode();
                if (this.ConditionExpression != null)
                    hashCode = hashCode * 59 + this.ConditionExpression.GetHashCode();
                if (this.KeywordsRequests != null)
                    hashCode = hashCode * 59 + this.KeywordsRequests.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.KeywordsAlarmLevel != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmLevel.GetHashCode();
                if (this.KeywordsAlarmSend != null)
                    hashCode = hashCode * 59 + this.KeywordsAlarmSend.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
