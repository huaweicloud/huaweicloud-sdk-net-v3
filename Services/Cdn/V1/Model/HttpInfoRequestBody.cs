using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HttpInfoRequestBody 
    {

        /// <summary>
        /// 证书名字。（长度限制为3-32字符）。
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// HTTPS证书是否启用。0：不启用，此时无需填写证书及私钥参数；1：启用HTTPS加速并协议跟随回源；2：启用HTTPS加速并HTTP回源；3：启用HTTPS加速并HTTPS回源，首次配置证书需要传递证书及私钥，如已有证书可不用传证书及私钥。
        /// </summary>
        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsStatus { get; set; }

        /// <summary>
        /// 功能说明：HTTPS协议使用的证书内容，不启用证书则无需输入。取值范围：PEM编码格式。初次配置证书时必传。
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// 功能说明： HTTPS协议使用的私钥，不启用证书则无需输入。取值范围：PEM编码格式。初次配置证书时必传。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 是否使用HTTP2.0。（1：是，0：否。）
        /// </summary>
        [JsonProperty("http2", NullValueHandling = NullValueHandling.Ignore)]
        public int? Http2 { get; set; }

        /// <summary>
        /// 证书类型。1：代表华为云托管证书；0：表示自有证书。 默认值0。
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateType { get; set; }

        /// <summary>
        /// 强制跳转HTTPS（0：不强制；1：强制） 为空值时默认设置为关闭。（建议使用force_redirect_config修改配置）
        /// </summary>
        [JsonProperty("force_redirect_https", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForceRedirectHttps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("force_redirect_config", NullValueHandling = NullValueHandling.Ignore)]
        public ForceRedirect ForceRedirectConfig { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpInfoRequestBody {\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  http2: ").Append(Http2).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  forceRedirectHttps: ").Append(ForceRedirectHttps).Append("\n");
            sb.Append("  forceRedirectConfig: ").Append(ForceRedirectConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpInfoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpInfoRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.HttpsStatus == input.HttpsStatus ||
                    (this.HttpsStatus != null &&
                    this.HttpsStatus.Equals(input.HttpsStatus))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.Http2 == input.Http2 ||
                    (this.Http2 != null &&
                    this.Http2.Equals(input.Http2))
                ) && 
                (
                    this.CertificateType == input.CertificateType ||
                    (this.CertificateType != null &&
                    this.CertificateType.Equals(input.CertificateType))
                ) && 
                (
                    this.ForceRedirectHttps == input.ForceRedirectHttps ||
                    (this.ForceRedirectHttps != null &&
                    this.ForceRedirectHttps.Equals(input.ForceRedirectHttps))
                ) && 
                (
                    this.ForceRedirectConfig == input.ForceRedirectConfig ||
                    (this.ForceRedirectConfig != null &&
                    this.ForceRedirectConfig.Equals(input.ForceRedirectConfig))
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
                if (this.CertName != null)
                    hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.HttpsStatus != null)
                    hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.Http2 != null)
                    hashCode = hashCode * 59 + this.Http2.GetHashCode();
                if (this.CertificateType != null)
                    hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.ForceRedirectHttps != null)
                    hashCode = hashCode * 59 + this.ForceRedirectHttps.GetHashCode();
                if (this.ForceRedirectConfig != null)
                    hashCode = hashCode * 59 + this.ForceRedirectConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
