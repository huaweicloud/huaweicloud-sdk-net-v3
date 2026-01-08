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
    /// Response Object
    /// </summary>
    public class ListSubnetsResponse : SdkResponse
    {

        /// <summary>
        /// 子网列表。
        /// </summary>
        [JsonProperty("subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubnetInfo> Subnets { get; set; }

        /// <summary>
        /// 子网数量。
        /// </summary>
        [JsonProperty("subnet_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubnetSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubnetsResponse {\n");
            sb.Append("  subnets: ").Append(Subnets).Append("\n");
            sb.Append("  subnetSize: ").Append(SubnetSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubnetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubnetsResponse input)
        {
            if (input == null) return false;
            if (this.Subnets != input.Subnets || (this.Subnets != null && input.Subnets != null && !this.Subnets.SequenceEqual(input.Subnets))) return false;
            if (this.SubnetSize != input.SubnetSize || (this.SubnetSize != null && !this.SubnetSize.Equals(input.SubnetSize))) return false;

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
                if (this.Subnets != null) hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                if (this.SubnetSize != null) hashCode = hashCode * 59 + this.SubnetSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
