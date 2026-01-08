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
    /// 配置负载均衡器用户自定义域名化相关配置参数。
    /// </summary>
    public class UserDefinedDnsConfigRequestBody 
    {

        /// <summary>
        /// **参数解释**：是否配置公网域名。  **约束限制**：不涉及  **取值范围**： true：开启公网域名 false：关闭公网域名  **默认取值**：false
        /// </summary>
        [JsonProperty("public_domain_name_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicDomainNameEnable { get; set; }

        /// <summary>
        /// **参数解释**：公网域名所使用的zone名称。  **约束限制**：公网域名只能使用公网类型的zone，当配置公网域名开关打开时，该字段不能置空，所填的公网zone必须在云解析服务已注册过。  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("public_dns_zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicDnsZoneName { get; set; }

        /// <summary>
        /// **参数解释**：公网解析记录集超时时间。解析记录在本地DNS服务器的缓存时间，缓存时间越长更新生效越慢，以秒为单位。如果您的服务地址经常更换，建议TTL值设置相对小些，反之，建议设置相对大些。  **约束限制**：不涉及  **取值范围**：1-2147483647  **默认取值**：300
        /// </summary>
        [JsonProperty("public_dns_record_set_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicDnsRecordSetTtl { get; set; }

        /// <summary>
        /// **参数解释**：是否配置私网域名。  **约束限制**：不涉及  **取值范围**： true：开启私网域名 false：关闭私网域名  **默认取值**：false
        /// </summary>
        [JsonProperty("private_domain_name_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateDomainNameEnable { get; set; }

        /// <summary>
        /// **参数解释**：私网域名所使用的zone的名称。  **约束限制**：   只有当private_domain_name_enable打开时，该字段才有效。   当private_domain_name_enable打开时，该字段不能置空。   所填的私网zone必须在云解析服务已注册过。   私网域名既能使用公网zone，也能使用私网zone，zone的类型在private_dns_zone_type字段中指定。  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("private_dns_zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateDnsZoneName { get; set; }

        /// <summary>
        /// **参数解释**：私网域名所使用的zone的类型。  **约束限制**：不涉及  **取值范围**： private: 使用私网zone public: 使用公网zone  **默认取值**：private
        /// </summary>
        [JsonProperty("private_dns_zone_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateDnsZoneType { get; set; }

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
            sb.Append("class UserDefinedDnsConfigRequestBody {\n");
            sb.Append("  publicDomainNameEnable: ").Append(PublicDomainNameEnable).Append("\n");
            sb.Append("  publicDnsZoneName: ").Append(PublicDnsZoneName).Append("\n");
            sb.Append("  publicDnsRecordSetTtl: ").Append(PublicDnsRecordSetTtl).Append("\n");
            sb.Append("  privateDomainNameEnable: ").Append(PrivateDomainNameEnable).Append("\n");
            sb.Append("  privateDnsZoneName: ").Append(PrivateDnsZoneName).Append("\n");
            sb.Append("  privateDnsZoneType: ").Append(PrivateDnsZoneType).Append("\n");
            sb.Append("  privateDnsRecordSetTtl: ").Append(PrivateDnsRecordSetTtl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserDefinedDnsConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserDefinedDnsConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.PublicDomainNameEnable != input.PublicDomainNameEnable || (this.PublicDomainNameEnable != null && !this.PublicDomainNameEnable.Equals(input.PublicDomainNameEnable))) return false;
            if (this.PublicDnsZoneName != input.PublicDnsZoneName || (this.PublicDnsZoneName != null && !this.PublicDnsZoneName.Equals(input.PublicDnsZoneName))) return false;
            if (this.PublicDnsRecordSetTtl != input.PublicDnsRecordSetTtl || (this.PublicDnsRecordSetTtl != null && !this.PublicDnsRecordSetTtl.Equals(input.PublicDnsRecordSetTtl))) return false;
            if (this.PrivateDomainNameEnable != input.PrivateDomainNameEnable || (this.PrivateDomainNameEnable != null && !this.PrivateDomainNameEnable.Equals(input.PrivateDomainNameEnable))) return false;
            if (this.PrivateDnsZoneName != input.PrivateDnsZoneName || (this.PrivateDnsZoneName != null && !this.PrivateDnsZoneName.Equals(input.PrivateDnsZoneName))) return false;
            if (this.PrivateDnsZoneType != input.PrivateDnsZoneType || (this.PrivateDnsZoneType != null && !this.PrivateDnsZoneType.Equals(input.PrivateDnsZoneType))) return false;
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
                if (this.PublicDomainNameEnable != null) hashCode = hashCode * 59 + this.PublicDomainNameEnable.GetHashCode();
                if (this.PublicDnsZoneName != null) hashCode = hashCode * 59 + this.PublicDnsZoneName.GetHashCode();
                if (this.PublicDnsRecordSetTtl != null) hashCode = hashCode * 59 + this.PublicDnsRecordSetTtl.GetHashCode();
                if (this.PrivateDomainNameEnable != null) hashCode = hashCode * 59 + this.PrivateDomainNameEnable.GetHashCode();
                if (this.PrivateDnsZoneName != null) hashCode = hashCode * 59 + this.PrivateDnsZoneName.GetHashCode();
                if (this.PrivateDnsZoneType != null) hashCode = hashCode * 59 + this.PrivateDnsZoneType.GetHashCode();
                if (this.PrivateDnsRecordSetTtl != null) hashCode = hashCode * 59 + this.PrivateDnsRecordSetTtl.GetHashCode();
                return hashCode;
            }
        }
    }
}
