using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5.Model
{
    /// <summary>
    /// 企业版附加参数信息。 
    /// </summary>
    public class AdditionalParamsResp 
    {

        /// <summary>
        /// **参数说明**：企业版实例的VPCID 
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数说明**：企业版实例的子网ID 
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// **参数说明**：企业版实例的安全组ID 
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// **参数说明**：实例支持的加密算法 **取值范围**： - COMMON_ALGORITHM: 通用加密算法（支持RSA，SHA256等国际通用的密码算法） - SM_ALGORITHM: 支持SM系列商密算法（支持SM2，SM3，SM4等国密算法） 
        /// </summary>
        [JsonProperty("ciphering_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string CipheringAlgorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("forwarding_info", NullValueHandling = NullValueHandling.Ignore)]
        public ForwardingInfo ForwardingInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalParamsResp {\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  cipheringAlgorithm: ").Append(CipheringAlgorithm).Append("\n");
            sb.Append("  forwardingInfo: ").Append(ForwardingInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalParamsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdditionalParamsResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.CipheringAlgorithm == input.CipheringAlgorithm ||
                    (this.CipheringAlgorithm != null &&
                    this.CipheringAlgorithm.Equals(input.CipheringAlgorithm))
                ) && 
                (
                    this.ForwardingInfo == input.ForwardingInfo ||
                    (this.ForwardingInfo != null &&
                    this.ForwardingInfo.Equals(input.ForwardingInfo))
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
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.CipheringAlgorithm != null)
                    hashCode = hashCode * 59 + this.CipheringAlgorithm.GetHashCode();
                if (this.ForwardingInfo != null)
                    hashCode = hashCode * 59 + this.ForwardingInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
