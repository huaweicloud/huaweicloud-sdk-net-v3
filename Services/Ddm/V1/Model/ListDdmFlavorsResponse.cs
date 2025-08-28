using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDdmFlavorsResponse : SdkResponse
    {

        /// <summary>
        /// 规格组。
        /// </summary>
        [JsonProperty("flavor_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlavorGroupInfo> FlavorGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDdmFlavorsResponse {\n");
            sb.Append("  flavorGroups: ").Append(FlavorGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDdmFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDdmFlavorsResponse input)
        {
            if (input == null) return false;
            if (this.FlavorGroups != input.FlavorGroups || (this.FlavorGroups != null && input.FlavorGroups != null && !this.FlavorGroups.SequenceEqual(input.FlavorGroups))) return false;

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
                if (this.FlavorGroups != null) hashCode = hashCode * 59 + this.FlavorGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
