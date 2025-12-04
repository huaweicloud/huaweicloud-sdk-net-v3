using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserPolicyEntity 
    {
        /// <summary>
        /// **参数解释**： 匹配方式。 **约束限制**： 不涉及。 **取值范围**： - LITERAL：完全匹配。 - PREFIXED：前缀匹配。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 匹配方式。 **约束限制**： 不涉及。 **取值范围**： - LITERAL：完全匹配。 - PREFIXED：前缀匹配。 **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<PatternTypeEnum>))]
        public class PatternTypeEnum
        {
            /// <summary>
            /// Enum LITERAL for value: LITERAL
            /// </summary>
            public static readonly PatternTypeEnum LITERAL = new PatternTypeEnum("LITERAL");

            /// <summary>
            /// Enum PREFIXED for value: PREFIXED
            /// </summary>
            public static readonly PatternTypeEnum PREFIXED = new PatternTypeEnum("PREFIXED");

            private static readonly Dictionary<string, PatternTypeEnum> StaticFields =
            new Dictionary<string, PatternTypeEnum>()
            {
                { "LITERAL", LITERAL },
                { "PREFIXED", PREFIXED },
            };

            private string _value;

            public PatternTypeEnum()
            {

            }

            public PatternTypeEnum(string value)
            {
                _value = value;
            }

            public static PatternTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PatternTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PatternTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PatternTypeEnum a, PatternTypeEnum b)
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

            public static bool operator !=(PatternTypeEnum a, PatternTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 权限类型。 **约束限制**： 不涉及。 **取值范围**： - all：拥有发布、订阅权限。 - pub：拥有发布权限。 - sub：拥有订阅权限。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 权限类型。 **约束限制**： 不涉及。 **取值范围**： - all：拥有发布、订阅权限。 - pub：拥有发布权限。 - sub：拥有订阅权限。 **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<AccessPolicyEnum>))]
        public class AccessPolicyEnum
        {
            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly AccessPolicyEnum ALL = new AccessPolicyEnum("all");

            /// <summary>
            /// Enum PUB for value: pub
            /// </summary>
            public static readonly AccessPolicyEnum PUB = new AccessPolicyEnum("pub");

            /// <summary>
            /// Enum SUB for value: sub
            /// </summary>
            public static readonly AccessPolicyEnum SUB = new AccessPolicyEnum("sub");

            private static readonly Dictionary<string, AccessPolicyEnum> StaticFields =
            new Dictionary<string, AccessPolicyEnum>()
            {
                { "all", ALL },
                { "pub", PUB },
                { "sub", SUB },
            };

            private string _value;

            public AccessPolicyEnum()
            {

            }

            public AccessPolicyEnum(string value)
            {
                _value = value;
            }

            public static AccessPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as AccessPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessPolicyEnum a, AccessPolicyEnum b)
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

            public static bool operator !=(AccessPolicyEnum a, AccessPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 资源类型。 **约束限制**： 不涉及。 **取值范围**： - TOPIC：表示资源类型为Topic。 **默认取值**： TOPIC
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// **参数解释**： 资源名称。 **约束限制**： 不涉及。 **取值范围**： - 已有的Topic名称。 - 符合Topic名称规则的前缀。 - “*”表示匹配所有的Topic。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// **参数解释**： 匹配方式。 **约束限制**： 不涉及。 **取值范围**： - LITERAL：完全匹配。 - PREFIXED：前缀匹配。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("pattern_type", NullValueHandling = NullValueHandling.Ignore)]
        public PatternTypeEnum PatternType { get; set; }
        /// <summary>
        /// **参数解释**： 权限类型。 **约束限制**： 不涉及。 **取值范围**： - all：拥有发布、订阅权限。 - pub：拥有发布权限。 - sub：拥有订阅权限。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("access_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AccessPolicyEnum AccessPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPolicyEntity {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  patternType: ").Append(PatternType).Append("\n");
            sb.Append("  accessPolicy: ").Append(AccessPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserPolicyEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserPolicyEntity input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.PatternType != input.PatternType) return false;
            if (this.AccessPolicy != input.AccessPolicy) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                hashCode = hashCode * 59 + this.PatternType.GetHashCode();
                hashCode = hashCode * 59 + this.AccessPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
