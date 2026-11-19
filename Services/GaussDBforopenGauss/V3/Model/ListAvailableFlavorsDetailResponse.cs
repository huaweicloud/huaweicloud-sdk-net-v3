using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAvailableFlavorsDetailResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor_category", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorCategoryDetail FlavorCategory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAvailableFlavorsDetailResponse {\n");
            sb.Append("  flavorCategory: ").Append(FlavorCategory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAvailableFlavorsDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAvailableFlavorsDetailResponse input)
        {
            if (input == null) return false;
            if (this.FlavorCategory != input.FlavorCategory || (this.FlavorCategory != null && !this.FlavorCategory.Equals(input.FlavorCategory))) return false;

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
                if (this.FlavorCategory != null) hashCode = hashCode * 59 + this.FlavorCategory.GetHashCode();
                return hashCode;
            }
        }
    }
}
