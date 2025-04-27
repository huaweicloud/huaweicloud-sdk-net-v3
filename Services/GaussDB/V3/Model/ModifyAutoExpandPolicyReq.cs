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
    /// 
    /// </summary>
    public class ModifyAutoExpandPolicyReq 
    {
        /// <summary>
        /// **参数解释**：  可用存储空间率。  **取值范围**：  - 10 - 15 - 20
        /// </summary>
        /// <value>**参数解释**：  可用存储空间率。  **取值范围**：  - 10 - 15 - 20</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerAvailablePercentEnum>))]
        public class TriggerAvailablePercentEnum
        {
            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            public static readonly TriggerAvailablePercentEnum NUMBER_10 = new TriggerAvailablePercentEnum(10);

            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            public static readonly TriggerAvailablePercentEnum NUMBER_15 = new TriggerAvailablePercentEnum(15);

            /// <summary>
            /// Enum NUMBER_20 for value: 20
            /// </summary>
            public static readonly TriggerAvailablePercentEnum NUMBER_20 = new TriggerAvailablePercentEnum(20);

            private static readonly Dictionary<int?, TriggerAvailablePercentEnum> StaticFields =
            new Dictionary<int?, TriggerAvailablePercentEnum>()
            {
                { 10, NUMBER_10 },
                { 15, NUMBER_15 },
                { 20, NUMBER_20 },
            };

            private int? _value;

            public TriggerAvailablePercentEnum()
            {

            }

            public TriggerAvailablePercentEnum(int? value)
            {
                _value = value;
            }

            public static TriggerAvailablePercentEnum FromValue(int? value)
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

                if (this.Equals(obj as TriggerAvailablePercentEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerAvailablePercentEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerAvailablePercentEnum a, TriggerAvailablePercentEnum b)
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

            public static bool operator !=(TriggerAvailablePercentEnum a, TriggerAvailablePercentEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  自动扩容策略开关。  **取值范围**：  - true：表示开启。 - false：表示关闭。
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOption { get; set; }

        /// <summary>
        /// **参数解释**：  存储自动扩容上限，需要为10的倍数，单位GB。  **取值范围**：  10 - 最大容量上限。  示例：500
        /// </summary>
        [JsonProperty("limit_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitSize { get; set; }

        /// <summary>
        /// **参数解释**：  可用存储空间率。  **取值范围**：  - 10 - 15 - 20
        /// </summary>
        [JsonProperty("trigger_available_percent", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerAvailablePercentEnum TriggerAvailablePercent { get; set; }
        /// <summary>
        /// **参数解释**：  扩容步长百分比。  **取值范围**:   5 - 50
        /// </summary>
        [JsonProperty("step_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? StepPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyAutoExpandPolicyReq {\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("  limitSize: ").Append(LimitSize).Append("\n");
            sb.Append("  triggerAvailablePercent: ").Append(TriggerAvailablePercent).Append("\n");
            sb.Append("  stepPercent: ").Append(StepPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyAutoExpandPolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyAutoExpandPolicyReq input)
        {
            if (input == null) return false;
            if (this.SwitchOption != input.SwitchOption || (this.SwitchOption != null && !this.SwitchOption.Equals(input.SwitchOption))) return false;
            if (this.LimitSize != input.LimitSize || (this.LimitSize != null && !this.LimitSize.Equals(input.LimitSize))) return false;
            if (this.TriggerAvailablePercent != input.TriggerAvailablePercent) return false;
            if (this.StepPercent != input.StepPercent || (this.StepPercent != null && !this.StepPercent.Equals(input.StepPercent))) return false;

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
                if (this.SwitchOption != null) hashCode = hashCode * 59 + this.SwitchOption.GetHashCode();
                if (this.LimitSize != null) hashCode = hashCode * 59 + this.LimitSize.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerAvailablePercent.GetHashCode();
                if (this.StepPercent != null) hashCode = hashCode * 59 + this.StepPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
