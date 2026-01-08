using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MemberHealthCheckFailedReason 
    {

        /// <summary>
        /// **参数解释**：健康检查异常原因码。  **取值范围**： - CONNECT_TIMEOUT: 负载均衡健康检查时向后端服务器建立连接超时。 - CONNECT_REFUSED: 负载均衡健康检查时向后端服务器拒绝连接。 - CONNECT_FAILED: 负载均衡健康检查时向后端服务器建立连接失败。 - CONNECT_INTERRUPT: 负载均衡健康检查与后端服务器连接中断。 - SSL_HANDSHAKE_ERROR: 负载均衡健康检查时与后端服务器SSL握手失败。 - RECV_RESPONSE_FAILED: 负载均衡健康检查时从后端服务器接收响应失败。 - RECV_RESPONSE_TIMEOUT: 负载均衡健康检查时从后端服务器接收响应超时。 - SEND_REQUEST_FAILED: 负载均衡健康检查时向后端服务器发送请求失败。 - SEND_REQUEST_TIMEOUT: 负载均衡健康检查时向后端服务器发送请求超时。 - RESPONSE_FORMAT_ERROR: 负载均衡健康检查时从后端服务器接收响应格式错误。 - RESPONSE_MISMATCH: 负载均衡健康检查时从后端服务器接收的响应码与预期配置返回码不一致。
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// **参数解释**：健康检查预期响应状态码。支持HTTP,HTTPS,GRPC健康检查。只有reason_code为RESPONSE_MISMATCH时，支持非null取值。  **取值范围**： - 单值：单个返回码。当type为GRPC[或GRPCS](tag:not_open)时，取值范围为0-99；当type为其他协议时，取值范围为200-599。例如：\&quot;0\&quot;或\&quot;200\&quot;。 - 列表：多个特定返回码，逗号分隔，最多支持5个返回码。例如:\&quot;200,202\&quot;或\&quot;0,1\&quot;。 - 区间：一个返回码区间，区间内\&quot;-\&quot;分隔，区间之间逗号分隔，最多支持5个区间。例如\&quot;200-204,300-399\&quot;或\&quot;0-5,10-12,20-30\&quot;。
        /// </summary>
        [JsonProperty("expected_response", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedResponse { get; set; }

        /// <summary>
        /// **参数解释**：健康检查探测实际响应状态码。支持HTTP,HTTPS,GRPC健康检查。只有reason_code为RESPONSE_MISMATCH时，支持非null取值。  **取值范围**： - 单个返回码。当type为GRPC[或GRPCS](tag:not_open)时，取值范围为0-99；当type为其他协议时，取值范围为200-599。例如：\&quot;0\&quot;或\&quot;200\&quot;。
        /// </summary>
        [JsonProperty("healthcheck_response", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthcheckResponse { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberHealthCheckFailedReason {\n");
            sb.Append("  reasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  expectedResponse: ").Append(ExpectedResponse).Append("\n");
            sb.Append("  healthcheckResponse: ").Append(HealthcheckResponse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberHealthCheckFailedReason);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MemberHealthCheckFailedReason input)
        {
            if (input == null) return false;
            if (this.ReasonCode != input.ReasonCode || (this.ReasonCode != null && !this.ReasonCode.Equals(input.ReasonCode))) return false;
            if (this.ExpectedResponse != input.ExpectedResponse || (this.ExpectedResponse != null && !this.ExpectedResponse.Equals(input.ExpectedResponse))) return false;
            if (this.HealthcheckResponse != input.HealthcheckResponse || (this.HealthcheckResponse != null && !this.HealthcheckResponse.Equals(input.HealthcheckResponse))) return false;

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
                if (this.ReasonCode != null) hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.ExpectedResponse != null) hashCode = hashCode * 59 + this.ExpectedResponse.GetHashCode();
                if (this.HealthcheckResponse != null) hashCode = hashCode * 59 + this.HealthcheckResponse.GetHashCode();
                return hashCode;
            }
        }
    }
}
