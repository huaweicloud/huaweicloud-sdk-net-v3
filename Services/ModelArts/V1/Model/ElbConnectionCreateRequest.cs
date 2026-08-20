using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ElbConnectionCreateRequest 
    {

        /// <summary>
        /// **参数解释：** 负载均衡器ID。 **约束限制：**  不涉及。 **取值范围：** 不涉及。 **默认取值：**  不涉及。
        /// </summary>
        [JsonProperty("elb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbId { get; set; }

        /// <summary>
        /// **参数解释：** 负载均衡器的HTTPS监听器是否开启双向认证。 **约束限制：** 仅推理服务协议为HTTPS或WSS时可配置为true，否则忽略该配置 **取值范围：** 不涉及。 **默认取值：** false
        /// </summary>
        [JsonProperty("m_tls", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MTls { get; set; }

        /// <summary>
        /// **参数解释：** 负载均衡器的HTTPS监听器配置的客户端证书ID。 **约束限制：** 仅推理服务协议为HTTPS或WSS时可配置，否则忽略该配置 **取值范围：** 不涉及。 **默认取值：**  不涉及。
        /// </summary>
        [JsonProperty("ca_cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CaCertId { get; set; }

        /// <summary>
        /// **参数解释：** 负载均衡器的HTTPS监听器配置的服务端证书ID。 **约束限制：** 仅推理服务协议为HTTPS或WSS时可配置，否则忽略该配置。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("server_cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerCertId { get; set; }

        /// <summary>
        /// **参数解释：** 负载均衡器的HTTPS监听器配置的SNI（服务器名称指示）证书ID列表。 **约束限制：** 仅推理服务协议为HTTPS或WSS时可配置，否则忽略该配置。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("sni_cert_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SniCertIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElbConnectionCreateRequest {\n");
            sb.Append("  elbId: ").Append(ElbId).Append("\n");
            sb.Append("  mTls: ").Append(MTls).Append("\n");
            sb.Append("  caCertId: ").Append(CaCertId).Append("\n");
            sb.Append("  serverCertId: ").Append(ServerCertId).Append("\n");
            sb.Append("  sniCertIds: ").Append(SniCertIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ElbConnectionCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ElbConnectionCreateRequest input)
        {
            if (input == null) return false;
            if (this.ElbId != input.ElbId || (this.ElbId != null && !this.ElbId.Equals(input.ElbId))) return false;
            if (this.MTls != input.MTls || (this.MTls != null && !this.MTls.Equals(input.MTls))) return false;
            if (this.CaCertId != input.CaCertId || (this.CaCertId != null && !this.CaCertId.Equals(input.CaCertId))) return false;
            if (this.ServerCertId != input.ServerCertId || (this.ServerCertId != null && !this.ServerCertId.Equals(input.ServerCertId))) return false;
            if (this.SniCertIds != input.SniCertIds || (this.SniCertIds != null && input.SniCertIds != null && !this.SniCertIds.SequenceEqual(input.SniCertIds))) return false;

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
                if (this.ElbId != null) hashCode = hashCode * 59 + this.ElbId.GetHashCode();
                if (this.MTls != null) hashCode = hashCode * 59 + this.MTls.GetHashCode();
                if (this.CaCertId != null) hashCode = hashCode * 59 + this.CaCertId.GetHashCode();
                if (this.ServerCertId != null) hashCode = hashCode * 59 + this.ServerCertId.GetHashCode();
                if (this.SniCertIds != null) hashCode = hashCode * 59 + this.SniCertIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
