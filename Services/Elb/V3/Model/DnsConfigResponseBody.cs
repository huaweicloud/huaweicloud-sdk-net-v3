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
    /// 配置负载均衡器响应体相关配置参数。
    /// </summary>
    public class DnsConfigResponseBody 
    {

        /// <summary>
        /// **参数解释**：负载均衡器的IPv4虚拟IP地址。
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// **参数解释**：双栈类型负载均衡器的IPv6地址。  **约束限制**：[不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipAddress { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器绑定的EIP。  注：该字段与publicips一致。
        /// </summary>
        [JsonProperty("eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<EipInfo> Eips { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器绑定的GEIP。
        /// </summary>
        [JsonProperty("global_eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<GlobalEipInfo> GlobalEips { get; set; }

        /// <summary>
        /// **参数解释**：是否配置公网域名。 **取值范围**：   true：开启公网域名   false：关闭公网域名
        /// </summary>
        [JsonProperty("public_domain_name_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicDomainNameEnable { get; set; }

        /// <summary>
        /// **参数解释**：公网域名所使用的zone名称。 **约束限制**：   公网域名只能使用公网类型的zone。   当配置公网域名开关打开时，该字段不能置空。   所填的公网zone必须在云解析服务已注册过。
        /// </summary>
        [JsonProperty("public_dns_zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicDnsZoneName { get; set; }

        /// <summary>
        /// **参数解释**：   公网域名所使用的zone对应的id。   根据传入的公网zone 名称查询得出。
        /// </summary>
        [JsonProperty("public_dns_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicDnsZoneId { get; set; }

        /// <summary>
        /// **参数解释**：   负载均衡实例的公网域名。 **约束限制**：   根据负载均衡实例id，局点id和zone信息以如下格式生成：   {lb_id}.elb.{region_id}.{zone_name}
        /// </summary>
        [JsonProperty("public_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicDomainName { get; set; }

        /// <summary>
        /// 参数解释:   公网解析记录集超时时间。   解析记录在本地DNS服务器的缓存时间，缓存时间越长更新生效越慢，以秒为单位。   如果您的服务地址经常更换，建议TTL值设置相对小些，反之，建议设置相对大些。 **取值范围**：   1-2147483647 **默认取值**：   300
        /// </summary>
        [JsonProperty("public_dns_record_set_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicDnsRecordSetTtl { get; set; }

        /// <summary>
        /// **参数解释**：   是否配置私网域名。 **取值范围**：   true：开启私网域名   false：关闭私网域名
        /// </summary>
        [JsonProperty("private_domain_name_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateDomainNameEnable { get; set; }

        /// <summary>
        /// **参数解释**：   私网域名所使用的zone的名称。 **约束限制**：   私网域名既能使用公网zone，也能使用私网zone，zone的类型在private_dns_zone_type字段中指定。   当配置私网域名开关打开时，该字段不能置空。   所填的私网zone必须在云解析服务已注册过。
        /// </summary>
        [JsonProperty("private_dns_zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateDnsZoneName { get; set; }

        /// <summary>
        /// **参数解释**：   私网域名所使用的zone对应的id。 **约束限制**：   根据传入的私网zone 名称查询得出。
        /// </summary>
        [JsonProperty("private_dns_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateDnsZoneId { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡实例的私网域名。 **约束限制**：   根据负载均衡实例id，局点id和zone信息以如下格式生成：   {lb_id}-internal.elb.{region_id}.{zone_name}
        /// </summary>
        [JsonProperty("private_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateDomainName { get; set; }

        /// <summary>
        /// **参数解释**：私网域名所使用的zone的类型。 **约束限制**：不涉及 **取值范围**：private public **默认取值**：private
        /// </summary>
        [JsonProperty("private_dns_zone_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateDnsZoneType { get; set; }

        /// <summary>
        /// **参数解释**：   私网解析记录集超时时间。   解析记录在本地DNS服务器的缓存时间，缓存时间越长更新生效越慢，以秒为单位。   如果您的服务地址经常更换，建议TTL值设置相对小些，反之，建议设置相对大些。 **取值范围**：   1-2147483647 **默认取值**：   300
        /// </summary>
        [JsonProperty("private_dns_record_set_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrivateDnsRecordSetTtl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DnsConfigResponseBody {\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("  eips: ").Append(Eips).Append("\n");
            sb.Append("  globalEips: ").Append(GlobalEips).Append("\n");
            sb.Append("  publicDomainNameEnable: ").Append(PublicDomainNameEnable).Append("\n");
            sb.Append("  publicDnsZoneName: ").Append(PublicDnsZoneName).Append("\n");
            sb.Append("  publicDnsZoneId: ").Append(PublicDnsZoneId).Append("\n");
            sb.Append("  publicDomainName: ").Append(PublicDomainName).Append("\n");
            sb.Append("  publicDnsRecordSetTtl: ").Append(PublicDnsRecordSetTtl).Append("\n");
            sb.Append("  privateDomainNameEnable: ").Append(PrivateDomainNameEnable).Append("\n");
            sb.Append("  privateDnsZoneName: ").Append(PrivateDnsZoneName).Append("\n");
            sb.Append("  privateDnsZoneId: ").Append(PrivateDnsZoneId).Append("\n");
            sb.Append("  privateDomainName: ").Append(PrivateDomainName).Append("\n");
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
            return this.Equals(input as DnsConfigResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DnsConfigResponseBody input)
        {
            if (input == null) return false;
            if (this.VipAddress != input.VipAddress || (this.VipAddress != null && !this.VipAddress.Equals(input.VipAddress))) return false;
            if (this.Ipv6VipAddress != input.Ipv6VipAddress || (this.Ipv6VipAddress != null && !this.Ipv6VipAddress.Equals(input.Ipv6VipAddress))) return false;
            if (this.Eips != input.Eips || (this.Eips != null && input.Eips != null && !this.Eips.SequenceEqual(input.Eips))) return false;
            if (this.GlobalEips != input.GlobalEips || (this.GlobalEips != null && input.GlobalEips != null && !this.GlobalEips.SequenceEqual(input.GlobalEips))) return false;
            if (this.PublicDomainNameEnable != input.PublicDomainNameEnable || (this.PublicDomainNameEnable != null && !this.PublicDomainNameEnable.Equals(input.PublicDomainNameEnable))) return false;
            if (this.PublicDnsZoneName != input.PublicDnsZoneName || (this.PublicDnsZoneName != null && !this.PublicDnsZoneName.Equals(input.PublicDnsZoneName))) return false;
            if (this.PublicDnsZoneId != input.PublicDnsZoneId || (this.PublicDnsZoneId != null && !this.PublicDnsZoneId.Equals(input.PublicDnsZoneId))) return false;
            if (this.PublicDomainName != input.PublicDomainName || (this.PublicDomainName != null && !this.PublicDomainName.Equals(input.PublicDomainName))) return false;
            if (this.PublicDnsRecordSetTtl != input.PublicDnsRecordSetTtl || (this.PublicDnsRecordSetTtl != null && !this.PublicDnsRecordSetTtl.Equals(input.PublicDnsRecordSetTtl))) return false;
            if (this.PrivateDomainNameEnable != input.PrivateDomainNameEnable || (this.PrivateDomainNameEnable != null && !this.PrivateDomainNameEnable.Equals(input.PrivateDomainNameEnable))) return false;
            if (this.PrivateDnsZoneName != input.PrivateDnsZoneName || (this.PrivateDnsZoneName != null && !this.PrivateDnsZoneName.Equals(input.PrivateDnsZoneName))) return false;
            if (this.PrivateDnsZoneId != input.PrivateDnsZoneId || (this.PrivateDnsZoneId != null && !this.PrivateDnsZoneId.Equals(input.PrivateDnsZoneId))) return false;
            if (this.PrivateDomainName != input.PrivateDomainName || (this.PrivateDomainName != null && !this.PrivateDomainName.Equals(input.PrivateDomainName))) return false;
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
                if (this.VipAddress != null) hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.Ipv6VipAddress != null) hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                if (this.Eips != null) hashCode = hashCode * 59 + this.Eips.GetHashCode();
                if (this.GlobalEips != null) hashCode = hashCode * 59 + this.GlobalEips.GetHashCode();
                if (this.PublicDomainNameEnable != null) hashCode = hashCode * 59 + this.PublicDomainNameEnable.GetHashCode();
                if (this.PublicDnsZoneName != null) hashCode = hashCode * 59 + this.PublicDnsZoneName.GetHashCode();
                if (this.PublicDnsZoneId != null) hashCode = hashCode * 59 + this.PublicDnsZoneId.GetHashCode();
                if (this.PublicDomainName != null) hashCode = hashCode * 59 + this.PublicDomainName.GetHashCode();
                if (this.PublicDnsRecordSetTtl != null) hashCode = hashCode * 59 + this.PublicDnsRecordSetTtl.GetHashCode();
                if (this.PrivateDomainNameEnable != null) hashCode = hashCode * 59 + this.PrivateDomainNameEnable.GetHashCode();
                if (this.PrivateDnsZoneName != null) hashCode = hashCode * 59 + this.PrivateDnsZoneName.GetHashCode();
                if (this.PrivateDnsZoneId != null) hashCode = hashCode * 59 + this.PrivateDnsZoneId.GetHashCode();
                if (this.PrivateDomainName != null) hashCode = hashCode * 59 + this.PrivateDomainName.GetHashCode();
                if (this.PrivateDnsZoneType != null) hashCode = hashCode * 59 + this.PrivateDnsZoneType.GetHashCode();
                if (this.PrivateDnsRecordSetTtl != null) hashCode = hashCode * 59 + this.PrivateDnsRecordSetTtl.GetHashCode();
                return hashCode;
            }
        }
    }
}
