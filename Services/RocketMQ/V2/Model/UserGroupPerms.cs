using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserGroupPerms 
    {
        /// <summary>
        /// **参数解释**： 消费组权限。 **约束限制**： 不涉及。 **取值范围**： - SUB：拥有订阅权限。 - DENY：无权限。  **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 消费组权限。 **约束限制**： 不涉及。 **取值范围**： - SUB：拥有订阅权限。 - DENY：无权限。  **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<PermEnum>))]
        public class PermEnum
        {
            /// <summary>
            /// Enum SUB for value: SUB
            /// </summary>
            public static readonly PermEnum SUB = new PermEnum("SUB");

            /// <summary>
            /// Enum DENY for value: DENY
            /// </summary>
            public static readonly PermEnum DENY = new PermEnum("DENY");

            private static readonly Dictionary<string, PermEnum> StaticFields =
            new Dictionary<string, PermEnum>()
            {
                { "SUB", SUB },
                { "DENY", DENY },
            };

            private string _value;

            public PermEnum()
            {

            }

            public PermEnum(string value)
            {
                _value = value;
            }

            public static PermEnum FromValue(string value)
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

                if (this.Equals(obj as PermEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermEnum a, PermEnum b)
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

            public static bool operator !=(PermEnum a, PermEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 消费组名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 消费组权限。 **约束限制**： 不涉及。 **取值范围**： - SUB：拥有订阅权限。 - DENY：无权限。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("perm", NullValueHandling = NullValueHandling.Ignore)]
        public PermEnum Perm { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserGroupPerms {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  perm: ").Append(Perm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserGroupPerms);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserGroupPerms input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Perm != input.Perm) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Perm.GetHashCode();
                return hashCode;
            }
        }
    }
}
