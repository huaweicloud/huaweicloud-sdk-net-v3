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
    /// 密钥对详细信息
    /// </summary>
    public class KeypairDetail 
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

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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

            private string Value;

            public ScopeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// SSH密钥对的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// SSH密钥对的ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// SSH密钥对的类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 租户级或者用户级
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
        /// SSH密钥对删除的标记
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// SSH密钥对的描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// SSH密钥对所属的用户信息
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// SSH密钥对创建的时间，时间戳，即从1970年1月1日至该时间的总秒数
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// SSH密钥对删除的时间，时间戳，即从1970年1月1日至该时间的总秒数
        /// </summary>
        [JsonProperty("delete_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeleteTime { get; set; }

        /// <summary>
        /// SSH密钥对的更新时间，时间戳，即从1970年1月1日至该时间的总秒数
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 冻结状态 - 0：正常状态 - 1：普通冻结 - 2：公安冻结 - 3：普通冻结及公安冻结 - 4：违规冻结 - 5：普通冻结及违规冻结 - 6：公安冻结及违规冻结 - 7：普通冻结、公安冻结及违规冻结 - 8：未实名认证冻结 - 9：普通冻结及未实名认证冻结 - 10：公安冻结及未实名认证冻结
        /// </summary>
        [JsonProperty("frozen_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrozenState { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeypairDetail {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  isKeyProtection: ").Append(IsKeyProtection).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  deleteTime: ").Append(DeleteTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  frozenState: ").Append(FrozenState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeypairDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeypairDetail input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.IsKeyProtection == input.IsKeyProtection ||
                    (this.IsKeyProtection != null &&
                    this.IsKeyProtection.Equals(input.IsKeyProtection))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.DeleteTime == input.DeleteTime ||
                    (this.DeleteTime != null &&
                    this.DeleteTime.Equals(input.DeleteTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.FrozenState == input.FrozenState ||
                    (this.FrozenState != null &&
                    this.FrozenState.Equals(input.FrozenState))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.IsKeyProtection != null)
                    hashCode = hashCode * 59 + this.IsKeyProtection.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DeleteTime != null)
                    hashCode = hashCode * 59 + this.DeleteTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.FrozenState != null)
                    hashCode = hashCode * 59 + this.FrozenState.GetHashCode();
                return hashCode;
            }
        }
    }
}
