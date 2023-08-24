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
    /// This is a auto create Body Object
    /// </summary>
    public class AssociateSubnetFirewallRequestBody 
    {

        /// <summary>
        /// 绑定ACL的子网列表
        /// </summary>
        [JsonProperty("subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<FirewallAssociation> Subnets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateSubnetFirewallRequestBody {\n");
            sb.Append("  subnets: ").Append(Subnets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateSubnetFirewallRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateSubnetFirewallRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subnets == input.Subnets ||
                    this.Subnets != null &&
                    input.Subnets != null &&
                    this.Subnets.SequenceEqual(input.Subnets)
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
                return hashCode;
            }
        }
    }
}
