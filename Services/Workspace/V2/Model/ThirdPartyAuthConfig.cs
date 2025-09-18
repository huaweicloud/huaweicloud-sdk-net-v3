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
    /// 第三方认证配置信息。
    /// </summary>
    public class ThirdPartyAuthConfig 
    {
        /// <summary>
        /// 更新认证配置类型，认证类型为第三方密码时使用。ADD代表新增，UPDATE代表修改，DELETE代表删除。
        /// </summary>
        /// <value>更新认证配置类型，认证类型为第三方密码时使用。ADD代表新增，UPDATE代表修改，DELETE代表删除。</value>
        [JsonConverter(typeof(EnumClassConverter<ThirdPasswordUpdateTypeEnum>))]
        public class ThirdPasswordUpdateTypeEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            public static readonly ThirdPasswordUpdateTypeEnum ADD = new ThirdPasswordUpdateTypeEnum("ADD");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly ThirdPasswordUpdateTypeEnum UPDATE = new ThirdPasswordUpdateTypeEnum("UPDATE");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly ThirdPasswordUpdateTypeEnum DELETE = new ThirdPasswordUpdateTypeEnum("DELETE");

            private static readonly Dictionary<string, ThirdPasswordUpdateTypeEnum> StaticFields =
            new Dictionary<string, ThirdPasswordUpdateTypeEnum>()
            {
                { "ADD", ADD },
                { "UPDATE", UPDATE },
                { "DELETE", DELETE },
            };

            private string _value;

            public ThirdPasswordUpdateTypeEnum()
            {

            }

            public ThirdPasswordUpdateTypeEnum(string value)
            {
                _value = value;
            }

            public static ThirdPasswordUpdateTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ThirdPasswordUpdateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ThirdPasswordUpdateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ThirdPasswordUpdateTypeEnum a, ThirdPasswordUpdateTypeEnum b)
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

            public static bool operator !=(ThirdPasswordUpdateTypeEnum a, ThirdPasswordUpdateTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 更新认证配置类型，认证类型为第三方单点登录时使用。
        /// </summary>
        [JsonProperty("update_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateType { get; set; }

        /// <summary>
        /// 是否启用。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 更新认证配置对象，认证类型为第三方单点登录时使用。
        /// </summary>
        [JsonProperty("update_object", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateObject { get; set; }

        /// <summary>
        /// 认证类型。
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("client_interface_config", NullValueHandling = NullValueHandling.Ignore)]
        public InterfacesConfig ClientInterfaceConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server_interface_config", NullValueHandling = NullValueHandling.Ignore)]
        public InterfacesConfig ServerInterfaceConfig { get; set; }

        /// <summary>
        /// 更新认证配置类型，认证类型为第三方密码时使用。ADD代表新增，UPDATE代表修改，DELETE代表删除。
        /// </summary>
        [JsonProperty("third_password_update_type", NullValueHandling = NullValueHandling.Ignore)]
        public ThirdPasswordUpdateTypeEnum ThirdPasswordUpdateType { get; set; }
        /// <summary>
        /// 自定义接口配置。
        /// </summary>
        [JsonProperty("custom_definition", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomDefinition { get; set; }

        /// <summary>
        /// oauth2配置。
        /// </summary>
        [JsonProperty("oauth_configs", NullValueHandling = NullValueHandling.Ignore)]
        public string OauthConfigs { get; set; }

        /// <summary>
        /// 单点登录配置信息列表。
        /// </summary>
        [JsonProperty("ldap_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<LdapConfig> LdapConfigs { get; set; }

        /// <summary>
        /// 更新认证配置对象，认证类型为第三方密码时使用。
        /// </summary>
        [JsonProperty("third_password_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdPasswordName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartyAuthConfig {\n");
            sb.Append("  updateType: ").Append(UpdateType).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  updateObject: ").Append(UpdateObject).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  clientInterfaceConfig: ").Append(ClientInterfaceConfig).Append("\n");
            sb.Append("  serverInterfaceConfig: ").Append(ServerInterfaceConfig).Append("\n");
            sb.Append("  thirdPasswordUpdateType: ").Append(ThirdPasswordUpdateType).Append("\n");
            sb.Append("  customDefinition: ").Append(CustomDefinition).Append("\n");
            sb.Append("  oauthConfigs: ").Append(OauthConfigs).Append("\n");
            sb.Append("  ldapConfigs: ").Append(LdapConfigs).Append("\n");
            sb.Append("  thirdPasswordName: ").Append(ThirdPasswordName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThirdPartyAuthConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThirdPartyAuthConfig input)
        {
            if (input == null) return false;
            if (this.UpdateType != input.UpdateType || (this.UpdateType != null && !this.UpdateType.Equals(input.UpdateType))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.UpdateObject != input.UpdateObject || (this.UpdateObject != null && !this.UpdateObject.Equals(input.UpdateObject))) return false;
            if (this.AuthType != input.AuthType || (this.AuthType != null && !this.AuthType.Equals(input.AuthType))) return false;
            if (this.ClientInterfaceConfig != input.ClientInterfaceConfig || (this.ClientInterfaceConfig != null && !this.ClientInterfaceConfig.Equals(input.ClientInterfaceConfig))) return false;
            if (this.ServerInterfaceConfig != input.ServerInterfaceConfig || (this.ServerInterfaceConfig != null && !this.ServerInterfaceConfig.Equals(input.ServerInterfaceConfig))) return false;
            if (this.ThirdPasswordUpdateType != input.ThirdPasswordUpdateType) return false;
            if (this.CustomDefinition != input.CustomDefinition || (this.CustomDefinition != null && !this.CustomDefinition.Equals(input.CustomDefinition))) return false;
            if (this.OauthConfigs != input.OauthConfigs || (this.OauthConfigs != null && !this.OauthConfigs.Equals(input.OauthConfigs))) return false;
            if (this.LdapConfigs != input.LdapConfigs || (this.LdapConfigs != null && input.LdapConfigs != null && !this.LdapConfigs.SequenceEqual(input.LdapConfigs))) return false;
            if (this.ThirdPasswordName != input.ThirdPasswordName || (this.ThirdPasswordName != null && !this.ThirdPasswordName.Equals(input.ThirdPasswordName))) return false;

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
                if (this.UpdateType != null) hashCode = hashCode * 59 + this.UpdateType.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.UpdateObject != null) hashCode = hashCode * 59 + this.UpdateObject.GetHashCode();
                if (this.AuthType != null) hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.ClientInterfaceConfig != null) hashCode = hashCode * 59 + this.ClientInterfaceConfig.GetHashCode();
                if (this.ServerInterfaceConfig != null) hashCode = hashCode * 59 + this.ServerInterfaceConfig.GetHashCode();
                hashCode = hashCode * 59 + this.ThirdPasswordUpdateType.GetHashCode();
                if (this.CustomDefinition != null) hashCode = hashCode * 59 + this.CustomDefinition.GetHashCode();
                if (this.OauthConfigs != null) hashCode = hashCode * 59 + this.OauthConfigs.GetHashCode();
                if (this.LdapConfigs != null) hashCode = hashCode * 59 + this.LdapConfigs.GetHashCode();
                if (this.ThirdPasswordName != null) hashCode = hashCode * 59 + this.ThirdPasswordName.GetHashCode();
                return hashCode;
            }
        }
    }
}
