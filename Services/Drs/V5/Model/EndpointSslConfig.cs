using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 数据库SSL证书信息体。如果数据库启用了SSL安全连接，请确保相关配置正确，并输入SSL证书相关参数，否则无需填写此参数。
    /// </summary>
    public class EndpointSslConfig 
    {

        /// <summary>
        /// 是否SSL安全连接。如果数据库启用了SSL安全连接，参数值为true。
        /// </summary>
        [JsonProperty("ssl_link", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslLink { get; set; }

        /// <summary>
        /// SSL证书名字。
        /// </summary>
        [JsonProperty("ssl_cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertName { get; set; }

        /// <summary>
        /// SSL证书内容，用base64加密。
        /// </summary>
        [JsonProperty("ssl_cert_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertKey { get; set; }

        /// <summary>
        /// SSL证书内容checksum值，后端校验，源库安全连接必选。
        /// </summary>
        [JsonProperty("ssl_cert_check_sum", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertCheckSum { get; set; }

        /// <summary>
        /// SSL证书密码，证书文件后缀为.p12时必填。
        /// </summary>
        [JsonProperty("ssl_cert_password", NullValueHandling = NullValueHandling.Ignore)]
        public string SslCertPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointSslConfig {\n");
            sb.Append("  sslLink: ").Append(SslLink).Append("\n");
            sb.Append("  sslCertName: ").Append(SslCertName).Append("\n");
            sb.Append("  sslCertKey: ").Append(SslCertKey).Append("\n");
            sb.Append("  sslCertCheckSum: ").Append(SslCertCheckSum).Append("\n");
            sb.Append("  sslCertPassword: ").Append(SslCertPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointSslConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointSslConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SslLink == input.SslLink ||
                    (this.SslLink != null &&
                    this.SslLink.Equals(input.SslLink))
                ) && 
                (
                    this.SslCertName == input.SslCertName ||
                    (this.SslCertName != null &&
                    this.SslCertName.Equals(input.SslCertName))
                ) && 
                (
                    this.SslCertKey == input.SslCertKey ||
                    (this.SslCertKey != null &&
                    this.SslCertKey.Equals(input.SslCertKey))
                ) && 
                (
                    this.SslCertCheckSum == input.SslCertCheckSum ||
                    (this.SslCertCheckSum != null &&
                    this.SslCertCheckSum.Equals(input.SslCertCheckSum))
                ) && 
                (
                    this.SslCertPassword == input.SslCertPassword ||
                    (this.SslCertPassword != null &&
                    this.SslCertPassword.Equals(input.SslCertPassword))
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
                if (this.SslLink != null)
                    hashCode = hashCode * 59 + this.SslLink.GetHashCode();
                if (this.SslCertName != null)
                    hashCode = hashCode * 59 + this.SslCertName.GetHashCode();
                if (this.SslCertKey != null)
                    hashCode = hashCode * 59 + this.SslCertKey.GetHashCode();
                if (this.SslCertCheckSum != null)
                    hashCode = hashCode * 59 + this.SslCertCheckSum.GetHashCode();
                if (this.SslCertPassword != null)
                    hashCode = hashCode * 59 + this.SslCertPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
