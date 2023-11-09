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
    public class ServiceNetwork 
    {

        /// <summary>
        /// kubernetes clusterIP IPv4 CIDR取值范围。创建集群时若未传参，默认为\&quot;10.247.0.0/16\&quot;。
        /// </summary>
        [JsonProperty("IPv4CIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string IPv4CIDR { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceNetwork {\n");
            sb.Append("  iPv4CIDR: ").Append(IPv4CIDR).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IPv4CIDR == input.IPv4CIDR ||
                    (this.IPv4CIDR != null &&
                    this.IPv4CIDR.Equals(input.IPv4CIDR))
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
                if (this.IPv4CIDR != null)
                    hashCode = hashCode * 59 + this.IPv4CIDR.GetHashCode();
                return hashCode;
            }
        }
    }
}
