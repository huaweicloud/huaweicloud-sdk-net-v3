using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 如下字段不可使用：  - node.kubernetes.io/memory-pressure - node.kubernetes.io/disk-pressure - node.kubernetes.io/out-of-disk - node.kubernetes.io/unschedulable - node.kubernetes.io/network-unavailable
    /// </summary>
    public class Taint 
    {
        /// <summary>
        /// **参数解释**： K8s污点的作用效果。 **约束限制**： 不涉及 **取值范围**： 只可选NoSchedule，PreferNoSchedule或NoExecute。 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： K8s污点的作用效果。 **约束限制**： 不涉及 **取值范围**： 只可选NoSchedule，PreferNoSchedule或NoExecute。 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<EffectEnum>))]
        public class EffectEnum
        {
            /// <summary>
            /// Enum NOSCHEDULE for value: NoSchedule
            /// </summary>
            public static readonly EffectEnum NOSCHEDULE = new EffectEnum("NoSchedule");

            /// <summary>
            /// Enum PREFERNOSCHEDULE for value: PreferNoSchedule
            /// </summary>
            public static readonly EffectEnum PREFERNOSCHEDULE = new EffectEnum("PreferNoSchedule");

            /// <summary>
            /// Enum NOEXECUTE for value: NoExecute
            /// </summary>
            public static readonly EffectEnum NOEXECUTE = new EffectEnum("NoExecute");

            private static readonly Dictionary<string, EffectEnum> StaticFields =
            new Dictionary<string, EffectEnum>()
            {
                { "NoSchedule", NOSCHEDULE },
                { "PreferNoSchedule", PREFERNOSCHEDULE },
                { "NoExecute", NOEXECUTE },
            };

            private string _value;

            public EffectEnum()
            {

            }

            public EffectEnum(string value)
            {
                _value = value;
            }

            public static EffectEnum FromValue(string value)
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

                if (this.Equals(obj as EffectEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EffectEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EffectEnum a, EffectEnum b)
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

            public static bool operator !=(EffectEnum a, EffectEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： K8s污点的键。 **约束限制**： 必须以字母或数字开头和结尾，可以包含字母、数字、连字符、下划线和点，最长63个字符。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**： K8s污点的值。 **约束限制**： 必须以字母或数字开头和结尾，可以包含字母、数字、连字符、下划线和点，最长63个字符。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数解释**： K8s污点的作用效果。 **约束限制**： 不涉及 **取值范围**： 只可选NoSchedule，PreferNoSchedule或NoExecute。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public EffectEnum Effect { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Taint {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Taint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Taint input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Effect != input.Effect) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Effect.GetHashCode();
                return hashCode;
            }
        }
    }
}
