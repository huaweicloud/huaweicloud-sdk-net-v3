using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TimeRangeBean 
    {
        /// <summary>
        /// 请求查询的时间段，和start_time，end_time不能同时使用，同时传该参数优先级更高。 - HALF_HOUR - HOUR - THREE_HOUR - TWELVE_HOUR - DAY - WEEK - MONTH
        /// </summary>
        /// <value>请求查询的时间段，和start_time，end_time不能同时使用，同时传该参数优先级更高。 - HALF_HOUR - HOUR - THREE_HOUR - TWELVE_HOUR - DAY - WEEK - MONTH</value>
        [JsonConverter(typeof(EnumClassConverter<TimeRangeEnum>))]
        public class TimeRangeEnum
        {
            /// <summary>
            /// Enum HALF_HOUR for value: HALF_HOUR
            /// </summary>
            public static readonly TimeRangeEnum HALF_HOUR = new TimeRangeEnum("HALF_HOUR");

            /// <summary>
            /// Enum _HOUR for value:  HOUR
            /// </summary>
            public static readonly TimeRangeEnum _HOUR = new TimeRangeEnum(" HOUR");

            /// <summary>
            /// Enum _THREE_HOUR for value:  THREE_HOUR
            /// </summary>
            public static readonly TimeRangeEnum _THREE_HOUR = new TimeRangeEnum(" THREE_HOUR");

            /// <summary>
            /// Enum _TWELVE_HOUR for value:  TWELVE_HOUR
            /// </summary>
            public static readonly TimeRangeEnum _TWELVE_HOUR = new TimeRangeEnum(" TWELVE_HOUR");

            /// <summary>
            /// Enum _DAY for value:  DAY
            /// </summary>
            public static readonly TimeRangeEnum _DAY = new TimeRangeEnum(" DAY");

            /// <summary>
            /// Enum _WEEK for value:  WEEK
            /// </summary>
            public static readonly TimeRangeEnum _WEEK = new TimeRangeEnum(" WEEK");

            /// <summary>
            /// Enum _MONTH for value:  MONTH
            /// </summary>
            public static readonly TimeRangeEnum _MONTH = new TimeRangeEnum(" MONTH");

            private static readonly Dictionary<string, TimeRangeEnum> StaticFields =
            new Dictionary<string, TimeRangeEnum>()
            {
                { "HALF_HOUR", HALF_HOUR },
                { " HOUR", _HOUR },
                { " THREE_HOUR", _THREE_HOUR },
                { " TWELVE_HOUR", _TWELVE_HOUR },
                { " DAY", _DAY },
                { " WEEK", _WEEK },
                { " MONTH", _MONTH },
            };

            private string _value;

            public TimeRangeEnum()
            {

            }

            public TimeRangeEnum(string value)
            {
                _value = value;
            }

            public static TimeRangeEnum FromValue(string value)
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

                if (this.Equals(obj as TimeRangeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TimeRangeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TimeRangeEnum a, TimeRangeEnum b)
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

            public static bool operator !=(TimeRangeEnum a, TimeRangeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 开始时间，必须和end_time成对出现。格式必须为yyyy-MM-dd HH:mm:ss。UTC时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 结束时间，必须和start_time成对出现。格式必须为yyyy-MM-dd HH:mm:ss。UTC时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 请求查询的时间段，和start_time，end_time不能同时使用，同时传该参数优先级更高。 - HALF_HOUR - HOUR - THREE_HOUR - TWELVE_HOUR - DAY - WEEK - MONTH
        /// </summary>
        [JsonProperty("time_range", NullValueHandling = NullValueHandling.Ignore)]
        public TimeRangeEnum TimeRange { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeRangeBean {\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  timeRange: ").Append(TimeRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimeRangeBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TimeRangeBean input)
        {
            if (input == null) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.TimeRange != input.TimeRange) return false;

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
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
