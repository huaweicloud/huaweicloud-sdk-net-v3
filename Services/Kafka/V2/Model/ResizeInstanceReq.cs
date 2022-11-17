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
    public class ResizeInstanceReq 
    {

        /// <summary>
        /// 规格变更后的规格ID。 若只扩展磁盘大小，则规格ID保持和原实例不变。
        /// </summary>
        [JsonProperty("new_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string NewSpecCode { get; set; }

        /// <summary>
        /// 规格变更后的消息存储空间，单位：GB。 若扩展实例基准带宽，则new_storage_space不能低于基准带宽规定的最小磁盘大小。
        /// </summary>
        [JsonProperty("new_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStorageSpace { get; set; }

        /// <summary>
        /// 扩容类型, 新规格支持扩容类型：\&quot;horizontal\&quot;、\&quot;vertical\&quot;、\&quot;node\&quot;、\&quot;storage\&quot;四种类型。
        /// </summary>
        [JsonProperty("oper_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperType { get; set; }

        /// <summary>
        /// 扩容后集群节点数。
        /// </summary>
        [JsonProperty("new_broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewBrokerNum { get; set; }

        /// <summary>
        /// 新规格变更后的产品ID。 涉及垂直扩容场景，需指定该项。
        /// </summary>
        [JsonProperty("new_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NewProductId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeInstanceReq {\n");
            sb.Append("  newSpecCode: ").Append(NewSpecCode).Append("\n");
            sb.Append("  newStorageSpace: ").Append(NewStorageSpace).Append("\n");
            sb.Append("  operType: ").Append(OperType).Append("\n");
            sb.Append("  newBrokerNum: ").Append(NewBrokerNum).Append("\n");
            sb.Append("  newProductId: ").Append(NewProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeInstanceReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewSpecCode == input.NewSpecCode ||
                    (this.NewSpecCode != null &&
                    this.NewSpecCode.Equals(input.NewSpecCode))
                ) && 
                (
                    this.NewStorageSpace == input.NewStorageSpace ||
                    (this.NewStorageSpace != null &&
                    this.NewStorageSpace.Equals(input.NewStorageSpace))
                ) && 
                (
                    this.OperType == input.OperType ||
                    (this.OperType != null &&
                    this.OperType.Equals(input.OperType))
                ) && 
                (
                    this.NewBrokerNum == input.NewBrokerNum ||
                    (this.NewBrokerNum != null &&
                    this.NewBrokerNum.Equals(input.NewBrokerNum))
                ) && 
                (
                    this.NewProductId == input.NewProductId ||
                    (this.NewProductId != null &&
                    this.NewProductId.Equals(input.NewProductId))
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
                if (this.NewSpecCode != null)
                    hashCode = hashCode * 59 + this.NewSpecCode.GetHashCode();
                if (this.NewStorageSpace != null)
                    hashCode = hashCode * 59 + this.NewStorageSpace.GetHashCode();
                if (this.OperType != null)
                    hashCode = hashCode * 59 + this.OperType.GetHashCode();
                if (this.NewBrokerNum != null)
                    hashCode = hashCode * 59 + this.NewBrokerNum.GetHashCode();
                if (this.NewProductId != null)
                    hashCode = hashCode * 59 + this.NewProductId.GetHashCode();
                return hashCode;
            }
        }
    }
}
