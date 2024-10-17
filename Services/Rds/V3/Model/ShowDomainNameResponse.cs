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
    public class ShowDomainNameResponse : SdkResponse
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
        /// 实例内网IPv4地址。
        /// </summary>
        [JsonProperty("ipv4_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv4Address { get; set; }

        /// <summary>
        /// 域名状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainNameResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  dnsName: ").Append(DnsName).Append("\n");
            sb.Append("  dnsType: ").Append(DnsType).Append("\n");
            sb.Append("  ipv4Address: ").Append(Ipv4Address).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainNameResponse input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.DnsName != input.DnsName || (this.DnsName != null && !this.DnsName.Equals(input.DnsName))) return false;
            if (this.DnsType != input.DnsType || (this.DnsType != null && !this.DnsType.Equals(input.DnsType))) return false;
            if (this.Ipv4Address != input.Ipv4Address || (this.Ipv4Address != null && !this.Ipv4Address.Equals(input.Ipv4Address))) return false;
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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.DnsName != null) hashCode = hashCode * 59 + this.DnsName.GetHashCode();
                if (this.DnsType != null) hashCode = hashCode * 59 + this.DnsType.GetHashCode();
                if (this.Ipv4Address != null) hashCode = hashCode * 59 + this.Ipv4Address.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
