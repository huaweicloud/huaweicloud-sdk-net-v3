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
    /// 变更集群规格的扩展参数
    /// </summary>
    public class ResizeClusterRequestExtendParam 
    {

        /// <summary>
        /// 专属云CCE集群可指定控制节点的规格
        /// </summary>
        [JsonProperty("decMasterFlavor", NullValueHandling = NullValueHandling.Ignore)]
        public string DecMasterFlavor { get; set; }

        /// <summary>
        /// 是否自动扣款 - “true”：自动扣款 - “false”：不自动扣款 &gt; 包周期集群时生效，不填写此参数时默认不会自动扣款。 
        /// </summary>
        [JsonProperty("isAutoPay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeClusterRequestExtendParam {\n");
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
            return this.Equals(input as ResizeClusterRequestExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeClusterRequestExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DecMasterFlavor == input.DecMasterFlavor ||
                    (this.DecMasterFlavor != null &&
                    this.DecMasterFlavor.Equals(input.DecMasterFlavor))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DecMasterFlavor != null)
                    hashCode = hashCode * 59 + this.DecMasterFlavor.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
