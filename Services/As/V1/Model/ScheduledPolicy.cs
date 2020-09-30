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
    /// 定时、周期任务策略
    /// </summary>
    public class ScheduledPolicy 
    {
        /// <summary>
        /// 周期触发类型，scaling_policy_type为RECURRENCE时该项必选。Daily：每天执行一次。Weekly：每周指定天执行一次。Monthly：每月指定天执行一次。
        /// </summary>
        /// <value>周期触发类型，scaling_policy_type为RECURRENCE时该项必选。Daily：每天执行一次。Weekly：每周指定天执行一次。Monthly：每月指定天执行一次。</value>
        [JsonConverter(typeof(EnumClassConverter<RecurrenceTypeEnum>))]
        public class RecurrenceTypeEnum
        {
            /// <summary>
            /// Enum DAILY for value: Daily
            /// </summary>
            public static readonly RecurrenceTypeEnum DAILY = new RecurrenceTypeEnum("Daily");

            /// <summary>
            /// Enum WEEKLY for value: Weekly
            /// </summary>
            public static readonly RecurrenceTypeEnum WEEKLY = new RecurrenceTypeEnum("Weekly");

            /// <summary>
            /// Enum MONTHLY for value: Monthly
            /// </summary>
            public static readonly RecurrenceTypeEnum MONTHLY = new RecurrenceTypeEnum("Monthly");

            private static readonly Dictionary<string, RecurrenceTypeEnum> StaticFields =
            new Dictionary<string, RecurrenceTypeEnum>()
            {
                { "Daily", DAILY },
                { "Weekly", WEEKLY },
                { "Monthly", MONTHLY },
            };

            private string Value;

            private RecurrenceTypeEnum(string value)
            {
                this.Value = value;
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 触发时间，遵循UTC时间。如果scaling_policy_type为SCHEDULED，则格式为：YYYY-MM-DDThh:mmZ。如果scaling_policy_type为RECURRENCE，则格式为：hh:mm。
        /// </summary>
        [JsonProperty("launch_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// 周期触发类型，scaling_policy_type为RECURRENCE时该项必选。Daily：每天执行一次。Weekly：每周指定天执行一次。Monthly：每月指定天执行一次。
        /// </summary>
        [JsonProperty("recurrence_type", NullValueHandling = NullValueHandling.Ignore)]
        public RecurrenceTypeEnum RecurrenceType { get; set; }
        /// <summary>
        /// 周期触发任务数值，scaling_policy_type为RECURRENCE时该项必选。类型为Daily时，该字段为null，表示每天执行类型为Weekly时，该字段取值范围为1-7，1表示星期日，以此类推，以”,”分割，例如：1,3,5。类型为Monthly时，该字段取值范围为1-31，分别表示每月的日期，以“,”分割，例如：1,10,13,28。
        /// </summary>
        [JsonProperty("recurrence_value", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurrenceValue { get; set; }

        /// <summary>
        /// 周期策略重复执行开始时间，遵循UTC时间。默认为当前时间，格式为：YYYY-MM-DDThh：mZ
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 周期策略重复执行结束时间，遵循UTC时间，scaling_policy_type为RECURRENCE时该项必选。当为周期类型策略时，不得早于当前时间和开始时间。格式为：YYYY-MM-DDThh：mmZ
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledPolicy {\n");
            sb.Append("  launchTime: ").Append(LaunchTime).Append("\n");
            sb.Append("  recurrenceType: ").Append(RecurrenceType).Append("\n");
            sb.Append("  recurrenceValue: ").Append(RecurrenceValue).Append("\n");
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
            return this.Equals(input as ScheduledPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduledPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LaunchTime == input.LaunchTime ||
                    (this.LaunchTime != null &&
                    this.LaunchTime.Equals(input.LaunchTime))
                ) && 
                (
                    this.RecurrenceType == input.RecurrenceType ||
                    (this.RecurrenceType != null &&
                    this.RecurrenceType.Equals(input.RecurrenceType))
                ) && 
                (
                    this.RecurrenceValue == input.RecurrenceValue ||
                    (this.RecurrenceValue != null &&
                    this.RecurrenceValue.Equals(input.RecurrenceValue))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LaunchTime != null)
                    hashCode = hashCode * 59 + this.LaunchTime.GetHashCode();
                if (this.RecurrenceType != null)
                    hashCode = hashCode * 59 + this.RecurrenceType.GetHashCode();
                if (this.RecurrenceValue != null)
                    hashCode = hashCode * 59 + this.RecurrenceValue.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
