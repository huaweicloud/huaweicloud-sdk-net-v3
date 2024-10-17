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
    public class UpdateDomainMultiCertificatesRequestBodyContent 
    {

        /// <summary>
        /// 域名列表,逗号分割，上限50个域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// https开关(0：\&quot;关闭\&quot;；1：\&quot;设置证书\&quot;)。
        /// </summary>
        [JsonProperty("https_switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsSwitch { get; set; }

        /// <summary>
        /// 回源方式:1：\&quot;回源跟随\&quot;；2：\&quot;HTTP\&quot;(默认)，3：https（自建）。
        /// </summary>
        [JsonProperty("access_origin_way", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessOriginWay { get; set; }

        /// <summary>
        /// 强制跳转HTTPS（0：不强制；1：强制） 为空值时默认设置为关闭。（此参数即将下线，建议使用force_redirect_config修改配置）.
        /// </summary>
        [JsonProperty("force_redirect_https", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForceRedirectHttps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("force_redirect_config", NullValueHandling = NullValueHandling.Ignore)]
        public ForceRedirect ForceRedirectConfig { get; set; }

        /// <summary>
        /// http2.0（0：关闭；1：开启） 为空值时默认设置为关闭
        /// </summary>
        [JsonProperty("http2", NullValueHandling = NullValueHandling.Ignore)]
        public int? Http2 { get; set; }

        /// <summary>
        /// 证书名称（设置证书必填）（长度限制为3-64字符）。
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// HTTPS协议使用的SSL证书内容，仅支持PEM编码格式。不启用证书则无需输入。初次配置证书时必传。
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// HTTPS协议使用的SSL证书私钥内容，仅支持PEM编码格式。不启用证书则无需输入。初次配置证书时必传。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 证书类型（0为自有证书 ；1为托管证书，此时不必不传入证书内容和私钥，自动根据证书名称匹配；不传默认为自有证书）
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainMultiCertificatesRequestBodyContent {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  httpsSwitch: ").Append(HttpsSwitch).Append("\n");
            sb.Append("  accessOriginWay: ").Append(AccessOriginWay).Append("\n");
            sb.Append("  forceRedirectHttps: ").Append(ForceRedirectHttps).Append("\n");
            sb.Append("  forceRedirectConfig: ").Append(ForceRedirectConfig).Append("\n");
            sb.Append("  http2: ").Append(Http2).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainMultiCertificatesRequestBodyContent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainMultiCertificatesRequestBodyContent input)
        {
            if (input == null) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.HttpsSwitch != input.HttpsSwitch || (this.HttpsSwitch != null && !this.HttpsSwitch.Equals(input.HttpsSwitch))) return false;
            if (this.AccessOriginWay != input.AccessOriginWay || (this.AccessOriginWay != null && !this.AccessOriginWay.Equals(input.AccessOriginWay))) return false;
            if (this.ForceRedirectHttps != input.ForceRedirectHttps || (this.ForceRedirectHttps != null && !this.ForceRedirectHttps.Equals(input.ForceRedirectHttps))) return false;
            if (this.ForceRedirectConfig != input.ForceRedirectConfig || (this.ForceRedirectConfig != null && !this.ForceRedirectConfig.Equals(input.ForceRedirectConfig))) return false;
            if (this.Http2 != input.Http2 || (this.Http2 != null && !this.Http2.Equals(input.Http2))) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;
            if (this.Certificate != input.Certificate || (this.Certificate != null && !this.Certificate.Equals(input.Certificate))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.CertificateType != input.CertificateType || (this.CertificateType != null && !this.CertificateType.Equals(input.CertificateType))) return false;

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
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.HttpsSwitch != null) hashCode = hashCode * 59 + this.HttpsSwitch.GetHashCode();
                if (this.AccessOriginWay != null) hashCode = hashCode * 59 + this.AccessOriginWay.GetHashCode();
                if (this.ForceRedirectHttps != null) hashCode = hashCode * 59 + this.ForceRedirectHttps.GetHashCode();
                if (this.ForceRedirectConfig != null) hashCode = hashCode * 59 + this.ForceRedirectConfig.GetHashCode();
                if (this.Http2 != null) hashCode = hashCode * 59 + this.Http2.GetHashCode();
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.Certificate != null) hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.CertificateType != null) hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                return hashCode;
            }
        }
    }
}
