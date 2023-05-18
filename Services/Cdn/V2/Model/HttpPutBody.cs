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
    /// 证书设置
    /// </summary>
    public class HttpPutBody 
    {

        /// <summary>
        /// HTTPS证书是否启用。（on：开启，off：关闭）
        /// </summary>
        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsStatus { get; set; }

        /// <summary>
        /// 证书名字。（长度限制为3-64字符）。当证书开启时必传。
        /// </summary>
        [JsonProperty("certificate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateName { get; set; }

        /// <summary>
        /// HTTPS协议使用的证书内容，当证书开启时必传。取值范围：PEM编码格式。
        /// </summary>
        [JsonProperty("certificate_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateValue { get; set; }

        /// <summary>
        /// HTTPS协议使用的私钥，当证书开启时必传。取值范围：PEM编码格式。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 证书来源。1：代表华为云托管证书；0：表示自有证书。 默认值0。当证书开启时必传。
        /// </summary>
        [JsonProperty("certificate_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateSource { get; set; }

        /// <summary>
        /// 证书类型。server：国际证书；server_sm：国密证书。
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateType { get; set; }

        /// <summary>
        /// 是否使用HTTP2.0。（on：是，off：否。）,默认关闭，https_status&#x3D;off时，该值不生效。
        /// </summary>
        [JsonProperty("http2_status", NullValueHandling = NullValueHandling.Ignore)]
        public string Http2Status { get; set; }

        /// <summary>
        /// 传输层安全性协议。目前支持TLSv1.0/1.1/1.2/1.3四个版本的协议。默认全部开启，不可全部关闭，只可开启连续或单个版本号。多版本开启时，使用逗号拼接传输，例：TLSv1.1,TLSv1.2。
        /// </summary>
        [JsonProperty("tls_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsVersion { get; set; }

        /// <summary>
        /// 是否开启ocsp stapling （on：是，off：否）。
        /// </summary>
        [JsonProperty("ocsp_stapling_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OcspStaplingStatus { get; set; }



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
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  http2Status: ").Append(Http2Status).Append("\n");
            sb.Append("  tlsVersion: ").Append(TlsVersion).Append("\n");
            sb.Append("  ocspStaplingStatus: ").Append(OcspStaplingStatus).Append("\n");
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
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.CertificateSource == input.CertificateSource ||
                    (this.CertificateSource != null &&
                    this.CertificateSource.Equals(input.CertificateSource))
                ) && 
                (
                    this.CertificateType == input.CertificateType ||
                    (this.CertificateType != null &&
                    this.CertificateType.Equals(input.CertificateType))
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
                ) && 
                (
                    this.OcspStaplingStatus == input.OcspStaplingStatus ||
                    (this.OcspStaplingStatus != null &&
                    this.OcspStaplingStatus.Equals(input.OcspStaplingStatus))
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
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.CertificateSource != null)
                    hashCode = hashCode * 59 + this.CertificateSource.GetHashCode();
                if (this.CertificateType != null)
                    hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.Http2Status != null)
                    hashCode = hashCode * 59 + this.Http2Status.GetHashCode();
                if (this.TlsVersion != null)
                    hashCode = hashCode * 59 + this.TlsVersion.GetHashCode();
                if (this.OcspStaplingStatus != null)
                    hashCode = hashCode * 59 + this.OcspStaplingStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
