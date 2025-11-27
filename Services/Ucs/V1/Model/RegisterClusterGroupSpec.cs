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
    public class RegisterClusterGroupSpec 
    {

        /// <summary>
        /// 关联的集群id
        /// </summary>
        [JsonProperty("clusterIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// 容器舰队描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterClusterGroupSpec {\n");
            sb.Append("  clusterIds: ").Append(ClusterIds).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterClusterGroupSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterClusterGroupSpec input)
        {
            if (input == null) return false;
            if (this.ClusterIds != input.ClusterIds || (this.ClusterIds != null && input.ClusterIds != null && !this.ClusterIds.SequenceEqual(input.ClusterIds))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
