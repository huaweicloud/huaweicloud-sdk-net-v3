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
    /// 证书配置查询响应体
    /// </summary>
    public class HttpGetBody 
    {

        /// <summary>
        /// HTTPS证书是否启用。（on：开启，off：关闭）
        /// </summary>
        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsStatus { get; set; }

        /// <summary>
        /// 证书名字。（长度限制为3-32字符）。当证书开启时必返回该字段。
        /// </summary>
        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        /// <summary>
        /// HTTPS协议使用的证书内容，当证书开启时必返回该字段。取值范围：PEM编码格式。
        /// </summary>
        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        /// <summary>
        /// 证书来源。1：代表华为云托管证书；0：表示自有证书。 默认值0。当证书开启时必返回该字段。
        /// </summary>
        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        /// <summary>
        /// 是否使用HTTP2.0。（on：是，off：否）
        /// </summary>
        [JsonProperty("http2_status", NullValueHandling = NullValueHandling.Ignore)]
        public string Http2Status { get; set; }

        /// <summary>
        /// 传输层安全性协议，目前支持TLSv1.0/1.1/1.2/1.3四个版本的协议。当证书开启时返回该字段，默认全部开启，不可全部关闭。
        /// </summary>
        [JsonProperty("tls_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpGetBody {\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  certificateName: ").Append(CertificateName).Append("\n");
            sb.Append("  certificateValue: ").Append(CertificateValue).Append("\n");
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
            return this.Equals(input as HttpGetBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpGetBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpsStatus == input.HttpsStatus ||
                    (this.HttpsStatus != null &&
                    this.HttpsStatus.Equals(input.HttpsStatus))
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
                    this.CertificateSource == input.CertificateSource ||
                    (this.CertificateSource != null &&
                    this.CertificateSource.Equals(input.CertificateSource))
                ) && 
                (
                    this.Http2Status == input.Http2Status ||
                    (this.Http2Status != null &&
                    this.Http2Status.Equals(input.Http2Status))
                ) && 
                (
                    this.TlsVersion == input.TlsVersion ||
                    (this.TlsVersion != null &&
                    this.TlsVersion.Equals(input.TlsVersion))
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
                if (this.HttpsStatus != null)
                    hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.CertificateName != null)
                    hashCode = hashCode * 59 + this.CertificateName.GetHashCode();
                if (this.CertificateValue != null)
                    hashCode = hashCode * 59 + this.CertificateValue.GetHashCode();
                if (this.CertificateSource != null)
                    hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.Http2Status != null)
                    hashCode = hashCode * 59 + this.Http2Status.GetHashCode();
                if (this.TlsVersion != null)
                    hashCode = hashCode * 59 + this.TlsVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
