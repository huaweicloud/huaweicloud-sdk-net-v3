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
    /// 
    /// </summary>
    public class SystemDefaultDnsConfigRequestBody 
    {

        /// <summary>
        /// **参数解释**：是否启用私网域名解析。  **约束限制**：不涉及  **取值范围**： - true：开启私网域名解析。 - false：关闭私网域名解析。  **默认取值**：false
        /// </summary>
        [JsonProperty("private_domain_name_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateDomainNameEnable { get; set; }

        /// <summary>
        /// **参数解释**：私网域名解析记录在本地DNS服务器的缓存超时时间，单位：秒。域名解析信息更新后，需要等待DNS服务器上的缓存超时才会生效。如果您的域名解析信息经常变更，建议TTL值设置相对小些，反之建议设置相对大些。  **约束限制**：不涉及  **取值范围**：1-2147483647  **默认取值**：300
        /// </summary>
        [JsonProperty("private_dns_record_set_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrivateDnsRecordSetTtl { get; set; }

        /// <summary>
        /// **参数解释**：是否启用公网域名解析。  **约束限制**：不涉及  **取值范围**： - true：开启公网域名解析。 - false：关闭公网域名解析。  **默认取值**：false
        /// </summary>
        [JsonProperty("public_domain_name_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicDomainNameEnable { get; set; }

        /// <summary>
        /// **参数解释**：公网域名解析记录在本地DNS服务器的缓存超时时间，单位：秒。域名解析信息更新后，需要等待DNS服务器上的缓存超时才会生效。如果您的域名解析信息经常变更，建议TTL值设置相对小些，反之建议设置相对大些。  **约束限制**：不涉及  **取值范围**：1-2147483647  **默认取值**：300
        /// </summary>
        [JsonProperty("public_dns_record_set_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicDnsRecordSetTtl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemDefaultDnsConfigRequestBody {\n");
            sb.Append("  privateDomainNameEnable: ").Append(PrivateDomainNameEnable).Append("\n");
            sb.Append("  privateDnsRecordSetTtl: ").Append(PrivateDnsRecordSetTtl).Append("\n");
            sb.Append("  publicDomainNameEnable: ").Append(PublicDomainNameEnable).Append("\n");
            sb.Append("  publicDnsRecordSetTtl: ").Append(PublicDnsRecordSetTtl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SystemDefaultDnsConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SystemDefaultDnsConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.PrivateDomainNameEnable != input.PrivateDomainNameEnable || (this.PrivateDomainNameEnable != null && !this.PrivateDomainNameEnable.Equals(input.PrivateDomainNameEnable))) return false;
            if (this.PrivateDnsRecordSetTtl != input.PrivateDnsRecordSetTtl || (this.PrivateDnsRecordSetTtl != null && !this.PrivateDnsRecordSetTtl.Equals(input.PrivateDnsRecordSetTtl))) return false;
            if (this.PublicDomainNameEnable != input.PublicDomainNameEnable || (this.PublicDomainNameEnable != null && !this.PublicDomainNameEnable.Equals(input.PublicDomainNameEnable))) return false;
            if (this.PublicDnsRecordSetTtl != input.PublicDnsRecordSetTtl || (this.PublicDnsRecordSetTtl != null && !this.PublicDnsRecordSetTtl.Equals(input.PublicDnsRecordSetTtl))) return false;

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
                if (this.PrivateDomainNameEnable != null) hashCode = hashCode * 59 + this.PrivateDomainNameEnable.GetHashCode();
                if (this.PrivateDnsRecordSetTtl != null) hashCode = hashCode * 59 + this.PrivateDnsRecordSetTtl.GetHashCode();
                if (this.PublicDomainNameEnable != null) hashCode = hashCode * 59 + this.PublicDomainNameEnable.GetHashCode();
                if (this.PublicDnsRecordSetTtl != null) hashCode = hashCode * 59 + this.PublicDnsRecordSetTtl.GetHashCode();
                return hashCode;
            }
        }
    }
}
