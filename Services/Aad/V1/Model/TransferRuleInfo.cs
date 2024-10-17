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
    public class TransferRuleInfo 
    {

        /// <summary>
        /// 转发规则名ID
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

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
        /// LVS转发规则
        /// </summary>
        [JsonProperty("lb_method", NullValueHandling = NullValueHandling.Ignore)]
        public string LbMethod { get; set; }

        /// <summary>
        /// 源站IP，多个IP用逗号隔开，限制20个IP
        /// </summary>
        [JsonProperty("source_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 源站状态 1 正常，2 异常
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferRuleInfo {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  forwardProtocol: ").Append(ForwardProtocol).Append("\n");
            sb.Append("  forwardPort: ").Append(ForwardPort).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  lbMethod: ").Append(LbMethod).Append("\n");
            sb.Append("  sourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferRuleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferRuleInfo input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.ForwardProtocol != input.ForwardProtocol || (this.ForwardProtocol != null && !this.ForwardProtocol.Equals(input.ForwardProtocol))) return false;
            if (this.ForwardPort != input.ForwardPort || (this.ForwardPort != null && !this.ForwardPort.Equals(input.ForwardPort))) return false;
            if (this.SourcePort != input.SourcePort || (this.SourcePort != null && !this.SourcePort.Equals(input.SourcePort))) return false;
            if (this.LbMethod != input.LbMethod || (this.LbMethod != null && !this.LbMethod.Equals(input.LbMethod))) return false;
            if (this.SourceIp != input.SourceIp || (this.SourceIp != null && !this.SourceIp.Equals(input.SourceIp))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.ForwardProtocol != null) hashCode = hashCode * 59 + this.ForwardProtocol.GetHashCode();
                if (this.ForwardPort != null) hashCode = hashCode * 59 + this.ForwardPort.GetHashCode();
                if (this.SourcePort != null) hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.LbMethod != null) hashCode = hashCode * 59 + this.LbMethod.GetHashCode();
                if (this.SourceIp != null) hashCode = hashCode * 59 + this.SourceIp.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
