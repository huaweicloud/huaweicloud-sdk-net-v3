using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHyperClusterResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：Hyper Cluster列表。
        /// </summary>
        [JsonProperty("hyper_clusters", NullValueHandling = NullValueHandling.Ignore)]
        public List<HyperCluster> HyperClusters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHyperClusterResponse {\n");
            sb.Append("  hyperClusters: ").Append(HyperClusters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHyperClusterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHyperClusterResponse input)
        {
            if (input == null) return false;
            if (this.HyperClusters != input.HyperClusters || (this.HyperClusters != null && input.HyperClusters != null && !this.HyperClusters.SequenceEqual(input.HyperClusters))) return false;

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
                if (this.HyperClusters != null) hashCode = hashCode * 59 + this.HyperClusters.GetHashCode();
                return hashCode;
            }
        }
    }
}
