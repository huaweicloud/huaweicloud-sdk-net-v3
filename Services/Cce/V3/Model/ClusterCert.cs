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
        /// 证书授权数据。
        /// </summary>
        [JsonProperty("certificate-authority-data", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateAuthorityData { get; set; }

        /// <summary>
        /// 不校验服务端证书，在 cluster 类型为 externalCluster 时，该值为 true。
        /// </summary>
        [JsonProperty("insecure-skip-tls-verify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InsecureSkipTlsVerify { get; set; }

        /// <summary>
        /// 服务器地址。
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterCert {\n");
            sb.Append("  certificateAuthorityData: ").Append(CertificateAuthorityData).Append("\n");
            sb.Append("  insecureSkipTlsVerify: ").Append(InsecureSkipTlsVerify).Append("\n");
            sb.Append("  server: ").Append(Server).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.CertificateAuthorityData == input.CertificateAuthorityData ||
                    (this.CertificateAuthorityData != null &&
                    this.CertificateAuthorityData.Equals(input.CertificateAuthorityData))
                ) && 
                (
                    this.InsecureSkipTlsVerify == input.InsecureSkipTlsVerify ||
                    (this.InsecureSkipTlsVerify != null &&
                    this.InsecureSkipTlsVerify.Equals(input.InsecureSkipTlsVerify))
                ) && 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
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
                if (this.CertificateAuthorityData != null)
                    hashCode = hashCode * 59 + this.CertificateAuthorityData.GetHashCode();
                if (this.InsecureSkipTlsVerify != null)
                    hashCode = hashCode * 59 + this.InsecureSkipTlsVerify.GetHashCode();
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                return hashCode;
            }
        }
    }
}
