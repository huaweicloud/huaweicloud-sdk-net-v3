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
    /// This is a auto create Body Object
    /// </summary>
    public class AssociateServerVirtualIpRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nic", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateServerVirtualIpOption Nic { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateServerVirtualIpRequestBody {\n");
            sb.Append("  nic: ").Append(Nic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateServerVirtualIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateServerVirtualIpRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nic == input.Nic ||
                    (this.Nic != null &&
                    this.Nic.Equals(input.Nic))
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
                if (this.Nic != null)
                    hashCode = hashCode * 59 + this.Nic.GetHashCode();
                return hashCode;
            }
        }
    }
}
