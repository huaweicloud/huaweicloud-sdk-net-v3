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
    public class UpdateDnsServersRequestBody 
    {

        /// <summary>
        /// **参数解释**： DNS服务器列表 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("dns_server", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateDnsServersRequestBodyDnsServer> DnsServer { get; set; }

        /// <summary>
        /// **参数解释**： 健康检查域名，可通过[查询DNS服务器列表接口](ListDnsServers.xml)查询获得，通过返回值中的data.health_check_domain_name（.表示各对象之间层级的区分）获得。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("health_check_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthCheckDomainName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDnsServersRequestBody {\n");
            sb.Append("  dnsServer: ").Append(DnsServer).Append("\n");
            sb.Append("  healthCheckDomainName: ").Append(HealthCheckDomainName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDnsServersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDnsServersRequestBody input)
        {
            if (input == null) return false;
            if (this.DnsServer != input.DnsServer || (this.DnsServer != null && input.DnsServer != null && !this.DnsServer.SequenceEqual(input.DnsServer))) return false;
            if (this.HealthCheckDomainName != input.HealthCheckDomainName || (this.HealthCheckDomainName != null && !this.HealthCheckDomainName.Equals(input.HealthCheckDomainName))) return false;

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
                if (this.DnsServer != null) hashCode = hashCode * 59 + this.DnsServer.GetHashCode();
                if (this.HealthCheckDomainName != null) hashCode = hashCode * 59 + this.HealthCheckDomainName.GetHashCode();
                return hashCode;
            }
        }
    }
}
