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
    /// **参数解释**： 变更集群规格扩展字段 **约束限制**： 不涉及 
    /// </summary>
    public class ResizeClusterRequestBodyExtendParam 
    {

        /// <summary>
        /// **参数解释**： 专属云CCE集群可指定控制节点的规格 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("decMasterFlavor", NullValueHandling = NullValueHandling.Ignore)]
        public string DecMasterFlavor { get; set; }

        /// <summary>
        /// **参数解释**： 是否自动扣款 **约束限制**： 不涉及 **取值范围**： - “true”：自动扣款 - “false”：不自动扣款 &gt; 包周期集群时生效，不填写此参数时默认不会自动扣款。  **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeClusterRequestBodyExtendParam {\n");
            sb.Append("  decMasterFlavor: ").Append(DecMasterFlavor).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeClusterRequestBodyExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeClusterRequestBodyExtendParam input)
        {
            if (input == null) return false;
            if (this.DecMasterFlavor != input.DecMasterFlavor || (this.DecMasterFlavor != null && !this.DecMasterFlavor.Equals(input.DecMasterFlavor))) return false;
            if (this.IsAutoPay != input.IsAutoPay || (this.IsAutoPay != null && !this.IsAutoPay.Equals(input.IsAutoPay))) return false;

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
                if (this.DecMasterFlavor != null) hashCode = hashCode * 59 + this.DecMasterFlavor.GetHashCode();
                if (this.IsAutoPay != null) hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
