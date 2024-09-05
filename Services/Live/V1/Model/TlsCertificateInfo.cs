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
    public class TlsCertificateInfo 
    {

        /// <summary>
        /// 证书来源， 可选,  scm: 云证书管理服务，user：默认，用户自有
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// SCM证书名， 证书来源为scm时可选
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// SCM证书ID, 证书来源为scm时必选
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }

        /// <summary>
        /// 证书内容，证书来源为user时必选
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// 私钥内容，证书来源为user时必选
        /// </summary>
        [JsonProperty("certificate_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TlsCertificateInfo {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  certificateKey: ").Append(CertificateKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TlsCertificateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TlsCertificateInfo input)
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
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.CertificateKey == input.CertificateKey ||
                    (this.CertificateKey != null &&
                    this.CertificateKey.Equals(input.CertificateKey))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.CertificateKey != null)
                    hashCode = hashCode * 59 + this.CertificateKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
