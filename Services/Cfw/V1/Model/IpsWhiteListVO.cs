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
    public class IpsWhiteListVO 
    {

        /// <summary>
        /// **参数解释**： 白名单源地址 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("source_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// **参数解释**：  目的地址  **取值范围**：  不涉及
        /// </summary>
        [JsonProperty("dest_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DestAddress { get; set; }

        /// <summary>
        /// **参数解释**：  白名单名称  **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  IPS白名单ID  **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("list_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListId { get; set; }

        /// <summary>
        /// **参数解释**：  生效范围：NAT EIP VPC HCS场景中还有VGW信息  **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("effective_scopes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EffectiveScopes { get; set; }

        /// <summary>
        /// **参数解释**：  生效范围：IPS规则ID，all代表所有IPS **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ips_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsId { get; set; }

        /// <summary>
        /// **参数解释**：  IP类型 **取值范围**：  4：表示IP类型为IPv4 6：表示IP类型为IPv6
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// **参数解释**：  白名单描述 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsWhiteListVO {\n");
            sb.Append("  sourceAddress: ").Append(SourceAddress).Append("\n");
            sb.Append("  destAddress: ").Append(DestAddress).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  listId: ").Append(ListId).Append("\n");
            sb.Append("  effectiveScopes: ").Append(EffectiveScopes).Append("\n");
            sb.Append("  ipsId: ").Append(IpsId).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsWhiteListVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsWhiteListVO input)
        {
            if (input == null) return false;
            if (this.SourceAddress != input.SourceAddress || (this.SourceAddress != null && !this.SourceAddress.Equals(input.SourceAddress))) return false;
            if (this.DestAddress != input.DestAddress || (this.DestAddress != null && !this.DestAddress.Equals(input.DestAddress))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ListId != input.ListId || (this.ListId != null && !this.ListId.Equals(input.ListId))) return false;
            if (this.EffectiveScopes != input.EffectiveScopes || (this.EffectiveScopes != null && input.EffectiveScopes != null && !this.EffectiveScopes.SequenceEqual(input.EffectiveScopes))) return false;
            if (this.IpsId != input.IpsId || (this.IpsId != null && !this.IpsId.Equals(input.IpsId))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ListId != null) hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.EffectiveScopes != null) hashCode = hashCode * 59 + this.EffectiveScopes.GetHashCode();
                if (this.IpsId != null) hashCode = hashCode * 59 + this.IpsId.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
