using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSqlAlarmRuleFrequency 
    {
        /// <summary>
        /// 时间类型。
        /// </summary>
        /// <value>时间类型。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum CRON for value: CRON
            /// </summary>
            public static readonly TypeEnum CRON = new TypeEnum("CRON");

            /// <summary>
            /// Enum HOURLY for value: HOURLY
            /// </summary>
            public static readonly TypeEnum HOURLY = new TypeEnum("HOURLY");

            /// <summary>
            /// Enum DAILY for value: DAILY
            /// </summary>
            public static readonly TypeEnum DAILY = new TypeEnum("DAILY");

            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            public static readonly TypeEnum WEEKLY = new TypeEnum("WEEKLY");

            /// <summary>
            /// Enum FIXED_RATE for value: FIXED_RATE
            /// </summary>
            public static readonly TypeEnum FIXED_RATE = new TypeEnum("FIXED_RATE");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "CRON", CRON },
                { "HOURLY", HOURLY },
                { "DAILY", DAILY },
                { "WEEKLY", WEEKLY },
                { "FIXED_RATE", FIXED_RATE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 时间单位。
        /// </summary>
        /// <value>时间单位。</value>
        [JsonConverter(typeof(EnumClassConverter<FixedRateUnitEnum>))]
        public class FixedRateUnitEnum
        {
            /// <summary>
            /// Enum MINUTE for value: minute
            /// </summary>
            public static readonly FixedRateUnitEnum MINUTE = new FixedRateUnitEnum("minute");

            /// <summary>
            /// Enum HOUR for value: hour
            /// </summary>
            public static readonly FixedRateUnitEnum HOUR = new FixedRateUnitEnum("hour");

            private static readonly Dictionary<string, FixedRateUnitEnum> StaticFields =
            new Dictionary<string, FixedRateUnitEnum>()
            {
                { "minute", MINUTE },
                { "hour", HOUR },
            };

            private string _value;

            public FixedRateUnitEnum()
            {

            }

            public FixedRateUnitEnum(string value)
            {
                _value = value;
            }

            public static FixedRateUnitEnum FromValue(string value)
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

                if (this.Equals(obj as FixedRateUnitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FixedRateUnitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FixedRateUnitEnum a, FixedRateUnitEnum b)
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

            public static bool operator !=(FixedRateUnitEnum a, FixedRateUnitEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 时间类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 当字段type为\&quot;CRON\&quot;时取该字段。
        /// </summary>
        [JsonProperty("cron_expr", NullValueHandling = NullValueHandling.Ignore)]
        public string CronExpr { get; set; }

        /// <summary>
        /// 当字段type为\&quot;DAILY\&quot;或者\&quot;WEEKLY\&quot;时取该字段。  DAILY：最小值：0，最大值：23 WEEKLY：最小值：0，最大值：23
        /// </summary>
        [JsonProperty("hour_of_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? HourOfDay { get; set; }

        /// <summary>
        /// 当字段type为\&quot;WEEKLY\&quot;时取该字段（周日~周六）。
        /// </summary>
        [JsonProperty("day_of_week", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayOfWeek { get; set; }

        /// <summary>
        /// 当字段type为\&quot;FIXED_RATE\&quot;时取该字段（当fixed_rate_unit单位为minute，最大值60；当fixed_rate_unit单位为hour，最大值24）。
        /// </summary>
        [JsonProperty("fixed_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FixedRate { get; set; }

        /// <summary>
        /// 时间单位。
        /// </summary>
        [JsonProperty("fixed_rate_unit", NullValueHandling = NullValueHandling.Ignore)]
        public FixedRateUnitEnum FixedRateUnit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSqlAlarmRuleFrequency {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cronExpr: ").Append(CronExpr).Append("\n");
            sb.Append("  hourOfDay: ").Append(HourOfDay).Append("\n");
            sb.Append("  dayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  fixedRate: ").Append(FixedRate).Append("\n");
            sb.Append("  fixedRateUnit: ").Append(FixedRateUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSqlAlarmRuleFrequency);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSqlAlarmRuleFrequency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CronExpr == input.CronExpr ||
                    (this.CronExpr != null &&
                    this.CronExpr.Equals(input.CronExpr))
                ) && 
                (
                    this.HourOfDay == input.HourOfDay ||
                    (this.HourOfDay != null &&
                    this.HourOfDay.Equals(input.HourOfDay))
                ) && 
                (
                    this.DayOfWeek == input.DayOfWeek ||
                    (this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(input.DayOfWeek))
                ) && 
                (
                    this.FixedRate == input.FixedRate ||
                    (this.FixedRate != null &&
                    this.FixedRate.Equals(input.FixedRate))
                ) && 
                (
                    this.FixedRateUnit == input.FixedRateUnit ||
                    (this.FixedRateUnit != null &&
                    this.FixedRateUnit.Equals(input.FixedRateUnit))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CronExpr != null)
                    hashCode = hashCode * 59 + this.CronExpr.GetHashCode();
                if (this.HourOfDay != null)
                    hashCode = hashCode * 59 + this.HourOfDay.GetHashCode();
                if (this.DayOfWeek != null)
                    hashCode = hashCode * 59 + this.DayOfWeek.GetHashCode();
                if (this.FixedRate != null)
                    hashCode = hashCode * 59 + this.FixedRate.GetHashCode();
                if (this.FixedRateUnit != null)
                    hashCode = hashCode * 59 + this.FixedRateUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
