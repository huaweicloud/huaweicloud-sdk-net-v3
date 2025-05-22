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
    /// **参数解释**： 更新节点的网卡信息。 **约束限制**： 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class NodeSpecUpdateNodeNicSpecUpdate 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("primaryNic", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSpecUpdateNodeNicSpecUpdatePrimaryNic PrimaryNic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSpecUpdateNodeNicSpecUpdate {\n");
            sb.Append("  primaryNic: ").Append(PrimaryNic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSpecUpdateNodeNicSpecUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSpecUpdateNodeNicSpecUpdate input)
        {
            if (input == null) return false;
            if (this.PrimaryNic != input.PrimaryNic || (this.PrimaryNic != null && !this.PrimaryNic.Equals(input.PrimaryNic))) return false;

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
                if (this.PrimaryNic != null) hashCode = hashCode * 59 + this.PrimaryNic.GetHashCode();
                return hashCode;
            }
        }
    }
}
