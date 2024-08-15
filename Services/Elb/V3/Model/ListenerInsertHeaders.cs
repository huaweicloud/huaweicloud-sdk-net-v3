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
    /// 可选的HTTP头插入，可以将从负载均衡器到后端云服务器的路径中需要被后端云服务器用到的信息写入HTTP中，随报文传递到后端云服务器使。例如可通过X-Forwarded-ELB-IP开关，将负载均衡器的弹性公网IP传到后端云服务器。
    /// </summary>
    public class ListenerInsertHeaders 
    {

        /// <summary>
        /// 参数解释：X-Forwarded-ELB-IP设为true可以将ELB实例的eip地址从报文的http头中带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-ELB-IP", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedELBIP { get; set; }

        /// <summary>
        /// 参数解释：X-Forwarded-Port设为true可以将ELB实例的监听端口从报文的http头中带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Port", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedPort { get; set; }

        /// <summary>
        /// X-Forwarded-For-Port设为true可以将客户端的源端口从报文的http头中带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-For-Port", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedForPort { get; set; }

        /// <summary>
        /// 参数解释：X-Forwarded-Host设为true可以将客户请求头的X-Forwarded-Host设置为请求头的Host带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Host", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedHost { get; set; }

        /// <summary>
        /// 参数解释：X-Forwarded-Proto设为true可以将负载均衡器实例的监听协议通过报文的http头带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Proto", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedProto { get; set; }

        /// <summary>
        /// 参数解释：X-Real-IP设为true可以将客户端的IP通过报文的http头带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Real-IP", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XRealIP { get; set; }

        /// <summary>
        /// 参数解释：X-Forwarded-ELB-ID设为true可以将负载均衡器实例的ID通过报文的http头带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-ELB-ID", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedELBID { get; set; }

        /// <summary>
        /// 参数解释：X-Forwarded-TLS-Certificate-ID设为true可以将负载均衡器实例的证书ID通过报文的http头带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-TLS-Certificate-ID", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTLSCertificateID { get; set; }

        /// <summary>
        /// 参数解释：X-Forwarded-TLS-Protocol设为true可以将负载均衡器实例的算法协议通过报文的http头带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-TLS-Protocol", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTLSProtocol { get; set; }

        /// <summary>
        /// 参数解释：X-Forwarded-TLS-Cipher设为true可以将负载均衡器实例的算法套件通过报文的http头带到后端云服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-TLS-Cipher", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTLSCipher { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListenerInsertHeaders {\n");
            sb.Append("  xForwardedELBIP: ").Append(XForwardedELBIP).Append("\n");
            sb.Append("  xForwardedPort: ").Append(XForwardedPort).Append("\n");
            sb.Append("  xForwardedForPort: ").Append(XForwardedForPort).Append("\n");
            sb.Append("  xForwardedHost: ").Append(XForwardedHost).Append("\n");
            sb.Append("  xForwardedProto: ").Append(XForwardedProto).Append("\n");
            sb.Append("  xRealIP: ").Append(XRealIP).Append("\n");
            sb.Append("  xForwardedELBID: ").Append(XForwardedELBID).Append("\n");
            sb.Append("  xForwardedTLSCertificateID: ").Append(XForwardedTLSCertificateID).Append("\n");
            sb.Append("  xForwardedTLSProtocol: ").Append(XForwardedTLSProtocol).Append("\n");
            sb.Append("  xForwardedTLSCipher: ").Append(XForwardedTLSCipher).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListenerInsertHeaders);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListenerInsertHeaders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XForwardedELBIP == input.XForwardedELBIP ||
                    (this.XForwardedELBIP != null &&
                    this.XForwardedELBIP.Equals(input.XForwardedELBIP))
                ) && 
                (
                    this.XForwardedPort == input.XForwardedPort ||
                    (this.XForwardedPort != null &&
                    this.XForwardedPort.Equals(input.XForwardedPort))
                ) && 
                (
                    this.XForwardedForPort == input.XForwardedForPort ||
                    (this.XForwardedForPort != null &&
                    this.XForwardedForPort.Equals(input.XForwardedForPort))
                ) && 
                (
                    this.XForwardedHost == input.XForwardedHost ||
                    (this.XForwardedHost != null &&
                    this.XForwardedHost.Equals(input.XForwardedHost))
                ) && 
                (
                    this.XForwardedProto == input.XForwardedProto ||
                    (this.XForwardedProto != null &&
                    this.XForwardedProto.Equals(input.XForwardedProto))
                ) && 
                (
                    this.XRealIP == input.XRealIP ||
                    (this.XRealIP != null &&
                    this.XRealIP.Equals(input.XRealIP))
                ) && 
                (
                    this.XForwardedELBID == input.XForwardedELBID ||
                    (this.XForwardedELBID != null &&
                    this.XForwardedELBID.Equals(input.XForwardedELBID))
                ) && 
                (
                    this.XForwardedTLSCertificateID == input.XForwardedTLSCertificateID ||
                    (this.XForwardedTLSCertificateID != null &&
                    this.XForwardedTLSCertificateID.Equals(input.XForwardedTLSCertificateID))
                ) && 
                (
                    this.XForwardedTLSProtocol == input.XForwardedTLSProtocol ||
                    (this.XForwardedTLSProtocol != null &&
                    this.XForwardedTLSProtocol.Equals(input.XForwardedTLSProtocol))
                ) && 
                (
                    this.XForwardedTLSCipher == input.XForwardedTLSCipher ||
                    (this.XForwardedTLSCipher != null &&
                    this.XForwardedTLSCipher.Equals(input.XForwardedTLSCipher))
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
                if (this.XForwardedELBIP != null)
                    hashCode = hashCode * 59 + this.XForwardedELBIP.GetHashCode();
                if (this.XForwardedPort != null)
                    hashCode = hashCode * 59 + this.XForwardedPort.GetHashCode();
                if (this.XForwardedForPort != null)
                    hashCode = hashCode * 59 + this.XForwardedForPort.GetHashCode();
                if (this.XForwardedHost != null)
                    hashCode = hashCode * 59 + this.XForwardedHost.GetHashCode();
                if (this.XForwardedProto != null)
                    hashCode = hashCode * 59 + this.XForwardedProto.GetHashCode();
                if (this.XRealIP != null)
                    hashCode = hashCode * 59 + this.XRealIP.GetHashCode();
                if (this.XForwardedELBID != null)
                    hashCode = hashCode * 59 + this.XForwardedELBID.GetHashCode();
                if (this.XForwardedTLSCertificateID != null)
                    hashCode = hashCode * 59 + this.XForwardedTLSCertificateID.GetHashCode();
                if (this.XForwardedTLSProtocol != null)
                    hashCode = hashCode * 59 + this.XForwardedTLSProtocol.GetHashCode();
                if (this.XForwardedTLSCipher != null)
                    hashCode = hashCode * 59 + this.XForwardedTLSCipher.GetHashCode();
                return hashCode;
            }
        }
    }
}
