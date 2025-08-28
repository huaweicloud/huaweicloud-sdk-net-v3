using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 归属云。
    /// </summary>
    public class NonRequiredHostedCloud 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hosted_cloud", NullValueHandling = NullValueHandling.Ignore)]
        public HostedCloudEnum HostedCloud { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonRequiredHostedCloud {\n");
            sb.Append("  hostedCloud: ").Append(HostedCloud).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NonRequiredHostedCloud);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NonRequiredHostedCloud input)
        {
            if (input == null) return false;
            if (this.HostedCloud != input.HostedCloud) return false;

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
                hashCode = hashCode * 59 + this.HostedCloud.GetHashCode();
                return hashCode;
            }
        }
    }
}
