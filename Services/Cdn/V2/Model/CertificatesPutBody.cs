using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 配置双证书时必传，需要同时传入国际证书和国密证书，不支持传两个国际证书或两个国密证书。   &gt; - 您也可以在certificates参数下传入一个国际证书或一个国密证书。   &gt; - 如果certificates传了证书（国际证书、国密证书或国际+国密双证书），外层证书配置将失效，仅保留当前参数传入的证书信息。
    /// </summary>
    public class CertificatesPutBody 
    {

        /// <summary>
        /// 证书来源，0：自有证书。2：SCM证书。
        /// </summary>
        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        /// <summary>
        /// SCM证书id
        /// </summary>
        [JsonProperty("scm_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmCertificateId { get; set; }

        /// <summary>
        /// 证书类型，server：国际证书；server_sm：国密证书。
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateType { get; set; }

        /// <summary>
        /// 证书名字，长度限制为3-64字符。
        /// </summary>
        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        /// <summary>
        /// HTTPS协议使用的证书内容。  &gt; PEM编码格式。
        /// </summary>
        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        /// <summary>
        /// HTTPS协议使用的私钥。  &gt; PEM编码格式。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 加密证书内容，证书类型为国密证书时必传。  &gt; PEM编码格式。
        /// </summary>
        [JsonProperty("enc_certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificateValue { get; set; }

        /// <summary>
        /// 加密私钥内容，证书类型为国密证书时必传。  &gt; PEM编码格式。
        /// </summary>
        [JsonProperty("enc_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string EncPrivateKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificatesPutBody {\n");
            sb.Append("  certificateSource: ").Append(CertificateSource).Append("\n");
            sb.Append("  scmCertificateId: ").Append(ScmCertificateId).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  certificateName: ").Append(CertificateName).Append("\n");
            sb.Append("  certificateValue: ").Append(CertificateValue).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  encCertificateValue: ").Append(EncCertificateValue).Append("\n");
            sb.Append("  encPrivateKey: ").Append(EncPrivateKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertificatesPutBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertificatesPutBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificateSource == input.CertificateSource ||
                    (this.CertificateSource != null &&
                    this.CertificateSource.Equals(input.CertificateSource))
                ) && 
                (
                    this.ScmCertificateId == input.ScmCertificateId ||
                    (this.ScmCertificateId != null &&
                    this.ScmCertificateId.Equals(input.ScmCertificateId))
                ) && 
                (
                    this.CertificateType == input.CertificateType ||
                    (this.CertificateType != null &&
                    this.CertificateType.Equals(input.CertificateType))
                ) && 
                (
                    this.CertificateName == input.CertificateName ||
                    (this.CertificateName != null &&
                    this.CertificateName.Equals(input.CertificateName))
                ) && 
                (
                    this.CertificateValue == input.CertificateValue ||
                    (this.CertificateValue != null &&
                    this.CertificateValue.Equals(input.CertificateValue))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.EncCertificateValue == input.EncCertificateValue ||
                    (this.EncCertificateValue != null &&
                    this.EncCertificateValue.Equals(input.EncCertificateValue))
                ) && 
                (
                    this.EncPrivateKey == input.EncPrivateKey ||
                    (this.EncPrivateKey != null &&
                    this.EncPrivateKey.Equals(input.EncPrivateKey))
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
                if (this.CertificateSource != null)
                    hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.ScmCertificateId != null)
                    hashCode = hashCode * 59 + this.ScmCertificateId.GetHashCode();
                if (this.CertificateType != null)
                    hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.CertificateName != null)
                    hashCode = hashCode * 59 + this.CertificateName.GetHashCode();
                if (this.CertificateValue != null)
                    hashCode = hashCode * 59 + this.CertificateValue.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.EncCertificateValue != null)
                    hashCode = hashCode * 59 + this.EncCertificateValue.GetHashCode();
                if (this.EncPrivateKey != null)
                    hashCode = hashCode * 59 + this.EncPrivateKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
