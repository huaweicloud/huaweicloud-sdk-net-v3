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
    public class BindingsDetails 
    {

        /// <summary>
        /// Exchange名称
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 绑定目标类型
        /// </summary>
        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationType { get; set; }

        /// <summary>
        /// 绑定目标的名称
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// 绑定键值
        /// </summary>
        [JsonProperty("routing_key", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutingKey { get; set; }

        /// <summary>
        /// 经过URL转译后routing_key
        /// </summary>
        [JsonProperty("properties_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertiesKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BindingsDetails {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  destinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  routingKey: ").Append(RoutingKey).Append("\n");
            sb.Append("  propertiesKey: ").Append(PropertiesKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BindingsDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BindingsDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.RoutingKey == input.RoutingKey ||
                    (this.RoutingKey != null &&
                    this.RoutingKey.Equals(input.RoutingKey))
                ) && 
                (
                    this.PropertiesKey == input.PropertiesKey ||
                    (this.PropertiesKey != null &&
                    this.PropertiesKey.Equals(input.PropertiesKey))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.RoutingKey != null)
                    hashCode = hashCode * 59 + this.RoutingKey.GetHashCode();
                if (this.PropertiesKey != null)
                    hashCode = hashCode * 59 + this.PropertiesKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
