using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetClusterFlavorSpecsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clusterFlavorSpecs", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterFlavorSpecification ClusterFlavorSpecs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetClusterFlavorSpecsResponse {\n");
            sb.Append("  clusterFlavorSpecs: ").Append(ClusterFlavorSpecs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetClusterFlavorSpecsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetClusterFlavorSpecsResponse input)
        {
            if (input == null) return false;
            if (this.ClusterFlavorSpecs != input.ClusterFlavorSpecs || (this.ClusterFlavorSpecs != null && !this.ClusterFlavorSpecs.Equals(input.ClusterFlavorSpecs))) return false;

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
                if (this.ClusterFlavorSpecs != null) hashCode = hashCode * 59 + this.ClusterFlavorSpecs.GetHashCode();
                return hashCode;
            }
        }
    }
}
