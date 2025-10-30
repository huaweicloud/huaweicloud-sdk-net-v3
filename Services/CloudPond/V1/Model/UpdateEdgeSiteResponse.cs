using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateEdgeSiteResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("edge_site", NullValueHandling = NullValueHandling.Ignore)]
        public EdgeSiteDetail EdgeSite { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEdgeSiteResponse {\n");
            sb.Append("  edgeSite: ").Append(EdgeSite).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEdgeSiteResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEdgeSiteResponse input)
        {
            if (input == null) return false;
            if (this.EdgeSite != input.EdgeSite || (this.EdgeSite != null && !this.EdgeSite.Equals(input.EdgeSite))) return false;

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
                if (this.EdgeSite != null) hashCode = hashCode * 59 + this.EdgeSite.GetHashCode();
                return hashCode;
            }
        }
    }
}
