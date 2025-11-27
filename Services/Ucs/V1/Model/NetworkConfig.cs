using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NetworkConfig 
    {

        /// <summary>
        /// 容器网段
        /// </summary>
        [JsonProperty("podCIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string PodCIDR { get; set; }

        /// <summary>
        /// 服务网段
        /// </summary>
        [JsonProperty("serviceCIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceCIDR { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkConfig {\n");
            sb.Append("  podCIDR: ").Append(PodCIDR).Append("\n");
            sb.Append("  serviceCIDR: ").Append(ServiceCIDR).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkConfig input)
        {
            if (input == null) return false;
            if (this.PodCIDR != input.PodCIDR || (this.PodCIDR != null && !this.PodCIDR.Equals(input.PodCIDR))) return false;
            if (this.ServiceCIDR != input.ServiceCIDR || (this.ServiceCIDR != null && !this.ServiceCIDR.Equals(input.ServiceCIDR))) return false;

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
                if (this.PodCIDR != null) hashCode = hashCode * 59 + this.PodCIDR.GetHashCode();
                if (this.ServiceCIDR != null) hashCode = hashCode * 59 + this.ServiceCIDR.GetHashCode();
                return hashCode;
            }
        }
    }
}
