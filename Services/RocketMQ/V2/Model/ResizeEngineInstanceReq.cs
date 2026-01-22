using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResizeEngineInstanceReq 
    {

        /// <summary>
        /// **参数解释**： 变更类型。 **约束限制**： 不涉及。 **取值范围**： [- storage：存储空间扩容，节点数量不变。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,dt,cmcc,ax,srg) - horizontal：[RocketMQ 5.x为实例规格扩容。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,dt,srg)[RocketMQ 4.8.0为代理数扩容。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,cmcc,ax) [- vertical：垂直扩容，broker的底层虚机规格变更，代理数量和存储空间不变，仅RocketMQ 4.8.0支持。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,cmcc,ax,srg) **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("oper_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperType { get; set; }

        /// <summary>
        /// **参数解释**： 新存储规格 **约束限制**： 当oper_type类型是storage时，该参数有效且必填。  [- 当oper_type类型是storage时，每个broker存储空间最少扩容100GB。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,dt,cmcc,ax,srg)  - 当oper_type类型是horizontal时，每个broker的存储空间不变。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("new_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 新产品ID **约束限制**：  [- RocketMQ 5.x：当oper_type类型是horizontal时该参数有效且必填，规格变更仅限于集群实例。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,dt,srg) [- RocketMQ 4.8.0：当oper_type类型是vertical时该参数有效且必填，规格变更仅限于集群实例。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,cmcc,ax) **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("new_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NewProductId { get; set; }

        /// <summary>
        /// **参数解释**： 代理数量 **约束限制**： 当oper_type参数为horizontal时，该参数必填。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("new_broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewBrokerNum { get; set; }

        /// <summary>
        /// **参数解释**： 实例绑定的弹性IP地址的ID。以英文逗号隔开多个弹性IP地址的ID。 **约束限制**：  当oper_type参数为horizontal且开启了公网访问时，此参数必填。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeEngineInstanceReq {\n");
            sb.Append("  operType: ").Append(OperType).Append("\n");
            sb.Append("  newStorageSpace: ").Append(NewStorageSpace).Append("\n");
            sb.Append("  newProductId: ").Append(NewProductId).Append("\n");
            sb.Append("  newBrokerNum: ").Append(NewBrokerNum).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeEngineInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeEngineInstanceReq input)
        {
            if (input == null) return false;
            if (this.OperType != input.OperType || (this.OperType != null && !this.OperType.Equals(input.OperType))) return false;
            if (this.NewStorageSpace != input.NewStorageSpace || (this.NewStorageSpace != null && !this.NewStorageSpace.Equals(input.NewStorageSpace))) return false;
            if (this.NewProductId != input.NewProductId || (this.NewProductId != null && !this.NewProductId.Equals(input.NewProductId))) return false;
            if (this.NewBrokerNum != input.NewBrokerNum || (this.NewBrokerNum != null && !this.NewBrokerNum.Equals(input.NewBrokerNum))) return false;
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
                if (this.OperType != null) hashCode = hashCode * 59 + this.OperType.GetHashCode();
                if (this.NewStorageSpace != null) hashCode = hashCode * 59 + this.NewStorageSpace.GetHashCode();
                if (this.NewProductId != null) hashCode = hashCode * 59 + this.NewProductId.GetHashCode();
                if (this.NewBrokerNum != null) hashCode = hashCode * 59 + this.NewBrokerNum.GetHashCode();
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
