using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPublicipPoolTypesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip-pool-types", NullValueHandling = NullValueHandling.Ignore)]
        public PublicPoolType PublicipPoolTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPublicipPoolTypesResponse {\n");
            sb.Append("  publicipPoolTypes: ").Append(PublicipPoolTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPublicipPoolTypesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPublicipPoolTypesResponse input)
        {
            if (input == null) return false;
            if (this.PublicipPoolTypes != input.PublicipPoolTypes || (this.PublicipPoolTypes != null && !this.PublicipPoolTypes.Equals(input.PublicipPoolTypes))) return false;

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
                if (this.PublicipPoolTypes != null) hashCode = hashCode * 59 + this.PublicipPoolTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
