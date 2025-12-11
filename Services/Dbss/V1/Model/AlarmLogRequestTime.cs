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
    /// 时间
    /// </summary>
    public class AlarmLogRequestTime 
    {
        /// <summary>
        /// 时间范围。和start_time，end_time不能同时使用，同时传该参数优先级更高。枚举值 - HALF_HOUR：半小时 - HOUR：1小时 - THREE_HOUR：3小时 - TWELVE_HOUR：12小时 - DAY：1天 - WEEK：1周 - MONTH：1个月;
        /// </summary>
        /// <value>时间范围。和start_time，end_time不能同时使用，同时传该参数优先级更高。枚举值 - HALF_HOUR：半小时 - HOUR：1小时 - THREE_HOUR：3小时 - TWELVE_HOUR：12小时 - DAY：1天 - WEEK：1周 - MONTH：1个月;</value>
        [JsonConverter(typeof(EnumClassConverter<TimeRangeEnum>))]
        public class TimeRangeEnum
        {
            /// <summary>
            /// Enum HALF_HOUR for value: HALF_HOUR
            /// </summary>
            public static readonly TimeRangeEnum HALF_HOUR = new TimeRangeEnum("HALF_HOUR");

            /// <summary>
            /// Enum HOUR for value: HOUR
            /// </summary>
            public static readonly TimeRangeEnum HOUR = new TimeRangeEnum("HOUR");

            /// <summary>
            /// Enum THREE_HOUR for value: THREE_HOUR
            /// </summary>
            public static readonly TimeRangeEnum THREE_HOUR = new TimeRangeEnum("THREE_HOUR");

            /// <summary>
            /// Enum TWELVE_HOUR for value: TWELVE_HOUR
            /// </summary>
            public static readonly TimeRangeEnum TWELVE_HOUR = new TimeRangeEnum("TWELVE_HOUR");

            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            public static readonly TimeRangeEnum DAY = new TimeRangeEnum("DAY");

            /// <summary>
            /// Enum WEEK for value: WEEK
            /// </summary>
            public static readonly TimeRangeEnum WEEK = new TimeRangeEnum("WEEK");

            /// <summary>
            /// Enum MONTH for value: MONTH
            /// </summary>
            public static readonly TimeRangeEnum MONTH = new TimeRangeEnum("MONTH");

            private static readonly Dictionary<string, TimeRangeEnum> StaticFields =
            new Dictionary<string, TimeRangeEnum>()
            {
                { "HALF_HOUR", HALF_HOUR },
                { "HOUR", HOUR },
                { "THREE_HOUR", THREE_HOUR },
                { "TWELVE_HOUR", TWELVE_HOUR },
                { "DAY", DAY },
                { "WEEK", WEEK },
                { "MONTH", MONTH },
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

            public static bool operator !=(TimeRangeEnum a, TimeRangeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 时间范围。和start_time，end_time不能同时使用，同时传该参数优先级更高。枚举值 - HALF_HOUR：半小时 - HOUR：1小时 - THREE_HOUR：3小时 - TWELVE_HOUR：12小时 - DAY：1天 - WEEK：1周 - MONTH：1个月;
        /// </summary>
        [JsonProperty("time_range", NullValueHandling = NullValueHandling.Ignore)]
        public TimeRangeEnum TimeRange { get; set; }
        /// <summary>
        /// 开始时间，必须和end_time成对出现。格式必须为yyyy-MM-dd HH:mm:ss。UTC时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，必须和start_time成对出现。格式必须为yyyy-MM-dd HH:mm:ss。UTC时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmLogRequestTime {\n");
            sb.Append("  timeRange: ").Append(TimeRange).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmLogRequestTime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmLogRequestTime input)
        {
            if (input == null) return false;
            if (this.TimeRange != input.TimeRange) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
