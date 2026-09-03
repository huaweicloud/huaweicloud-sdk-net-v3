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
    /// Response Object
    /// </summary>
    public class ShowBackupUsageAlarmConfigResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**：  告警开关。  **约束限制**：  不涉及。  **取值范围**：  - ON - OFF  **默认取值**：  OFF。
        /// </summary>
        /// <value>**参数解释**：  告警开关。  **约束限制**：  不涉及。  **取值范围**：  - ON - OFF  **默认取值**：  OFF。</value>
        [JsonConverter(typeof(EnumClassConverter<AlarmEnabledEnum>))]
        public class AlarmEnabledEnum
        {
            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly AlarmEnabledEnum ON = new AlarmEnabledEnum("ON");

            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly AlarmEnabledEnum OFF = new AlarmEnabledEnum("OFF");

            private static readonly Dictionary<string, AlarmEnabledEnum> StaticFields =
            new Dictionary<string, AlarmEnabledEnum>()
            {
                { "ON", ON },
                { "OFF", OFF },
            };

            private string _value;

            public AlarmEnabledEnum()
            {

            }

            public AlarmEnabledEnum(string value)
            {
                _value = value;
            }

            public static AlarmEnabledEnum FromValue(string value)
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

                if (this.Equals(obj as AlarmEnabledEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmEnabledEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmEnabledEnum a, AlarmEnabledEnum b)
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

            public static bool operator !=(AlarmEnabledEnum a, AlarmEnabledEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  告警开关。  **约束限制**：  不涉及。  **取值范围**：  - ON - OFF  **默认取值**：  OFF。
        /// </summary>
        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmEnabledEnum AlarmEnabled { get; set; }
        /// <summary>
        /// **参数解释**：  阈值百分比，占免费备份空间大小的百分比。  **约束限制**：  不涉及。  **取值范围**：  1-100。  **默认取值**：  90。
        /// </summary>
        [JsonProperty("threshold_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThresholdPercent { get; set; }

        /// <summary>
        /// **参数解释**：  增量百分比，占免费备份空间大小的百分比。  **约束限制**：  不涉及。  **取值范围**：  1-100。  **默认取值**：  10。
        /// </summary>
        [JsonProperty("increment_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? IncrementPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackupUsageAlarmConfigResponse {\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  thresholdPercent: ").Append(ThresholdPercent).Append("\n");
            sb.Append("  incrementPercent: ").Append(IncrementPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackupUsageAlarmConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackupUsageAlarmConfigResponse input)
        {
            if (input == null) return false;
            if (this.AlarmEnabled != input.AlarmEnabled) return false;
            if (this.ThresholdPercent != input.ThresholdPercent || (this.ThresholdPercent != null && !this.ThresholdPercent.Equals(input.ThresholdPercent))) return false;
            if (this.IncrementPercent != input.IncrementPercent || (this.IncrementPercent != null && !this.IncrementPercent.Equals(input.IncrementPercent))) return false;

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
                hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.ThresholdPercent != null) hashCode = hashCode * 59 + this.ThresholdPercent.GetHashCode();
                if (this.IncrementPercent != null) hashCode = hashCode * 59 + this.IncrementPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
