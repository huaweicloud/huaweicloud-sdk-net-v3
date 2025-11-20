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
    /// **参数解释**： 状态信息 **约束限制**： 不涉及 
    /// </summary>
    public class MasterEIPResponseStatus 
    {

        /// <summary>
        /// **参数解释**： 集群访问的PrivateIP(HA集群返回VIP) **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("privateEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateEndpoint { get; set; }

        /// <summary>
        /// **参数解释**： 集群访问的PublicIP **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
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
            if (input == null) return false;
            if (this.PrivateEndpoint != input.PrivateEndpoint || (this.PrivateEndpoint != null && !this.PrivateEndpoint.Equals(input.PrivateEndpoint))) return false;
            if (this.PublicEndpoint != input.PublicEndpoint || (this.PublicEndpoint != null && !this.PublicEndpoint.Equals(input.PublicEndpoint))) return false;

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
                if (this.PrivateEndpoint != null) hashCode = hashCode * 59 + this.PrivateEndpoint.GetHashCode();
                if (this.PublicEndpoint != null) hashCode = hashCode * 59 + this.PublicEndpoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
