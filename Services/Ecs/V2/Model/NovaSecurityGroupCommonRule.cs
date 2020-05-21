using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NovaSecurityGroupCommonRule 
    {

        /// <summary>
        /// 起始端口，范围1-65535，且不大于to_port。 ip_protocol设置为icmp时，from_port表示type，范围是0-255。
        /// </summary>
        [JsonProperty("from_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? FromPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public NovaSecurityGroupCommonGroup Group { get; set; }

        /// <summary>
        /// 安全组规则ID，UUID格式。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 协议类型或直接指定IP协议号，取值可为icmp，tcp，udp或IP协议号。
        /// </summary>
        [JsonProperty("ip_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_range", NullValueHandling = NullValueHandling.Ignore)]
        public NovaSecurityGroupCommonIpRange IpRange { get; set; }

        /// <summary>
        /// 相关联的安全组ID，UUID格式。
        /// </summary>
        [JsonProperty("parent_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentGroupId { get; set; }

        /// <summary>
        /// 终止端口，范围1-65535，且不小于from_port。 ip_protocol设置为icmp时，to_port表示code，范围是0-255，且如果from_port为-1，to_port为-1表示任意ICMP报文。
        /// </summary>
        [JsonProperty("to_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ToPort { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaSecurityGroupCommonRule {\n");
            sb.Append("  fromPort: ").Append(FromPort).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipProtocol: ").Append(IpProtocol).Append("\n");
            sb.Append("  ipRange: ").Append(IpRange).Append("\n");
            sb.Append("  parentGroupId: ").Append(ParentGroupId).Append("\n");
            sb.Append("  toPort: ").Append(ToPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaSecurityGroupCommonRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaSecurityGroupCommonRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromPort == input.FromPort ||
                    (this.FromPort != null &&
                    this.FromPort.Equals(input.FromPort))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IpProtocol == input.IpProtocol ||
                    (this.IpProtocol != null &&
                    this.IpProtocol.Equals(input.IpProtocol))
                ) && 
                (
                    this.IpRange == input.IpRange ||
                    (this.IpRange != null &&
                    this.IpRange.Equals(input.IpRange))
                ) && 
                (
                    this.ParentGroupId == input.ParentGroupId ||
                    (this.ParentGroupId != null &&
                    this.ParentGroupId.Equals(input.ParentGroupId))
                ) && 
                (
                    this.ToPort == input.ToPort ||
                    (this.ToPort != null &&
                    this.ToPort.Equals(input.ToPort))
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
                if (this.FromPort != null)
                    hashCode = hashCode * 59 + this.FromPort.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpProtocol != null)
                    hashCode = hashCode * 59 + this.IpProtocol.GetHashCode();
                if (this.IpRange != null)
                    hashCode = hashCode * 59 + this.IpRange.GetHashCode();
                if (this.ParentGroupId != null)
                    hashCode = hashCode * 59 + this.ParentGroupId.GetHashCode();
                if (this.ToPort != null)
                    hashCode = hashCode * 59 + this.ToPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
