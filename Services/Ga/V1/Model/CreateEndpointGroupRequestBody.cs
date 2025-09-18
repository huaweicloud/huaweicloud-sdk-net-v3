using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// create Endpoint Group request
    /// </summary>
    public class CreateEndpointGroupRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endpoint_group", NullValueHandling = NullValueHandling.Ignore)]
        public CreateEndpointGroupOption EndpointGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEndpointGroupRequestBody {\n");
            sb.Append("  endpointGroup: ").Append(EndpointGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEndpointGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEndpointGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.EndpointGroup != input.EndpointGroup || (this.EndpointGroup != null && !this.EndpointGroup.Equals(input.EndpointGroup))) return false;

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
                if (this.EndpointGroup != null) hashCode = hashCode * 59 + this.EndpointGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
