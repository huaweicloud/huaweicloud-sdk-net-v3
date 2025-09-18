using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 伸缩策略详情
    /// </summary>
    public class ScalingV2PolicyDetail 
    {
        /// <summary>
        /// 伸缩资源类型。伸缩组：SCALING_GROUP。带宽：BANDWIDTH。
        /// </summary>
        /// <value>伸缩资源类型。伸缩组：SCALING_GROUP。带宽：BANDWIDTH。</value>
        [JsonConverter(typeof(EnumClassConverter<ScalingResourceTypeEnum>))]
        public class ScalingResourceTypeEnum
        {
            /// <summary>
            /// Enum SCALING_GROUP for value: SCALING_GROUP
            /// </summary>
            public static readonly ScalingResourceTypeEnum SCALING_GROUP = new ScalingResourceTypeEnum("SCALING_GROUP");

            /// <summary>
            /// Enum BANDWIDTH for value: BANDWIDTH
            /// </summary>
            public static readonly ScalingResourceTypeEnum BANDWIDTH = new ScalingResourceTypeEnum("BANDWIDTH");

            private static readonly Dictionary<string, ScalingResourceTypeEnum> StaticFields =
            new Dictionary<string, ScalingResourceTypeEnum>()
            {
                { "SCALING_GROUP", SCALING_GROUP },
                { "BANDWIDTH", BANDWIDTH },
            };

            private string _value;

            public ScalingResourceTypeEnum()
            {

            }

            public ScalingResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ScalingResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ScalingResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScalingResourceTypeEnum a, ScalingResourceTypeEnum b)
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

            public static bool operator !=(ScalingResourceTypeEnum a, ScalingResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 伸缩策略状态。INSERVICE：使用中。PAUSED：停止。EXECUTING：执行中。
        /// </summary>
        /// <value>伸缩策略状态。INSERVICE：使用中。PAUSED：停止。EXECUTING：执行中。</value>
        [JsonConverter(typeof(EnumClassConverter<PolicyStatusEnum>))]
        public class PolicyStatusEnum
        {
            /// <summary>
            /// Enum INSERVICE for value: INSERVICE
            /// </summary>
            public static readonly PolicyStatusEnum INSERVICE = new PolicyStatusEnum("INSERVICE");

            /// <summary>
            /// Enum PAUSED for value: PAUSED
            /// </summary>
            public static readonly PolicyStatusEnum PAUSED = new PolicyStatusEnum("PAUSED");

            /// <summary>
            /// Enum EXECUTING for value: EXECUTING
            /// </summary>
            public static readonly PolicyStatusEnum EXECUTING = new PolicyStatusEnum("EXECUTING");

            private static readonly Dictionary<string, PolicyStatusEnum> StaticFields =
            new Dictionary<string, PolicyStatusEnum>()
            {
                { "INSERVICE", INSERVICE },
                { "PAUSED", PAUSED },
                { "EXECUTING", EXECUTING },
            };

            private string _value;

            public PolicyStatusEnum()
            {

            }

            public PolicyStatusEnum(string value)
            {
                _value = value;
            }

            public static PolicyStatusEnum FromValue(string value)
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

                if (this.Equals(obj as PolicyStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PolicyStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PolicyStatusEnum a, PolicyStatusEnum b)
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

            public static bool operator !=(PolicyStatusEnum a, PolicyStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 伸缩策略类型：ALARM：告警策略，此时alarm_id有返回，scheduled_policy不会返回。SCHEDULED：定时策略，此时alarm_id不会返回，scheduled_policy有返回，并且recurrence_type、recurrence_value、start_time和end_time不会返回。RECURRENCE：周期策略，此时alarm_id不会返回，scheduled_policy有返回，并且recurrence_type、recurrence_value、start_time和end_time有返回。
        /// </summary>
        /// <value>伸缩策略类型：ALARM：告警策略，此时alarm_id有返回，scheduled_policy不会返回。SCHEDULED：定时策略，此时alarm_id不会返回，scheduled_policy有返回，并且recurrence_type、recurrence_value、start_time和end_time不会返回。RECURRENCE：周期策略，此时alarm_id不会返回，scheduled_policy有返回，并且recurrence_type、recurrence_value、start_time和end_time有返回。</value>
        [JsonConverter(typeof(EnumClassConverter<ScalingPolicyTypeEnum>))]
        public class ScalingPolicyTypeEnum
        {
            /// <summary>
            /// Enum ALARM for value: ALARM
            /// </summary>
            public static readonly ScalingPolicyTypeEnum ALARM = new ScalingPolicyTypeEnum("ALARM");

            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            public static readonly ScalingPolicyTypeEnum SCHEDULED = new ScalingPolicyTypeEnum("SCHEDULED");

            /// <summary>
            /// Enum RECURRENCE for value: RECURRENCE
            /// </summary>
            public static readonly ScalingPolicyTypeEnum RECURRENCE = new ScalingPolicyTypeEnum("RECURRENCE");

            /// <summary>
            /// Enum INTERVAL_ALARM for value: INTERVAL_ALARM
            /// </summary>
            public static readonly ScalingPolicyTypeEnum INTERVAL_ALARM = new ScalingPolicyTypeEnum("INTERVAL_ALARM");

            private static readonly Dictionary<string, ScalingPolicyTypeEnum> StaticFields =
            new Dictionary<string, ScalingPolicyTypeEnum>()
            {
                { "ALARM", ALARM },
                { "SCHEDULED", SCHEDULED },
                { "RECURRENCE", RECURRENCE },
                { "INTERVAL_ALARM", INTERVAL_ALARM },
            };

            private string _value;

            public ScalingPolicyTypeEnum()
            {

            }

            public ScalingPolicyTypeEnum(string value)
            {
                _value = value;
            }

            public static ScalingPolicyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ScalingPolicyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingPolicyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScalingPolicyTypeEnum a, ScalingPolicyTypeEnum b)
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

            public static bool operator !=(ScalingPolicyTypeEnum a, ScalingPolicyTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩策略名称。
        /// </summary>
        [JsonProperty("scaling_policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyName { get; set; }

        /// <summary>
        /// 伸缩策略ID。
        /// </summary>
        [JsonProperty("scaling_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// 伸缩资源ID。
        /// </summary>
        [JsonProperty("scaling_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingResourceId { get; set; }

        /// <summary>
        /// 伸缩资源类型。伸缩组：SCALING_GROUP。带宽：BANDWIDTH。
        /// </summary>
        [JsonProperty("scaling_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingResourceTypeEnum ScalingResourceType { get; set; }
        /// <summary>
        /// 伸缩策略状态。INSERVICE：使用中。PAUSED：停止。EXECUTING：执行中。
        /// </summary>
        [JsonProperty("policy_status", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyStatusEnum PolicyStatus { get; set; }
        /// <summary>
        /// 伸缩策略类型：ALARM：告警策略，此时alarm_id有返回，scheduled_policy不会返回。SCHEDULED：定时策略，此时alarm_id不会返回，scheduled_policy有返回，并且recurrence_type、recurrence_value、start_time和end_time不会返回。RECURRENCE：周期策略，此时alarm_id不会返回，scheduled_policy有返回，并且recurrence_type、recurrence_value、start_time和end_time有返回。
        /// </summary>
        [JsonProperty("scaling_policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingPolicyTypeEnum ScalingPolicyType { get; set; }
        /// <summary>
        /// 告警ID。
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduled_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduledPolicy ScheduledPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scaling_policy_action", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingPolicyActionV2 ScalingPolicyAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("interval_alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<IntervalAlarmActionsV2> IntervalAlarmActions { get; set; }

        /// <summary>
        /// 冷却时间，取值范围0-86400，默认为300，单位是秒。
        /// </summary>
        [JsonProperty("cool_down_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoolDownTime { get; set; }

        /// <summary>
        /// 创建伸缩策略时间，遵循UTC时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingPolicyV2MetaData MetaData { get; set; }

        /// <summary>
        /// 伸缩策略描述（1-256个字符）
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingV2PolicyDetail {\n");
            sb.Append("  scalingPolicyName: ").Append(ScalingPolicyName).Append("\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("  scalingResourceId: ").Append(ScalingResourceId).Append("\n");
            sb.Append("  scalingResourceType: ").Append(ScalingResourceType).Append("\n");
            sb.Append("  policyStatus: ").Append(PolicyStatus).Append("\n");
            sb.Append("  scalingPolicyType: ").Append(ScalingPolicyType).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  scheduledPolicy: ").Append(ScheduledPolicy).Append("\n");
            sb.Append("  scalingPolicyAction: ").Append(ScalingPolicyAction).Append("\n");
            sb.Append("  intervalAlarmActions: ").Append(IntervalAlarmActions).Append("\n");
            sb.Append("  coolDownTime: ").Append(CoolDownTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingV2PolicyDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingV2PolicyDetail input)
        {
            if (input == null) return false;
            if (this.ScalingPolicyName != input.ScalingPolicyName || (this.ScalingPolicyName != null && !this.ScalingPolicyName.Equals(input.ScalingPolicyName))) return false;
            if (this.ScalingPolicyId != input.ScalingPolicyId || (this.ScalingPolicyId != null && !this.ScalingPolicyId.Equals(input.ScalingPolicyId))) return false;
            if (this.ScalingResourceId != input.ScalingResourceId || (this.ScalingResourceId != null && !this.ScalingResourceId.Equals(input.ScalingResourceId))) return false;
            if (this.ScalingResourceType != input.ScalingResourceType) return false;
            if (this.PolicyStatus != input.PolicyStatus) return false;
            if (this.ScalingPolicyType != input.ScalingPolicyType) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.ScheduledPolicy != input.ScheduledPolicy || (this.ScheduledPolicy != null && !this.ScheduledPolicy.Equals(input.ScheduledPolicy))) return false;
            if (this.ScalingPolicyAction != input.ScalingPolicyAction || (this.ScalingPolicyAction != null && !this.ScalingPolicyAction.Equals(input.ScalingPolicyAction))) return false;
            if (this.IntervalAlarmActions != input.IntervalAlarmActions || (this.IntervalAlarmActions != null && input.IntervalAlarmActions != null && !this.IntervalAlarmActions.SequenceEqual(input.IntervalAlarmActions))) return false;
            if (this.CoolDownTime != input.CoolDownTime || (this.CoolDownTime != null && !this.CoolDownTime.Equals(input.CoolDownTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.MetaData != input.MetaData || (this.MetaData != null && !this.MetaData.Equals(input.MetaData))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.ScalingPolicyName != null) hashCode = hashCode * 59 + this.ScalingPolicyName.GetHashCode();
                if (this.ScalingPolicyId != null) hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                if (this.ScalingResourceId != null) hashCode = hashCode * 59 + this.ScalingResourceId.GetHashCode();
                hashCode = hashCode * 59 + this.ScalingResourceType.GetHashCode();
                hashCode = hashCode * 59 + this.PolicyStatus.GetHashCode();
                hashCode = hashCode * 59 + this.ScalingPolicyType.GetHashCode();
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.ScheduledPolicy != null) hashCode = hashCode * 59 + this.ScheduledPolicy.GetHashCode();
                if (this.ScalingPolicyAction != null) hashCode = hashCode * 59 + this.ScalingPolicyAction.GetHashCode();
                if (this.IntervalAlarmActions != null) hashCode = hashCode * 59 + this.IntervalAlarmActions.GetHashCode();
                if (this.CoolDownTime != null) hashCode = hashCode * 59 + this.CoolDownTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.MetaData != null) hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
