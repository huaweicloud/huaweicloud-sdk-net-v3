using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释**：透明大页（Transparent Hugepage，THP）配置，用于设置节点内存大页策略。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
    /// </summary>
    public class NodeconfigUpdateSpecConfigsTransparentHugepage 
    {
        /// <summary>
        /// **参数解释**：透明大页模式。 **约束限制**：不涉及。 **取值范围**：可选值如下： - always：始终启用。 - madvise：建议启用。 - never：不启用。 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：透明大页模式。 **约束限制**：不涉及。 **取值范围**：可选值如下： - always：始终启用。 - madvise：建议启用。 - never：不启用。 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum ALWAYS for value: always
            /// </summary>
            public static readonly ModeEnum ALWAYS = new ModeEnum("always");

            /// <summary>
            /// Enum MADVISE for value: madvise
            /// </summary>
            public static readonly ModeEnum MADVISE = new ModeEnum("madvise");

            /// <summary>
            /// Enum NEVER for value: never
            /// </summary>
            public static readonly ModeEnum NEVER = new ModeEnum("never");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "always", ALWAYS },
                { "madvise", MADVISE },
                { "never", NEVER },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：透明大页模式。 **约束限制**：不涉及。 **取值范围**：可选值如下： - always：始终启用。 - madvise：建议启用。 - never：不启用。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeconfigUpdateSpecConfigsTransparentHugepage {\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeconfigUpdateSpecConfigsTransparentHugepage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeconfigUpdateSpecConfigsTransparentHugepage input)
        {
            if (input == null) return false;
            if (this.Mode != input.Mode) return false;

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
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
