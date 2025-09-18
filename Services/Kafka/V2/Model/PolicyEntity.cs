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
    public class PolicyEntity 
    {
        /// <summary>
        /// 权限类型。 - all：拥有发布、订阅权限; - pub：拥有发布权限; - sub：拥有订阅权限。
        /// </summary>
        /// <value>权限类型。 - all：拥有发布、订阅权限; - pub：拥有发布权限; - sub：拥有订阅权限。</value>
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
        /// 是否为创建Topic时所选择的用户。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Owner { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 权限类型。 - all：拥有发布、订阅权限; - pub：拥有发布权限; - sub：拥有订阅权限。
        /// </summary>
        [JsonProperty("access_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AccessPolicyEnum AccessPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyEntity {\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  accessPolicy: ").Append(AccessPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyEntity input)
        {
            if (input == null) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
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
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                hashCode = hashCode * 59 + this.AccessPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
