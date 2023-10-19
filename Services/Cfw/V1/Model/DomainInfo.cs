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
    /// 
    /// </summary>
    public class DomainInfo 
    {

        /// <summary>
        /// 域名地址id
        /// </summary>
        [JsonProperty("domain_address_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAddressId { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 域名服务器列表
        /// </summary>
        [JsonProperty("dns_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainInfo {\n");
            sb.Append("  domainAddressId: ").Append(DomainAddressId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  dnsIps: ").Append(DnsIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainAddressId == input.DomainAddressId ||
                    (this.DomainAddressId != null &&
                    this.DomainAddressId.Equals(input.DomainAddressId))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DnsIps == input.DnsIps ||
                    this.DnsIps != null &&
                    input.DnsIps != null &&
                    this.DnsIps.SequenceEqual(input.DnsIps)
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
                if (this.DomainAddressId != null)
                    hashCode = hashCode * 59 + this.DomainAddressId.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DnsIps != null)
                    hashCode = hashCode * 59 + this.DnsIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
