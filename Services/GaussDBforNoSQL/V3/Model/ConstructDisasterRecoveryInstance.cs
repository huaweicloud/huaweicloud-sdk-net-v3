using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConstructDisasterRecoveryInstance 
    {

        /// <summary>
        /// 容灾实例的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 容灾实例所在Region的code。
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 与当前实例建立容灾关系实例所在子网的CIDR列表。
        /// </summary>
        [JsonProperty("subnet_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetCidrs { get; set; }

        /// <summary>
        /// 与当前实例建立容灾关系实例的所有节点的IP列表。
        /// </summary>
        [JsonProperty("node_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructDisasterRecoveryInstance {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  subnetCidrs: ").Append(SubnetCidrs).Append("\n");
            sb.Append("  nodeIps: ").Append(NodeIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConstructDisasterRecoveryInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConstructDisasterRecoveryInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RegionCode == input.RegionCode ||
                    (this.RegionCode != null &&
                    this.RegionCode.Equals(input.RegionCode))
                ) && 
                (
                    this.SubnetCidrs == input.SubnetCidrs ||
                    this.SubnetCidrs != null &&
                    input.SubnetCidrs != null &&
                    this.SubnetCidrs.SequenceEqual(input.SubnetCidrs)
                ) && 
                (
                    this.NodeIps == input.NodeIps ||
                    this.NodeIps != null &&
                    input.NodeIps != null &&
                    this.NodeIps.SequenceEqual(input.NodeIps)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RegionCode != null)
                    hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.SubnetCidrs != null)
                    hashCode = hashCode * 59 + this.SubnetCidrs.GetHashCode();
                if (this.NodeIps != null)
                    hashCode = hashCode * 59 + this.NodeIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
