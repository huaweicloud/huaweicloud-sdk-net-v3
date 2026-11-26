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
    /// **参数解释：** 客户端证书配置，实现客户端与CDN节点的双向证书认证，提高网站通信安全性 **约束限制：** 不涉及
    /// </summary>
    public class ClientCert 
    {

        /// <summary>
        /// **参数解释：** 客户端证书配置开关 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 客户端CA证书的内容 **约束限制：** 仅支持PEM格式 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("trusted_cert", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustedCert { get; set; }

        /// <summary>
        /// **参数解释：** 客户端CA证书指定的域名 **约束限制：** - 如果不配置域名，则CDN会放行所有持有该CA证书的客户端请求 - 最多可配置100个域名 - 多个域名用“,”或“|”分隔  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public string Hosts { get; set; }

        /// <summary>
        /// **参数解释：** 多证书场景下客户端CA证书列表 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("trusted_certs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientCertTrustedCerts> TrustedCerts { get; set; }

        /// <summary>
        /// **参数解释：** 国密证书场景下客户端CA证书列表 **约束限制：** - 开启国密证书后配置 - 仅支持PEM格式
        /// </summary>
        [JsonProperty("sm_trusted_certs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientCertTrustedCerts> SmTrustedCerts { get; set; }

        /// <summary>
        /// **参数解释：** 国密证书指定访问的客户端域名 **约束限制：** - 开启国密证书后配置 - 最多可配置100个域名 - 多个域名用“|”分隔  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("sm_cert_hosts", NullValueHandling = NullValueHandling.Ignore)]
        public string SmCertHosts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientCert {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  trustedCert: ").Append(TrustedCert).Append("\n");
            sb.Append("  hosts: ").Append(Hosts).Append("\n");
            sb.Append("  trustedCerts: ").Append(TrustedCerts).Append("\n");
            sb.Append("  smTrustedCerts: ").Append(SmTrustedCerts).Append("\n");
            sb.Append("  smCertHosts: ").Append(SmCertHosts).Append("\n");
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
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TrustedCert != input.TrustedCert || (this.TrustedCert != null && !this.TrustedCert.Equals(input.TrustedCert))) return false;
            if (this.Hosts != input.Hosts || (this.Hosts != null && !this.Hosts.Equals(input.Hosts))) return false;
            if (this.TrustedCerts != input.TrustedCerts || (this.TrustedCerts != null && input.TrustedCerts != null && !this.TrustedCerts.SequenceEqual(input.TrustedCerts))) return false;
            if (this.SmTrustedCerts != input.SmTrustedCerts || (this.SmTrustedCerts != null && input.SmTrustedCerts != null && !this.SmTrustedCerts.SequenceEqual(input.SmTrustedCerts))) return false;
            if (this.SmCertHosts != input.SmCertHosts || (this.SmCertHosts != null && !this.SmCertHosts.Equals(input.SmCertHosts))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TrustedCert != null) hashCode = hashCode * 59 + this.TrustedCert.GetHashCode();
                if (this.Hosts != null) hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.TrustedCerts != null) hashCode = hashCode * 59 + this.TrustedCerts.GetHashCode();
                if (this.SmTrustedCerts != null) hashCode = hashCode * 59 + this.SmTrustedCerts.GetHashCode();
                if (this.SmCertHosts != null) hashCode = hashCode * 59 + this.SmCertHosts.GetHashCode();
                return hashCode;
            }
        }
    }
}
