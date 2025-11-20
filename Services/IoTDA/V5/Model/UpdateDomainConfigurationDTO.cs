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
    /// 修改域配置请求体。
    /// </summary>
    public class UpdateDomainConfigurationDTO 
    {

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
            sb.Append("class UpdateDomainConfigurationDTO {\n");
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
            return this.Equals(input as UpdateDomainConfigurationDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainConfigurationDTO input)
        {
            if (input == null) return false;
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
                if (this.ServerCertificateId != null) hashCode = hashCode * 59 + this.ServerCertificateId.GetHashCode();
                if (this.ServerCertificateConfig != null) hashCode = hashCode * 59 + this.ServerCertificateConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
