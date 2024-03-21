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
    /// 
    /// </summary>
    public class CustomerModifyAutoEnlargePolicyReq 
    {
        /// <summary>
        /// 可用存储空间百分比，小于等于此值或者10GB时触发扩容，switch_option为true时必填
        /// </summary>
        /// <value>可用存储空间百分比，小于等于此值或者10GB时触发扩容，switch_option为true时必填</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerThresholdEnum>))]
        public class TriggerThresholdEnum
        {
            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            public static readonly TriggerThresholdEnum NUMBER_10 = new TriggerThresholdEnum(10);

            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            public static readonly TriggerThresholdEnum NUMBER_15 = new TriggerThresholdEnum(15);

            /// <summary>
            /// Enum NUMBER_20 for value: 20
            /// </summary>
            public static readonly TriggerThresholdEnum NUMBER_20 = new TriggerThresholdEnum(20);

            private static readonly Dictionary<int?, TriggerThresholdEnum> StaticFields =
            new Dictionary<int?, TriggerThresholdEnum>()
            {
                { 10, NUMBER_10 },
                { 15, NUMBER_15 },
                { 20, NUMBER_20 },
            };

            private int? _value;

            public TriggerThresholdEnum()
            {

            }

            public TriggerThresholdEnum(int? value)
            {
                _value = value;
            }

            public static TriggerThresholdEnum FromValue(int? value)
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

                if (this.Equals(obj as TriggerThresholdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerThresholdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerThresholdEnum a, TriggerThresholdEnum b)
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

            public static bool operator !=(TriggerThresholdEnum a, TriggerThresholdEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启自动扩容,true为开启,false为关闭
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOption { get; set; }

        /// <summary>
        /// 扩容上限，单位GB, 取值范围40~4000，需要大于等于实例当前存储空间总大小，switch_option为true必填
        /// </summary>
        [JsonProperty("limit_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitSize { get; set; }

        /// <summary>
        /// 可用存储空间百分比，小于等于此值或者10GB时触发扩容，switch_option为true时必填
        /// </summary>
        [JsonProperty("trigger_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerThresholdEnum TriggerThreshold { get; set; }
        /// <summary>
        /// 每次自动扩容的百分比步长，取值范围5~50，开启自定义步长功能时必填
        /// </summary>
        [JsonProperty("step_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? StepPercent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerModifyAutoEnlargePolicyReq {\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("  limitSize: ").Append(LimitSize).Append("\n");
            sb.Append("  triggerThreshold: ").Append(TriggerThreshold).Append("\n");
            sb.Append("  stepPercent: ").Append(StepPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerModifyAutoEnlargePolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerModifyAutoEnlargePolicyReq input)
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
                    this.LimitSize == input.LimitSize ||
                    (this.LimitSize != null &&
                    this.LimitSize.Equals(input.LimitSize))
                ) && 
                (
                    this.TriggerThreshold == input.TriggerThreshold ||
                    (this.TriggerThreshold != null &&
                    this.TriggerThreshold.Equals(input.TriggerThreshold))
                ) && 
                (
                    this.StepPercent == input.StepPercent ||
                    (this.StepPercent != null &&
                    this.StepPercent.Equals(input.StepPercent))
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
                if (this.LimitSize != null)
                    hashCode = hashCode * 59 + this.LimitSize.GetHashCode();
                if (this.TriggerThreshold != null)
                    hashCode = hashCode * 59 + this.TriggerThreshold.GetHashCode();
                if (this.StepPercent != null)
                    hashCode = hashCode * 59 + this.StepPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
