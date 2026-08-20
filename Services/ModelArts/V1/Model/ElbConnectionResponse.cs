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
    public class ElbConnectionResponse 
    {

        /// <summary>
        /// **参数解释：** 负载均衡器ID。 **约束限制：**  不涉及。 **取值范围：** 不涉及。 **默认取值：**  不涉及。
        /// </summary>
        [JsonProperty("elb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbId { get; set; }

        /// <summary>
        /// **参数解释：** 负载均衡器的监听器ID。 **约束限制：**  不涉及。 **取值范围：** 不涉及。 **默认取值：**  不涉及。
        /// </summary>
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

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
        /// **参数解释：** ELB连接状态。 **约束限制：** 仅在响应中返回，请求中传入不生效。 **取值范围：** - CONNECTING：连接中。 - CONNECTED：已连接。 - CONNECT_FAILED：连接失败。 - DISCONNECTING：断开中 - DISCONNET_FAILED：断开失败 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** ELB连接失败时的错误信息。 **约束限制：** 仅在响应中返回，请求中传入不生效；仅当ELB连接状态为CONNECT_FAILED时返回。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("residual_resources", NullValueHandling = NullValueHandling.Ignore)]
        public ResidualResources ResidualResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElbConnectionResponse {\n");
            sb.Append("  elbId: ").Append(ElbId).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  mTls: ").Append(MTls).Append("\n");
            sb.Append("  caCertId: ").Append(CaCertId).Append("\n");
            sb.Append("  serverCertId: ").Append(ServerCertId).Append("\n");
            sb.Append("  sniCertIds: ").Append(SniCertIds).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  residualResources: ").Append(ResidualResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ElbConnectionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ElbConnectionResponse input)
        {
            if (input == null) return false;
            if (this.ElbId != input.ElbId || (this.ElbId != null && !this.ElbId.Equals(input.ElbId))) return false;
            if (this.ListenerId != input.ListenerId || (this.ListenerId != null && !this.ListenerId.Equals(input.ListenerId))) return false;
            if (this.MTls != input.MTls || (this.MTls != null && !this.MTls.Equals(input.MTls))) return false;
            if (this.CaCertId != input.CaCertId || (this.CaCertId != null && !this.CaCertId.Equals(input.CaCertId))) return false;
            if (this.ServerCertId != input.ServerCertId || (this.ServerCertId != null && !this.ServerCertId.Equals(input.ServerCertId))) return false;
            if (this.SniCertIds != input.SniCertIds || (this.SniCertIds != null && input.SniCertIds != null && !this.SniCertIds.SequenceEqual(input.SniCertIds))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.ResidualResources != input.ResidualResources || (this.ResidualResources != null && !this.ResidualResources.Equals(input.ResidualResources))) return false;

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
                if (this.ListenerId != null) hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.MTls != null) hashCode = hashCode * 59 + this.MTls.GetHashCode();
                if (this.CaCertId != null) hashCode = hashCode * 59 + this.CaCertId.GetHashCode();
                if (this.ServerCertId != null) hashCode = hashCode * 59 + this.ServerCertId.GetHashCode();
                if (this.SniCertIds != null) hashCode = hashCode * 59 + this.SniCertIds.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ResidualResources != null) hashCode = hashCode * 59 + this.ResidualResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
