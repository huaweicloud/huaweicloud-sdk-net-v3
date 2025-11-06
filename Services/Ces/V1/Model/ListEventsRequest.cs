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
    public class ListEventsRequest 
    {
        /// <summary>
        /// 事件类型，值为EVENT.SYS或EVENT.CUSTOM，EVENT.SYS表示系统事件，EVENT.CUSTOM表示自定义事件。
        /// </summary>
        /// <value>事件类型，值为EVENT.SYS或EVENT.CUSTOM，EVENT.SYS表示系统事件，EVENT.CUSTOM表示自定义事件。</value>
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
        /// 事件子类, 枚举类型：SUB_EVENT.OPS 运维事件, SUB_EVENT.PLAN 计划事件，SUB_EVENT.CUSTOM 自定义事件
        /// </summary>
        /// <value>事件子类, 枚举类型：SUB_EVENT.OPS 运维事件, SUB_EVENT.PLAN 计划事件，SUB_EVENT.CUSTOM 自定义事件</value>
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
        /// 事件类型，值为EVENT.SYS或EVENT.CUSTOM，EVENT.SYS表示系统事件，EVENT.CUSTOM表示自定义事件。
        /// </summary>
        [SDKProperty("event_type", IsQuery = true)]
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// 事件子类, 枚举类型：SUB_EVENT.OPS 运维事件, SUB_EVENT.PLAN 计划事件，SUB_EVENT.CUSTOM 自定义事件
        /// </summary>
        [SDKProperty("sub_event_type", IsQuery = true)]
        [JsonProperty("sub_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public SubEventTypeEnum SubEventType { get; set; }
        /// <summary>
        /// 事件名称，值为系统产生的事件名称，或用户自定义上报的事件名称。
        /// </summary>
        [SDKProperty("event_name", IsQuery = true)]
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 查询数据起始时间，UNIX时间戳，单位毫秒；例如：1605952700911。
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        /// <summary>
        /// 查询数据截止时间UNIX时间戳，单位毫秒。from必须小于to，例如：1606557500911。
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }

        /// <summary>
        /// 分页起始值，默认值为0。
        /// </summary>
        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }

        /// <summary>
        /// 单次查询的条数限制，取值范围[0,100]，默认值为100，用于限制结果数据条数。
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
            sb.Append("class ListEventsRequest {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  subEventType: ").Append(SubEventType).Append("\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
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
            return this.Equals(input as ListEventsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEventsRequest input)
        {
            if (input == null) return false;
            if (this.EventType != input.EventType) return false;
            if (this.SubEventType != input.SubEventType) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
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
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
                hashCode = hashCode * 59 + this.SubEventType.GetHashCode();
                if (this.EventName != null) hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Start != null) hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
