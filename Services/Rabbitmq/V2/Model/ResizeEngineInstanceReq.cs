using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResizeEngineInstanceReq 
    {

        /// <summary>
        /// 变更类型。  取值范围：  [storage：存储空间扩容，代理数量不变。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)  horizontal：代理数量扩容，每个broker的存储空间不变。  [vertical：垂直扩容，broker的底层虚机规格变更，代理数量和存储空间不变。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)
        /// </summary>
        [JsonProperty("oper_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperType { get; set; }

        /// <summary>
        /// 扩容后的存储空间。  [当oper_type类型是storage或horizontal时，该参数有效且必填。  实例存储空间 &#x3D; 代理数量 * 每个broker的存储空间。  当oper_type类型是storage时，代理数量不变，每个broker存储空间最少扩容100GB。  当oper_type类型是horizontal时，每个broker的存储空间不变。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)  [实例存储空间 &#x3D; 代理数量 * 每个broker的存储空间。 每个broker的存储空间不变。](tag:hcs)
        /// </summary>
        [JsonProperty("new_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStorageSpace { get; set; }

        /// <summary>
        /// 规格，例如c6.8u16g.cluster，当oper_type类型是vertical时，该参数才有效且必填。
        /// </summary>
        [JsonProperty("new_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NewProductId { get; set; }

        /// <summary>
        /// 当oper_type参数为horizontal时，该参数有效。
        /// </summary>
        [JsonProperty("new_broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewBrokerNum { get; set; }

        /// <summary>
        /// 老规格，例如dms.instance.rabbitmq.cluster.c3.8u16g，当oper_type类型horizontal时，为dms.instance.rabbitmq.cluster.c3.8u16g.5，最后的数字5为代理数
        /// </summary>
        [JsonProperty("new_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string NewSpecCode { get; set; }



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
            sb.Append("  newSpecCode: ").Append(NewSpecCode).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.OperType == input.OperType ||
                    (this.OperType != null &&
                    this.OperType.Equals(input.OperType))
                ) && 
                (
                    this.NewStorageSpace == input.NewStorageSpace ||
                    (this.NewStorageSpace != null &&
                    this.NewStorageSpace.Equals(input.NewStorageSpace))
                ) && 
                (
                    this.NewProductId == input.NewProductId ||
                    (this.NewProductId != null &&
                    this.NewProductId.Equals(input.NewProductId))
                ) && 
                (
                    this.NewBrokerNum == input.NewBrokerNum ||
                    (this.NewBrokerNum != null &&
                    this.NewBrokerNum.Equals(input.NewBrokerNum))
                ) && 
                (
                    this.NewSpecCode == input.NewSpecCode ||
                    (this.NewSpecCode != null &&
                    this.NewSpecCode.Equals(input.NewSpecCode))
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
                if (this.OperType != null)
                    hashCode = hashCode * 59 + this.OperType.GetHashCode();
                if (this.NewStorageSpace != null)
                    hashCode = hashCode * 59 + this.NewStorageSpace.GetHashCode();
                if (this.NewProductId != null)
                    hashCode = hashCode * 59 + this.NewProductId.GetHashCode();
                if (this.NewBrokerNum != null)
                    hashCode = hashCode * 59 + this.NewBrokerNum.GetHashCode();
                if (this.NewSpecCode != null)
                    hashCode = hashCode * 59 + this.NewSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
