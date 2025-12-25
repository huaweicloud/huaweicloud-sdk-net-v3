using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAlarmRequestBody 
    {
        /// <summary>
        /// **参数解释**： 告警类型。 **约束限制**： 不涉及 **取值范围**： - EVENT.SYS：针对系统事件的告警规则。 - EVENT.CUSTOM：针对自定义事件的告警规则。 - RESOURCE_GROUP：针对资源分组的告警规则。 - MULTI_INSTANCE： 针对指定资源的告警规则。 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释**： 告警类型。 **约束限制**： 不涉及 **取值范围**： - EVENT.SYS：针对系统事件的告警规则。 - EVENT.CUSTOM：针对自定义事件的告警规则。 - RESOURCE_GROUP：针对资源分组的告警规则。 - MULTI_INSTANCE： 针对指定资源的告警规则。 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<AlarmTypeEnum>))]
        public class AlarmTypeEnum
        {
            /// <summary>
            /// Enum EVENT_SYS for value: EVENT.SYS
            /// </summary>
            public static readonly AlarmTypeEnum EVENT_SYS = new AlarmTypeEnum("EVENT.SYS");

            /// <summary>
            /// Enum EVENT_CUSTOM for value: EVENT.CUSTOM
            /// </summary>
            public static readonly AlarmTypeEnum EVENT_CUSTOM = new AlarmTypeEnum("EVENT.CUSTOM");

            /// <summary>
            /// Enum RESOURCE_GROUP for value: RESOURCE_GROUP
            /// </summary>
            public static readonly AlarmTypeEnum RESOURCE_GROUP = new AlarmTypeEnum("RESOURCE_GROUP");

            /// <summary>
            /// Enum MULTI_INSTANCE for value: MULTI_INSTANCE
            /// </summary>
            public static readonly AlarmTypeEnum MULTI_INSTANCE = new AlarmTypeEnum("MULTI_INSTANCE");

            private static readonly Dictionary<string, AlarmTypeEnum> StaticFields =
            new Dictionary<string, AlarmTypeEnum>()
            {
                { "EVENT.SYS", EVENT_SYS },
                { "EVENT.CUSTOM", EVENT_CUSTOM },
                { "RESOURCE_GROUP", RESOURCE_GROUP },
                { "MULTI_INSTANCE", MULTI_INSTANCE },
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

            public static bool operator !=(AlarmTypeEnum a, AlarmTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 告警规则名称 **约束限制**： 不涉及 **取值范围**： 只能包含0-9/a-z/A-Z/_/-或汉字，长度[1, 128]个字符 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("alarm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmName { get; set; }

        /// <summary>
        /// **参数解释**： 告警描述。 **约束限制**： 不涉及。 **取值范围**： 长度[0,256]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Condition Condition { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启告警通知 **约束限制**： 若alarm_action_enabled为true，对应的alarm_actions、ok_actions至少有一个不能为空。若alarm_actions、ok_actions同时存在时，notificationList值保持一致。 **取值范围**： 只能为true、false - true: 开启告警通知 - false：关闭告警通知 **默认取值**: false。 
        /// </summary>
        [JsonProperty("alarm_action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmActionEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 告警级别 **约束限制**： 不涉及 **取值范围**： 级别为1、2、3、4。 - 1：紧急 - 2：重要 - 3：次要 - 4：提示 **默认取值**: 2 
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }

        /// <summary>
        /// **参数解释**： 告警类型。 **约束限制**： 不涉及 **取值范围**： - EVENT.SYS：针对系统事件的告警规则。 - EVENT.CUSTOM：针对自定义事件的告警规则。 - RESOURCE_GROUP：针对资源分组的告警规则。 - MULTI_INSTANCE： 针对指定资源的告警规则。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmTypeEnum AlarmType { get; set; }
        /// <summary>
        /// **参数解释**： 告警触发时，通知组/主题订阅的信息。结构样例如下： { \&quot;type\&quot;: \&quot;notification\&quot;,\&quot;notificationList\&quot;:[\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;] } **约束限制**： 最多包含10个告警触发时的通知对象信息。 
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<Notification>> AlarmActions { get; set; }

        /// <summary>
        /// **参数解释**： 数据不足触发告警时，通知组/主题订阅的信息。（该参数已废弃，建议无需配置） **约束限制**： 最多包含10个告警动作。 
        /// </summary>
        [JsonProperty("insufficientdata_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<Notification>> InsufficientdataActions { get; set; }

        /// <summary>
        /// **参数解释**： 告警恢复时，通知组/主题订阅的信息。结构样例如下： { \&quot;type\&quot;: \&quot;notification\&quot;,\&quot;notificationList\&quot;:[\&quot;urn:smn:southchina:68438a86d98e427e907e0097b7e35d47:sd\&quot;] }  **约束限制**： 最多包含10个告警触发时的通知对象信息。 
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<Notification>> OkActions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAlarmRequestBody {\n");
            sb.Append("  alarmName: ").Append(AlarmName).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmActionEnabled: ").Append(AlarmActionEnabled).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  insufficientdataActions: ").Append(InsufficientdataActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAlarmRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAlarmRequestBody input)
        {
            if (input == null) return false;
            if (this.AlarmName != input.AlarmName || (this.AlarmName != null && !this.AlarmName.Equals(input.AlarmName))) return false;
            if (this.AlarmDescription != input.AlarmDescription || (this.AlarmDescription != null && !this.AlarmDescription.Equals(input.AlarmDescription))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.AlarmActionEnabled != input.AlarmActionEnabled || (this.AlarmActionEnabled != null && !this.AlarmActionEnabled.Equals(input.AlarmActionEnabled))) return false;
            if (this.AlarmLevel != input.AlarmLevel || (this.AlarmLevel != null && !this.AlarmLevel.Equals(input.AlarmLevel))) return false;
            if (this.AlarmType != input.AlarmType) return false;
            if (this.AlarmActions != input.AlarmActions || (this.AlarmActions != null && input.AlarmActions != null && !this.AlarmActions.SequenceEqual(input.AlarmActions))) return false;
            if (this.InsufficientdataActions != input.InsufficientdataActions || (this.InsufficientdataActions != null && input.InsufficientdataActions != null && !this.InsufficientdataActions.SequenceEqual(input.InsufficientdataActions))) return false;
            if (this.OkActions != input.OkActions || (this.OkActions != null && input.OkActions != null && !this.OkActions.SequenceEqual(input.OkActions))) return false;

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
                if (this.AlarmName != null) hashCode = hashCode * 59 + this.AlarmName.GetHashCode();
                if (this.AlarmDescription != null) hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmActionEnabled != null) hashCode = hashCode * 59 + this.AlarmActionEnabled.GetHashCode();
                if (this.AlarmLevel != null) hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.AlarmActions != null) hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.InsufficientdataActions != null) hashCode = hashCode * 59 + this.InsufficientdataActions.GetHashCode();
                if (this.OkActions != null) hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                return hashCode;
            }
        }
    }
}
