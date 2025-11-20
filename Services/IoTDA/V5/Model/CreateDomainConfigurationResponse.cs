using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateDomainConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// 域配置唯一标识ID
        /// </summary>
        [JsonProperty("configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// **参数说明**：自定义域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数说明**：应用协议场景，当前仅支持Device-MQTTS：设备接入MQTTS场景
        /// </summary>
        [JsonProperty("access_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessProtocol { get; set; }

        /// <summary>
        /// **参数说明**：自定义服务端证书ID
        /// </summary>
        [JsonProperty("server_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server_certificate_config", NullValueHandling = NullValueHandling.Ignore)]
        public ServerCertificateConfig ServerCertificateConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDomainConfigurationResponse {\n");
            sb.Append("  configurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  accessProtocol: ").Append(AccessProtocol).Append("\n");
            sb.Append("  serverCertificateId: ").Append(ServerCertificateId).Append("\n");
            sb.Append("  serverCertificateConfig: ").Append(ServerCertificateConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDomainConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDomainConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.ConfigurationId != input.ConfigurationId || (this.ConfigurationId != null && !this.ConfigurationId.Equals(input.ConfigurationId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.AccessProtocol != input.AccessProtocol || (this.AccessProtocol != null && !this.AccessProtocol.Equals(input.AccessProtocol))) return false;
            if (this.ServerCertificateId != input.ServerCertificateId || (this.ServerCertificateId != null && !this.ServerCertificateId.Equals(input.ServerCertificateId))) return false;
            if (this.ServerCertificateConfig != input.ServerCertificateConfig || (this.ServerCertificateConfig != null && !this.ServerCertificateConfig.Equals(input.ServerCertificateConfig))) return false;

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
                if (this.ConfigurationId != null) hashCode = hashCode * 59 + this.ConfigurationId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.AccessProtocol != null) hashCode = hashCode * 59 + this.AccessProtocol.GetHashCode();
                if (this.ServerCertificateId != null) hashCode = hashCode * 59 + this.ServerCertificateId.GetHashCode();
                if (this.ServerCertificateConfig != null) hashCode = hashCode * 59 + this.ServerCertificateConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
