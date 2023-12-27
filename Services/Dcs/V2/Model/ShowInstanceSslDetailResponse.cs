using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceSslDetailResponse : SdkResponse
    {

        /// <summary>
        /// 开启或关闭SSL。true：开启/false：关闭
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// SSL连接IP。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// SSL连接端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// SSL连接域名。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// SSL证书有效期（UTC时间）。
        /// </summary>
        [JsonProperty("ssl_expired_at", NullValueHandling = NullValueHandling.Ignore)]
        public string SslExpiredAt { get; set; }

        /// <summary>
        /// SSL证书是否有效。
        /// </summary>
        [JsonProperty("ssl_validated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslValidated { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceSslDetailResponse {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  sslExpiredAt: ").Append(SslExpiredAt).Append("\n");
            sb.Append("  sslValidated: ").Append(SslValidated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceSslDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceSslDetailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.SslExpiredAt == input.SslExpiredAt ||
                    (this.SslExpiredAt != null &&
                    this.SslExpiredAt.Equals(input.SslExpiredAt))
                ) && 
                (
                    this.SslValidated == input.SslValidated ||
                    (this.SslValidated != null &&
                    this.SslValidated.Equals(input.SslValidated))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.SslExpiredAt != null)
                    hashCode = hashCode * 59 + this.SslExpiredAt.GetHashCode();
                if (this.SslValidated != null)
                    hashCode = hashCode * 59 + this.SslValidated.GetHashCode();
                return hashCode;
            }
        }
    }
}
