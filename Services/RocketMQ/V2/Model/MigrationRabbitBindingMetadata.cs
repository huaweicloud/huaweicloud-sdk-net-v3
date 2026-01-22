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
    /// **参数解释**： RocketMQ元数据迁移，RabbitMQ binding元数据。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
    /// </summary>
    public class MigrationRabbitBindingMetadata 
    {

        /// <summary>
        /// **参数解释**： vhost名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>
        /// **参数解释**： 消息的来源。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释**： 消息的目标。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// **参数解释**： 目标的类型。 **约束限制**： 不涉及。 **取值范围**： - exchange：交换机。 - queue：队列。[RabbitMQ AMQP版本只支持绑定queue。](tag:hws,hws_hk) **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationType { get; set; }

        /// <summary>
        /// **参数解释**： 路由键。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("routing_key", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutingKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationRabbitBindingMetadata {\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  destinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  routingKey: ").Append(RoutingKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationRabbitBindingMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationRabbitBindingMetadata input)
        {
            if (input == null) return false;
            if (this.Vhost != input.Vhost || (this.Vhost != null && !this.Vhost.Equals(input.Vhost))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.DestinationType != input.DestinationType || (this.DestinationType != null && !this.DestinationType.Equals(input.DestinationType))) return false;
            if (this.RoutingKey != input.RoutingKey || (this.RoutingKey != null && !this.RoutingKey.Equals(input.RoutingKey))) return false;

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
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.DestinationType != null) hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.RoutingKey != null) hashCode = hashCode * 59 + this.RoutingKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
