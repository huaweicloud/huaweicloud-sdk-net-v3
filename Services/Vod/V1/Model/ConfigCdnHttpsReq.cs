using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigCdnHttpsReq 
    {

        /// <summary>
        /// 来源，user表示用户自己上传，scm表示scm证书，默认user 
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 加速域名 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 证书名称，若来源是scm则非必填，不填默认取scm上的证书名称 
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// scm证书ID，若来源是scm则必填 
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }

        /// <summary>
        /// https配置，0为关闭https配置，1为开启https配置，默认0 
        /// </summary>
        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsStatus { get; set; }

        /// <summary>
        /// 证书内容，若来源是user则需填写，来源是scm则非必填 
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// 私钥，若来源是user则需填写，来源是scm则非必填 
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 客户端请求是否强制重定向，0表示不重定向，1表示重定向，默认0 
        /// </summary>
        [JsonProperty("force_redirect_https", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForceRedirectHttps { get; set; }

        /// <summary>
        /// 是否使用HTTP2.0，0表示不使用HTTP2.0，1表示使用，默认0 
        /// </summary>
        [JsonProperty("http2", NullValueHandling = NullValueHandling.Ignore)]
        public int? Http2 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigCdnHttpsReq {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  forceRedirectHttps: ").Append(ForceRedirectHttps).Append("\n");
            sb.Append("  http2: ").Append(Http2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigCdnHttpsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigCdnHttpsReq input)
        {
            if (input == null) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;
            if (this.CertId != input.CertId || (this.CertId != null && !this.CertId.Equals(input.CertId))) return false;
            if (this.HttpsStatus != input.HttpsStatus || (this.HttpsStatus != null && !this.HttpsStatus.Equals(input.HttpsStatus))) return false;
            if (this.Certificate != input.Certificate || (this.Certificate != null && !this.Certificate.Equals(input.Certificate))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.ForceRedirectHttps != input.ForceRedirectHttps || (this.ForceRedirectHttps != null && !this.ForceRedirectHttps.Equals(input.ForceRedirectHttps))) return false;
            if (this.Http2 != input.Http2 || (this.Http2 != null && !this.Http2.Equals(input.Http2))) return false;

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
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.CertId != null) hashCode = hashCode * 59 + this.CertId.GetHashCode();
                if (this.HttpsStatus != null) hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.Certificate != null) hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.ForceRedirectHttps != null) hashCode = hashCode * 59 + this.ForceRedirectHttps.GetHashCode();
                if (this.Http2 != null) hashCode = hashCode * 59 + this.Http2.GetHashCode();
                return hashCode;
            }
        }
    }
}
