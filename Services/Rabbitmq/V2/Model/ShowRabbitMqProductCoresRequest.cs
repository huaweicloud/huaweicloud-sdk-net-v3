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
    /// Request Object
    /// </summary>
    public class ShowRabbitMqProductCoresRequest 
    {

        /// <summary>
        /// **参数解释**： 实例ID。获取方法如下：调用“查询所有实例列表”接口，从响应体中获取实例ID。实例ID非必填项，只有填写实例ID响应体才会返回total_extend_storage_space。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 产品ID。 **约束限制**： 不涉及。 **取值范围**： - c6.2u4g.single：对应规格rabbitmq.2u4g.single。 - c6.4u8g.single：对应规格rabbitmq.4u8g.single。 - c6.8u16g.single：对应规格rabbitmq.8u16g.single。 - c6.16u32g.single：对应规格rabbitmq.16u32g.single。 - c6.24u48g.single：对应规格rabbitmq.24u48g.single。 - c6.2u4g.cluster：对应规格rabbitmq.2u4g.cluster。 - c6.4u8g.cluster：对应规格rabbitmq.4u8g.cluster。 - c6.8u16g.cluster：对应规格rabbitmq.8u16g.cluster。 - c6.12u24g.cluster：对应规格rabbitmq.12u24g.cluster。 - c6.16u32g.cluster：对应规格rabbitmq.16u32g.cluster。 - c6.24u48g.cluster：对应规格rabbitmq.24u48g.cluster。 - c6.32u64g.cluster：对应规格rabbitmq.32u64g.cluster。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("product_id", IsQuery = true)]
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释**： broker数量。 **约束限制**： 不涉及。 **取值范围**： - 1 - 3 - 5 - 7 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("broker_num", IsQuery = true)]
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRabbitMqProductCoresRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRabbitMqProductCoresRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRabbitMqProductCoresRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.BrokerNum != input.BrokerNum || (this.BrokerNum != null && !this.BrokerNum.Equals(input.BrokerNum))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.BrokerNum != null) hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
