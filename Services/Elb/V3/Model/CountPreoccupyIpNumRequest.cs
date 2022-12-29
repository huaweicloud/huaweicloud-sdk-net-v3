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
        /// 负载均衡器七层规格的ID。传入该字段表示计算创建该规格的LB，或变更LB的原七层规格到该规格所需要的预占IP。  适用场景：创建负LB，变更LB规格。  [不支持传入l7_flavor_id](tag:fcs)
        /// </summary>
        [SDKProperty("l7_flavor_id", IsQuery = true)]
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// 是否开启跨VPC转发。  取值true表示计算创建或变更为开启跨VPC转发的LB的预占IP。  取值false表示计算创建或变更为不开启跨VPC转发的LB的预占IP。不传等价false。  适用场景：创建LB，变更LB规格。  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [SDKProperty("ip_target_enable", IsQuery = true)]
        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        /// <summary>
        /// 负载均衡器IP地址类型，取值4，6 。  取值4表示计算创建支持IPv4地址的LB的预占IP。  取值6表示计算创建支持IPv6地址的LB的预占IP。  适用场景：创建LB。  [不支持IPv6，请勿设置为6。](tag:dt,dt_test)
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// 负载均衡器ID。计算LB规格变更或创建LB中的第一个七层监听器的预占IP。  适用场景：变更LB规格，创建LB中的第一个七层监听器。
        /// </summary>
        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// 计算创建AZ列表为availability_zone_id的负载局衡器实例的预占IP。  适用场景：创建LB。  使用说明：传入loadbalancer_id时，该参数无效。
        /// </summary>
        [SDKProperty("availability_zone_id", IsQuery = true)]
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountPreoccupyIpNumRequest {\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  ipTargetEnable: ").Append(IpTargetEnable).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
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
                    this.L7FlavorId == input.L7FlavorId ||
                    (this.L7FlavorId != null &&
                    this.L7FlavorId.Equals(input.L7FlavorId))
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
                    this.LoadbalancerId == input.LoadbalancerId ||
                    (this.LoadbalancerId != null &&
                    this.LoadbalancerId.Equals(input.LoadbalancerId))
                ) && 
                (
                    this.AvailabilityZoneId == input.AvailabilityZoneId ||
                    this.AvailabilityZoneId != null &&
                    input.AvailabilityZoneId != null &&
                    this.AvailabilityZoneId.SequenceEqual(input.AvailabilityZoneId)
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
                if (this.L7FlavorId != null)
                    hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.IpTargetEnable != null)
                    hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.AvailabilityZoneId != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
