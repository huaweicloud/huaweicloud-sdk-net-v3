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
    /// 参数解释：创建ELB时，新建公网IP请求参数
    /// </summary>
    public class CreateLoadBalancerPublicIpOption 
    {

        /// <summary>
        /// 参数解释：IP版本。  约束限制：取值只有4和6。4：IPv4, 6: IPv6。 [不支持IPv6，请勿设置为6。](tag:dt)  取值范围：  - 4：表示IPv4。  - 6：表示IPv6。  默认取值：4
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// 参数解释：弹性公网IP的网络类型，默认5_bgp，更多请参考弹性公网ip创建。  [约束限制：华南-深圳局点该参数取值只能为5_gray。](tag:hws) [约束限制：只支持设置为5_gray。](tag:dt)  取值范围：5_bgp。  默认取值：5_bgp。
        /// </summary>
        [JsonProperty("network_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkType { get; set; }

        /// <summary>
        /// 参数解释：计费订单信息。  约束限制： - 空：按需计费。 [ - 非空：包周期计费。格式：order_id:product_id:region_id:project_id ](tag:hws)  [不支持该字段，请勿使用。](tag:hws_hk,hws_eu,hws_eu_wb,hws_test,srg,fcs,fcs_vm,dt,ctc,cmcc,tm,sbc,hk_sbc,hk_tm,hk_vdf,ct)
        /// </summary>
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// 参数解释：弹性公网IP的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public CreateLoadBalancerBandwidthOption Bandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoadBalancerPublicIpOption {\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  networkType: ").Append(NetworkType).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoadBalancerPublicIpOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoadBalancerPublicIpOption input)
        {
            if (input == null) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;
            if (this.NetworkType != input.NetworkType || (this.NetworkType != null && !this.NetworkType.Equals(input.NetworkType))) return false;
            if (this.BillingInfo != input.BillingInfo || (this.BillingInfo != null && !this.BillingInfo.Equals(input.BillingInfo))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;

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
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.NetworkType != null) hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.BillingInfo != null) hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
