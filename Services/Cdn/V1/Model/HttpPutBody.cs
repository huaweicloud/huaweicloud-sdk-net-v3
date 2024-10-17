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
    /// 设置证书请求体
    /// </summary>
    public class HttpPutBody 
    {

        /// <summary>
        /// HTTPS证书是否启用，on：开启，off：关闭。
        /// </summary>
        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsStatus { get; set; }

        /// <summary>
        /// 证书名字，长度限制为3-64字符。  &gt; 当证书开启时必传。
        /// </summary>
        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        /// <summary>
        /// HTTPS协议使用的证书内容，当证书开启时必传。  &gt; PEM编码格式。
        /// </summary>
        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        /// <summary>
        /// HTTPS协议使用的私钥，当证书开启时必传。  &gt; PEM编码格式。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 证书来源,0：自有证书。  &gt; 证书开启时必传
        /// </summary>
        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        /// <summary>
        /// 是否使用HTTP2.0，on：是，off：否。  &gt; 默认关闭，https_status&#x3D;off时，该值不生效。
        /// </summary>
        [JsonProperty("http2_status", NullValueHandling = NullValueHandling.Ignore)]
        public string Http2Status { get; set; }

        /// <summary>
        /// 传输层安全性协议， 目前支持TLSv1.0/1.1/1.2/1.3四个版本的协议，CDN默认开启TLS1.1/1.2/1.3，不可全部关闭。  &gt; 1.需开启连续或单个版本号，例：不可仅开启TLS1.0/1.2而关闭TLS1.1。  &gt; 2.多版本开启时，使用逗号拼接传输，例：TLSv1.1,TLSv1.2。
        /// </summary>
        [JsonProperty("tls_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpPutBody {\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  certificateName: ").Append(CertificateName).Append("\n");
            sb.Append("  certificateValue: ").Append(CertificateValue).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  certificateSource: ").Append(CertificateSource).Append("\n");
            sb.Append("  http2Status: ").Append(Http2Status).Append("\n");
            sb.Append("  tlsVersion: ").Append(TlsVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpPutBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpPutBody input)
        {
            if (input == null) return false;
            if (this.HttpsStatus != input.HttpsStatus || (this.HttpsStatus != null && !this.HttpsStatus.Equals(input.HttpsStatus))) return false;
            if (this.CertificateName != input.CertificateName || (this.CertificateName != null && !this.CertificateName.Equals(input.CertificateName))) return false;
            if (this.CertificateValue != input.CertificateValue || (this.CertificateValue != null && !this.CertificateValue.Equals(input.CertificateValue))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.CertificateSource != input.CertificateSource || (this.CertificateSource != null && !this.CertificateSource.Equals(input.CertificateSource))) return false;
            if (this.Http2Status != input.Http2Status || (this.Http2Status != null && !this.Http2Status.Equals(input.Http2Status))) return false;
            if (this.TlsVersion != input.TlsVersion || (this.TlsVersion != null && !this.TlsVersion.Equals(input.TlsVersion))) return false;

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
                if (this.HttpsStatus != null) hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.CertificateName != null) hashCode = hashCode * 59 + this.CertificateName.GetHashCode();
                if (this.CertificateValue != null) hashCode = hashCode * 59 + this.CertificateValue.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.CertificateSource != null) hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.Http2Status != null) hashCode = hashCode * 59 + this.Http2Status.GetHashCode();
                if (this.TlsVersion != null) hashCode = hashCode * 59 + this.TlsVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
