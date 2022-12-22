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
    /// vpc protects vo
    /// </summary>
    public class VPCProtectsVo 
    {

        /// <summary>
        /// 总VPC数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 本项目防护VPC数
        /// </summary>
        [JsonProperty("self_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? SelfTotal { get; set; }

        /// <summary>
        /// 其他项目防护VPC数
        /// </summary>
        [JsonProperty("other_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? OtherTotal { get; set; }

        /// <summary>
        /// 防护VPC
        /// </summary>
        [JsonProperty("protect_vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcAttachmentDetail> ProtectVpcs { get; set; }

        /// <summary>
        /// 本项目防护VPC
        /// </summary>
        [JsonProperty("self_protect_vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcAttachmentDetail> SelfProtectVpcs { get; set; }

        /// <summary>
        /// 其他项目防护VPC
        /// </summary>
        [JsonProperty("other_protect_vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcAttachmentDetail> OtherProtectVpcs { get; set; }


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
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.SelfTotal == input.SelfTotal ||
                    (this.SelfTotal != null &&
                    this.SelfTotal.Equals(input.SelfTotal))
                ) && 
                (
                    this.OtherTotal == input.OtherTotal ||
                    (this.OtherTotal != null &&
                    this.OtherTotal.Equals(input.OtherTotal))
                ) && 
                (
                    this.ProtectVpcs == input.ProtectVpcs ||
                    this.ProtectVpcs != null &&
                    input.ProtectVpcs != null &&
                    this.ProtectVpcs.SequenceEqual(input.ProtectVpcs)
                ) && 
                (
                    this.SelfProtectVpcs == input.SelfProtectVpcs ||
                    this.SelfProtectVpcs != null &&
                    input.SelfProtectVpcs != null &&
                    this.SelfProtectVpcs.SequenceEqual(input.SelfProtectVpcs)
                ) && 
                (
                    this.OtherProtectVpcs == input.OtherProtectVpcs ||
                    this.OtherProtectVpcs != null &&
                    input.OtherProtectVpcs != null &&
                    this.OtherProtectVpcs.SequenceEqual(input.OtherProtectVpcs)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.SelfTotal != null)
                    hashCode = hashCode * 59 + this.SelfTotal.GetHashCode();
                if (this.OtherTotal != null)
                    hashCode = hashCode * 59 + this.OtherTotal.GetHashCode();
                if (this.ProtectVpcs != null)
                    hashCode = hashCode * 59 + this.ProtectVpcs.GetHashCode();
                if (this.SelfProtectVpcs != null)
                    hashCode = hashCode * 59 + this.SelfProtectVpcs.GetHashCode();
                if (this.OtherProtectVpcs != null)
                    hashCode = hashCode * 59 + this.OtherProtectVpcs.GetHashCode();
                return hashCode;
            }
        }
    }
}
