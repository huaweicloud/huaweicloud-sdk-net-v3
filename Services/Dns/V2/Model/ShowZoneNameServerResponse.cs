using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowZoneNameServerResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 是否全部为华为云DNS服务器地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("all_hw_dns", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllHwDns { get; set; }

        /// <summary>
        /// **参数解释：** 是否包含华为云DNS服务器地址。  **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("include_hw_dns", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeHwDns { get; set; }

        /// <summary>
        /// **参数解释：** DNS服务器地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("dns_servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsServers { get; set; }

        /// <summary>
        /// **参数解释：** 期望的DNS服务器地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("expected_dns_servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExpectedDnsServers { get; set; }

        /// <summary>
        /// **参数解释：** 公网域名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowZoneNameServerResponse {\n");
            sb.Append("  allHwDns: ").Append(AllHwDns).Append("\n");
            sb.Append("  includeHwDns: ").Append(IncludeHwDns).Append("\n");
            sb.Append("  dnsServers: ").Append(DnsServers).Append("\n");
            sb.Append("  expectedDnsServers: ").Append(ExpectedDnsServers).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowZoneNameServerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowZoneNameServerResponse input)
        {
            if (input == null) return false;
            if (this.AllHwDns != input.AllHwDns || (this.AllHwDns != null && !this.AllHwDns.Equals(input.AllHwDns))) return false;
            if (this.IncludeHwDns != input.IncludeHwDns || (this.IncludeHwDns != null && !this.IncludeHwDns.Equals(input.IncludeHwDns))) return false;
            if (this.DnsServers != input.DnsServers || (this.DnsServers != null && input.DnsServers != null && !this.DnsServers.SequenceEqual(input.DnsServers))) return false;
            if (this.ExpectedDnsServers != input.ExpectedDnsServers || (this.ExpectedDnsServers != null && input.ExpectedDnsServers != null && !this.ExpectedDnsServers.SequenceEqual(input.ExpectedDnsServers))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;

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
                if (this.AllHwDns != null) hashCode = hashCode * 59 + this.AllHwDns.GetHashCode();
                if (this.IncludeHwDns != null) hashCode = hashCode * 59 + this.IncludeHwDns.GetHashCode();
                if (this.DnsServers != null) hashCode = hashCode * 59 + this.DnsServers.GetHashCode();
                if (this.ExpectedDnsServers != null) hashCode = hashCode * 59 + this.ExpectedDnsServers.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                return hashCode;
            }
        }
    }
}
