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
    public class CreateBindingBody 
    {

        /// <summary>
        /// 要投递的Exchange或Queue名称
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// 绑定键值，用于告知Exchange应该将消息投递到哪些Queue或Exchange中
        /// </summary>
        [JsonProperty("routing_key", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutingKey { get; set; }

        /// <summary>
        /// 绑定目标端类型，Exchange或Queue。[（AMQP版本只支持绑定Queue）](tag:hws,hws_hk)
        /// </summary>
        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBindingBody {\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  routingKey: ").Append(RoutingKey).Append("\n");
            sb.Append("  destinationType: ").Append(DestinationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBindingBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBindingBody input)
        {
            if (input == null) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.RoutingKey != input.RoutingKey || (this.RoutingKey != null && !this.RoutingKey.Equals(input.RoutingKey))) return false;
            if (this.DestinationType != input.DestinationType || (this.DestinationType != null && !this.DestinationType.Equals(input.DestinationType))) return false;

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
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.RoutingKey != null) hashCode = hashCode * 59 + this.RoutingKey.GetHashCode();
                if (this.DestinationType != null) hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                return hashCode;
            }
        }
    }
}
