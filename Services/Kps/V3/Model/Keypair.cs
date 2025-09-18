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
    /// 密钥对信息
    /// </summary>
    public class Keypair 
    {
        /// <summary>
        /// SSH密钥对的类型，值为“ssh”或“x509”
        /// </summary>
        /// <value>SSH密钥对的类型，值为“ssh”或“x509”</value>
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 租户级或者用户级。domain或user。
        /// </summary>
        /// <value>租户级或者用户级。domain或user。</value>
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

            public static bool operator !=(ScopeEnum a, ScopeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// SSH密钥对的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// SSH密钥对的类型，值为“ssh”或“x509”
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 租户级或者用户级。domain或user。
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public ScopeEnum Scope { get; set; }
        /// <summary>
        /// SSH密钥对对应的publicKey信息
        /// </summary>
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        /// SSH密钥对应指纹信息
        /// </summary>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// 是否托管密钥
        /// </summary>
        [JsonProperty("is_key_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsKeyProtection { get; set; }

        /// <summary>
        /// 冻结状态 - 0：正常状态 - 1：普通冻结 - 2：公安冻结 - 3：普通冻结及公安冻结 - 4：违规冻结 - 5：普通冻结及违规冻结 - 6：公安冻结及违规冻结 - 7：普通冻结、公安冻结及违规冻结 - 8：未实名认证冻结 - 9：普通冻结及未实名认证冻结 - 10：公安冻结及未实名认证冻结
        /// </summary>
        [JsonProperty("frozen_state", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Keypair {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  isKeyProtection: ").Append(IsKeyProtection).Append("\n");
            sb.Append("  frozenState: ").Append(FrozenState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Keypair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Keypair input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type) return false;
            if (this.Scope != input.Scope) return false;
            if (this.PublicKey != input.PublicKey || (this.PublicKey != null && !this.PublicKey.Equals(input.PublicKey))) return false;
            if (this.Fingerprint != input.Fingerprint || (this.Fingerprint != null && !this.Fingerprint.Equals(input.Fingerprint))) return false;
            if (this.IsKeyProtection != input.IsKeyProtection || (this.IsKeyProtection != null && !this.IsKeyProtection.Equals(input.IsKeyProtection))) return false;
            if (this.FrozenState != input.FrozenState || (this.FrozenState != null && !this.FrozenState.Equals(input.FrozenState))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.PublicKey != null) hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.Fingerprint != null) hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.IsKeyProtection != null) hashCode = hashCode * 59 + this.IsKeyProtection.GetHashCode();
                if (this.FrozenState != null) hashCode = hashCode * 59 + this.FrozenState.GetHashCode();
                return hashCode;
            }
        }
    }
}
