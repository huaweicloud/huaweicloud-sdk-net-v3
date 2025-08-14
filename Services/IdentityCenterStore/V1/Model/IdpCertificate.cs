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
    public class IdpCertificate 
    {

        /// <summary>
        /// 证书全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateId { get; set; }

        /// <summary>
        /// 身份提供商签发者
        /// </summary>
        [JsonProperty("issuer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerName { get; set; }

        /// <summary>
        /// 证书有效期
        /// </summary>
        [JsonProperty("not_after", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? NotAfter { get; set; }

        /// <summary>
        /// 证书有效期
        /// </summary>
        [JsonProperty("not_before", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? NotBefore { get; set; }

        /// <summary>
        /// 证书公钥
        /// </summary>
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        /// 证书序列号
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SerialNumber { get; set; }

        /// <summary>
        /// 证书序列号文本
        /// </summary>
        [JsonProperty("serial_number_string", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumberString { get; set; }

        /// <summary>
        /// 签名算法
        /// </summary>
        [JsonProperty("signature_algorithm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureAlgorithmName { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        [JsonProperty("subject_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectName { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Version { get; set; }

        /// <summary>
        /// x509格式证书
        /// </summary>
        [JsonProperty("x509_Certificate_in_pem", NullValueHandling = NullValueHandling.Ignore)]
        public string X509CertificateInPem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdpCertificate {\n");
            sb.Append("  certificateId: ").Append(CertificateId).Append("\n");
            sb.Append("  issuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  notAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  notBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  serialNumberString: ").Append(SerialNumberString).Append("\n");
            sb.Append("  signatureAlgorithmName: ").Append(SignatureAlgorithmName).Append("\n");
            sb.Append("  subjectName: ").Append(SubjectName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  x509CertificateInPem: ").Append(X509CertificateInPem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdpCertificate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdpCertificate input)
        {
            if (input == null) return false;
            if (this.CertificateId != input.CertificateId || (this.CertificateId != null && !this.CertificateId.Equals(input.CertificateId))) return false;
            if (this.IssuerName != input.IssuerName || (this.IssuerName != null && !this.IssuerName.Equals(input.IssuerName))) return false;
            if (this.NotAfter != input.NotAfter || (this.NotAfter != null && !this.NotAfter.Equals(input.NotAfter))) return false;
            if (this.NotBefore != input.NotBefore || (this.NotBefore != null && !this.NotBefore.Equals(input.NotBefore))) return false;
            if (this.PublicKey != input.PublicKey || (this.PublicKey != null && !this.PublicKey.Equals(input.PublicKey))) return false;
            if (this.SerialNumber != input.SerialNumber || (this.SerialNumber != null && !this.SerialNumber.Equals(input.SerialNumber))) return false;
            if (this.SerialNumberString != input.SerialNumberString || (this.SerialNumberString != null && !this.SerialNumberString.Equals(input.SerialNumberString))) return false;
            if (this.SignatureAlgorithmName != input.SignatureAlgorithmName || (this.SignatureAlgorithmName != null && !this.SignatureAlgorithmName.Equals(input.SignatureAlgorithmName))) return false;
            if (this.SubjectName != input.SubjectName || (this.SubjectName != null && !this.SubjectName.Equals(input.SubjectName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.X509CertificateInPem != input.X509CertificateInPem || (this.X509CertificateInPem != null && !this.X509CertificateInPem.Equals(input.X509CertificateInPem))) return false;

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
                if (this.IssuerName != null) hashCode = hashCode * 59 + this.IssuerName.GetHashCode();
                if (this.NotAfter != null) hashCode = hashCode * 59 + this.NotAfter.GetHashCode();
                if (this.NotBefore != null) hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                if (this.PublicKey != null) hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.SerialNumber != null) hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.SerialNumberString != null) hashCode = hashCode * 59 + this.SerialNumberString.GetHashCode();
                if (this.SignatureAlgorithmName != null) hashCode = hashCode * 59 + this.SignatureAlgorithmName.GetHashCode();
                if (this.SubjectName != null) hashCode = hashCode * 59 + this.SubjectName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.X509CertificateInPem != null) hashCode = hashCode * 59 + this.X509CertificateInPem.GetHashCode();
                return hashCode;
            }
        }
    }
}
