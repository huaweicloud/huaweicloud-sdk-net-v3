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
        /// **参数解释**： 公网IP的ID。[获取方法：参考[[《弹性公网IP API参考》](https://support.huaweicloud.com/api-eip/ListPublicipsV3.html)](tag:hws)[[《弹性公网IP API参考》](https://support.huaweicloud.com/intl/zh-cn/api-eip/ListPublicipsV3.html)](tag:hws_hk)[[《弹性公网IP API参考》](https://support.huaweicloud.com/eu/api-eip/ListPublicipsV3.html)](tag:hws_eu)[《弹性公网IP API参考》](tag:ax,cmcc,ctc,sbc,hk_sbc,g42,hk_g42,srg,dt,ocb,hws_ocb,hcs,fcs)，调用“查询弹性公网IP列表”接口，从响应体中获取弹性公网IP的ID。](tag:ax,cmcc,ctc,sbc,hk_sbc,g42,hk_g42,srg,dt,ocb,hws_ocb,hcs,fcs,hws,hws_hk,hws_eu) **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyKafkaPublicIPAccessSwitchReq {\n");
            sb.Append("  eipAddress: ").Append(EipAddress).Append("\n");
            sb.Append("  publicBoundwidth: ").Append(PublicBoundwidth).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
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
            if (this.PublicipId != input.PublicipId || (this.PublicipId != null && !this.PublicipId.Equals(input.PublicipId))) return false;

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
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
