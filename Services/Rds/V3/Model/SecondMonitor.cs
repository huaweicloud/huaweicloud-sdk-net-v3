using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 秒级监控信息
    /// </summary>
    public class SecondMonitor 
    {
        /// <summary>
        /// 监控间隔, 支持1秒和5秒
        /// </summary>
        /// <value>监控间隔, 支持1秒和5秒</value>
        [JsonConverter(typeof(EnumClassConverter<IntervalEnum>))]
        public class IntervalEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly IntervalEnum NUMBER_1 = new IntervalEnum(1);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly IntervalEnum NUMBER_5 = new IntervalEnum(5);

            private static readonly Dictionary<int?, IntervalEnum> StaticFields =
            new Dictionary<int?, IntervalEnum>()
            {
                { 1, NUMBER_1 },
                { 5, NUMBER_5 },
            };

            private int? _value;

            public IntervalEnum()
            {

            }

            public IntervalEnum(int? value)
            {
                _value = value;
            }

            public static IntervalEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as IntervalEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IntervalEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IntervalEnum a, IntervalEnum b)
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

            public static bool operator !=(IntervalEnum a, IntervalEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 秒级监控开关
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOption { get; set; }

        /// <summary>
        /// 监控间隔, 支持1秒和5秒
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public IntervalEnum Interval { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecondMonitor {\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecondMonitor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecondMonitor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SwitchOption == input.SwitchOption ||
                    (this.SwitchOption != null &&
                    this.SwitchOption.Equals(input.SwitchOption))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
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
                if (this.SwitchOption != null)
                    hashCode = hashCode * 59 + this.SwitchOption.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                return hashCode;
            }
        }
    }
}
