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
    /// 配置负载均衡器系统默认域名化相关配置参数。
    /// </summary>
    public class SystemDefaultDnsConfigRequestBody 
    {

        /// <summary>
        /// **参数解释**：公网解析记录集超时时间。解析记录在本地DNS服务器的缓存时间，缓存时间越长更新生效越慢，以秒为单位。如果您的服务地址经常更换，建议TTL值设置相对小些，反之，建议设置相对大些  **约束限制**：不涉及  **取值范围**：1-2147483647  **默认取值**：300
        /// </summary>
        [JsonProperty("public_dns_record_set_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicDnsRecordSetTtl { get; set; }

        /// <summary>
        /// **参数解释**：是否配置私网域名。  **约束限制**：不涉及  **取值范围**： true：开启私网域名 false：关闭私网域名  **默认取值**：false
        /// </summary>
        [JsonProperty("private_domain_name_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateDomainNameEnable { get; set; }

        /// <summary>
        /// **参数解释**：是否配置公网域名。  **约束限制**：不涉及  **取值范围**： true：开启公网域名 false：关闭公网域名  **默认取值**：false
        /// </summary>
        [JsonProperty("public_domain_name_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicDomainNameEnable { get; set; }

        /// <summary>
        /// **参数解释**：私网解析记录集超时时间。解析记录在本地DNS服务器的缓存时间，缓存时间越长更新生效越慢，以秒为单位。如果您的服务地址经常更换，建议TTL值设置相对小些，反之，建议设置相对大些。  **约束限制**：不涉及  **取值范围**：1-2147483647  **默认取值**：300
        /// </summary>
        [JsonProperty("private_dns_record_set_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrivateDnsRecordSetTtl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemDefaultDnsConfigRequestBody {\n");
            sb.Append("  publicDnsRecordSetTtl: ").Append(PublicDnsRecordSetTtl).Append("\n");
            sb.Append("  privateDomainNameEnable: ").Append(PrivateDomainNameEnable).Append("\n");
            sb.Append("  publicDomainNameEnable: ").Append(PublicDomainNameEnable).Append("\n");
            sb.Append("  privateDnsRecordSetTtl: ").Append(PrivateDnsRecordSetTtl).Append("\n");
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
            if (this.PublicDnsRecordSetTtl != input.PublicDnsRecordSetTtl || (this.PublicDnsRecordSetTtl != null && !this.PublicDnsRecordSetTtl.Equals(input.PublicDnsRecordSetTtl))) return false;
            if (this.PrivateDomainNameEnable != input.PrivateDomainNameEnable || (this.PrivateDomainNameEnable != null && !this.PrivateDomainNameEnable.Equals(input.PrivateDomainNameEnable))) return false;
            if (this.PublicDomainNameEnable != input.PublicDomainNameEnable || (this.PublicDomainNameEnable != null && !this.PublicDomainNameEnable.Equals(input.PublicDomainNameEnable))) return false;
            if (this.PrivateDnsRecordSetTtl != input.PrivateDnsRecordSetTtl || (this.PrivateDnsRecordSetTtl != null && !this.PrivateDnsRecordSetTtl.Equals(input.PrivateDnsRecordSetTtl))) return false;

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
                if (this.PublicDnsRecordSetTtl != null) hashCode = hashCode * 59 + this.PublicDnsRecordSetTtl.GetHashCode();
                if (this.PrivateDomainNameEnable != null) hashCode = hashCode * 59 + this.PrivateDomainNameEnable.GetHashCode();
                if (this.PublicDomainNameEnable != null) hashCode = hashCode * 59 + this.PublicDomainNameEnable.GetHashCode();
                if (this.PrivateDnsRecordSetTtl != null) hashCode = hashCode * 59 + this.PrivateDnsRecordSetTtl.GetHashCode();
                return hashCode;
            }
        }
    }
}
