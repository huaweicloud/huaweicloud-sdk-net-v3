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
    public class EventItemDetail 
    {
        /// <summary>
        /// **参数解释**： 事件状态。 **约束限制**： 不涉及。 **取值范围**： 枚举类型。 - normal：正常发生 - warning：异常 - incident：严重 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释**： 事件状态。 **约束限制**： 不涉及。 **取值范围**： 枚举类型。 - normal：正常发生 - warning：异常 - incident：严重 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<EventStateEnum>))]
        public class EventStateEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly EventStateEnum NORMAL = new EventStateEnum("normal");

            /// <summary>
            /// Enum WARNING for value: warning
            /// </summary>
            public static readonly EventStateEnum WARNING = new EventStateEnum("warning");

            /// <summary>
            /// Enum INCIDENT for value: incident
            /// </summary>
            public static readonly EventStateEnum INCIDENT = new EventStateEnum("incident");

            private static readonly Dictionary<string, EventStateEnum> StaticFields =
            new Dictionary<string, EventStateEnum>()
            {
                { "normal", NORMAL },
                { "warning", WARNING },
                { "incident", INCIDENT },
            };

            private string _value;

            public EventStateEnum()
            {

            }

            public EventStateEnum(string value)
            {
                _value = value;
            }

            public static EventStateEnum FromValue(string value)
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

                if (this.Equals(obj as EventStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventStateEnum a, EventStateEnum b)
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

            public static bool operator !=(EventStateEnum a, EventStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 事件级别。 **约束限制**： 不涉及。 **取值范围**： 枚举类型：Critical, Major, Minor, Info。 - Critical: 紧急 - Major: 重要 - Minor: 次要 - Info: 提示 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释**： 事件级别。 **约束限制**： 不涉及。 **取值范围**： 枚举类型：Critical, Major, Minor, Info。 - Critical: 紧急 - Major: 重要 - Minor: 次要 - Info: 提示 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<EventLevelEnum>))]
        public class EventLevelEnum
        {
            /// <summary>
            /// Enum CRITICAL for value: Critical
            /// </summary>
            public static readonly EventLevelEnum CRITICAL = new EventLevelEnum("Critical");

            /// <summary>
            /// Enum MAJOR for value: Major
            /// </summary>
            public static readonly EventLevelEnum MAJOR = new EventLevelEnum("Major");

            /// <summary>
            /// Enum MINOR for value: Minor
            /// </summary>
            public static readonly EventLevelEnum MINOR = new EventLevelEnum("Minor");

            /// <summary>
            /// Enum INFO for value: Info
            /// </summary>
            public static readonly EventLevelEnum INFO = new EventLevelEnum("Info");

            private static readonly Dictionary<string, EventLevelEnum> StaticFields =
            new Dictionary<string, EventLevelEnum>()
            {
                { "Critical", CRITICAL },
                { "Major", MAJOR },
                { "Minor", MINOR },
                { "Info", INFO },
            };

            private string _value;

            public EventLevelEnum()
            {

            }

            public EventLevelEnum(string value)
            {
                _value = value;
            }

            public static EventLevelEnum FromValue(string value)
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

                if (this.Equals(obj as EventLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventLevelEnum a, EventLevelEnum b)
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

            public static bool operator !=(EventLevelEnum a, EventLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 事件类型。 **约束限制**： EVENT.SYS为系统事件，用户自己不能上报系统事件，只能传EVENT.CUSTOM。 **取值范围**： 枚举类型，EVENT.SYS或EVENT.CUSTOM。 - EVENT.SYS：系统事件 - EVENT.CUSTOM：自定义事件 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释**： 事件类型。 **约束限制**： EVENT.SYS为系统事件，用户自己不能上报系统事件，只能传EVENT.CUSTOM。 **取值范围**： 枚举类型，EVENT.SYS或EVENT.CUSTOM。 - EVENT.SYS：系统事件 - EVENT.CUSTOM：自定义事件 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<EventTypeEnum>))]
        public class EventTypeEnum
        {
            /// <summary>
            /// Enum EVENT_SYS for value: EVENT.SYS
            /// </summary>
            public static readonly EventTypeEnum EVENT_SYS = new EventTypeEnum("EVENT.SYS");

            /// <summary>
            /// Enum EVENT_CUSTOM for value: EVENT.CUSTOM
            /// </summary>
            public static readonly EventTypeEnum EVENT_CUSTOM = new EventTypeEnum("EVENT.CUSTOM");

            private static readonly Dictionary<string, EventTypeEnum> StaticFields =
            new Dictionary<string, EventTypeEnum>()
            {
                { "EVENT.SYS", EVENT_SYS },
                { "EVENT.CUSTOM", EVENT_CUSTOM },
            };

            private string _value;

            public EventTypeEnum()
            {

            }

            public EventTypeEnum(string value)
            {
                _value = value;
            }

            public static EventTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EventTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventTypeEnum a, EventTypeEnum b)
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

            public static bool operator !=(EventTypeEnum a, EventTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 事件子类。 **约束限制**： 不涉及。 **取值范围**： 枚举类型 - SUB_EVENT.OPS: 运维事件 - SUB_EVENT.PLAN: 计划事件 - SUB_EVENT.CUSTOM: 自定义事件 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释**： 事件子类。 **约束限制**： 不涉及。 **取值范围**： 枚举类型 - SUB_EVENT.OPS: 运维事件 - SUB_EVENT.PLAN: 计划事件 - SUB_EVENT.CUSTOM: 自定义事件 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<SubEventTypeEnum>))]
        public class SubEventTypeEnum
        {
            /// <summary>
            /// Enum SUB_EVENT_OPS for value: SUB_EVENT.OPS
            /// </summary>
            public static readonly SubEventTypeEnum SUB_EVENT_OPS = new SubEventTypeEnum("SUB_EVENT.OPS");

            /// <summary>
            /// Enum SUB_EVENT_PLAN for value: SUB_EVENT.PLAN
            /// </summary>
            public static readonly SubEventTypeEnum SUB_EVENT_PLAN = new SubEventTypeEnum("SUB_EVENT.PLAN");

            /// <summary>
            /// Enum SUB_EVENT_CUSTOM for value: SUB_EVENT.CUSTOM
            /// </summary>
            public static readonly SubEventTypeEnum SUB_EVENT_CUSTOM = new SubEventTypeEnum("SUB_EVENT.CUSTOM");

            private static readonly Dictionary<string, SubEventTypeEnum> StaticFields =
            new Dictionary<string, SubEventTypeEnum>()
            {
                { "SUB_EVENT.OPS", SUB_EVENT_OPS },
                { "SUB_EVENT.PLAN", SUB_EVENT_PLAN },
                { "SUB_EVENT.CUSTOM", SUB_EVENT_CUSTOM },
            };

            private string _value;

            public SubEventTypeEnum()
            {

            }

            public SubEventTypeEnum(string value)
            {
                _value = value;
            }

            public static SubEventTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SubEventTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SubEventTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SubEventTypeEnum a, SubEventTypeEnum b)
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

            public static bool operator !=(SubEventTypeEnum a, SubEventTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 事件内容 **约束限制**： 不涉及。 **取值范围**： 长度为[0,4096]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// **参数解释**： 所属分组。 资源分组对应的ID，必须是已存在的分组ID。 分组ID查询方法： 1.登录管理控制台。 2.单击“云监控服务”。 3.单击页面左侧的“资源分组”。 在名称/ID列获取具体资源分组ID。 **约束限制**： 不涉及。 **取值范围**： 长度只能为24个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 资源ID。 资源ID的查询方法： 1.登录管理控制台。 2.单击“计算 &gt; 弹性云服务器”。 在资源概览页可获取具体资源ID。 **约束限制**： 不涉及。 **取值范围**： 支持字母、数字支持字母、数字、下划线（_）、中划线（-）和冒号（:），最大长度128个字符。例如，6a69bf28-ee62-49f3-9785-845dacd799ec。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// **参数解释**： 资源名称。 **约束限制**： 不涉及。 **取值范围**： 支持字母 中文 数字_ -. ，最大长度128个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// **参数解释**： 事件状态。 **约束限制**： 不涉及。 **取值范围**： 枚举类型。 - normal：正常发生 - warning：异常 - incident：严重 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("event_state", NullValueHandling = NullValueHandling.Ignore)]
        public EventStateEnum EventState { get; set; }
        /// <summary>
        /// **参数解释**： 事件级别。 **约束限制**： 不涉及。 **取值范围**： 枚举类型：Critical, Major, Minor, Info。 - Critical: 紧急 - Major: 重要 - Minor: 次要 - Info: 提示 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("event_level", NullValueHandling = NullValueHandling.Ignore)]
        public EventLevelEnum EventLevel { get; set; }
        /// <summary>
        /// **参数解释**： 事件用户。 **约束限制**： 不涉及。 **取值范围**： 支持字母 数字_ -/空格 ，长度为[0,64]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("event_user", NullValueHandling = NullValueHandling.Ignore)]
        public string EventUser { get; set; }

        /// <summary>
        /// **参数解释**： 事件类型。 **约束限制**： EVENT.SYS为系统事件，用户自己不能上报系统事件，只能传EVENT.CUSTOM。 **取值范围**： 枚举类型，EVENT.SYS或EVENT.CUSTOM。 - EVENT.SYS：系统事件 - EVENT.CUSTOM：自定义事件 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// **参数解释**： 事件子类。 **约束限制**： 不涉及。 **取值范围**： 枚举类型 - SUB_EVENT.OPS: 运维事件 - SUB_EVENT.PLAN: 计划事件 - SUB_EVENT.CUSTOM: 自定义事件 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sub_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public SubEventTypeEnum SubEventType { get; set; }
        /// <summary>
        /// **参数解释**： 事件的维度，根据维度描述资源信息。 用于指定资源、资源分组的事件告警场景中，支持按维度配置告警规则。 **约束限制**： 目前最大支持4个维度。 
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricsDimension> Dimensions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventItemDetail {\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  eventState: ").Append(EventState).Append("\n");
            sb.Append("  eventLevel: ").Append(EventLevel).Append("\n");
            sb.Append("  eventUser: ").Append(EventUser).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  subEventType: ").Append(SubEventType).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventItemDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventItemDetail input)
        {
            if (input == null) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.EventState != input.EventState) return false;
            if (this.EventLevel != input.EventLevel) return false;
            if (this.EventUser != input.EventUser || (this.EventUser != null && !this.EventUser.Equals(input.EventUser))) return false;
            if (this.EventType != input.EventType) return false;
            if (this.SubEventType != input.SubEventType) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;

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
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                hashCode = hashCode * 59 + this.EventState.GetHashCode();
                hashCode = hashCode * 59 + this.EventLevel.GetHashCode();
                if (this.EventUser != null) hashCode = hashCode * 59 + this.EventUser.GetHashCode();
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
                hashCode = hashCode * 59 + this.SubEventType.GetHashCode();
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                return hashCode;
            }
        }
    }
}
