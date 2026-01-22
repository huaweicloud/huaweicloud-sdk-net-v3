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
    /// **参数解释**： vpc protects vo **取值范围**： 不涉及
    /// </summary>
    public class VPCProtectsVo 
    {

        /// <summary>
        /// **参数解释**： 总防护VPC数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙东西向防护可进行跨账号防护VPC，self_total表示本项目防护VPC总数。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("self_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? SelfTotal { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙东西向防护可进行跨账号防护VPC，other_total表示其他项目防护VPC数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("other_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? OtherTotal { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙东西向防护可进行跨账号防护VPC，protect_vpcs表示总体防护VPC列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protect_vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcAttachmentDetail> ProtectVpcs { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙东西向防护可进行跨账号防护VPC，self_protect_vpcs表示本项目防护VPC列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("self_protect_vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcAttachmentDetail> SelfProtectVpcs { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙东西向防护可进行跨账号防护VPC，other_protect_vpcs表示其他项目防护VPC列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("other_protect_vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcAttachmentDetail> OtherProtectVpcs { get; set; }

        /// <summary>
        /// **参数解释**： 租户的所有VPC资产数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("total_assets", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalAssets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VPCProtectsVo {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  selfTotal: ").Append(SelfTotal).Append("\n");
            sb.Append("  otherTotal: ").Append(OtherTotal).Append("\n");
            sb.Append("  protectVpcs: ").Append(ProtectVpcs).Append("\n");
            sb.Append("  selfProtectVpcs: ").Append(SelfProtectVpcs).Append("\n");
            sb.Append("  otherProtectVpcs: ").Append(OtherProtectVpcs).Append("\n");
            sb.Append("  totalAssets: ").Append(TotalAssets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VPCProtectsVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VPCProtectsVo input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.SelfTotal != input.SelfTotal || (this.SelfTotal != null && !this.SelfTotal.Equals(input.SelfTotal))) return false;
            if (this.OtherTotal != input.OtherTotal || (this.OtherTotal != null && !this.OtherTotal.Equals(input.OtherTotal))) return false;
            if (this.ProtectVpcs != input.ProtectVpcs || (this.ProtectVpcs != null && input.ProtectVpcs != null && !this.ProtectVpcs.SequenceEqual(input.ProtectVpcs))) return false;
            if (this.SelfProtectVpcs != input.SelfProtectVpcs || (this.SelfProtectVpcs != null && input.SelfProtectVpcs != null && !this.SelfProtectVpcs.SequenceEqual(input.SelfProtectVpcs))) return false;
            if (this.OtherProtectVpcs != input.OtherProtectVpcs || (this.OtherProtectVpcs != null && input.OtherProtectVpcs != null && !this.OtherProtectVpcs.SequenceEqual(input.OtherProtectVpcs))) return false;
            if (this.TotalAssets != input.TotalAssets || (this.TotalAssets != null && !this.TotalAssets.Equals(input.TotalAssets))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.SelfTotal != null) hashCode = hashCode * 59 + this.SelfTotal.GetHashCode();
                if (this.OtherTotal != null) hashCode = hashCode * 59 + this.OtherTotal.GetHashCode();
                if (this.ProtectVpcs != null) hashCode = hashCode * 59 + this.ProtectVpcs.GetHashCode();
                if (this.SelfProtectVpcs != null) hashCode = hashCode * 59 + this.SelfProtectVpcs.GetHashCode();
                if (this.OtherProtectVpcs != null) hashCode = hashCode * 59 + this.OtherProtectVpcs.GetHashCode();
                if (this.TotalAssets != null) hashCode = hashCode * 59 + this.TotalAssets.GetHashCode();
                return hashCode;
            }
        }
    }
}
