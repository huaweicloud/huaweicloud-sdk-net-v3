using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClusterCert 
    {

        /// <summary>
        /// **参数解释**： 上下文user信息 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// **参数解释**： 证书授权数据 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("certificate-authority-data", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateAuthorityData { get; set; }

        /// <summary>
        /// **参数解释**： 不校验服务端证书 **约束限制**： 不涉及 **取值范围**： - true：跳过校验服务端证书 - false：校验服务端证书  **默认取值**： 在 cluster 类型为 externalCluster 时，该值为 true。 
        /// </summary>
        [JsonProperty("insecure-skip-tls-verify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InsecureSkipTlsVerify { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterCert {\n");
            sb.Append("  server: ").Append(Server).Append("\n");
            sb.Append("  certificateAuthorityData: ").Append(CertificateAuthorityData).Append("\n");
            sb.Append("  insecureSkipTlsVerify: ").Append(InsecureSkipTlsVerify).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterCert);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterCert input)
        {
            if (input == null) return false;
            if (this.Server != input.Server || (this.Server != null && !this.Server.Equals(input.Server))) return false;
            if (this.CertificateAuthorityData != input.CertificateAuthorityData || (this.CertificateAuthorityData != null && !this.CertificateAuthorityData.Equals(input.CertificateAuthorityData))) return false;
            if (this.InsecureSkipTlsVerify != input.InsecureSkipTlsVerify || (this.InsecureSkipTlsVerify != null && !this.InsecureSkipTlsVerify.Equals(input.InsecureSkipTlsVerify))) return false;

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
                if (this.Server != null) hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.CertificateAuthorityData != null) hashCode = hashCode * 59 + this.CertificateAuthorityData.GetHashCode();
                if (this.InsecureSkipTlsVerify != null) hashCode = hashCode * 59 + this.InsecureSkipTlsVerify.GetHashCode();
                return hashCode;
            }
        }
    }
}
