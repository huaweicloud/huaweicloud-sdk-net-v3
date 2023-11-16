using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TransferRuleBody 
    {

        /// <summary>
        /// 转发协议，tcp或udp
        /// </summary>
        [JsonProperty("forward_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string ForwardProtocol { get; set; }

        /// <summary>
        /// 转发端口
        /// </summary>
        [JsonProperty("forward_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForwardPort { get; set; }

        /// <summary>
        /// 源站端口
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourcePort { get; set; }

        /// <summary>
        /// 源站IP，多个IP用逗号隔开，限制20个IP
        /// </summary>
        [JsonProperty("source_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferRuleBody {\n");
            sb.Append("  forwardProtocol: ").Append(ForwardProtocol).Append("\n");
            sb.Append("  forwardPort: ").Append(ForwardPort).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  sourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferRuleBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferRuleBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForwardProtocol == input.ForwardProtocol ||
                    (this.ForwardProtocol != null &&
                    this.ForwardProtocol.Equals(input.ForwardProtocol))
                ) && 
                (
                    this.ForwardPort == input.ForwardPort ||
                    (this.ForwardPort != null &&
                    this.ForwardPort.Equals(input.ForwardPort))
                ) && 
                (
                    this.SourcePort == input.SourcePort ||
                    (this.SourcePort != null &&
                    this.SourcePort.Equals(input.SourcePort))
                ) && 
                (
                    this.SourceIp == input.SourceIp ||
                    (this.SourceIp != null &&
                    this.SourceIp.Equals(input.SourceIp))
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
                if (this.ForwardProtocol != null)
                    hashCode = hashCode * 59 + this.ForwardProtocol.GetHashCode();
                if (this.ForwardPort != null)
                    hashCode = hashCode * 59 + this.ForwardPort.GetHashCode();
                if (this.SourcePort != null)
                    hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.SourceIp != null)
                    hashCode = hashCode * 59 + this.SourceIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
