using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 秒级监控修改请求
    /// </summary>
    public class TaurusModifyInstanceMonitorRequestBody 
    {
        /// <summary>
        /// 采集周期，仅在monitor_switch为true时生效。默认为5s。monitor_switch为false时，不传该参数。取值：  - 1：采集周期为1s。 - 5：采集周期为5s。
        /// </summary>
        /// <value>采集周期，仅在monitor_switch为true时生效。默认为5s。monitor_switch为false时，不传该参数。取值：  - 1：采集周期为1s。 - 5：采集周期为5s。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodEnum>))]
        public class PeriodEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly PeriodEnum NUMBER_1 = new PeriodEnum(1);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly PeriodEnum NUMBER_5 = new PeriodEnum(5);

            private static readonly Dictionary<int?, PeriodEnum> StaticFields =
            new Dictionary<int?, PeriodEnum>()
            {
                { 1, NUMBER_1 },
                { 5, NUMBER_5 },
            };

            private int? _value;

            public PeriodEnum()
            {

            }

            public PeriodEnum(int? value)
            {
                _value = value;
            }

            public static PeriodEnum FromValue(int? value)
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

                if (this.Equals(obj as PeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodEnum a, PeriodEnum b)
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

            public static bool operator !=(PeriodEnum a, PeriodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例秒级监控开关。  - true：开启 - false：关闭
        /// </summary>
        [JsonProperty("monitor_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MonitorSwitch { get; set; }

        /// <summary>
        /// 采集周期，仅在monitor_switch为true时生效。默认为5s。monitor_switch为false时，不传该参数。取值：  - 1：采集周期为1s。 - 5：采集周期为5s。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodEnum Period { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaurusModifyInstanceMonitorRequestBody {\n");
            sb.Append("  monitorSwitch: ").Append(MonitorSwitch).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaurusModifyInstanceMonitorRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaurusModifyInstanceMonitorRequestBody input)
        {
            if (input == null) return false;
            if (this.MonitorSwitch != input.MonitorSwitch || (this.MonitorSwitch != null && !this.MonitorSwitch.Equals(input.MonitorSwitch))) return false;
            if (this.Period != input.Period) return false;

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
                if (this.MonitorSwitch != null) hashCode = hashCode * 59 + this.MonitorSwitch.GetHashCode();
                hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
