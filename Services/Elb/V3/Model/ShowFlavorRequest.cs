using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowFlavorRequest 
    {

        /// <summary>
        /// 规格ID。
        /// </summary>
        [SDKProperty("flavor_id", IsPath = true)]
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFlavorRequest {\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFlavorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFlavorRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlavorId == input.FlavorId ||
                    (this.FlavorId != null &&
                    this.FlavorId.Equals(input.FlavorId))
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
                if (this.FlavorId != null)
                    hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
