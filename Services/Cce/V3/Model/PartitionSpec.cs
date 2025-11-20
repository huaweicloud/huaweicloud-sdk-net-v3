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
    /// **参数解释**： 分区的配置信息 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
    /// </summary>
    public class PartitionSpec 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hostNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public PartitionSpecHostNetwork HostNetwork { get; set; }

        /// <summary>
        /// **参数解释**： 分区容器子网 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("containerNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public List<PartitionSpecContainerNetwork> ContainerNetwork { get; set; }

        /// <summary>
        /// **参数解释**： 群组，IES边缘场景为可用区ID，中心区统一为“center”。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("publicBorderGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// **参数解释**： 可用区分类 **约束限制**： 不涉及 **取值范围**： - Default: 中心云可用区 - IES: 专属云可用区 - HomeZone: 智能边缘云可用区  **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartitionSpec {\n");
            sb.Append("  hostNetwork: ").Append(HostNetwork).Append("\n");
            sb.Append("  containerNetwork: ").Append(ContainerNetwork).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartitionSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PartitionSpec input)
        {
            if (input == null) return false;
            if (this.HostNetwork != input.HostNetwork || (this.HostNetwork != null && !this.HostNetwork.Equals(input.HostNetwork))) return false;
            if (this.ContainerNetwork != input.ContainerNetwork || (this.ContainerNetwork != null && input.ContainerNetwork != null && !this.ContainerNetwork.SequenceEqual(input.ContainerNetwork))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && !this.PublicBorderGroup.Equals(input.PublicBorderGroup))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;

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
                if (this.HostNetwork != null) hashCode = hashCode * 59 + this.HostNetwork.GetHashCode();
                if (this.ContainerNetwork != null) hashCode = hashCode * 59 + this.ContainerNetwork.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }
    }
}
