using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NetworkIpAvailability 
    {

        /// <summary>
        /// 网络ID
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        /// <summary>
        /// 网络名称
        /// </summary>
        [JsonProperty("network_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkName { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 网络中IP总数（不包含系统预留地址）
        /// </summary>
        [JsonProperty("total_ips", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalIps { get; set; }

        /// <summary>
        /// 网络中已经使用的IP数目（不包含系统预留地址）
        /// </summary>
        [JsonProperty("used_ips", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedIps { get; set; }

        /// <summary>
        /// 子网IP使用情况的对象
        /// </summary>
        [JsonProperty("subnet_ip_availability", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubnetIpAvailability> SubnetIpAvailability { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkIpAvailability {\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  networkName: ").Append(NetworkName).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  totalIps: ").Append(TotalIps).Append("\n");
            sb.Append("  usedIps: ").Append(UsedIps).Append("\n");
            sb.Append("  subnetIpAvailability: ").Append(SubnetIpAvailability).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkIpAvailability);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkIpAvailability input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.NetworkName == input.NetworkName ||
                    (this.NetworkName != null &&
                    this.NetworkName.Equals(input.NetworkName))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.TotalIps == input.TotalIps ||
                    (this.TotalIps != null &&
                    this.TotalIps.Equals(input.TotalIps))
                ) && 
                (
                    this.UsedIps == input.UsedIps ||
                    (this.UsedIps != null &&
                    this.UsedIps.Equals(input.UsedIps))
                ) && 
                (
                    this.SubnetIpAvailability == input.SubnetIpAvailability ||
                    this.SubnetIpAvailability != null &&
                    input.SubnetIpAvailability != null &&
                    this.SubnetIpAvailability.SequenceEqual(input.SubnetIpAvailability)
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
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.NetworkName != null)
                    hashCode = hashCode * 59 + this.NetworkName.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TotalIps != null)
                    hashCode = hashCode * 59 + this.TotalIps.GetHashCode();
                if (this.UsedIps != null)
                    hashCode = hashCode * 59 + this.UsedIps.GetHashCode();
                if (this.SubnetIpAvailability != null)
                    hashCode = hashCode * 59 + this.SubnetIpAvailability.GetHashCode();
                return hashCode;
            }
        }
    }
}
