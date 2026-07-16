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
    /// **参数解释**：资源池集群信息，特权池才有该字段。
    /// </summary>
    public class PoolStatusClusters 
    {

        /// <summary>
        /// **参数解释**：集群名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：标准池的集群规格。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("clusterFlavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterFlavor { get; set; }

        /// <summary>
        /// **参数解释**：资源池集群的类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：集群的版本号。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plugins", NullValueHandling = NullValueHandling.Ignore)]
        public PoolStatusClustersPlugins Plugins { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolStatusClusters {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  clusterFlavor: ").Append(ClusterFlavor).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  plugins: ").Append(Plugins).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolStatusClusters);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolStatusClusters input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ClusterFlavor != input.ClusterFlavor || (this.ClusterFlavor != null && !this.ClusterFlavor.Equals(input.ClusterFlavor))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Plugins != input.Plugins || (this.Plugins != null && !this.Plugins.Equals(input.Plugins))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ClusterFlavor != null) hashCode = hashCode * 59 + this.ClusterFlavor.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Plugins != null) hashCode = hashCode * 59 + this.Plugins.GetHashCode();
                return hashCode;
            }
        }
    }
}
