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
    /// 节点迁移到自定义节点池参数。
    /// </summary>
    public class MigrateNodesToNodePool 
    {

        /// <summary>
        /// **参数解释**： 节点ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("nodeID", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NodeID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateNodesToNodePool {\n");
            sb.Append("  nodeID: ").Append(NodeID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateNodesToNodePool);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateNodesToNodePool input)
        {
            if (input == null) return false;
            if (this.NodeID != input.NodeID || (this.NodeID != null && !this.NodeID.Equals(input.NodeID))) return false;

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
                if (this.NodeID != null) hashCode = hashCode * 59 + this.NodeID.GetHashCode();
                return hashCode;
            }
        }
    }
}
