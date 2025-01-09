using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// ldap认证配置
    /// </summary>
    public class LdapConfig 
    {
        /// <summary>
        /// 安全类型
        /// </summary>
        /// <value>安全类型</value>
        [JsonConverter(typeof(EnumClassConverter<SecurityTypeEnum>))]
        public class SecurityTypeEnum
        {
            /// <summary>
            /// Enum USE_SSL for value: USE_SSL
            /// </summary>
            public static readonly SecurityTypeEnum USE_SSL = new SecurityTypeEnum("USE_SSL");

            /// <summary>
            /// Enum USE_TLS for value: USE_TLS
            /// </summary>
            public static readonly SecurityTypeEnum USE_TLS = new SecurityTypeEnum("USE_TLS");

            /// <summary>
            /// Enum CLOSE for value: CLOSE
            /// </summary>
            public static readonly SecurityTypeEnum CLOSE = new SecurityTypeEnum("CLOSE");

            private static readonly Dictionary<string, SecurityTypeEnum> StaticFields =
            new Dictionary<string, SecurityTypeEnum>()
            {
                { "USE_SSL", USE_SSL },
                { "USE_TLS", USE_TLS },
                { "CLOSE", CLOSE },
            };

            private string _value;

            public SecurityTypeEnum()
            {

            }

            public SecurityTypeEnum(string value)
            {
                _value = value;
            }

            public static SecurityTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SecurityTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SecurityTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SecurityTypeEnum a, SecurityTypeEnum b)
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

            public static bool operator !=(SecurityTypeEnum a, SecurityTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// host
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// 端口,取值范围1-65535,默认389
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// base_dn
        /// </summary>
        [JsonProperty("base_dn", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseDn { get; set; }

        /// <summary>
        /// 管理员dn
        /// </summary>
        [JsonProperty("administrator_dn", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministratorDn { get; set; }

        /// <summary>
        /// 管理员密码
        /// </summary>
        [JsonProperty("administrator_password", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministratorPassword { get; set; }

        /// <summary>
        /// 用户dn
        /// </summary>
        [JsonProperty("user_dn", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDn { get; set; }

        /// <summary>
        /// 是否启用ssl
        /// </summary>
        [JsonProperty("use_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSsl { get; set; }

        /// <summary>
        /// 证书
        /// </summary>
        [JsonProperty("cert_content", NullValueHandling = NullValueHandling.Ignore)]
        public string CertContent { get; set; }

        /// <summary>
        /// 用户名属性
        /// </summary>
        [JsonProperty("username_attribute", NullValueHandling = NullValueHandling.Ignore)]
        public string UsernameAttribute { get; set; }

        /// <summary>
        /// 用户ObjectClass
        /// </summary>
        [JsonProperty("object_class", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectClass { get; set; }

        /// <summary>
        /// 安全类型
        /// </summary>
        [JsonProperty("security_type", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityTypeEnum SecurityType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LdapConfig {\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  baseDn: ").Append(BaseDn).Append("\n");
            sb.Append("  administratorDn: ").Append(AdministratorDn).Append("\n");
            sb.Append("  administratorPassword: ").Append(AdministratorPassword).Append("\n");
            sb.Append("  userDn: ").Append(UserDn).Append("\n");
            sb.Append("  useSsl: ").Append(UseSsl).Append("\n");
            sb.Append("  certContent: ").Append(CertContent).Append("\n");
            sb.Append("  usernameAttribute: ").Append(UsernameAttribute).Append("\n");
            sb.Append("  objectClass: ").Append(ObjectClass).Append("\n");
            sb.Append("  securityType: ").Append(SecurityType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LdapConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LdapConfig input)
        {
            if (input == null) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.BaseDn != input.BaseDn || (this.BaseDn != null && !this.BaseDn.Equals(input.BaseDn))) return false;
            if (this.AdministratorDn != input.AdministratorDn || (this.AdministratorDn != null && !this.AdministratorDn.Equals(input.AdministratorDn))) return false;
            if (this.AdministratorPassword != input.AdministratorPassword || (this.AdministratorPassword != null && !this.AdministratorPassword.Equals(input.AdministratorPassword))) return false;
            if (this.UserDn != input.UserDn || (this.UserDn != null && !this.UserDn.Equals(input.UserDn))) return false;
            if (this.UseSsl != input.UseSsl || (this.UseSsl != null && !this.UseSsl.Equals(input.UseSsl))) return false;
            if (this.CertContent != input.CertContent || (this.CertContent != null && !this.CertContent.Equals(input.CertContent))) return false;
            if (this.UsernameAttribute != input.UsernameAttribute || (this.UsernameAttribute != null && !this.UsernameAttribute.Equals(input.UsernameAttribute))) return false;
            if (this.ObjectClass != input.ObjectClass || (this.ObjectClass != null && !this.ObjectClass.Equals(input.ObjectClass))) return false;
            if (this.SecurityType != input.SecurityType) return false;

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
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.BaseDn != null) hashCode = hashCode * 59 + this.BaseDn.GetHashCode();
                if (this.AdministratorDn != null) hashCode = hashCode * 59 + this.AdministratorDn.GetHashCode();
                if (this.AdministratorPassword != null) hashCode = hashCode * 59 + this.AdministratorPassword.GetHashCode();
                if (this.UserDn != null) hashCode = hashCode * 59 + this.UserDn.GetHashCode();
                if (this.UseSsl != null) hashCode = hashCode * 59 + this.UseSsl.GetHashCode();
                if (this.CertContent != null) hashCode = hashCode * 59 + this.CertContent.GetHashCode();
                if (this.UsernameAttribute != null) hashCode = hashCode * 59 + this.UsernameAttribute.GetHashCode();
                if (this.ObjectClass != null) hashCode = hashCode * 59 + this.ObjectClass.GetHashCode();
                hashCode = hashCode * 59 + this.SecurityType.GetHashCode();
                return hashCode;
            }
        }
    }
}
