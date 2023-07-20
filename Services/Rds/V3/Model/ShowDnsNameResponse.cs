using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDnsNameResponse : SdkResponse
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例域名。
        /// </summary>
        [JsonProperty("dns_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsName { get; set; }

        /// <summary>
        /// 实例域名类型，当前只支持private。
        /// </summary>
        [JsonProperty("dns_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsType { get; set; }

        /// <summary>
        /// 实例内网IPv6地址。
        /// </summary>
        [JsonProperty("ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// 域名状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDnsNameResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  dnsName: ").Append(DnsName).Append("\n");
            sb.Append("  dnsType: ").Append(DnsType).Append("\n");
            sb.Append("  ipv6Address: ").Append(Ipv6Address).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDnsNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDnsNameResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.DnsName == input.DnsName ||
                    (this.DnsName != null &&
                    this.DnsName.Equals(input.DnsName))
                ) && 
                (
                    this.DnsType == input.DnsType ||
                    (this.DnsType != null &&
                    this.DnsType.Equals(input.DnsType))
                ) && 
                (
                    this.Ipv6Address == input.Ipv6Address ||
                    (this.Ipv6Address != null &&
                    this.Ipv6Address.Equals(input.Ipv6Address))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.DnsName != null)
                    hashCode = hashCode * 59 + this.DnsName.GetHashCode();
                if (this.DnsType != null)
                    hashCode = hashCode * 59 + this.DnsType.GetHashCode();
                if (this.Ipv6Address != null)
                    hashCode = hashCode * 59 + this.Ipv6Address.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
