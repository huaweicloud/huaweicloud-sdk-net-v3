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
    public class ListExternalIdPCertificatesResponse : SdkResponse
    {

        /// <summary>
        /// 外部身份提供商证书列表
        /// </summary>
        [JsonProperty("idp_certificates", NullValueHandling = NullValueHandling.Ignore)]
        public List<IdpCertificate> IdpCertificates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListExternalIdPCertificatesResponse {\n");
            sb.Append("  idpCertificates: ").Append(IdpCertificates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListExternalIdPCertificatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListExternalIdPCertificatesResponse input)
        {
            if (input == null) return false;
            if (this.IdpCertificates != input.IdpCertificates || (this.IdpCertificates != null && input.IdpCertificates != null && !this.IdpCertificates.SequenceEqual(input.IdpCertificates))) return false;

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
                if (this.IdpCertificates != null) hashCode = hashCode * 59 + this.IdpCertificates.GetHashCode();
                return hashCode;
            }
        }
    }
}
