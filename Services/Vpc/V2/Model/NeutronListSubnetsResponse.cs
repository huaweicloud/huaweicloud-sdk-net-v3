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
    /// Response Object
    /// </summary>
    public class NeutronListSubnetsResponse : SdkResponse
    {

        /// <summary>
        /// subnet对象列表
        /// </summary>
        [JsonProperty("subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronSubnet> Subnets { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("subnets_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> SubnetsLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListSubnetsResponse {\n");
            sb.Append("  subnets: ").Append(Subnets).Append("\n");
            sb.Append("  subnetsLinks: ").Append(SubnetsLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListSubnetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListSubnetsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subnets == input.Subnets ||
                    this.Subnets != null &&
                    input.Subnets != null &&
                    this.Subnets.SequenceEqual(input.Subnets)
                ) && 
                (
                    this.SubnetsLinks == input.SubnetsLinks ||
                    this.SubnetsLinks != null &&
                    input.SubnetsLinks != null &&
                    this.SubnetsLinks.SequenceEqual(input.SubnetsLinks)
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
                if (this.Subnets != null)
                    hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                if (this.SubnetsLinks != null)
                    hashCode = hashCode * 59 + this.SubnetsLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
