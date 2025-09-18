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
    /// 创建伸缩策略
    /// </summary>
    public class CreateScalingPolicyOption 
    {
        /// <summary>
        /// 策略类型。告警策略：ALARM（与alarm_id对应）；定时策略：SCHEDULED（与scheduled_policy对应）；周期策略：RECURRENCE（与scheduled_policy对应）
        /// </summary>
        /// <value>策略类型。告警策略：ALARM（与alarm_id对应）；定时策略：SCHEDULED（与scheduled_policy对应）；周期策略：RECURRENCE（与scheduled_policy对应）</value>
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

            private static readonly Dictionary<string, ScalingPolicyTypeEnum> StaticFields =
            new Dictionary<string, ScalingPolicyTypeEnum>()
            {
                { "ALARM", ALARM },
                { "SCHEDULED", SCHEDULED },
                { "RECURRENCE", RECURRENCE },
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
        /// 策略名称(1-64字符)，可以用中文、字母、数字、下划线、中划线的组合。
        /// </summary>
        [JsonProperty("scaling_policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyName { get; set; }

        /// <summary>
        /// 伸缩组ID，通过查询弹性伸缩组列表获取，详见查询弹性伸缩组列表。
        /// </summary>
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 策略类型。告警策略：ALARM（与alarm_id对应）；定时策略：SCHEDULED（与scheduled_policy对应）；周期策略：RECURRENCE（与scheduled_policy对应）
        /// </summary>
        [JsonProperty("scaling_policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingPolicyTypeEnum ScalingPolicyType { get; set; }
        /// <summary>
        /// 告警ID，即告警规则的ID，当scaling_policy_type为ALARM时该项必选，此时scheduled_policy不生效。创建告警策略成功后，会自动为该告警ID对应的告警规则的alarm_actions字段增加类型为autoscaling的告警触发动作。告警ID通过查询云监控告警规则列表获取，详见《云监控API参考》的“查询告警规则列表”。
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
        public ScalingPolicyActionV1 ScalingPolicyAction { get; set; }

        /// <summary>
        /// 冷却时间，取值范围0-86400，默认为300，单位是秒。
        /// </summary>
        [JsonProperty("cool_down_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoolDownTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScalingPolicyOption {\n");
            sb.Append("  scalingPolicyName: ").Append(ScalingPolicyName).Append("\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  scalingPolicyType: ").Append(ScalingPolicyType).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  scheduledPolicy: ").Append(ScheduledPolicy).Append("\n");
            sb.Append("  scalingPolicyAction: ").Append(ScalingPolicyAction).Append("\n");
            sb.Append("  coolDownTime: ").Append(CoolDownTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScalingPolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScalingPolicyOption input)
        {
            if (input == null) return false;
            if (this.ScalingPolicyName != input.ScalingPolicyName || (this.ScalingPolicyName != null && !this.ScalingPolicyName.Equals(input.ScalingPolicyName))) return false;
            if (this.ScalingGroupId != input.ScalingGroupId || (this.ScalingGroupId != null && !this.ScalingGroupId.Equals(input.ScalingGroupId))) return false;
            if (this.ScalingPolicyType != input.ScalingPolicyType) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.ScheduledPolicy != input.ScheduledPolicy || (this.ScheduledPolicy != null && !this.ScheduledPolicy.Equals(input.ScheduledPolicy))) return false;
            if (this.ScalingPolicyAction != input.ScalingPolicyAction || (this.ScalingPolicyAction != null && !this.ScalingPolicyAction.Equals(input.ScalingPolicyAction))) return false;
            if (this.CoolDownTime != input.CoolDownTime || (this.CoolDownTime != null && !this.CoolDownTime.Equals(input.CoolDownTime))) return false;

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
                if (this.ScalingGroupId != null) hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                hashCode = hashCode * 59 + this.ScalingPolicyType.GetHashCode();
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.ScheduledPolicy != null) hashCode = hashCode * 59 + this.ScheduledPolicy.GetHashCode();
                if (this.ScalingPolicyAction != null) hashCode = hashCode * 59 + this.ScalingPolicyAction.GetHashCode();
                if (this.CoolDownTime != null) hashCode = hashCode * 59 + this.CoolDownTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
