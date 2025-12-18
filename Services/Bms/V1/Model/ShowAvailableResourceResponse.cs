using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAvailableResourceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("available_resource", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvailableResourceResp> AvailableResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAvailableResourceResponse {\n");
            sb.Append("  availableResource: ").Append(AvailableResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAvailableResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAvailableResourceResponse input)
        {
            if (input == null) return false;
            if (this.AvailableResource != input.AvailableResource || (this.AvailableResource != null && input.AvailableResource != null && !this.AvailableResource.SequenceEqual(input.AvailableResource))) return false;

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
                if (this.AvailableResource != null) hashCode = hashCode * 59 + this.AvailableResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
