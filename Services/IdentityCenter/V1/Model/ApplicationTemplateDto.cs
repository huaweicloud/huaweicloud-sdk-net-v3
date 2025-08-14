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
    /// 应用程序模板
    /// </summary>
    public class ApplicationTemplateDto 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public ApplicationTemplateDisplayDto Application { get; set; }

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
        /// 支持的协议
        /// </summary>
        [JsonProperty("sso_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string SsoProtocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_config", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityConfigDto SecurityConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_provider_config", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceProviderConfigDto ServiceProviderConfig { get; set; }

        /// <summary>
        /// 应用程序模板唯一标识ID
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 应用程序模板版本
        /// </summary>
        [JsonProperty("template_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationTemplateDto {\n");
            sb.Append("  application: ").Append(Application).Append("\n");
            sb.Append("  responseConfig: ").Append(ResponseConfig).Append("\n");
            sb.Append("  responseSchemaConfig: ").Append(ResponseSchemaConfig).Append("\n");
            sb.Append("  ssoProtocol: ").Append(SsoProtocol).Append("\n");
            sb.Append("  securityConfig: ").Append(SecurityConfig).Append("\n");
            sb.Append("  serviceProviderConfig: ").Append(ServiceProviderConfig).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  templateVersion: ").Append(TemplateVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationTemplateDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplicationTemplateDto input)
        {
            if (input == null) return false;
            if (this.Application != input.Application || (this.Application != null && !this.Application.Equals(input.Application))) return false;
            if (this.ResponseConfig != input.ResponseConfig || (this.ResponseConfig != null && !this.ResponseConfig.Equals(input.ResponseConfig))) return false;
            if (this.ResponseSchemaConfig != input.ResponseSchemaConfig || (this.ResponseSchemaConfig != null && !this.ResponseSchemaConfig.Equals(input.ResponseSchemaConfig))) return false;
            if (this.SsoProtocol != input.SsoProtocol || (this.SsoProtocol != null && !this.SsoProtocol.Equals(input.SsoProtocol))) return false;
            if (this.SecurityConfig != input.SecurityConfig || (this.SecurityConfig != null && !this.SecurityConfig.Equals(input.SecurityConfig))) return false;
            if (this.ServiceProviderConfig != input.ServiceProviderConfig || (this.ServiceProviderConfig != null && !this.ServiceProviderConfig.Equals(input.ServiceProviderConfig))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.TemplateVersion != input.TemplateVersion || (this.TemplateVersion != null && !this.TemplateVersion.Equals(input.TemplateVersion))) return false;

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
                if (this.Application != null) hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.ResponseConfig != null) hashCode = hashCode * 59 + this.ResponseConfig.GetHashCode();
                if (this.ResponseSchemaConfig != null) hashCode = hashCode * 59 + this.ResponseSchemaConfig.GetHashCode();
                if (this.SsoProtocol != null) hashCode = hashCode * 59 + this.SsoProtocol.GetHashCode();
                if (this.SecurityConfig != null) hashCode = hashCode * 59 + this.SecurityConfig.GetHashCode();
                if (this.ServiceProviderConfig != null) hashCode = hashCode * 59 + this.ServiceProviderConfig.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateVersion != null) hashCode = hashCode * 59 + this.TemplateVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
