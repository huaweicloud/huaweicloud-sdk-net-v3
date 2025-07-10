using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Association 
    {

        /// <summary>
        /// 网卡绑定的eipId
        /// </summary>
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Association {\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Association);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Association input)
        {
            if (input == null) return false;
            if (this.PublicIpAddress != input.PublicIpAddress || (this.PublicIpAddress != null && !this.PublicIpAddress.Equals(input.PublicIpAddress))) return false;

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
                if (this.PublicIpAddress != null) hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
