using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EwPrivateNetworkSegmentsDto 
    {

        /// <summary>
        /// **参数解释**： 私网网段的信息列表，用于东西向VPC防护引流 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("private_network_segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivateNetworkSegmentVO> PrivateNetworkSegments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EwPrivateNetworkSegmentsDto {\n");
            sb.Append("  privateNetworkSegments: ").Append(PrivateNetworkSegments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EwPrivateNetworkSegmentsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EwPrivateNetworkSegmentsDto input)
        {
            if (input == null) return false;
            if (this.PrivateNetworkSegments != input.PrivateNetworkSegments || (this.PrivateNetworkSegments != null && input.PrivateNetworkSegments != null && !this.PrivateNetworkSegments.SequenceEqual(input.PrivateNetworkSegments))) return false;

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
                if (this.PrivateNetworkSegments != null) hashCode = hashCode * 59 + this.PrivateNetworkSegments.GetHashCode();
                return hashCode;
            }
        }
    }
}
