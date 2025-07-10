using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplyInternetReq 
    {

        /// <summary>
        /// 公网NAT网关的规格，1：小型，2：中型，3：大型，4：超大型。
        /// </summary>
        [JsonProperty("nat_spec", NullValueHandling = NullValueHandling.Ignore)]
        public string NatSpec { get; set; }

        /// <summary>
        /// traffic（按流量计费），bandwidth（按带宽计费）。
        /// </summary>
        [JsonProperty("eip_charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string EipChargeMode { get; set; }

        /// <summary>
        /// 带宽大小。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthSize { get; set; }

        /// <summary>
        /// EIP的类型，5_bgp（全动态BGP），5_sbgp（静态BGP），默认值：5_bgp。
        /// </summary>
        [JsonProperty("eip_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EipType { get; set; }

        /// <summary>
        /// vpc的id。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网的id。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 企业项目ID，默认\&quot;0。\&quot;
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// nat的id，有传则使用该NAT，否则新建。
        /// </summary>
        [JsonProperty("nat_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NatId { get; set; }

        /// <summary>
        /// nat名称，默认值：nat-workspace。
        /// </summary>
        [JsonProperty("nat_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NatName { get; set; }

        /// <summary>
        /// eip名称，默认值：eip-workspace。
        /// </summary>
        [JsonProperty("eip_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EipName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyInternetReq {\n");
            sb.Append("  natSpec: ").Append(NatSpec).Append("\n");
            sb.Append("  eipChargeMode: ").Append(EipChargeMode).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  eipType: ").Append(EipType).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  natId: ").Append(NatId).Append("\n");
            sb.Append("  natName: ").Append(NatName).Append("\n");
            sb.Append("  eipName: ").Append(EipName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyInternetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyInternetReq input)
        {
            if (input == null) return false;
            if (this.NatSpec != input.NatSpec || (this.NatSpec != null && !this.NatSpec.Equals(input.NatSpec))) return false;
            if (this.EipChargeMode != input.EipChargeMode || (this.EipChargeMode != null && !this.EipChargeMode.Equals(input.EipChargeMode))) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.EipType != input.EipType || (this.EipType != null && !this.EipType.Equals(input.EipType))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.NatId != input.NatId || (this.NatId != null && !this.NatId.Equals(input.NatId))) return false;
            if (this.NatName != input.NatName || (this.NatName != null && !this.NatName.Equals(input.NatName))) return false;
            if (this.EipName != input.EipName || (this.EipName != null && !this.EipName.Equals(input.EipName))) return false;

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
                if (this.NatSpec != null) hashCode = hashCode * 59 + this.NatSpec.GetHashCode();
                if (this.EipChargeMode != null) hashCode = hashCode * 59 + this.EipChargeMode.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                if (this.EipType != null) hashCode = hashCode * 59 + this.EipType.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.NatId != null) hashCode = hashCode * 59 + this.NatId.GetHashCode();
                if (this.NatName != null) hashCode = hashCode * 59 + this.NatName.GetHashCode();
                if (this.EipName != null) hashCode = hashCode * 59 + this.EipName.GetHashCode();
                return hashCode;
            }
        }
    }
}
