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
    /// **参数解释：** DNS批量查询接口支持响应的维度。 **取值范围：** - dns_public_zone_id：公网域名ID - dns_public_recordset_id：公网记录集ID，需与dns_public_zone_id组合使用 - dns_private_zone_id：内网域名ID - vpc_id：VPC ID，需与dns_private_zone_id组合使用
    /// </summary>
    public class ResolutionInstances 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dns_public_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public ZoneResolutionInstances DnsPublicZoneId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dns_public_recordset_id", NullValueHandling = NullValueHandling.Ignore)]
        public RsetResolutionInstances DnsPublicRecordsetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dns_private_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public ZoneResolutionInstances DnsPrivateZoneId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public VpcResolutionInstances VpcId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResolutionInstances {\n");
            sb.Append("  dnsPublicZoneId: ").Append(DnsPublicZoneId).Append("\n");
            sb.Append("  dnsPublicRecordsetId: ").Append(DnsPublicRecordsetId).Append("\n");
            sb.Append("  dnsPrivateZoneId: ").Append(DnsPrivateZoneId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResolutionInstances);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResolutionInstances input)
        {
            if (input == null) return false;
            if (this.DnsPublicZoneId != input.DnsPublicZoneId || (this.DnsPublicZoneId != null && !this.DnsPublicZoneId.Equals(input.DnsPublicZoneId))) return false;
            if (this.DnsPublicRecordsetId != input.DnsPublicRecordsetId || (this.DnsPublicRecordsetId != null && !this.DnsPublicRecordsetId.Equals(input.DnsPublicRecordsetId))) return false;
            if (this.DnsPrivateZoneId != input.DnsPrivateZoneId || (this.DnsPrivateZoneId != null && !this.DnsPrivateZoneId.Equals(input.DnsPrivateZoneId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;

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
                if (this.DnsPublicZoneId != null) hashCode = hashCode * 59 + this.DnsPublicZoneId.GetHashCode();
                if (this.DnsPublicRecordsetId != null) hashCode = hashCode * 59 + this.DnsPublicRecordsetId.GetHashCode();
                if (this.DnsPrivateZoneId != null) hashCode = hashCode * 59 + this.DnsPrivateZoneId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                return hashCode;
            }
        }
    }
}
