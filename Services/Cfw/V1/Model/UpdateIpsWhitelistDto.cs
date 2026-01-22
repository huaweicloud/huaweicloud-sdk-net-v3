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
    /// **参数解释**：  更新ips白名单请求体 **约束限制**：  不涉及  **取值范围**： 不涉及  **默认取值**：  不涉及
    /// </summary>
    public class UpdateIpsWhitelistDto 
    {

        /// <summary>
        /// **参数解释**： 白名单源地址 **约束限制**： 不涉及  **取值范围**： 不涉及  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("source_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// **参数解释**：  目的地址  **约束限制**：  不涉及  **取值范围**：  不涉及  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("dest_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DestAddress { get; set; }

        /// <summary>
        /// **参数解释**：  IP类型 **约束限制**：  不涉及  **取值范围**：  4：表示IP类型为IPv4 6：表示IP类型为IPv6 **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// **参数解释**：  白名单名称  **约束限制**：  不涉及  **取值范围**： 不涉及  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  ips规则id，不填写时默认为全部ips规则  **约束限制**：  不涉及  **取值范围**： 不涉及  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("ips_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsId { get; set; }

        /// <summary>
        /// **参数解释**：  生效范围：NAT EIP VPC HCS场景中还有VGW信息  **约束限制**：  不涉及  **取值范围**： 不涉及  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("effective_scopes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EffectiveScopes { get; set; }

        /// <summary>
        /// **参数解释**：  白名单描述  **约束限制**：  不涉及  **取值范围**： 不涉及  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateIpsWhitelistDto {\n");
            sb.Append("  sourceAddress: ").Append(SourceAddress).Append("\n");
            sb.Append("  destAddress: ").Append(DestAddress).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  ipsId: ").Append(IpsId).Append("\n");
            sb.Append("  effectiveScopes: ").Append(EffectiveScopes).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateIpsWhitelistDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateIpsWhitelistDto input)
        {
            if (input == null) return false;
            if (this.SourceAddress != input.SourceAddress || (this.SourceAddress != null && !this.SourceAddress.Equals(input.SourceAddress))) return false;
            if (this.DestAddress != input.DestAddress || (this.DestAddress != null && !this.DestAddress.Equals(input.DestAddress))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.IpsId != input.IpsId || (this.IpsId != null && !this.IpsId.Equals(input.IpsId))) return false;
            if (this.EffectiveScopes != input.EffectiveScopes || (this.EffectiveScopes != null && input.EffectiveScopes != null && !this.EffectiveScopes.SequenceEqual(input.EffectiveScopes))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.SourceAddress != null) hashCode = hashCode * 59 + this.SourceAddress.GetHashCode();
                if (this.DestAddress != null) hashCode = hashCode * 59 + this.DestAddress.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IpsId != null) hashCode = hashCode * 59 + this.IpsId.GetHashCode();
                if (this.EffectiveScopes != null) hashCode = hashCode * 59 + this.EffectiveScopes.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
