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
    /// 导入pem证书。
    /// </summary>
    public class ImportCertificatePemReq 
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
        /// 事务id。
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("crl_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public CrlConfigurationData CrlConfiguration { get; set; }

        /// <summary>
        /// 证书pem。
        /// </summary>
        [JsonProperty("pem_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PemCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportCertificatePemReq {\n");
            sb.Append("  distinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  keyAlgorithm: ").Append(KeyAlgorithm).Append("\n");
            sb.Append("  signatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  crlConfiguration: ").Append(CrlConfiguration).Append("\n");
            sb.Append("  pemCode: ").Append(PemCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportCertificatePemReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportCertificatePemReq input)
        {
            if (input == null) return false;
            if (this.DistinguishedName != input.DistinguishedName || (this.DistinguishedName != null && !this.DistinguishedName.Equals(input.DistinguishedName))) return false;
            if (this.KeyAlgorithm != input.KeyAlgorithm || (this.KeyAlgorithm != null && !this.KeyAlgorithm.Equals(input.KeyAlgorithm))) return false;
            if (this.SignatureAlgorithm != input.SignatureAlgorithm || (this.SignatureAlgorithm != null && !this.SignatureAlgorithm.Equals(input.SignatureAlgorithm))) return false;
            if (this.TransactionId != input.TransactionId || (this.TransactionId != null && !this.TransactionId.Equals(input.TransactionId))) return false;
            if (this.CrlConfiguration != input.CrlConfiguration || (this.CrlConfiguration != null && !this.CrlConfiguration.Equals(input.CrlConfiguration))) return false;
            if (this.PemCode != input.PemCode || (this.PemCode != null && !this.PemCode.Equals(input.PemCode))) return false;

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
                if (this.TransactionId != null) hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.CrlConfiguration != null) hashCode = hashCode * 59 + this.CrlConfiguration.GetHashCode();
                if (this.PemCode != null) hashCode = hashCode * 59 + this.PemCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
