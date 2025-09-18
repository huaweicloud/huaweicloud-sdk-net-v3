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
    /// 应用程序实例
    /// </summary>
    public class ApplicationInstanceDto 
    {
        /// <summary>
        /// 应用程序实例状态
        /// </summary>
        /// <value>应用程序实例状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            public static readonly StatusEnum CREATED = new StatusEnum("CREATED");

            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly StatusEnum ENABLED = new StatusEnum("ENABLED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATED", CREATED },
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
        /// 
        /// </summary>
        [JsonProperty("active_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public CertificateDto ActiveCertificate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayDto Display { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identity_provider_config", NullValueHandling = NullValueHandling.Ignore)]
        public IdentityProviderConfigDto IdentityProviderConfig { get; set; }

        /// <summary>
        /// 应用程序实例唯一标识ID
        /// </summary>
        [JsonProperty("application_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationInstanceId { get; set; }

        /// <summary>
        /// 应用程序UUID
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用程序在门户是否可见
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_config", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseConfigDto ResponseConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_schema_config", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseSchemaConfigDto ResponseSchemaConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_config", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityConfigDto SecurityConfig { get; set; }

        /// <summary>
        /// 应用程序实例状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public ApplicationTemplateDto Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_provider_config", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceProviderConfigDto ServiceProviderConfig { get; set; }

        /// <summary>
        /// OIDC Client ID
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// 用户是否可见
        /// </summary>
        [JsonProperty("end_user_visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EndUserVisible { get; set; }

        /// <summary>
        /// 组员所属账号ID
        /// </summary>
        [JsonProperty("managed_account", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedAccount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInstanceDto {\n");
            sb.Append("  activeCertificate: ").Append(ActiveCertificate).Append("\n");
            sb.Append("  display: ").Append(Display).Append("\n");
            sb.Append("  identityProviderConfig: ").Append(IdentityProviderConfig).Append("\n");
            sb.Append("  applicationInstanceId: ").Append(ApplicationInstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  visible: ").Append(Visible).Append("\n");
            sb.Append("  responseConfig: ").Append(ResponseConfig).Append("\n");
            sb.Append("  responseSchemaConfig: ").Append(ResponseSchemaConfig).Append("\n");
            sb.Append("  securityConfig: ").Append(SecurityConfig).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("  serviceProviderConfig: ").Append(ServiceProviderConfig).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  endUserVisible: ").Append(EndUserVisible).Append("\n");
            sb.Append("  managedAccount: ").Append(ManagedAccount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationInstanceDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplicationInstanceDto input)
        {
            if (input == null) return false;
            if (this.ActiveCertificate != input.ActiveCertificate || (this.ActiveCertificate != null && !this.ActiveCertificate.Equals(input.ActiveCertificate))) return false;
            if (this.Display != input.Display || (this.Display != null && !this.Display.Equals(input.Display))) return false;
            if (this.IdentityProviderConfig != input.IdentityProviderConfig || (this.IdentityProviderConfig != null && !this.IdentityProviderConfig.Equals(input.IdentityProviderConfig))) return false;
            if (this.ApplicationInstanceId != input.ApplicationInstanceId || (this.ApplicationInstanceId != null && !this.ApplicationInstanceId.Equals(input.ApplicationInstanceId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Visible != input.Visible || (this.Visible != null && !this.Visible.Equals(input.Visible))) return false;
            if (this.ResponseConfig != input.ResponseConfig || (this.ResponseConfig != null && !this.ResponseConfig.Equals(input.ResponseConfig))) return false;
            if (this.ResponseSchemaConfig != input.ResponseSchemaConfig || (this.ResponseSchemaConfig != null && !this.ResponseSchemaConfig.Equals(input.ResponseSchemaConfig))) return false;
            if (this.SecurityConfig != input.SecurityConfig || (this.SecurityConfig != null && !this.SecurityConfig.Equals(input.SecurityConfig))) return false;
            if (this.Status != input.Status) return false;
            if (this.Template != input.Template || (this.Template != null && !this.Template.Equals(input.Template))) return false;
            if (this.ServiceProviderConfig != input.ServiceProviderConfig || (this.ServiceProviderConfig != null && !this.ServiceProviderConfig.Equals(input.ServiceProviderConfig))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.EndUserVisible != input.EndUserVisible || (this.EndUserVisible != null && !this.EndUserVisible.Equals(input.EndUserVisible))) return false;
            if (this.ManagedAccount != input.ManagedAccount || (this.ManagedAccount != null && !this.ManagedAccount.Equals(input.ManagedAccount))) return false;

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
                if (this.ActiveCertificate != null) hashCode = hashCode * 59 + this.ActiveCertificate.GetHashCode();
                if (this.Display != null) hashCode = hashCode * 59 + this.Display.GetHashCode();
                if (this.IdentityProviderConfig != null) hashCode = hashCode * 59 + this.IdentityProviderConfig.GetHashCode();
                if (this.ApplicationInstanceId != null) hashCode = hashCode * 59 + this.ApplicationInstanceId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Visible != null) hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.ResponseConfig != null) hashCode = hashCode * 59 + this.ResponseConfig.GetHashCode();
                if (this.ResponseSchemaConfig != null) hashCode = hashCode * 59 + this.ResponseSchemaConfig.GetHashCode();
                if (this.SecurityConfig != null) hashCode = hashCode * 59 + this.SecurityConfig.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Template != null) hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.ServiceProviderConfig != null) hashCode = hashCode * 59 + this.ServiceProviderConfig.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.EndUserVisible != null) hashCode = hashCode * 59 + this.EndUserVisible.GetHashCode();
                if (this.ManagedAccount != null) hashCode = hashCode * 59 + this.ManagedAccount.GetHashCode();
                return hashCode;
            }
        }
    }
}
