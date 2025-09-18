using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IdentityStoreDto 
    {
        /// <summary>
        /// 身份源类型
        /// </summary>
        /// <value>身份源类型</value>
        [JsonConverter(typeof(EnumClassConverter<IdentityStoreTypeEnum>))]
        public class IdentityStoreTypeEnum
        {
            /// <summary>
            /// Enum USERPOOL for value: UserPool
            /// </summary>
            public static readonly IdentityStoreTypeEnum USERPOOL = new IdentityStoreTypeEnum("UserPool");

            private static readonly Dictionary<string, IdentityStoreTypeEnum> StaticFields =
            new Dictionary<string, IdentityStoreTypeEnum>()
            {
                { "UserPool", USERPOOL },
            };

            private string _value;

            public IdentityStoreTypeEnum()
            {

            }

            public IdentityStoreTypeEnum(string value)
            {
                _value = value;
            }

            public static IdentityStoreTypeEnum FromValue(string value)
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

                if (this.Equals(obj as IdentityStoreTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IdentityStoreTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IdentityStoreTypeEnum a, IdentityStoreTypeEnum b)
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

            public static bool operator !=(IdentityStoreTypeEnum a, IdentityStoreTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 登录认证类型
        /// </summary>
        /// <value>登录认证类型</value>
        [JsonConverter(typeof(EnumClassConverter<AuthenticationTypeEnum>))]
        public class AuthenticationTypeEnum
        {
            /// <summary>
            /// Enum SAML_2_0 for value: SAML_2.0
            /// </summary>
            public static readonly AuthenticationTypeEnum SAML_2_0 = new AuthenticationTypeEnum("SAML_2.0");

            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly AuthenticationTypeEnum DEFAULT = new AuthenticationTypeEnum("DEFAULT");

            private static readonly Dictionary<string, AuthenticationTypeEnum> StaticFields =
            new Dictionary<string, AuthenticationTypeEnum>()
            {
                { "SAML_2.0", SAML_2_0 },
                { "DEFAULT", DEFAULT },
            };

            private string _value;

            public AuthenticationTypeEnum()
            {

            }

            public AuthenticationTypeEnum(string value)
            {
                _value = value;
            }

            public static AuthenticationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AuthenticationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AuthenticationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AuthenticationTypeEnum a, AuthenticationTypeEnum b)
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

            public static bool operator !=(AuthenticationTypeEnum a, AuthenticationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines provisioningType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ProvisioningTypeEnum>))]
        public class ProvisioningTypeEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly ProvisioningTypeEnum DEFAULT = new ProvisioningTypeEnum("DEFAULT");

            /// <summary>
            /// Enum SCIM for value: SCIM
            /// </summary>
            public static readonly ProvisioningTypeEnum SCIM = new ProvisioningTypeEnum("SCIM");

            private static readonly Dictionary<string, ProvisioningTypeEnum> StaticFields =
            new Dictionary<string, ProvisioningTypeEnum>()
            {
                { "DEFAULT", DEFAULT },
                { "SCIM", SCIM },
            };

            private string _value;

            public ProvisioningTypeEnum()
            {

            }

            public ProvisioningTypeEnum(string value)
            {
                _value = value;
            }

            public static ProvisioningTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ProvisioningTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProvisioningTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProvisioningTypeEnum a, ProvisioningTypeEnum b)
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

            public static bool operator !=(ProvisioningTypeEnum a, ProvisioningTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 身份源是否启用状态
        /// </summary>
        /// <value>身份源是否启用状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly StatusEnum DISABLED = new StatusEnum("DISABLED");

            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly StatusEnum ENABLED = new StatusEnum("ENABLED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "DISABLED", DISABLED },
                { "ENABLED", ENABLED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 关联到IAM身份中心实例的身份源的全局唯一标识符（ID）。
        /// </summary>
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// 身份源类型
        /// </summary>
        [JsonProperty("identity_store_type", NullValueHandling = NullValueHandling.Ignore)]
        public IdentityStoreTypeEnum IdentityStoreType { get; set; }
        /// <summary>
        /// 登录认证类型
        /// </summary>
        [JsonProperty("authentication_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthenticationTypeEnum AuthenticationType { get; set; }
        /// <summary>
        /// 预配类型
        /// </summary>
        [JsonProperty("provisioning_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProvisioningTypeEnum> ProvisioningType { get; set; }
        /// <summary>
        /// 身份源是否启用状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityStoreDto {\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("  identityStoreType: ").Append(IdentityStoreType).Append("\n");
            sb.Append("  authenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  provisioningType: ").Append(ProvisioningType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdentityStoreDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdentityStoreDto input)
        {
            if (input == null) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;
            if (this.IdentityStoreType != input.IdentityStoreType) return false;
            if (this.AuthenticationType != input.AuthenticationType) return false;
            if (this.ProvisioningType != input.ProvisioningType || (this.ProvisioningType != null && input.ProvisioningType != null && !this.ProvisioningType.SequenceEqual(input.ProvisioningType))) return false;
            if (this.Status != input.Status) return false;

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
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                hashCode = hashCode * 59 + this.IdentityStoreType.GetHashCode();
                hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
                hashCode = hashCode * 59 + this.ProvisioningType.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
