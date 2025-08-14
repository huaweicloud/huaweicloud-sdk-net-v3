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
    /// 
    /// </summary>
    public class CreateIDPReqBody 
    {

        /// <summary>
        /// 身份提供商SAML元数据，与身份提供商SAML配置二选一
        /// </summary>
        [JsonProperty("idp_saml_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpSamlMetadata { get; set; }

        /// <summary>
        /// 身份提供商证书，与身份提供商SAML配置联合使用
        /// </summary>
        [JsonProperty("idp_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpCertificate { get; set; }

        /// <summary>
        /// 身份提供商SAML配置信息，与身份提供商SAML元数据二选一
        /// </summary>
        [JsonProperty("idp_saml_config", NullValueHandling = NullValueHandling.Ignore)]
        public Object IdpSamlConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateIDPReqBody {\n");
            sb.Append("  idpSamlMetadata: ").Append(IdpSamlMetadata).Append("\n");
            sb.Append("  idpCertificate: ").Append(IdpCertificate).Append("\n");
            sb.Append("  idpSamlConfig: ").Append(IdpSamlConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateIDPReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateIDPReqBody input)
        {
            if (input == null) return false;
            if (this.IdpSamlMetadata != input.IdpSamlMetadata || (this.IdpSamlMetadata != null && !this.IdpSamlMetadata.Equals(input.IdpSamlMetadata))) return false;
            if (this.IdpCertificate != input.IdpCertificate || (this.IdpCertificate != null && !this.IdpCertificate.Equals(input.IdpCertificate))) return false;
            if (this.IdpSamlConfig != input.IdpSamlConfig || (this.IdpSamlConfig != null && !this.IdpSamlConfig.Equals(input.IdpSamlConfig))) return false;

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
                if (this.IdpSamlMetadata != null) hashCode = hashCode * 59 + this.IdpSamlMetadata.GetHashCode();
                if (this.IdpCertificate != null) hashCode = hashCode * 59 + this.IdpCertificate.GetHashCode();
                if (this.IdpSamlConfig != null) hashCode = hashCode * 59 + this.IdpSamlConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
