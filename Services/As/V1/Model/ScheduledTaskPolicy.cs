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
    /// 
    /// </summary>
    public class ScheduledTaskPolicy 
    {
        /// <summary>
        /// 非必选，不填写时计划任务为定时执行， 填写时，为周期执行，且只能填写DAILY，WEEKLY，MONTHLY 中的一种，分别为按天，按周，按月周期执行
        /// </summary>
        /// <value>非必选，不填写时计划任务为定时执行， 填写时，为周期执行，且只能填写DAILY，WEEKLY，MONTHLY 中的一种，分别为按天，按周，按月周期执行</value>
        [JsonConverter(typeof(EnumClassConverter<RecurrenceTypeEnum>))]
        public class RecurrenceTypeEnum
        {
            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            public static readonly RecurrenceTypeEnum DAILY = new RecurrenceTypeEnum("DAILY");

            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            public static readonly RecurrenceTypeEnum WEEKLY = new RecurrenceTypeEnum("WEEKLY");

            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            public static readonly RecurrenceTypeEnum MONTHLY = new RecurrenceTypeEnum("MONTHLY");

            private static readonly Dictionary<string, RecurrenceTypeEnum> StaticFields =
            new Dictionary<string, RecurrenceTypeEnum>()
            {
                { "DAILY", DAILY },
                { "WEEKLY", WEEKLY },
                { "MONTHLY", MONTHLY },
            };

            private string _value;

            public RecurrenceTypeEnum()
            {

            }

            public RecurrenceTypeEnum(string value)
            {
                _value = value;
            }

            public static RecurrenceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RecurrenceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecurrenceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecurrenceTypeEnum a, RecurrenceTypeEnum b)
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

            public static bool operator !=(RecurrenceTypeEnum a, RecurrenceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 非必选，仅当recurrence_type不为空时生效，表示计划任务的生效开始时间，格式为yyyy-MM-ddTHH:mmZ，不填写时默认为任务创建成功的时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 仅当recurrence_type不为空时生效且必选，表示计划任务的生效结束时间，格式为yyyy-MM-ddTHH:mmZ
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 必选，执行时间，采用UTC时间，recurrence_type不填写或为空时，格式为yyyy-MM-ddTHH:mmZ, recurrence_type不为空时，格式为 HH:mm
        /// </summary>
        [JsonProperty("launch_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LaunchTime { get; set; }

        /// <summary>
        /// 非必选，不填写时计划任务为定时执行， 填写时，为周期执行，且只能填写DAILY，WEEKLY，MONTHLY 中的一种，分别为按天，按周，按月周期执行
        /// </summary>
        [JsonProperty("recurrence_type", NullValueHandling = NullValueHandling.Ignore)]
        public RecurrenceTypeEnum RecurrenceType { get; set; }
        /// <summary>
        /// 仅当recurrence_type为WEEKLY，MONTHLY时必选，表示周期执行的具体日期，多个日期用,分割。recurrence_type为WEEKLY时，可填入1-7， recurrence_type为MONTHLY时，可填入1-31
        /// </summary>
        [JsonProperty("recurrence_value", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurrenceValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledTaskPolicy {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  launchTime: ").Append(LaunchTime).Append("\n");
            sb.Append("  recurrenceType: ").Append(RecurrenceType).Append("\n");
            sb.Append("  recurrenceValue: ").Append(RecurrenceValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduledTaskPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduledTaskPolicy input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.LaunchTime != input.LaunchTime || (this.LaunchTime != null && !this.LaunchTime.Equals(input.LaunchTime))) return false;
            if (this.RecurrenceType != input.RecurrenceType) return false;
            if (this.RecurrenceValue != input.RecurrenceValue || (this.RecurrenceValue != null && !this.RecurrenceValue.Equals(input.RecurrenceValue))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.LaunchTime != null) hashCode = hashCode * 59 + this.LaunchTime.GetHashCode();
                hashCode = hashCode * 59 + this.RecurrenceType.GetHashCode();
                if (this.RecurrenceValue != null) hashCode = hashCode * 59 + this.RecurrenceValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
