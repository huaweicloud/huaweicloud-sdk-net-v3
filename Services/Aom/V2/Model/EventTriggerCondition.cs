using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EventTriggerCondition 
    {
        /// <summary>
        /// 触发方式： - “immediately”：立即触发 - “accumulative”：累计触发
        /// </summary>
        /// <value>触发方式： - “immediately”：立即触发 - “accumulative”：累计触发</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerTypeEnum>))]
        public class TriggerTypeEnum
        {
            /// <summary>
            /// Enum IMMEDIATELY for value: immediately
            /// </summary>
            public static readonly TriggerTypeEnum IMMEDIATELY = new TriggerTypeEnum("immediately");

            /// <summary>
            /// Enum ACCUMULATIVE for value: accumulative
            /// </summary>
            public static readonly TriggerTypeEnum ACCUMULATIVE = new TriggerTypeEnum("accumulative");

            private static readonly Dictionary<string, TriggerTypeEnum> StaticFields =
            new Dictionary<string, TriggerTypeEnum>()
            {
                { "immediately", IMMEDIATELY },
                { "accumulative", ACCUMULATIVE },
            };

            private string _value;

            public TriggerTypeEnum()
            {

            }

            public TriggerTypeEnum(string value)
            {
                _value = value;
            }

            public static TriggerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TriggerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerTypeEnum a, TriggerTypeEnum b)
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

            public static bool operator !=(TriggerTypeEnum a, TriggerTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 事件名称。
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 触发方式： - “immediately”：立即触发 - “accumulative”：累计触发
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerTypeEnum TriggerType { get; set; }
        /// <summary>
        /// 统计周期。单位为秒，例如 1小时 填“3600”，当trigger_type为“immediately”时 不填。
        /// </summary>
        [JsonProperty("aggregation_window", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregationWindow { get; set; }

        /// <summary>
        /// 判断条件：“&gt;”,“&lt;”,“&#x3D;”,“&gt;&#x3D;”,“&lt;&#x3D;”，当trigger_type为“immediately”时 不填。
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// 键值对形式，键为告警级别，值为累计次数，当trigger_type为“immediately”时 值为空。
        /// </summary>
        [JsonProperty("thresholds", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int?> Thresholds { get; set; }

        /// <summary>
        /// 事件类告警频率。当trigger_type为“immediately”时 不填。 - “0”：只告警一次 - “300”：每5分钟 - “600”：每10分钟： - “900”：每15分钟： - “1800”：每30分钟： - “3600”：每1小时： - “10800”：每3小时： - “21600”：每6小时： - “43200”：每12小时： - “86400”：每天：
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public string Frequency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventTriggerCondition {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  aggregationWindow: ").Append(AggregationWindow).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  thresholds: ").Append(Thresholds).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventTriggerCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventTriggerCondition input)
        {
            if (input == null) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
            if (this.TriggerType != input.TriggerType) return false;
            if (this.AggregationWindow != input.AggregationWindow || (this.AggregationWindow != null && !this.AggregationWindow.Equals(input.AggregationWindow))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.Thresholds != input.Thresholds || (this.Thresholds != null && input.Thresholds != null && !this.Thresholds.SequenceEqual(input.Thresholds))) return false;
            if (this.Frequency != input.Frequency || (this.Frequency != null && !this.Frequency.Equals(input.Frequency))) return false;

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
                if (this.EventName != null) hashCode = hashCode * 59 + this.EventName.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.AggregationWindow != null) hashCode = hashCode * 59 + this.AggregationWindow.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Thresholds != null) hashCode = hashCode * 59 + this.Thresholds.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                return hashCode;
            }
        }
    }
}
