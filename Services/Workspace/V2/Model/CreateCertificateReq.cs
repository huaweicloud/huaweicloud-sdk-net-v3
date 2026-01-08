using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 创建证书请求体。
    /// </summary>
    public class CreateCertificateReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("distinguished_name", NullValueHandling = NullValueHandling.Ignore)]
        public DistinguishedName DistinguishedName { get; set; }

        /// <summary>
        /// 密钥对生成算法 RSA-2048 RSA-3072。
        /// </summary>
        [JsonProperty("key_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// 签名哈希算法 SHA-256 SHA-512。
        /// </summary>
        [JsonProperty("signature_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("validity", NullValueHandling = NullValueHandling.Ignore)]
        public CertValidityData Validity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("crl_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public CrlConfigurationData CrlConfiguration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCertificateReq {\n");
            sb.Append("  distinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  keyAlgorithm: ").Append(KeyAlgorithm).Append("\n");
            sb.Append("  signatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  validity: ").Append(Validity).Append("\n");
            sb.Append("  crlConfiguration: ").Append(CrlConfiguration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCertificateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCertificateReq input)
        {
            if (input == null) return false;
            if (this.DistinguishedName != input.DistinguishedName || (this.DistinguishedName != null && !this.DistinguishedName.Equals(input.DistinguishedName))) return false;
            if (this.KeyAlgorithm != input.KeyAlgorithm || (this.KeyAlgorithm != null && !this.KeyAlgorithm.Equals(input.KeyAlgorithm))) return false;
            if (this.SignatureAlgorithm != input.SignatureAlgorithm || (this.SignatureAlgorithm != null && !this.SignatureAlgorithm.Equals(input.SignatureAlgorithm))) return false;
            if (this.Validity != input.Validity || (this.Validity != null && !this.Validity.Equals(input.Validity))) return false;
            if (this.CrlConfiguration != input.CrlConfiguration || (this.CrlConfiguration != null && !this.CrlConfiguration.Equals(input.CrlConfiguration))) return false;

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
                if (this.DistinguishedName != null) hashCode = hashCode * 59 + this.DistinguishedName.GetHashCode();
                if (this.KeyAlgorithm != null) hashCode = hashCode * 59 + this.KeyAlgorithm.GetHashCode();
                if (this.SignatureAlgorithm != null) hashCode = hashCode * 59 + this.SignatureAlgorithm.GetHashCode();
                if (this.Validity != null) hashCode = hashCode * 59 + this.Validity.GetHashCode();
                if (this.CrlConfiguration != null) hashCode = hashCode * 59 + this.CrlConfiguration.GetHashCode();
                return hashCode;
            }
        }
    }
}
