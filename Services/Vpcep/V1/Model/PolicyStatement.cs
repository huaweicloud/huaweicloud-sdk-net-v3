using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// policy
    /// </summary>
    public class PolicyStatement 
    {
        /// <summary>
        /// - Allow，允许控制访问权限 - Deny，拒绝控制访问权限
        /// </summary>
        /// <value>- Allow，允许控制访问权限 - Deny，拒绝控制访问权限</value>
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
        /// - Allow，允许控制访问权限 - Deny，拒绝控制访问权限
        /// </summary>
        [JsonProperty("Effect", NullValueHandling = NullValueHandling.Ignore)]
        public EffectEnum Effect { get; set; }
        /// <summary>
        /// obs访问权限
        /// </summary>
        [JsonProperty("Action", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Action { get; set; }

        /// <summary>
        /// obs对象
        /// </summary>
        [JsonProperty("Resource", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Resource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyStatement {\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyStatement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyStatement input)
        {
            if (input == null) return false;
            if (this.Effect != input.Effect) return false;
            if (this.Action != input.Action || (this.Action != null && input.Action != null && !this.Action.SequenceEqual(input.Action))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && input.Resource != null && !this.Resource.SequenceEqual(input.Resource))) return false;

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
                hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }
    }
}
