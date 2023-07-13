using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kps.V3.Model
{
    /// <summary>
    /// 创建密钥对请求体请求参数
    /// </summary>
    public class CreateKeypairAction 
    {
        /// <summary>
        /// SSH密钥对的类型
        /// </summary>
        /// <value>SSH密钥对的类型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SSH for value: ssh
            /// </summary>
            public static readonly TypeEnum SSH = new TypeEnum("ssh");

            /// <summary>
            /// Enum X509 for value: x509
            /// </summary>
            public static readonly TypeEnum X509 = new TypeEnum("x509");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "ssh", SSH },
                { "x509", X509 },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 租户级或者用户级
        /// </summary>
        /// <value>租户级或者用户级</value>
        [JsonConverter(typeof(EnumClassConverter<ScopeEnum>))]
        public class ScopeEnum
        {
            /// <summary>
            /// Enum DOMAIN for value: domain
            /// </summary>
            public static readonly ScopeEnum DOMAIN = new ScopeEnum("domain");

            /// <summary>
            /// Enum USER for value: user
            /// </summary>
            public static readonly ScopeEnum USER = new ScopeEnum("user");

            private static readonly Dictionary<string, ScopeEnum> StaticFields =
            new Dictionary<string, ScopeEnum>()
            {
                { "domain", DOMAIN },
                { "user", USER },
            };

            private string _value;

            public ScopeEnum()
            {

            }

            public ScopeEnum(string value)
            {
                _value = value;
            }

            public static ScopeEnum FromValue(string value)
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

                if (this.Equals(obj as ScopeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScopeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScopeEnum a, ScopeEnum b)
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

            public static bool operator !=(ScopeEnum a, ScopeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// SSH密钥对的名称。 - 新创建的密钥对名称不能和已有密钥对的名称相同。 - SSH密钥对名称由英文字母、数字、下划线、中划线组成，长度不能超过64个字节
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// SSH密钥对的类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 导入公钥的字符串信息。
        /// </summary>
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        /// 租户级或者用户级
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public ScopeEnum Scope { get; set; }
        /// <summary>
        /// SSH密钥对所属的用户信息
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("key_protection", NullValueHandling = NullValueHandling.Ignore)]
        public KeyProtection KeyProtection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKeypairAction {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  keyProtection: ").Append(KeyProtection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKeypairAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKeypairAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.KeyProtection == input.KeyProtection ||
                    (this.KeyProtection != null &&
                    this.KeyProtection.Equals(input.KeyProtection))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.KeyProtection != null)
                    hashCode = hashCode * 59 + this.KeyProtection.GetHashCode();
                return hashCode;
            }
        }
    }
}
