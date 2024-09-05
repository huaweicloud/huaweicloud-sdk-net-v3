using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GmCertificateInfo 
    {

        /// <summary>
        /// 证书来源， 可选,  scm: 云证书管理服务，user：默认，用户自有
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// SCM证书名， 可选
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// SCM证书ID, 证书来源为scm时必选
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }

        /// <summary>
        /// 国密签名证书内容
        /// </summary>
        [JsonProperty("sign_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string SignCertificate { get; set; }

        /// <summary>
        /// 国密签名私钥内容
        /// </summary>
        [JsonProperty("sign_certificate_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SignCertificateKey { get; set; }

        /// <summary>
        /// 国密加密证书内容
        /// </summary>
        [JsonProperty("enc_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificate { get; set; }

        /// <summary>
        /// 国密加密私钥内容
        /// </summary>
        [JsonProperty("enc_certificate_key", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificateKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GmCertificateInfo {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("  signCertificate: ").Append(SignCertificate).Append("\n");
            sb.Append("  signCertificateKey: ").Append(SignCertificateKey).Append("\n");
            sb.Append("  encCertificate: ").Append(EncCertificate).Append("\n");
            sb.Append("  encCertificateKey: ").Append(EncCertificateKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GmCertificateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GmCertificateInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.CertId == input.CertId ||
                    (this.CertId != null &&
                    this.CertId.Equals(input.CertId))
                ) && 
                (
                    this.SignCertificate == input.SignCertificate ||
                    (this.SignCertificate != null &&
                    this.SignCertificate.Equals(input.SignCertificate))
                ) && 
                (
                    this.SignCertificateKey == input.SignCertificateKey ||
                    (this.SignCertificateKey != null &&
                    this.SignCertificateKey.Equals(input.SignCertificateKey))
                ) && 
                (
                    this.EncCertificate == input.EncCertificate ||
                    (this.EncCertificate != null &&
                    this.EncCertificate.Equals(input.EncCertificate))
                ) && 
                (
                    this.EncCertificateKey == input.EncCertificateKey ||
                    (this.EncCertificateKey != null &&
                    this.EncCertificateKey.Equals(input.EncCertificateKey))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.CertName != null)
                    hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.CertId != null)
                    hashCode = hashCode * 59 + this.CertId.GetHashCode();
                if (this.SignCertificate != null)
                    hashCode = hashCode * 59 + this.SignCertificate.GetHashCode();
                if (this.SignCertificateKey != null)
                    hashCode = hashCode * 59 + this.SignCertificateKey.GetHashCode();
                if (this.EncCertificate != null)
                    hashCode = hashCode * 59 + this.EncCertificate.GetHashCode();
                if (this.EncCertificateKey != null)
                    hashCode = hashCode * 59 + this.EncCertificateKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
