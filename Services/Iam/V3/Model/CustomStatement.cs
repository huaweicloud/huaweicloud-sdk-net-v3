using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomStatement 
    {
        /// <summary>
        /// 作用。包含两种：允许（Allow）和拒绝（Deny），既有Allow又有Deny的授权语句时，遵循Deny优先的原则。
        /// </summary>
        /// <value>作用。包含两种：允许（Allow）和拒绝（Deny），既有Allow又有Deny的授权语句时，遵循Deny优先的原则。</value>
        [JsonConverter(typeof(EnumClassConverter<EffectEnum>))]
        public class EffectEnum
        {
            /// <summary>
            /// Enum ALLOW for value: Allow
            /// </summary>
            public static readonly EffectEnum ALLOW = new EffectEnum("Allow");

            /// <summary>
            /// Enum DENY for value: Deny
            /// </summary>
            public static readonly EffectEnum DENY = new EffectEnum("Deny");

            private static readonly Dictionary<string, EffectEnum> StaticFields =
            new Dictionary<string, EffectEnum>()
            {
                { "Allow", ALLOW },
                { "Deny", DENY },
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
        /// 授权项，指对资源的具体操作权限。 &gt; - 格式为：服务名:资源类型:操作，例：vpc:ports:create。 &gt; - 服务名为产品名称，例如ecs、evs和vpc等，服务名仅支持小写。 资源类型和操作没有大小写，要求支持通配符号*，无需罗列全部授权项。
        /// </summary>
        [JsonProperty("Action", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Action { get; set; }

        /// <summary>
        /// 作用。包含两种：允许（Allow）和拒绝（Deny），既有Allow又有Deny的授权语句时，遵循Deny优先的原则。
        /// </summary>
        [JsonProperty("Effect", NullValueHandling = NullValueHandling.Ignore)]
        public EffectEnum Effect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Condition", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, List<string>>> Condition { get; set; }

        /// <summary>
        /// 资源。规则如下： &gt; - 可填 * 的五段式：&lt;service-name&gt;:&lt;region&gt;:&lt;account-id&gt;:&lt;resource-type&gt;:&lt;resource-path&gt;，例：\&quot;obs:*:*:bucket:*\&quot;。 &gt; - region字段为*或用户可访问的region。service必须存在且resource属于对应service。
        /// </summary>
        [JsonProperty("Resource", NullValueHandling = NullValueHandling.Ignore)]
        public Object Resource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomStatement {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomStatement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomStatement input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && input.Action != null && !this.Action.SequenceEqual(input.Action))) return false;
            if (this.Effect != input.Effect) return false;
            if (this.Condition != input.Condition || (this.Condition != null && input.Condition != null && !this.Condition.SequenceEqual(input.Condition))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }
    }
}
