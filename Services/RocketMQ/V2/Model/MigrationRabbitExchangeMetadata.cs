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
    /// **参数解释**： RocketMQ元数据迁移，RabbitMQ交换机元数据。 **约束限制**： 不涉及。 **取值范围**： - true：持久化。 - false：不进行持久化。 **默认取值**： 不涉及。
    /// </summary>
    public class MigrationRabbitExchangeMetadata 
    {

        /// <summary>
        /// **参数解释**： vhost名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>
        /// **参数解释**： 交换机名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 交换机类型。 **约束限制**： 不涉及。 **取值范围**： - topic：支持routing key的模糊匹配。 - direct：按routing key精确匹配进行消息路由。 - fanout：广播模式，消息会发送到所有绑定的队列，忽略routing key。 - headers：根据消息头（headers）中的键值对进行路由，而不是routing key。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 是否持久化。 **约束限制**： 不涉及。 **取值范围**： - true：持久化。 - false：不进行持久化。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("durable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Durable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationRabbitExchangeMetadata {\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  durable: ").Append(Durable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationRabbitExchangeMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationRabbitExchangeMetadata input)
        {
            if (input == null) return false;
            if (this.Vhost != input.Vhost || (this.Vhost != null && !this.Vhost.Equals(input.Vhost))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Durable != input.Durable || (this.Durable != null && !this.Durable.Equals(input.Durable))) return false;

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
                if (this.Vhost != null) hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Durable != null) hashCode = hashCode * 59 + this.Durable.GetHashCode();
                return hashCode;
            }
        }
    }
}
