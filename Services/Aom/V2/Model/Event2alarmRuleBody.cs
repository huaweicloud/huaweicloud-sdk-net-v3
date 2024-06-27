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
    /// 事件类告警实体
    /// </summary>
    public class Event2alarmRuleBody 
    {
        /// <summary>
        /// 告警类型。notification：直接告警。denoising：告警降噪。
        /// </summary>
        /// <value>告警类型。notification：直接告警。denoising：告警降噪。</value>
        [JsonConverter(typeof(EnumClassConverter<AlarmTypeEnum>))]
        public class AlarmTypeEnum
        {
            /// <summary>
            /// Enum NOTIFICATION for value: notification
            /// </summary>
            public static readonly AlarmTypeEnum NOTIFICATION = new AlarmTypeEnum("notification");

            /// <summary>
            /// Enum DENOISING for value: denoising
            /// </summary>
            public static readonly AlarmTypeEnum DENOISING = new AlarmTypeEnum("denoising");

            private static readonly Dictionary<string, AlarmTypeEnum> StaticFields =
            new Dictionary<string, AlarmTypeEnum>()
            {
                { "notification", NOTIFICATION },
                { "denoising", DENOISING },
            };

            private string _value;

            public AlarmTypeEnum()
            {

            }

            public AlarmTypeEnum(string value)
            {
                _value = value;
            }

            public static AlarmTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AlarmTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmTypeEnum a, AlarmTypeEnum b)
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

            public static bool operator !=(AlarmTypeEnum a, AlarmTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户项目id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 规则名称。规则名称包含大小写字母，数字，特殊字符（_-）和汉字组成，不能以特殊字符开头或结尾，最大长度为100。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规则描述。描述包含大小写字母，数字，特殊字符（_-&lt;&gt;&#x3D;,.）和汉字组成，不能以下划线、中划线开头结尾，最大长度为1024。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 事件源
        /// </summary>
        [JsonProperty("resource_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Event2alarmRuleBodyMetadata Metadata { get; set; }

        /// <summary>
        /// 规则是否启用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 触发策略
        /// </summary>
        [JsonProperty("trigger_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Event2alarmRuleBodyTriggerPolicies> TriggerPolicies { get; set; }

        /// <summary>
        /// 告警类型。notification：直接告警。denoising：告警降噪。
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmTypeEnum AlarmType { get; set; }
        /// <summary>
        /// 告警行动规则
        /// </summary>
        [JsonProperty("action_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionRule { get; set; }

        /// <summary>
        /// 告警抑制规则
        /// </summary>
        [JsonProperty("inhibit_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string InhibitRule { get; set; }

        /// <summary>
        /// 告警分组规则
        /// </summary>
        [JsonProperty("route_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string RouteGroupRule { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [JsonProperty("event_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EventNames { get; set; }

        /// <summary>
        /// 是否迁移到2.0
        /// </summary>
        [JsonProperty("migrated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Migrated { get; set; }

        /// <summary>
        /// smn信息
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmnTopics> Topics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event2alarmRuleBody {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  resourceProvider: ").Append(ResourceProvider).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  triggerPolicies: ").Append(TriggerPolicies).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  actionRule: ").Append(ActionRule).Append("\n");
            sb.Append("  inhibitRule: ").Append(InhibitRule).Append("\n");
            sb.Append("  routeGroupRule: ").Append(RouteGroupRule).Append("\n");
            sb.Append("  eventNames: ").Append(EventNames).Append("\n");
            sb.Append("  migrated: ").Append(Migrated).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Event2alarmRuleBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Event2alarmRuleBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.ResourceProvider == input.ResourceProvider ||
                    (this.ResourceProvider != null &&
                    this.ResourceProvider.Equals(input.ResourceProvider))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.TriggerPolicies == input.TriggerPolicies ||
                    this.TriggerPolicies != null &&
                    input.TriggerPolicies != null &&
                    this.TriggerPolicies.SequenceEqual(input.TriggerPolicies)
                ) && 
                (
                    this.AlarmType == input.AlarmType ||
                    (this.AlarmType != null &&
                    this.AlarmType.Equals(input.AlarmType))
                ) && 
                (
                    this.ActionRule == input.ActionRule ||
                    (this.ActionRule != null &&
                    this.ActionRule.Equals(input.ActionRule))
                ) && 
                (
                    this.InhibitRule == input.InhibitRule ||
                    (this.InhibitRule != null &&
                    this.InhibitRule.Equals(input.InhibitRule))
                ) && 
                (
                    this.RouteGroupRule == input.RouteGroupRule ||
                    (this.RouteGroupRule != null &&
                    this.RouteGroupRule.Equals(input.RouteGroupRule))
                ) && 
                (
                    this.EventNames == input.EventNames ||
                    this.EventNames != null &&
                    input.EventNames != null &&
                    this.EventNames.SequenceEqual(input.EventNames)
                ) && 
                (
                    this.Migrated == input.Migrated ||
                    (this.Migrated != null &&
                    this.Migrated.Equals(input.Migrated))
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ResourceProvider != null)
                    hashCode = hashCode * 59 + this.ResourceProvider.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.TriggerPolicies != null)
                    hashCode = hashCode * 59 + this.TriggerPolicies.GetHashCode();
                if (this.AlarmType != null)
                    hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.ActionRule != null)
                    hashCode = hashCode * 59 + this.ActionRule.GetHashCode();
                if (this.InhibitRule != null)
                    hashCode = hashCode * 59 + this.InhibitRule.GetHashCode();
                if (this.RouteGroupRule != null)
                    hashCode = hashCode * 59 + this.RouteGroupRule.GetHashCode();
                if (this.EventNames != null)
                    hashCode = hashCode * 59 + this.EventNames.GetHashCode();
                if (this.Migrated != null)
                    hashCode = hashCode * 59 + this.Migrated.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                return hashCode;
            }
        }
    }
}
