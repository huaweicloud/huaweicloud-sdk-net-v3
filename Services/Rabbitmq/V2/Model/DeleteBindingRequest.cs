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
    public class DeleteBindingRequest 
    {

        /// <summary>
        /// 实例ID
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Vhost名称
        /// </summary>
        [SDKProperty("vhost", IsPath = true)]
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>
        /// Exchange名称
        /// </summary>
        [SDKProperty("exchange", IsPath = true)]
        [JsonProperty("exchange", NullValueHandling = NullValueHandling.Ignore)]
        public string Exchange { get; set; }

        /// <summary>
        /// 绑定目标端类型，Exchange或Queue。[（AMQP版本只支持Queue绑定类型）](tag:hws,hws_hk)
        /// </summary>
        [SDKProperty("destination_type", IsPath = true)]
        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationType { get; set; }

        /// <summary>
        /// 绑定的目标端名称
        /// </summary>
        [SDKProperty("destination", IsPath = true)]
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// 绑定路由键，经过URL转译后routing_key，可通过调用[查询Exchange绑定列表](ListBindings.xml)或者[查询指定Queue详情](ShowQueueDetails.xml)接口的响应信息获取。
        /// </summary>
        [SDKProperty("properties_key", IsPath = true)]
        [JsonProperty("properties_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertiesKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteBindingRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("  exchange: ").Append(Exchange).Append("\n");
            sb.Append("  destinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  propertiesKey: ").Append(PropertiesKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteBindingRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteBindingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Vhost == input.Vhost ||
                    (this.Vhost != null &&
                    this.Vhost.Equals(input.Vhost))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Vhost != null)
                    hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.PropertiesKey != null)
                    hashCode = hashCode * 59 + this.PropertiesKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
