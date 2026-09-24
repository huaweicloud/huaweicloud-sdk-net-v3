using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 设置年备备份的保留规则
    /// </summary>
    public class PolicyYearlyRetentionRules 
    {
        /// <summary>
        /// 年备规则的类型
        /// </summary>
        /// <value>年备规则的类型</value>
        [JsonConverter(typeof(EnumClassConverter<RetentionTypeEnum>))]
        public class RetentionTypeEnum
        {
            /// <summary>
            /// Enum WEEKLY_MONTHLY for value: WEEKLY，MONTHLY
            /// </summary>
            public static readonly RetentionTypeEnum WEEKLY_MONTHLY = new RetentionTypeEnum("WEEKLY，MONTHLY");

            private static readonly Dictionary<string, RetentionTypeEnum> StaticFields =
            new Dictionary<string, RetentionTypeEnum>()
            {
                { "WEEKLY，MONTHLY", WEEKLY_MONTHLY },
            };

            private string _value;

            public RetentionTypeEnum()
            {

            }

            public RetentionTypeEnum(string value)
            {
                _value = value;
            }

            public static RetentionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RetentionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RetentionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RetentionTypeEnum a, RetentionTypeEnum b)
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

            public static bool operator !=(RetentionTypeEnum a, RetentionTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines retentionMonths
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<RetentionMonthsEnum>))]
        public class RetentionMonthsEnum
        {
            /// <summary>
            /// Enum JANUARY for value: JANUARY
            /// </summary>
            public static readonly RetentionMonthsEnum JANUARY = new RetentionMonthsEnum("JANUARY");

            /// <summary>
            /// Enum FEBRUARY for value: FEBRUARY
            /// </summary>
            public static readonly RetentionMonthsEnum FEBRUARY = new RetentionMonthsEnum("FEBRUARY");

            /// <summary>
            /// Enum MARCH for value: MARCH
            /// </summary>
            public static readonly RetentionMonthsEnum MARCH = new RetentionMonthsEnum("MARCH");

            /// <summary>
            /// Enum APRIL for value: APRIL
            /// </summary>
            public static readonly RetentionMonthsEnum APRIL = new RetentionMonthsEnum("APRIL");

            /// <summary>
            /// Enum MAY for value: MAY
            /// </summary>
            public static readonly RetentionMonthsEnum MAY = new RetentionMonthsEnum("MAY");

            /// <summary>
            /// Enum JUNE for value: JUNE
            /// </summary>
            public static readonly RetentionMonthsEnum JUNE = new RetentionMonthsEnum("JUNE");

            /// <summary>
            /// Enum JULY for value: JULY
            /// </summary>
            public static readonly RetentionMonthsEnum JULY = new RetentionMonthsEnum("JULY");

            /// <summary>
            /// Enum AUGUST for value: AUGUST
            /// </summary>
            public static readonly RetentionMonthsEnum AUGUST = new RetentionMonthsEnum("AUGUST");

            /// <summary>
            /// Enum SEPTEMBER for value: SEPTEMBER
            /// </summary>
            public static readonly RetentionMonthsEnum SEPTEMBER = new RetentionMonthsEnum("SEPTEMBER");

            /// <summary>
            /// Enum OCTOBER for value: OCTOBER
            /// </summary>
            public static readonly RetentionMonthsEnum OCTOBER = new RetentionMonthsEnum("OCTOBER");

            /// <summary>
            /// Enum NOVEMBER for value: NOVEMBER
            /// </summary>
            public static readonly RetentionMonthsEnum NOVEMBER = new RetentionMonthsEnum("NOVEMBER");

            /// <summary>
            /// Enum DECEMBER for value: DECEMBER
            /// </summary>
            public static readonly RetentionMonthsEnum DECEMBER = new RetentionMonthsEnum("DECEMBER");

            private static readonly Dictionary<string, RetentionMonthsEnum> StaticFields =
            new Dictionary<string, RetentionMonthsEnum>()
            {
                { "JANUARY", JANUARY },
                { "FEBRUARY", FEBRUARY },
                { "MARCH", MARCH },
                { "APRIL", APRIL },
                { "MAY", MAY },
                { "JUNE", JUNE },
                { "JULY", JULY },
                { "AUGUST", AUGUST },
                { "SEPTEMBER", SEPTEMBER },
                { "OCTOBER", OCTOBER },
                { "NOVEMBER", NOVEMBER },
                { "DECEMBER", DECEMBER },
            };

            private string _value;

            public RetentionMonthsEnum()
            {

            }

            public RetentionMonthsEnum(string value)
            {
                _value = value;
            }

            public static RetentionMonthsEnum FromValue(string value)
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

                if (this.Equals(obj as RetentionMonthsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RetentionMonthsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RetentionMonthsEnum a, RetentionMonthsEnum b)
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

            public static bool operator !=(RetentionMonthsEnum a, RetentionMonthsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines retentionWeeks
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<RetentionWeeksEnum>))]
        public class RetentionWeeksEnum
        {
            /// <summary>
            /// Enum FIRST for value: FIRST
            /// </summary>
            public static readonly RetentionWeeksEnum FIRST = new RetentionWeeksEnum("FIRST");

            /// <summary>
            /// Enum SECOND for value: SECOND
            /// </summary>
            public static readonly RetentionWeeksEnum SECOND = new RetentionWeeksEnum("SECOND");

            /// <summary>
            /// Enum THIRD for value: THIRD
            /// </summary>
            public static readonly RetentionWeeksEnum THIRD = new RetentionWeeksEnum("THIRD");

            /// <summary>
            /// Enum FOURTH for value: FOURTH
            /// </summary>
            public static readonly RetentionWeeksEnum FOURTH = new RetentionWeeksEnum("FOURTH");

            /// <summary>
            /// Enum LAST for value: LAST
            /// </summary>
            public static readonly RetentionWeeksEnum LAST = new RetentionWeeksEnum("LAST");

            private static readonly Dictionary<string, RetentionWeeksEnum> StaticFields =
            new Dictionary<string, RetentionWeeksEnum>()
            {
                { "FIRST", FIRST },
                { "SECOND", SECOND },
                { "THIRD", THIRD },
                { "FOURTH", FOURTH },
                { "LAST", LAST },
            };

            private string _value;

            public RetentionWeeksEnum()
            {

            }

            public RetentionWeeksEnum(string value)
            {
                _value = value;
            }

            public static RetentionWeeksEnum FromValue(string value)
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

                if (this.Equals(obj as RetentionWeeksEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RetentionWeeksEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RetentionWeeksEnum a, RetentionWeeksEnum b)
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

            public static bool operator !=(RetentionWeeksEnum a, RetentionWeeksEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines daysOfWeek
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DaysOfWeekEnum>))]
        public class DaysOfWeekEnum
        {
            /// <summary>
            /// Enum MO for value: MO
            /// </summary>
            public static readonly DaysOfWeekEnum MO = new DaysOfWeekEnum("MO");

            /// <summary>
            /// Enum TU for value: TU
            /// </summary>
            public static readonly DaysOfWeekEnum TU = new DaysOfWeekEnum("TU");

            /// <summary>
            /// Enum WE for value: WE
            /// </summary>
            public static readonly DaysOfWeekEnum WE = new DaysOfWeekEnum("WE");

            /// <summary>
            /// Enum TH for value: TH
            /// </summary>
            public static readonly DaysOfWeekEnum TH = new DaysOfWeekEnum("TH");

            /// <summary>
            /// Enum FR for value: FR
            /// </summary>
            public static readonly DaysOfWeekEnum FR = new DaysOfWeekEnum("FR");

            /// <summary>
            /// Enum SA for value: SA
            /// </summary>
            public static readonly DaysOfWeekEnum SA = new DaysOfWeekEnum("SA");

            /// <summary>
            /// Enum SU for value: SU
            /// </summary>
            public static readonly DaysOfWeekEnum SU = new DaysOfWeekEnum("SU");

            private static readonly Dictionary<string, DaysOfWeekEnum> StaticFields =
            new Dictionary<string, DaysOfWeekEnum>()
            {
                { "MO", MO },
                { "TU", TU },
                { "WE", WE },
                { "TH", TH },
                { "FR", FR },
                { "SA", SA },
                { "SU", SU },
            };

            private string _value;

            public DaysOfWeekEnum()
            {

            }

            public DaysOfWeekEnum(string value)
            {
                _value = value;
            }

            public static DaysOfWeekEnum FromValue(string value)
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

                if (this.Equals(obj as DaysOfWeekEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DaysOfWeekEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DaysOfWeekEnum a, DaysOfWeekEnum b)
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

            public static bool operator !=(DaysOfWeekEnum a, DaysOfWeekEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 年备规则的类型
        /// </summary>
        [JsonProperty("retention_type", NullValueHandling = NullValueHandling.Ignore)]
        public RetentionTypeEnum RetentionType { get; set; }
        /// <summary>
        /// 将每年中指定月份的备份设置为年备备份，当retention_type为Weekly时，需要与retention_weeks和days_of_week共同设置，当retention_type为Monthly时，需要与days_of_month共同设置
        /// </summary>
        [JsonProperty("retention_months", NullValueHandling = NullValueHandling.Ignore)]
        public List<RetentionMonthsEnum> RetentionMonths { get; set; }
        /// <summary>
        /// 将选中月份的第几个星期的备份设置为年备备份，当retention_type为Weekly时才能设置，设置时需要与retention_months和days_of_week共同设置
        /// </summary>
        [JsonProperty("retention_weeks", NullValueHandling = NullValueHandling.Ignore)]
        public List<RetentionWeeksEnum> RetentionWeeks { get; set; }
        /// <summary>
        /// 表示将选中月份的指定天的备份设置为年备备份，当retention_type为Monthly时才能设置，取值范围为1-28和-1，-1代表每个月的最后一天，需要与retention_months共同设置
        /// </summary>
        [JsonProperty("days_of_month", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DaysOfMonth { get; set; }

        /// <summary>
        /// 设置指定月份的指定星期中的指定天的备份为年备备份，当retention_type为Weekly时才能设置，设置时需要与retention_weeks和retention_months共同设置
        /// </summary>
        [JsonProperty("days_of_week", NullValueHandling = NullValueHandling.Ignore)]
        public List<DaysOfWeekEnum> DaysOfWeek { get; set; }
        /// <summary>
        /// 年备备份的保留时间，取值范围为1-100，以及-1，单位为年，-1代表年备策略不启用
        /// </summary>
        [JsonProperty("retention_duration_periods", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDurationPeriods { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyYearlyRetentionRules {\n");
            sb.Append("  retentionType: ").Append(RetentionType).Append("\n");
            sb.Append("  retentionMonths: ").Append(RetentionMonths).Append("\n");
            sb.Append("  retentionWeeks: ").Append(RetentionWeeks).Append("\n");
            sb.Append("  daysOfMonth: ").Append(DaysOfMonth).Append("\n");
            sb.Append("  daysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("  retentionDurationPeriods: ").Append(RetentionDurationPeriods).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyYearlyRetentionRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyYearlyRetentionRules input)
        {
            if (input == null) return false;
            if (this.RetentionType != input.RetentionType) return false;
            if (this.RetentionMonths != input.RetentionMonths || (this.RetentionMonths != null && input.RetentionMonths != null && !this.RetentionMonths.SequenceEqual(input.RetentionMonths))) return false;
            if (this.RetentionWeeks != input.RetentionWeeks || (this.RetentionWeeks != null && input.RetentionWeeks != null && !this.RetentionWeeks.SequenceEqual(input.RetentionWeeks))) return false;
            if (this.DaysOfMonth != input.DaysOfMonth || (this.DaysOfMonth != null && input.DaysOfMonth != null && !this.DaysOfMonth.SequenceEqual(input.DaysOfMonth))) return false;
            if (this.DaysOfWeek != input.DaysOfWeek || (this.DaysOfWeek != null && input.DaysOfWeek != null && !this.DaysOfWeek.SequenceEqual(input.DaysOfWeek))) return false;
            if (this.RetentionDurationPeriods != input.RetentionDurationPeriods || (this.RetentionDurationPeriods != null && !this.RetentionDurationPeriods.Equals(input.RetentionDurationPeriods))) return false;

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
                hashCode = hashCode * 59 + this.RetentionType.GetHashCode();
                hashCode = hashCode * 59 + this.RetentionMonths.GetHashCode();
                hashCode = hashCode * 59 + this.RetentionWeeks.GetHashCode();
                if (this.DaysOfMonth != null) hashCode = hashCode * 59 + this.DaysOfMonth.GetHashCode();
                hashCode = hashCode * 59 + this.DaysOfWeek.GetHashCode();
                if (this.RetentionDurationPeriods != null) hashCode = hashCode * 59 + this.RetentionDurationPeriods.GetHashCode();
                return hashCode;
            }
        }
    }
}
