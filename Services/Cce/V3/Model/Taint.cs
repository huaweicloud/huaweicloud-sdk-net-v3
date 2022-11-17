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
        /// 作用效果
        /// </summary>
        /// <value>作用效果</value>
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

            private string Value;

            public EffectEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(EffectEnum a, EffectEnum b)
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

            public static bool operator !=(EffectEnum a, EffectEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 键
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 作用效果
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
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Effect == input.Effect ||
                    (this.Effect != null &&
                    this.Effect.Equals(input.Effect))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Effect != null)
                    hashCode = hashCode * 59 + this.Effect.GetHashCode();
                return hashCode;
            }
        }
    }
}
