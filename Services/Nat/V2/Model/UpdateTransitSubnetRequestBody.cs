using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateTransitSubnetRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transit_subnet", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTransitSubnetOption TransitSubnet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTransitSubnetRequestBody {\n");
            sb.Append("  transitSubnet: ").Append(TransitSubnet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTransitSubnetRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTransitSubnetRequestBody input)
        {
            if (input == null) return false;
            if (this.TransitSubnet != input.TransitSubnet || (this.TransitSubnet != null && !this.TransitSubnet.Equals(input.TransitSubnet))) return false;

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
                if (this.TransitSubnet != null) hashCode = hashCode * 59 + this.TransitSubnet.GetHashCode();
                return hashCode;
            }
        }
    }
}
