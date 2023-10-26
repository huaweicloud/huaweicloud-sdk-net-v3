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
    public class Event2alarmRuleBodyTriggerPolicies 
    {
        /// <summary>
        /// 触发类型
        /// </summary>
        /// <value>触发类型</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerTypeEnum>))]
        public class TriggerTypeEnum
        {
            /// <summary>
            /// Enum ACCUMULATIVE for value: accumulative
            /// </summary>
            public static readonly TriggerTypeEnum ACCUMULATIVE = new TriggerTypeEnum("accumulative");

            /// <summary>
            /// Enum NOTIFICATION for value: notification
            /// </summary>
            public static readonly TriggerTypeEnum NOTIFICATION = new TriggerTypeEnum("notification");

            private static readonly Dictionary<string, TriggerTypeEnum> StaticFields =
            new Dictionary<string, TriggerTypeEnum>()
            {
                { "accumulative", ACCUMULATIVE },
                { "notification", NOTIFICATION },
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

            public static bool operator !=(TriggerTypeEnum a, TriggerTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 自增编号
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 触发类型
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerTypeEnum TriggerType { get; set; }
        /// <summary>
        /// 触发周期
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 比较符
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// 触发次数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 告警等级
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event2alarmRuleBodyTriggerPolicies {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Event2alarmRuleBodyTriggerPolicies);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Event2alarmRuleBodyTriggerPolicies input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TriggerType == input.TriggerType ||
                    (this.TriggerType != null &&
                    this.TriggerType.Equals(input.TriggerType))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TriggerType != null)
                    hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                return hashCode;
            }
        }
    }
}
