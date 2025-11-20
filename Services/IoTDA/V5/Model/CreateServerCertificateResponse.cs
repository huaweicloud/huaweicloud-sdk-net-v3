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
    public class CreateServerCertificateResponse : SdkResponse
    {

        /// <summary>
        /// 唯一标识ID
        /// </summary>
        [JsonProperty("server_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// **参数说明**：证书通用名
        /// </summary>
        [JsonProperty("common_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommonName { get; set; }

        /// <summary>
        /// 证书生效日期。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("effective_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 证书失效日期。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 证书所有者。
        /// </summary>
        [JsonProperty("certificate_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateOwner { get; set; }

        /// <summary>
        /// 证书颁发者。
        /// </summary>
        [JsonProperty("certificate_issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateIssuer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServerCertificateResponse {\n");
            sb.Append("  serverCertificateId: ").Append(ServerCertificateId).Append("\n");
            sb.Append("  commonName: ").Append(CommonName).Append("\n");
            sb.Append("  effectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  certificateOwner: ").Append(CertificateOwner).Append("\n");
            sb.Append("  certificateIssuer: ").Append(CertificateIssuer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateServerCertificateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateServerCertificateResponse input)
        {
            if (input == null) return false;
            if (this.ServerCertificateId != input.ServerCertificateId || (this.ServerCertificateId != null && !this.ServerCertificateId.Equals(input.ServerCertificateId))) return false;
            if (this.CommonName != input.CommonName || (this.CommonName != null && !this.CommonName.Equals(input.CommonName))) return false;
            if (this.EffectiveDate != input.EffectiveDate || (this.EffectiveDate != null && !this.EffectiveDate.Equals(input.EffectiveDate))) return false;
            if (this.ExpiryDate != input.ExpiryDate || (this.ExpiryDate != null && !this.ExpiryDate.Equals(input.ExpiryDate))) return false;
            if (this.CertificateOwner != input.CertificateOwner || (this.CertificateOwner != null && !this.CertificateOwner.Equals(input.CertificateOwner))) return false;
            if (this.CertificateIssuer != input.CertificateIssuer || (this.CertificateIssuer != null && !this.CertificateIssuer.Equals(input.CertificateIssuer))) return false;

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
                if (this.CommonName != null) hashCode = hashCode * 59 + this.CommonName.GetHashCode();
                if (this.EffectiveDate != null) hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpiryDate != null) hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.CertificateOwner != null) hashCode = hashCode * 59 + this.CertificateOwner.GetHashCode();
                if (this.CertificateIssuer != null) hashCode = hashCode * 59 + this.CertificateIssuer.GetHashCode();
                return hashCode;
            }
        }
    }
}
