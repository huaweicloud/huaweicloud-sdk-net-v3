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
    /// 一条事件监控信息
    /// </summary>
    public class EventInfo 
    {
        /// <summary>
        /// 枚举类型 EVENT.SYS或EVENT.CUSTOM，EVENT.SYS为系统事件，EVENT.CUSTOM为自定义事件
        /// </summary>
        /// <value>枚举类型 EVENT.SYS或EVENT.CUSTOM，EVENT.SYS为系统事件，EVENT.CUSTOM为自定义事件</value>
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
        /// 事件子类。 枚举类型：SUB_EVENT.OPS为运维事件，SUB_EVENT.PLAN为计划事件，SUB_EVENT.CUSTOM为自定义事件。 
        /// </summary>
        /// <value>事件子类。 枚举类型：SUB_EVENT.OPS为运维事件，SUB_EVENT.PLAN为计划事件，SUB_EVENT.CUSTOM为自定义事件。 </value>
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
        /// 事件名称。
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 枚举类型 EVENT.SYS或EVENT.CUSTOM，EVENT.SYS为系统事件，EVENT.CUSTOM为自定义事件
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// 事件子类。 枚举类型：SUB_EVENT.OPS为运维事件，SUB_EVENT.PLAN为计划事件，SUB_EVENT.CUSTOM为自定义事件。 
        /// </summary>
        [JsonProperty("sub_event_type", NullValueHandling = NullValueHandling.Ignore)]
        public SubEventTypeEnum SubEventType { get; set; }
        /// <summary>
        /// 选择查询的时间范围内，此事件发生的数量。
        /// </summary>
        [JsonProperty("event_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventCount { get; set; }

        /// <summary>
        /// 此事件最近一次发生的时间。
        /// </summary>
        [JsonProperty("latest_occur_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LatestOccurTime { get; set; }

        /// <summary>
        /// 事件来源，如果是系统事件则值为各服务的命名空间，各服务命名空间请参阅[[支持监控的服务列表](https://support.huaweicloud.com/api-ces/ces_03_0059.html)](tag:hc)[[支持监控的服务列表](https://support.huaweicloud.com/intl/en-us/api-ces/ces_03_0059.html)](tag:hk)[[支持监控的服务列表](https://support.huaweicloud.com/eu/en-us/api-ces/ces_03_0059.html)](tag:hws_eu)[[支持监控的服务列表](ces_03_0059.xml)](tag:ax,cmcc,ctc,dt,dt_test,hcso_dt,fcs,fcs_vm,mix,g42,hk_g42,hk_sbc,hk_tm,hk_vdf,hws_ocb,ocb,sbc,srg)。；如果是自定义事件，则为用户自定义上报定义。
        /// </summary>
        [JsonProperty("latest_event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestEventSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventInfo {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  subEventType: ").Append(SubEventType).Append("\n");
            sb.Append("  eventCount: ").Append(EventCount).Append("\n");
            sb.Append("  latestOccurTime: ").Append(LatestOccurTime).Append("\n");
            sb.Append("  latestEventSource: ").Append(LatestEventSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventInfo input)
        {
            if (input == null) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
            if (this.EventType != input.EventType) return false;
            if (this.SubEventType != input.SubEventType) return false;
            if (this.EventCount != input.EventCount || (this.EventCount != null && !this.EventCount.Equals(input.EventCount))) return false;
            if (this.LatestOccurTime != input.LatestOccurTime || (this.LatestOccurTime != null && !this.LatestOccurTime.Equals(input.LatestOccurTime))) return false;
            if (this.LatestEventSource != input.LatestEventSource || (this.LatestEventSource != null && !this.LatestEventSource.Equals(input.LatestEventSource))) return false;

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
                if (this.EventCount != null) hashCode = hashCode * 59 + this.EventCount.GetHashCode();
                if (this.LatestOccurTime != null) hashCode = hashCode * 59 + this.LatestOccurTime.GetHashCode();
                if (this.LatestEventSource != null) hashCode = hashCode * 59 + this.LatestEventSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
