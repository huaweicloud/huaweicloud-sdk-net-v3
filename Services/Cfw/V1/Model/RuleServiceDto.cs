using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// RuleServiceDto
    /// </summary>
    public class RuleServiceDto 
    {

        /// <summary>
        /// 服务输入类型，0为手动输入类型，1为自动输入类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 协议类型:TCP为6, UDP为17,ICMP为1,ICMPV6为58,ANY为-1,手动类型不为空，自动类型为空
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePort { get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("dest_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DestPort { get; set; }

        /// <summary>
        /// 服务组id，手动类型为空，自动类型为非空
        /// </summary>
        [JsonProperty("service_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceSetId { get; set; }

        /// <summary>
        /// 服务组名称
        /// </summary>
        [JsonProperty("service_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceSetName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleServiceDto {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  destPort: ").Append(DestPort).Append("\n");
            sb.Append("  serviceSetId: ").Append(ServiceSetId).Append("\n");
            sb.Append("  serviceSetName: ").Append(ServiceSetName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleServiceDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleServiceDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.SourcePort == input.SourcePort ||
                    (this.SourcePort != null &&
                    this.SourcePort.Equals(input.SourcePort))
                ) && 
                (
                    this.DestPort == input.DestPort ||
                    (this.DestPort != null &&
                    this.DestPort.Equals(input.DestPort))
                ) && 
                (
                    this.ServiceSetId == input.ServiceSetId ||
                    (this.ServiceSetId != null &&
                    this.ServiceSetId.Equals(input.ServiceSetId))
                ) && 
                (
                    this.ServiceSetName == input.ServiceSetName ||
                    (this.ServiceSetName != null &&
                    this.ServiceSetName.Equals(input.ServiceSetName))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.SourcePort != null)
                    hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.DestPort != null)
                    hashCode = hashCode * 59 + this.DestPort.GetHashCode();
                if (this.ServiceSetId != null)
                    hashCode = hashCode * 59 + this.ServiceSetId.GetHashCode();
                if (this.ServiceSetName != null)
                    hashCode = hashCode * 59 + this.ServiceSetName.GetHashCode();
                return hashCode;
            }
        }
    }
}
