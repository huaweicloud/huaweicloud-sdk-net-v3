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
    /// **参数解释**： 属主对象。 **约束限制**： - 创建成功后自动生成，填写无效。 - 创建节点接口返回内容中无该参数  **取值范围**： 不涉及 **默认取值**： 不涉及
    /// </summary>
    public class NodeMetadataOwnerReference 
    {

        /// <summary>
        /// **参数解释**： 节点池名称 **约束限制**： 创建成功后自动生成，填写无效。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("nodepoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string NodepoolName { get; set; }

        /// <summary>
        /// **参数解释**： 节点池ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。 **约束限制**： 创建成功后自动生成，填写无效。 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("nodepoolID", NullValueHandling = NullValueHandling.Ignore)]
        public string NodepoolID { get; set; }

        /// <summary>
        /// **参数解释**： 超节点名称。如果节点不属于超节点，此字段不展示。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("hyperNodeName", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperNodeName { get; set; }

        /// <summary>
        /// **参数解释**： 超节点ID。如果节点不属于超节点，此字段不展示。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("hyperNodeID", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperNodeID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeMetadataOwnerReference {\n");
            sb.Append("  nodepoolName: ").Append(NodepoolName).Append("\n");
            sb.Append("  nodepoolID: ").Append(NodepoolID).Append("\n");
            sb.Append("  hyperNodeName: ").Append(HyperNodeName).Append("\n");
            sb.Append("  hyperNodeID: ").Append(HyperNodeID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeMetadataOwnerReference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeMetadataOwnerReference input)
        {
            if (input == null) return false;
            if (this.NodepoolName != input.NodepoolName || (this.NodepoolName != null && !this.NodepoolName.Equals(input.NodepoolName))) return false;
            if (this.NodepoolID != input.NodepoolID || (this.NodepoolID != null && !this.NodepoolID.Equals(input.NodepoolID))) return false;
            if (this.HyperNodeName != input.HyperNodeName || (this.HyperNodeName != null && !this.HyperNodeName.Equals(input.HyperNodeName))) return false;
            if (this.HyperNodeID != input.HyperNodeID || (this.HyperNodeID != null && !this.HyperNodeID.Equals(input.HyperNodeID))) return false;

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
                if (this.NodepoolName != null) hashCode = hashCode * 59 + this.NodepoolName.GetHashCode();
                if (this.NodepoolID != null) hashCode = hashCode * 59 + this.NodepoolID.GetHashCode();
                if (this.HyperNodeName != null) hashCode = hashCode * 59 + this.HyperNodeName.GetHashCode();
                if (this.HyperNodeID != null) hashCode = hashCode * 59 + this.HyperNodeID.GetHashCode();
                return hashCode;
            }
        }
    }
}
