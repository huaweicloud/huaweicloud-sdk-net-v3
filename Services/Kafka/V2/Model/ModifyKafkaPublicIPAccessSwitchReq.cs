using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyKafkaPublicIPAccessSwitchReq 
    {

        /// <summary>
        /// **参数解释**： EIP地址。  **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("eip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EipAddress { get; set; }

        /// <summary>
        /// **参数解释**： 公网带宽。  **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("public_boundwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicBoundwidth { get; set; }

        /// <summary>
        /// **参数解释**： 公网IP的ID。  **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("publicIpId", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyKafkaPublicIPAccessSwitchReq {\n");
            sb.Append("  eipAddress: ").Append(EipAddress).Append("\n");
            sb.Append("  publicBoundwidth: ").Append(PublicBoundwidth).Append("\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyKafkaPublicIPAccessSwitchReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyKafkaPublicIPAccessSwitchReq input)
        {
            if (input == null) return false;
            if (this.EipAddress != input.EipAddress || (this.EipAddress != null && !this.EipAddress.Equals(input.EipAddress))) return false;
            if (this.PublicBoundwidth != input.PublicBoundwidth || (this.PublicBoundwidth != null && !this.PublicBoundwidth.Equals(input.PublicBoundwidth))) return false;
            if (this.PublicIpId != input.PublicIpId || (this.PublicIpId != null && !this.PublicIpId.Equals(input.PublicIpId))) return false;

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
                if (this.EipAddress != null) hashCode = hashCode * 59 + this.EipAddress.GetHashCode();
                if (this.PublicBoundwidth != null) hashCode = hashCode * 59 + this.PublicBoundwidth.GetHashCode();
                if (this.PublicIpId != null) hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                return hashCode;
            }
        }
    }
}
