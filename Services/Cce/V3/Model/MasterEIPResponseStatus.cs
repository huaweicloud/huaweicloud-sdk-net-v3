using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MasterEIPResponseStatus 
    {

        /// <summary>
        /// 集群访问的PrivateIP(HA集群返回VIP)
        /// </summary>
        [JsonProperty("privateEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateEndpoint { get; set; }

        /// <summary>
        /// 集群访问的PublicIP
        /// </summary>
        [JsonProperty("publicEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicEndpoint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MasterEIPResponseStatus {\n");
            sb.Append("  privateEndpoint: ").Append(PrivateEndpoint).Append("\n");
            sb.Append("  publicEndpoint: ").Append(PublicEndpoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MasterEIPResponseStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MasterEIPResponseStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrivateEndpoint == input.PrivateEndpoint ||
                    (this.PrivateEndpoint != null &&
                    this.PrivateEndpoint.Equals(input.PrivateEndpoint))
                ) && 
                (
                    this.PublicEndpoint == input.PublicEndpoint ||
                    (this.PublicEndpoint != null &&
                    this.PublicEndpoint.Equals(input.PublicEndpoint))
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
                if (this.PrivateEndpoint != null)
                    hashCode = hashCode * 59 + this.PrivateEndpoint.GetHashCode();
                if (this.PublicEndpoint != null)
                    hashCode = hashCode * 59 + this.PublicEndpoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
