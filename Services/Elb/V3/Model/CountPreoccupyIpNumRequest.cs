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
    /// Request Object
    /// </summary>
    public class CountPreoccupyIpNumRequest 
    {

        /// <summary>
        /// 功能描述：LB需要部署的AZ列表 约束：若查询创建一个LB所需预占IP数时，该参数为必选
        /// </summary>
        [SDKProperty("availability_zone_id", IsQuery = true)]
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneId { get; set; }

        /// <summary>
        /// 是否启用跨VPC后端转发
        /// </summary>
        [SDKProperty("ip_target_enable", IsQuery = true)]
        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        /// <summary>
        /// 负载均衡器网络类型，枚举值4，6
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// 七层Flavor的ID。如果欲创建7层规格的弹性负载均衡实例，则该参数为必选
        /// </summary>
        [SDKProperty("l7_flavor_id", IsQuery = true)]
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// 负载均衡器ID。当查询创建第一个七层监听器所需预占的ip数时，该参数为必选。
        /// </summary>
        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountPreoccupyIpNumRequest {\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("  ipTargetEnable: ").Append(IpTargetEnable).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountPreoccupyIpNumRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountPreoccupyIpNumRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilityZoneId == input.AvailabilityZoneId ||
                    this.AvailabilityZoneId != null &&
                    input.AvailabilityZoneId != null &&
                    this.AvailabilityZoneId.SequenceEqual(input.AvailabilityZoneId)
                ) && 
                (
                    this.IpTargetEnable == input.IpTargetEnable ||
                    (this.IpTargetEnable != null &&
                    this.IpTargetEnable.Equals(input.IpTargetEnable))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.L7FlavorId == input.L7FlavorId ||
                    (this.L7FlavorId != null &&
                    this.L7FlavorId.Equals(input.L7FlavorId))
                ) && 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    (this.LoadbalancerId != null &&
                    this.LoadbalancerId.Equals(input.LoadbalancerId))
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
                if (this.AvailabilityZoneId != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.IpTargetEnable != null)
                    hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.L7FlavorId != null)
                    hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
