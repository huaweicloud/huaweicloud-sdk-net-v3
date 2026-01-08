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
    /// Response Object
    /// </summary>
    public class ShowCertDetailResponse : SdkResponse
    {

        /// <summary>
        /// 证书id。
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }

        /// <summary>
        /// 序列号。
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 证书类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 证书应用范围。
        /// </summary>
        [JsonProperty("apply", NullValueHandling = NullValueHandling.Ignore)]
        public string Apply { get; set; }

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
        /// 生效时间。
        /// </summary>
        [JsonProperty("not_before", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBefore { get; set; }

        /// <summary>
        /// 过期时间。
        /// </summary>
        [JsonProperty("not_after", NullValueHandling = NullValueHandling.Ignore)]
        public string NotAfter { get; set; }

        /// <summary>
        /// 证书状态 DISABLE,ENABLE,EXPIRED,DELETE。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 证书pem编码。
        /// </summary>
        [JsonProperty("pem_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PemCode { get; set; }

        /// <summary>
        /// 颁发者名字。
        /// </summary>
        [JsonProperty("issuer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerName { get; set; }

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
            sb.Append("class ShowCertDetailResponse {\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  apply: ").Append(Apply).Append("\n");
            sb.Append("  distinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  keyAlgorithm: ").Append(KeyAlgorithm).Append("\n");
            sb.Append("  signatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  notBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  notAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  pemCode: ").Append(PemCode).Append("\n");
            sb.Append("  issuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  crlConfiguration: ").Append(CrlConfiguration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCertDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCertDetailResponse input)
        {
            if (input == null) return false;
            if (this.CertId != input.CertId || (this.CertId != null && !this.CertId.Equals(input.CertId))) return false;
            if (this.SerialNumber != input.SerialNumber || (this.SerialNumber != null && !this.SerialNumber.Equals(input.SerialNumber))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Apply != input.Apply || (this.Apply != null && !this.Apply.Equals(input.Apply))) return false;
            if (this.DistinguishedName != input.DistinguishedName || (this.DistinguishedName != null && !this.DistinguishedName.Equals(input.DistinguishedName))) return false;
            if (this.KeyAlgorithm != input.KeyAlgorithm || (this.KeyAlgorithm != null && !this.KeyAlgorithm.Equals(input.KeyAlgorithm))) return false;
            if (this.SignatureAlgorithm != input.SignatureAlgorithm || (this.SignatureAlgorithm != null && !this.SignatureAlgorithm.Equals(input.SignatureAlgorithm))) return false;
            if (this.NotBefore != input.NotBefore || (this.NotBefore != null && !this.NotBefore.Equals(input.NotBefore))) return false;
            if (this.NotAfter != input.NotAfter || (this.NotAfter != null && !this.NotAfter.Equals(input.NotAfter))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PemCode != input.PemCode || (this.PemCode != null && !this.PemCode.Equals(input.PemCode))) return false;
            if (this.IssuerName != input.IssuerName || (this.IssuerName != null && !this.IssuerName.Equals(input.IssuerName))) return false;
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
                if (this.CertId != null) hashCode = hashCode * 59 + this.CertId.GetHashCode();
                if (this.SerialNumber != null) hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Apply != null) hashCode = hashCode * 59 + this.Apply.GetHashCode();
                if (this.DistinguishedName != null) hashCode = hashCode * 59 + this.DistinguishedName.GetHashCode();
                if (this.KeyAlgorithm != null) hashCode = hashCode * 59 + this.KeyAlgorithm.GetHashCode();
                if (this.SignatureAlgorithm != null) hashCode = hashCode * 59 + this.SignatureAlgorithm.GetHashCode();
                if (this.NotBefore != null) hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                if (this.NotAfter != null) hashCode = hashCode * 59 + this.NotAfter.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PemCode != null) hashCode = hashCode * 59 + this.PemCode.GetHashCode();
                if (this.IssuerName != null) hashCode = hashCode * 59 + this.IssuerName.GetHashCode();
                if (this.CrlConfiguration != null) hashCode = hashCode * 59 + this.CrlConfiguration.GetHashCode();
                return hashCode;
            }
        }
    }
}
