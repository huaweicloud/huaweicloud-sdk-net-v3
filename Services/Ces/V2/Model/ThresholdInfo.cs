using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// **参数解释** 监控视图的阈值辅助线配置 **约束限制** 不涉及 
    /// </summary>
    public class ThresholdInfo 
    {
        /// <summary>
        /// **参数解释** 监控视图辅助线的颜色 **约束限制** 不涉及           **取值范围** - \&quot;#B50E65\&quot;:紫色 - \&quot;#F23030\&quot;:红色 - \&quot;#FF8800\&quot;:橙色 - \&quot;#F2E70C\&quot;:黄色 **默认取值** 不涉及 
        /// </summary>
        /// <value>**参数解释** 监控视图辅助线的颜色 **约束限制** 不涉及           **取值范围** - \&quot;#B50E65\&quot;:紫色 - \&quot;#F23030\&quot;:红色 - \&quot;#FF8800\&quot;:橙色 - \&quot;#F2E70C\&quot;:黄色 **默认取值** 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<ThresholdColorEnum>))]
        public class ThresholdColorEnum
        {
            /// <summary>
            /// Enum _B50E65 for value: #B50E65
            /// </summary>
            public static readonly ThresholdColorEnum _B50E65 = new ThresholdColorEnum("#B50E65");

            /// <summary>
            /// Enum _F23030 for value: #F23030
            /// </summary>
            public static readonly ThresholdColorEnum _F23030 = new ThresholdColorEnum("#F23030");

            /// <summary>
            /// Enum _FF8800 for value: #FF8800
            /// </summary>
            public static readonly ThresholdColorEnum _FF8800 = new ThresholdColorEnum("#FF8800");

            /// <summary>
            /// Enum _F2E70C for value: #F2E70C
            /// </summary>
            public static readonly ThresholdColorEnum _F2E70C = new ThresholdColorEnum("#F2E70C");

            private static readonly Dictionary<string, ThresholdColorEnum> StaticFields =
            new Dictionary<string, ThresholdColorEnum>()
            {
                { "#B50E65", _B50E65 },
                { "#F23030", _F23030 },
                { "#FF8800", _FF8800 },
                { "#F2E70C", _F2E70C },
            };

            private string _value;

            public ThresholdColorEnum()
            {

            }

            public ThresholdColorEnum(string value)
            {
                _value = value;
            }

            public static ThresholdColorEnum FromValue(string value)
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

                if (this.Equals(obj as ThresholdColorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ThresholdColorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ThresholdColorEnum a, ThresholdColorEnum b)
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

            public static bool operator !=(ThresholdColorEnum a, ThresholdColorEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释** 监控视图辅助线的阈值 **约束限制** 不涉及 **取值范围** 最小值为0，最大值为2147483647 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Threshold { get; set; }

        /// <summary>
        /// **参数解释** 监控视图辅助线的颜色 **约束限制** 不涉及           **取值范围** - \&quot;#B50E65\&quot;:紫色 - \&quot;#F23030\&quot;:红色 - \&quot;#FF8800\&quot;:橙色 - \&quot;#F2E70C\&quot;:黄色 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("threshold_color", NullValueHandling = NullValueHandling.Ignore)]
        public ThresholdColorEnum ThresholdColor { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThresholdInfo {\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  thresholdColor: ").Append(ThresholdColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThresholdInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThresholdInfo input)
        {
            if (input == null) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.ThresholdColor != input.ThresholdColor) return false;

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
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                hashCode = hashCode * 59 + this.ThresholdColor.GetHashCode();
                return hashCode;
            }
        }
    }
}
