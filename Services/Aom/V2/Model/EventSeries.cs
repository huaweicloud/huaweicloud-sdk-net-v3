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
    /// 事件或者告警统计值统计结果元数据。
    /// </summary>
    public class EventSeries 
    {
        /// <summary>
        /// 事件或者告警级别枚举类型。
        /// </summary>
        /// <value>事件或者告警级别枚举类型。</value>
        [JsonConverter(typeof(EnumClassConverter<EventSeverityEnum>))]
        public class EventSeverityEnum
        {
            /// <summary>
            /// Enum CRITICAL for value: Critical
            /// </summary>
            public static readonly EventSeverityEnum CRITICAL = new EventSeverityEnum("Critical");

            /// <summary>
            /// Enum MAJOR for value: Major
            /// </summary>
            public static readonly EventSeverityEnum MAJOR = new EventSeverityEnum("Major");

            /// <summary>
            /// Enum MINOR for value: Minor
            /// </summary>
            public static readonly EventSeverityEnum MINOR = new EventSeverityEnum("Minor");

            /// <summary>
            /// Enum INFO for value: Info
            /// </summary>
            public static readonly EventSeverityEnum INFO = new EventSeverityEnum("Info");

            private static readonly Dictionary<string, EventSeverityEnum> StaticFields =
            new Dictionary<string, EventSeverityEnum>()
            {
                { "Critical", CRITICAL },
                { "Major", MAJOR },
                { "Minor", MINOR },
                { "Info", INFO },
            };

            private string _value;

            public EventSeverityEnum()
            {

            }

            public EventSeverityEnum(string value)
            {
                _value = value;
            }

            public static EventSeverityEnum FromValue(string value)
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

                if (this.Equals(obj as EventSeverityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventSeverityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventSeverityEnum a, EventSeverityEnum b)
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

            public static bool operator !=(EventSeverityEnum a, EventSeverityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 事件或者告警级别枚举类型。
        /// </summary>
        [JsonProperty("event_severity", NullValueHandling = NullValueHandling.Ignore)]
        public EventSeverityEnum EventSeverity { get; set; }
        /// <summary>
        /// 事件或者告警统计结果。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventSeries {\n");
            sb.Append("  eventSeverity: ").Append(EventSeverity).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventSeries);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventSeries input)
        {
            if (input == null) return false;
            if (this.EventSeverity != input.EventSeverity) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;

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
                hashCode = hashCode * 59 + this.EventSeverity.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
