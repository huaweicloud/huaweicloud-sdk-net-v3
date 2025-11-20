using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 服务端证书配置结构体
    /// </summary>
    public class ServerCertificateConfig 
    {

        /// <summary>
        /// 是否开启服务端OCSP装订
        /// </summary>
        [JsonProperty("ocsp_stapling_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OcspStaplingEnable { get; set; }

        /// <summary>
        /// ocsp服务器端CA证书id，仅当ocsp服务器为https协议时支持配置。
        /// </summary>
        [JsonProperty("ocsp_server_ca_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OcspServerCaId { get; set; }

        /// <summary>
        /// 访问ocsp服务器是否开启SSL
        /// </summary>
        [JsonProperty("ocsp_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OcspSslEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerCertificateConfig {\n");
            sb.Append("  ocspStaplingEnable: ").Append(OcspStaplingEnable).Append("\n");
            sb.Append("  ocspServerCaId: ").Append(OcspServerCaId).Append("\n");
            sb.Append("  ocspSslEnable: ").Append(OcspSslEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerCertificateConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerCertificateConfig input)
        {
            if (input == null) return false;
            if (this.OcspStaplingEnable != input.OcspStaplingEnable || (this.OcspStaplingEnable != null && !this.OcspStaplingEnable.Equals(input.OcspStaplingEnable))) return false;
            if (this.OcspServerCaId != input.OcspServerCaId || (this.OcspServerCaId != null && !this.OcspServerCaId.Equals(input.OcspServerCaId))) return false;
            if (this.OcspSslEnable != input.OcspSslEnable || (this.OcspSslEnable != null && !this.OcspSslEnable.Equals(input.OcspSslEnable))) return false;

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
                if (this.OcspStaplingEnable != null) hashCode = hashCode * 59 + this.OcspStaplingEnable.GetHashCode();
                if (this.OcspServerCaId != null) hashCode = hashCode * 59 + this.OcspServerCaId.GetHashCode();
                if (this.OcspSslEnable != null) hashCode = hashCode * 59 + this.OcspSslEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
