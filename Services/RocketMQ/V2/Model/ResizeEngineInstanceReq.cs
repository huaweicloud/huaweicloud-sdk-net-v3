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
    /// 变更类型  取值范围： - storage：存储空间扩容，代理数量不变。 - horizontal：代理数量扩容，每个broker的存储空间不变。 - vertical：垂直扩缩容，broker的底层虚机规格变更，代理数量和存储空间不变。
    /// </summary>
    public class ResizeEngineInstanceReq 
    {

        /// <summary>
        /// 变更类型  取值范围： [- storage：存储空间扩容，代理数量不变。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,dt) - horizontal：代理数量扩容，每个broker的存储空间不变。 [- vertical：垂直扩容，broker的底层虚机规格变更，代理数量和存储空间不变。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,dt)
        /// </summary>
        [JsonProperty("oper_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperType { get; set; }

        /// <summary>
        /// 当oper_type类型是[storage或](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,dt)horizontal时，该参数有效且必填，实例存储空间 &#x3D; 代理数量 * 每个broker的存储空间。  [- 当oper_type类型是storage时，代理数量不变，每个broker存储空间最少扩容100GB。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm,fcs,dt)  - 当oper_type类型是horizontal时，每个broker的存储空间不变。
        /// </summary>
        [JsonProperty("new_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStorageSpace { get; set; }

        /// <summary>
        /// 当oper_type类型是vertical时，该参数才有效且必填。
        /// </summary>
        [JsonProperty("new_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NewProductId { get; set; }

        /// <summary>
        /// 代理数量  当oper_type参数为horizontal时，该参数必填。
        /// </summary>
        [JsonProperty("new_broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewBrokerNum { get; set; }

        /// <summary>
        /// 实例绑定的弹性IP地址的ID。 以英文逗号隔开多个弹性IP地址的ID。 当oper_type参数为horizontal且开启了公网访问时，此参数必填。
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
