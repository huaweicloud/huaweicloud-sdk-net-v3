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
    public class CreateExternalIdPConfigurationForDirectoryResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hws_sp_saml_config", NullValueHandling = NullValueHandling.Ignore)]
        public SPSAMLConfig HwsSpSamlConfig { get; set; }

        /// <summary>
        /// 身份提供商证书全局唯一标识符（ID)
        /// </summary>
        [JsonProperty("idp_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpCertificateId { get; set; }

        /// <summary>
        /// 身份提供商证书全局唯一标识符列表
        /// </summary>
        [JsonProperty("idp_certificate_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IdpCertificateIds { get; set; }

        /// <summary>
        /// 外部身份提供商的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("idp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateExternalIdPConfigurationForDirectoryResponse {\n");
            sb.Append("  hwsSpSamlConfig: ").Append(HwsSpSamlConfig).Append("\n");
            sb.Append("  idpCertificateId: ").Append(IdpCertificateId).Append("\n");
            sb.Append("  idpCertificateIds: ").Append(IdpCertificateIds).Append("\n");
            sb.Append("  idpId: ").Append(IdpId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateExternalIdPConfigurationForDirectoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateExternalIdPConfigurationForDirectoryResponse input)
        {
            if (input == null) return false;
            if (this.HwsSpSamlConfig != input.HwsSpSamlConfig || (this.HwsSpSamlConfig != null && !this.HwsSpSamlConfig.Equals(input.HwsSpSamlConfig))) return false;
            if (this.IdpCertificateId != input.IdpCertificateId || (this.IdpCertificateId != null && !this.IdpCertificateId.Equals(input.IdpCertificateId))) return false;
            if (this.IdpCertificateIds != input.IdpCertificateIds || (this.IdpCertificateIds != null && input.IdpCertificateIds != null && !this.IdpCertificateIds.SequenceEqual(input.IdpCertificateIds))) return false;
            if (this.IdpId != input.IdpId || (this.IdpId != null && !this.IdpId.Equals(input.IdpId))) return false;

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
                if (this.HwsSpSamlConfig != null) hashCode = hashCode * 59 + this.HwsSpSamlConfig.GetHashCode();
                if (this.IdpCertificateId != null) hashCode = hashCode * 59 + this.IdpCertificateId.GetHashCode();
                if (this.IdpCertificateIds != null) hashCode = hashCode * 59 + this.IdpCertificateIds.GetHashCode();
                if (this.IdpId != null) hashCode = hashCode * 59 + this.IdpId.GetHashCode();
                return hashCode;
            }
        }
    }
}
