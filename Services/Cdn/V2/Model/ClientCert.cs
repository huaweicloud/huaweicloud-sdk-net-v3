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
    /// 客户端证书配置
    /// </summary>
    public class ClientCert 
    {

        /// <summary>
        /// 客户端证书配置开关，1：打开；0：关闭。
        /// </summary>
        [JsonProperty("validation", NullValueHandling = NullValueHandling.Ignore)]
        public int? Validation { get; set; }

        /// <summary>
        /// 客户端CA证书的内容，仅支持PEM格式。
        /// </summary>
        [JsonProperty("trusted_cert", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustedCert { get; set; }

        /// <summary>
        /// 客户端CA证书指定的域名。   &gt; 1. 如果不配置域名，则CDN会放行所有持有该CA证书的客户端请求。   &gt; 2. 最多可配置100个域名，多个域名用“,”或“|”分隔。
        /// </summary>
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public string Hosts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientCert {\n");
            sb.Append("  validation: ").Append(Validation).Append("\n");
            sb.Append("  trustedCert: ").Append(TrustedCert).Append("\n");
            sb.Append("  hosts: ").Append(Hosts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientCert);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClientCert input)
        {
            if (input == null) return false;
            if (this.Validation != input.Validation || (this.Validation != null && !this.Validation.Equals(input.Validation))) return false;
            if (this.TrustedCert != input.TrustedCert || (this.TrustedCert != null && !this.TrustedCert.Equals(input.TrustedCert))) return false;
            if (this.Hosts != input.Hosts || (this.Hosts != null && !this.Hosts.Equals(input.Hosts))) return false;

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
                if (this.Validation != null) hashCode = hashCode * 59 + this.Validation.GetHashCode();
                if (this.TrustedCert != null) hashCode = hashCode * 59 + this.TrustedCert.GetHashCode();
                if (this.Hosts != null) hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                return hashCode;
            }
        }
    }
}
