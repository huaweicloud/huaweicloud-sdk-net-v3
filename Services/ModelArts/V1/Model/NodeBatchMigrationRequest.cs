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
    /// **参数解释**：批量迁移节点请求体。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
    /// </summary>
    public class NodeBatchMigrationRequest 
    {

        /// <summary>
        /// **参数解释**：待迁移的节点名称列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("migrateNodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MigrateNodeNames { get; set; }

        /// <summary>
        /// **参数解释**：迁移起始集群名称。 专属算力资源时该字段与源资源池名称相同，取自源资源池metadata.name字段的值； 轻量算力集群时该字段取自迁移节点metadata.labels[os.modelarts.node/cluster]字段的值。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("fromClusterName", NullValueHandling = NullValueHandling.Ignore)]
        public string FromClusterName { get; set; }

        /// <summary>
        /// **参数解释**：迁移目标集群名称。 专属算力资源时该字段与源资源池名称相同，取自目标资源池metadata.name字段的值； 轻量算力集群时该字段取自目标资源池内节点metadata.labels[os.modelarts.node/cluster]字段的值。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("toClusterName", NullValueHandling = NullValueHandling.Ignore)]
        public string ToClusterName { get; set; }

        /// <summary>
        /// **参数解释**：迁移目标资源池名称。该字段取自目标资源池metadata.name字段的值。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("toPoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string ToPoolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resourceSpec", NullValueHandling = NullValueHandling.Ignore)]
        public MigrateResourceSpec ResourceSpec { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeBatchMigrationRequest {\n");
            sb.Append("  migrateNodeNames: ").Append(MigrateNodeNames).Append("\n");
            sb.Append("  fromClusterName: ").Append(FromClusterName).Append("\n");
            sb.Append("  toClusterName: ").Append(ToClusterName).Append("\n");
            sb.Append("  toPoolName: ").Append(ToPoolName).Append("\n");
            sb.Append("  resourceSpec: ").Append(ResourceSpec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeBatchMigrationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeBatchMigrationRequest input)
        {
            if (input == null) return false;
            if (this.MigrateNodeNames != input.MigrateNodeNames || (this.MigrateNodeNames != null && input.MigrateNodeNames != null && !this.MigrateNodeNames.SequenceEqual(input.MigrateNodeNames))) return false;
            if (this.FromClusterName != input.FromClusterName || (this.FromClusterName != null && !this.FromClusterName.Equals(input.FromClusterName))) return false;
            if (this.ToClusterName != input.ToClusterName || (this.ToClusterName != null && !this.ToClusterName.Equals(input.ToClusterName))) return false;
            if (this.ToPoolName != input.ToPoolName || (this.ToPoolName != null && !this.ToPoolName.Equals(input.ToPoolName))) return false;
            if (this.ResourceSpec != input.ResourceSpec || (this.ResourceSpec != null && !this.ResourceSpec.Equals(input.ResourceSpec))) return false;

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
                if (this.MigrateNodeNames != null) hashCode = hashCode * 59 + this.MigrateNodeNames.GetHashCode();
                if (this.FromClusterName != null) hashCode = hashCode * 59 + this.FromClusterName.GetHashCode();
                if (this.ToClusterName != null) hashCode = hashCode * 59 + this.ToClusterName.GetHashCode();
                if (this.ToPoolName != null) hashCode = hashCode * 59 + this.ToPoolName.GetHashCode();
                if (this.ResourceSpec != null) hashCode = hashCode * 59 + this.ResourceSpec.GetHashCode();
                return hashCode;
            }
        }
    }
}
