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
    /// Request Object
    /// </summary>
    public class ListEventDetailRequest 
    {
        /// <summary>
        /// **参数解释**： 事件类型。 **约束限制**： 不涉及。 **取值范围**： 值为EVENT.SYS或EVENT.CUSTOM。 - EVENT.SYS：系统事件。 - EVENT.CUSTOM：自定义事件。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 事件类型。 **约束限制**： 不涉及。 **取值范围**： 值为EVENT.SYS或EVENT.CUSTOM。 - EVENT.SYS：系统事件。 - EVENT.CUSTOM：自定义事件。 **默认取值**： 不涉及。</value>
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
        /// <value>**参数解释**： 事件子类。 **约束限制**： 不涉及。 **取值范围**： 枚举类型 - SUB_EVENT.OPS: 运维事件 - SUB_EVENT.PLAN: 计划事件 - SUB_EVENT.CUSTOM: 自定义事件 **默认取值**： 不涉及。</value>
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
        /// **参数解释**： 事件的级别。 **约束限制**： 不涉及。 **取值范围**： 值为Critical、Major、Minor、Info。 - Critical: 紧急 - Major: 重要 - Minor: 次要 - Info: 提示 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 事件的级别。 **约束限制**： 不涉及。 **取值范围**： 值为Critical、Major、Minor、Info。 - Critical: 紧急 - Major: 重要 - Minor: 次要 - Info: 提示 **默认取值**： 不涉及。</value>
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
            /// Enum INFO for value: Info
            /// </summary>
            public static readonly EventLevelEnum INFO = new EventLevelEnum("Info");

            /// <summary>
            /// Enum MINOR for value: Minor
            /// </summary>
            public static readonly EventLevelEnum MINOR = new EventLevelEnum("Minor");

            private static readonly Dictionary<string, EventLevelEnum> StaticFields =
            new Dictionary<string, EventLevelEnum>()
            {
                { "Critical", CRITICAL },
                { "Major", MAJOR },
                { "Info", INFO },
                { "Minor", MINOR },
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
        /// **参数解释**： 事件的状态。 **约束限制**： 不涉及。 **取值范围**： 值为normal、warning、incident。 - normal: 正常 - warning: 警告 - incident: 故障 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 事件的状态。 **约束限制**： 不涉及。 **取值范围**： 值为normal、warning、incident。 - normal: 正常 - warning: 警告 - incident: 故障 **默认取值**： 不涉及。</value>
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
        /// **参数解释**： 事件名称，值为系统产生的事件名称或用户自定义上报的事件名称。 **约束限制**： 不涉及。 **取值范围**： 长度为[1,64]个字符。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("event_name", IsPath = true)]
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// **参数解释**： 事件类型。 **约束限制**： 不涉及。 **取值范围**： 值为EVENT.SYS或EVENT.CUSTOM。 - EVENT.SYS：系统事件。 - EVENT.CUSTOM：自定义事件。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("event_type", IsQuery = true)]
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// **参数解释**： 事件子类。 **约束限制**： 不涉及。 **取值范围**： 枚举类型 - SUB_EVENT.OPS: 运维事件 - SUB_EVENT.PLAN: 计划事件 - SUB_EVENT.CUSTOM: 自定义事件 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("sub_event_type", IsQuery = true)]
        [JsonProperty("sub_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public SubEventTypeEnum SubEventType { get; set; }
        /// <summary>
        /// **参数解释**： 事件来源，取值为各云服务的命名空间。云服务的命名空间请参考“[支持监控的服务列表](ces_03_0059.xml)”。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,32]个字符。 正则匹配：以字母开头，中间有一个点，包含字母、数字、下划线的字符串。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("event_source", IsQuery = true)]
        [JsonProperty("event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSource { get; set; }

        /// <summary>
        /// **参数解释**： 事件的级别。 **约束限制**： 不涉及。 **取值范围**： 值为Critical、Major、Minor、Info。 - Critical: 紧急 - Major: 重要 - Minor: 次要 - Info: 提示 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("event_level", IsQuery = true)]
        [JsonProperty("event_level", NullValueHandling = NullValueHandling.Ignore)]
        public EventLevelEnum EventLevel { get; set; }
        /// <summary>
        /// **参数解释**： 上报事件监控数据时用户的名称，也可为projectID。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,64]个字符。 正则匹配：由零个或多个字母、数字、下划线、横线、斜杠、空格、@ 符号或点号组成的字符串。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("event_user", IsQuery = true)]
        [JsonProperty("event_user", NullValueHandling = NullValueHandling.Ignore)]
        public string EventUser { get; set; }

        /// <summary>
        /// **参数解释**： 事件的状态。 **约束限制**： 不涉及。 **取值范围**： 值为normal、warning、incident。 - normal: 正常 - warning: 警告 - incident: 故障 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("event_state", IsQuery = true)]
        [JsonProperty("event_state", NullValueHandling = NullValueHandling.Ignore)]
        public EventStateEnum EventState { get; set; }
        /// <summary>
        /// **参数解释**： 查询数据起始时间，UNIX时间戳，单位毫秒。例如：1605952700911。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        /// <summary>
        /// **参数解释**： 查询数据截止时间，UNIX时间戳，单位毫秒。 **约束限制**： 其中from必须小于to。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }

        /// <summary>
        /// **参数解释**： 分页起始值。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 0
        /// </summary>
        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public long? Start { get; set; }

        /// <summary>
        /// **参数解释**： 单次查询的条数限制，用于限制结果数据条数。 **约束限制**： 不涉及。 **取值范围**： 大小为[1,100]的整数 **默认取值**： 100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEventDetailRequest {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  subEventType: ").Append(SubEventType).Append("\n");
            sb.Append("  eventSource: ").Append(EventSource).Append("\n");
            sb.Append("  eventLevel: ").Append(EventLevel).Append("\n");
            sb.Append("  eventUser: ").Append(EventUser).Append("\n");
            sb.Append("  eventState: ").Append(EventState).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEventDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEventDetailRequest input)
        {
            if (input == null) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
            if (this.EventType != input.EventType) return false;
            if (this.SubEventType != input.SubEventType) return false;
            if (this.EventSource != input.EventSource || (this.EventSource != null && !this.EventSource.Equals(input.EventSource))) return false;
            if (this.EventLevel != input.EventLevel) return false;
            if (this.EventUser != input.EventUser || (this.EventUser != null && !this.EventUser.Equals(input.EventUser))) return false;
            if (this.EventState != input.EventState) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;
            if (this.Start != input.Start || (this.Start != null && !this.Start.Equals(input.Start))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.EventName != null) hashCode = hashCode * 59 + this.EventName.GetHashCode();
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
                hashCode = hashCode * 59 + this.SubEventType.GetHashCode();
                if (this.EventSource != null) hashCode = hashCode * 59 + this.EventSource.GetHashCode();
                hashCode = hashCode * 59 + this.EventLevel.GetHashCode();
                if (this.EventUser != null) hashCode = hashCode * 59 + this.EventUser.GetHashCode();
                hashCode = hashCode * 59 + this.EventState.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Start != null) hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
