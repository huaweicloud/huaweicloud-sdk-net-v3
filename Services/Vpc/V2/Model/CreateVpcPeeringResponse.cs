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
    public class CreateVpcPeeringResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("peering", NullValueHandling = NullValueHandling.Ignore)]
        public VpcPeering Peering { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVpcPeeringResponse {\n");
            sb.Append("  peering: ").Append(Peering).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVpcPeeringResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVpcPeeringResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Peering == input.Peering ||
                    (this.Peering != null &&
                    this.Peering.Equals(input.Peering))
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
                if (this.Peering != null)
                    hashCode = hashCode * 59 + this.Peering.GetHashCode();
                return hashCode;
            }
        }
    }
}
