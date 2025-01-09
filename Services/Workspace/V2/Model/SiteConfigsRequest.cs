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
    public class SiteConfigsRequest 
    {

        /// <summary>
        /// 开通服务资源使用的可用分区
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_config", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkConfigReq NetworkConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_config", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigReq AccessConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteConfigsRequest {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  networkConfig: ").Append(NetworkConfig).Append("\n");
            sb.Append("  accessConfig: ").Append(AccessConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SiteConfigsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SiteConfigsRequest input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.NetworkConfig != input.NetworkConfig || (this.NetworkConfig != null && !this.NetworkConfig.Equals(input.NetworkConfig))) return false;
            if (this.AccessConfig != input.AccessConfig || (this.AccessConfig != null && !this.AccessConfig.Equals(input.AccessConfig))) return false;

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
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.NetworkConfig != null) hashCode = hashCode * 59 + this.NetworkConfig.GetHashCode();
                if (this.AccessConfig != null) hashCode = hashCode * 59 + this.AccessConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
