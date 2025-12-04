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
    /// Request Object
    /// </summary>
    public class ShowKafkaProductCoresRequest 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 产品ID。 **约束限制**： 不涉及。 **取值范围**： - s6.2u4g.single.small：规格kafka.2u4g.single.small的产品ID。 - c6.2u4g.single：规格kafka.2u4g.single的产品ID。 [- s6.2u4g.cluster.small：规格kafka.2u4g.cluster.small的产品ID。](tag:hws,hws_hk,hws_eu,dt,ax) - c6.2u4g.cluster：规格kafka.2u4g.cluster的产品ID。 - c6.4u8g.cluster：规格kafka.4u8g.cluster的产品ID。 - c6.8u16g.cluster：规格kafka.8u16g.cluster的产品ID。 - c6.12u24g.cluster：规格kafka.12u24g.cluster的产品ID。 - c6.16u32g.cluster：规格kafka.16u32g.cluster的产品ID。  **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("product_id", IsQuery = true)]
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释**： broker数量。 **约束限制**： 不涉及。 **取值范围**： - Kafka实例规格为kafka.2u4g.single.small时，代理数建议取值范围1。 - Kafka实例规格为kafka.2u4g.single时，代理数建议取值范围1。 [- Kafka实例规格为kafka.2u4g.cluster.small时，代理数取值范围3-30。](tag:hws,hws_hk,hws_eu,dt,ax) - Kafka实例规格为kafka.2u4g.cluster时，代理数取值范围3-30。 - Kafka实例规格为kafka.4u8g.cluster时，代理数取值范围3-30。 - Kafka实例规格为kafka.8u16g.cluster时，代理数取值范围3-50。 - Kafka实例规格为kafka.12u24g.cluster时，代理数取值范围3-50。 - Kafka实例规格为kafka.16u32g.cluster时，代理数取值范围3-50。 **默认取值**： 不涉及。
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
            sb.Append("class ShowKafkaProductCoresRequest {\n");
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
            return this.Equals(input as ShowKafkaProductCoresRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKafkaProductCoresRequest input)
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
