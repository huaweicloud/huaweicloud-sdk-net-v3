using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateClusterGroupAssociatedClustersRequestBody 
    {

        /// <summary>
        /// 更新容器舰队关联集群信息。
        /// </summary>
        [JsonProperty("clusterIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClusterIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateClusterGroupAssociatedClustersRequestBody {\n");
            sb.Append("  clusterIds: ").Append(ClusterIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateClusterGroupAssociatedClustersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateClusterGroupAssociatedClustersRequestBody input)
        {
            if (input == null) return false;
            if (this.ClusterIds != input.ClusterIds || (this.ClusterIds != null && input.ClusterIds != null && !this.ClusterIds.SequenceEqual(input.ClusterIds))) return false;

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
                if (this.ClusterIds != null) hashCode = hashCode * 59 + this.ClusterIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
