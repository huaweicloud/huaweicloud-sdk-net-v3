using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ImportExternalIdPCertificateResponse : SdkResponse
    {

        /// <summary>
        /// 证书的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportExternalIdPCertificateResponse {\n");
            sb.Append("  certificateId: ").Append(CertificateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportExternalIdPCertificateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportExternalIdPCertificateResponse input)
        {
            if (input == null) return false;
            if (this.CertificateId != input.CertificateId || (this.CertificateId != null && !this.CertificateId.Equals(input.CertificateId))) return false;

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
                if (this.CertificateId != null) hashCode = hashCode * 59 + this.CertificateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
