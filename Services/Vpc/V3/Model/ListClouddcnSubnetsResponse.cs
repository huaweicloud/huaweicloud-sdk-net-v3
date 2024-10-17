using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListClouddcnSubnetsResponse : SdkResponse
    {

        /// <summary>
        /// clouddcn subnet对象列表
        /// </summary>
        [JsonProperty("clouddcn_subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClouddcnSubnet> ClouddcnSubnets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListClouddcnSubnetsResponse {\n");
            sb.Append("  clouddcnSubnets: ").Append(ClouddcnSubnets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListClouddcnSubnetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListClouddcnSubnetsResponse input)
        {
            if (input == null) return false;
            if (this.ClouddcnSubnets != input.ClouddcnSubnets || (this.ClouddcnSubnets != null && input.ClouddcnSubnets != null && !this.ClouddcnSubnets.SequenceEqual(input.ClouddcnSubnets))) return false;

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
                if (this.ClouddcnSubnets != null) hashCode = hashCode * 59 + this.ClouddcnSubnets.GetHashCode();
                return hashCode;
            }
        }
    }
}
