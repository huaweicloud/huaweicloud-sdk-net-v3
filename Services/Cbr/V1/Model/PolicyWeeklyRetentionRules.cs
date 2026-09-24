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
    /// 
    /// </summary>
    public class PolicyWeeklyRetentionRules 
    {
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
        /// 设置每个星期中的指定天为周备备份
        /// </summary>
        [JsonProperty("days_of_week", NullValueHandling = NullValueHandling.Ignore)]
        public List<DaysOfWeekEnum> DaysOfWeek { get; set; }
        /// <summary>
        /// 周备的保留时间，取值范围为1-5200，以及-1，单位为周，-1代表周备策略不启用
        /// </summary>
        [JsonProperty("retention_duration_periods", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDurationPeriods { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyWeeklyRetentionRules {\n");
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
            return this.Equals(input as PolicyWeeklyRetentionRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyWeeklyRetentionRules input)
        {
            if (input == null) return false;
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
                hashCode = hashCode * 59 + this.DaysOfWeek.GetHashCode();
                if (this.RetentionDurationPeriods != null) hashCode = hashCode * 59 + this.RetentionDurationPeriods.GetHashCode();
                return hashCode;
            }
        }
    }
}
