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
    /// 私网网段的详细信息，会将参数中conf_id的私网网段信息覆盖更新
    /// </summary>
    public class PrivateNetworkSegmentVO 
    {

        /// <summary>
        /// **参数解释**： 私网网段ID，更新私网网段时需要 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("conf_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfId { get; set; }

        /// <summary>
        /// **参数解释**： 私网网段，格式为：IP/Mask **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("protect_network", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectNetwork { get; set; }

        /// <summary>
        /// **参数解释**： 私网网段的可用区信息，如AZ1 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("az_info", NullValueHandling = NullValueHandling.Ignore)]
        public string AzInfo { get; set; }

        /// <summary>
        /// **参数解释**： 子网名称 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("subnet_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateNetworkSegmentVO {\n");
            sb.Append("  confId: ").Append(ConfId).Append("\n");
            sb.Append("  protectNetwork: ").Append(ProtectNetwork).Append("\n");
            sb.Append("  azInfo: ").Append(AzInfo).Append("\n");
            sb.Append("  subnetName: ").Append(SubnetName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateNetworkSegmentVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateNetworkSegmentVO input)
        {
            if (input == null) return false;
            if (this.ConfId != input.ConfId || (this.ConfId != null && !this.ConfId.Equals(input.ConfId))) return false;
            if (this.ProtectNetwork != input.ProtectNetwork || (this.ProtectNetwork != null && !this.ProtectNetwork.Equals(input.ProtectNetwork))) return false;
            if (this.AzInfo != input.AzInfo || (this.AzInfo != null && !this.AzInfo.Equals(input.AzInfo))) return false;
            if (this.SubnetName != input.SubnetName || (this.SubnetName != null && !this.SubnetName.Equals(input.SubnetName))) return false;

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
                if (this.ConfId != null) hashCode = hashCode * 59 + this.ConfId.GetHashCode();
                if (this.ProtectNetwork != null) hashCode = hashCode * 59 + this.ProtectNetwork.GetHashCode();
                if (this.AzInfo != null) hashCode = hashCode * 59 + this.AzInfo.GetHashCode();
                if (this.SubnetName != null) hashCode = hashCode * 59 + this.SubnetName.GetHashCode();
                return hashCode;
            }
        }
    }
}
