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
    /// 
    /// </summary>
    public class RetentionPolicy 
    {
        /// <summary>
        /// **参数解释**：作业级库记录自动老化策略。 **约束限制**：   - 仅当平台开启作业老化能力且作业类型为自定义训练作业（kind&#x3D;job）时生效；   - 与用户级「作业自动老化」开关联动：     - 用户级开关**开启**：该用户下所有作业均参与老化（&#x60;policy&#x3D;disabled&#x60; 不能单独豁免）；     - 用户级开关**关闭**：仅 &#x60;policy&#x3D;enabled&#x60; 的作业参与老化；未设置或 &#x60;disabled&#x60; 均不参与。 **取值范围**：   - enabled：开启本作业老化   - disabled：关闭本作业老化（仅在用户级开关关闭时有效） **默认取值**：不传表示未单独设置，跟随用户级开关策略。
        /// </summary>
        /// <value>**参数解释**：作业级库记录自动老化策略。 **约束限制**：   - 仅当平台开启作业老化能力且作业类型为自定义训练作业（kind&#x3D;job）时生效；   - 与用户级「作业自动老化」开关联动：     - 用户级开关**开启**：该用户下所有作业均参与老化（&#x60;policy&#x3D;disabled&#x60; 不能单独豁免）；     - 用户级开关**关闭**：仅 &#x60;policy&#x3D;enabled&#x60; 的作业参与老化；未设置或 &#x60;disabled&#x60; 均不参与。 **取值范围**：   - enabled：开启本作业老化   - disabled：关闭本作业老化（仅在用户级开关关闭时有效） **默认取值**：不传表示未单独设置，跟随用户级开关策略。</value>
        [JsonConverter(typeof(EnumClassConverter<PolicyEnum>))]
        public class PolicyEnum
        {
            /// <summary>
            /// Enum ENABLED for value: enabled
            /// </summary>
            public static readonly PolicyEnum ENABLED = new PolicyEnum("enabled");

            /// <summary>
            /// Enum DISABLED for value: disabled
            /// </summary>
            public static readonly PolicyEnum DISABLED = new PolicyEnum("disabled");

            private static readonly Dictionary<string, PolicyEnum> StaticFields =
            new Dictionary<string, PolicyEnum>()
            {
                { "enabled", ENABLED },
                { "disabled", DISABLED },
            };

            private string _value;

            public PolicyEnum()
            {

            }

            public PolicyEnum(string value)
            {
                _value = value;
            }

            public static PolicyEnum FromValue(string value)
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

                if (this.Equals(obj as PolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PolicyEnum a, PolicyEnum b)
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

            public static bool operator !=(PolicyEnum a, PolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：作业级库记录自动老化策略。 **约束限制**：   - 仅当平台开启作业老化能力且作业类型为自定义训练作业（kind&#x3D;job）时生效；   - 与用户级「作业自动老化」开关联动：     - 用户级开关**开启**：该用户下所有作业均参与老化（&#x60;policy&#x3D;disabled&#x60; 不能单独豁免）；     - 用户级开关**关闭**：仅 &#x60;policy&#x3D;enabled&#x60; 的作业参与老化；未设置或 &#x60;disabled&#x60; 均不参与。 **取值范围**：   - enabled：开启本作业老化   - disabled：关闭本作业老化（仅在用户级开关关闭时有效） **默认取值**：不传表示未单独设置，跟随用户级开关策略。
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyEnum Policy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetentionPolicy {\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetentionPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetentionPolicy input)
        {
            if (input == null) return false;
            if (this.Policy != input.Policy) return false;

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
                hashCode = hashCode * 59 + this.Policy.GetHashCode();
                return hashCode;
            }
        }
    }
}
