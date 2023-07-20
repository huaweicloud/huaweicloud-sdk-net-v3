using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceBiactiveRegionsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("region_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RegionCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceBiactiveRegionsResponse {\n");
            sb.Append("  regionCodes: ").Append(RegionCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceBiactiveRegionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceBiactiveRegionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegionCodes == input.RegionCodes ||
                    this.RegionCodes != null &&
                    input.RegionCodes != null &&
                    this.RegionCodes.SequenceEqual(input.RegionCodes)
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
                if (this.RegionCodes != null)
                    hashCode = hashCode * 59 + this.RegionCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
