using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 物联网平台转发数据的通道配置参数。
    /// </summary>
    public class ChannelDetail 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("http_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public HttpForwarding HttpForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dis_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public DisForwarding DisForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public ObsForwarding ObsForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amqp_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public AmqpForwarding AmqpForwarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dms_kafka_forwarding", NullValueHandling = NullValueHandling.Ignore)]
        public DmsKafkaForwarding DmsKafkaForwarding { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelDetail {\n");
            sb.Append("  httpForwarding: ").Append(HttpForwarding).Append("\n");
            sb.Append("  disForwarding: ").Append(DisForwarding).Append("\n");
            sb.Append("  obsForwarding: ").Append(ObsForwarding).Append("\n");
            sb.Append("  amqpForwarding: ").Append(AmqpForwarding).Append("\n");
            sb.Append("  dmsKafkaForwarding: ").Append(DmsKafkaForwarding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChannelDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChannelDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpForwarding == input.HttpForwarding ||
                    (this.HttpForwarding != null &&
                    this.HttpForwarding.Equals(input.HttpForwarding))
                ) && 
                (
                    this.DisForwarding == input.DisForwarding ||
                    (this.DisForwarding != null &&
                    this.DisForwarding.Equals(input.DisForwarding))
                ) && 
                (
                    this.ObsForwarding == input.ObsForwarding ||
                    (this.ObsForwarding != null &&
                    this.ObsForwarding.Equals(input.ObsForwarding))
                ) && 
                (
                    this.AmqpForwarding == input.AmqpForwarding ||
                    (this.AmqpForwarding != null &&
                    this.AmqpForwarding.Equals(input.AmqpForwarding))
                ) && 
                (
                    this.DmsKafkaForwarding == input.DmsKafkaForwarding ||
                    (this.DmsKafkaForwarding != null &&
                    this.DmsKafkaForwarding.Equals(input.DmsKafkaForwarding))
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
                if (this.HttpForwarding != null)
                    hashCode = hashCode * 59 + this.HttpForwarding.GetHashCode();
                if (this.DisForwarding != null)
                    hashCode = hashCode * 59 + this.DisForwarding.GetHashCode();
                if (this.ObsForwarding != null)
                    hashCode = hashCode * 59 + this.ObsForwarding.GetHashCode();
                if (this.AmqpForwarding != null)
                    hashCode = hashCode * 59 + this.AmqpForwarding.GetHashCode();
                if (this.DmsKafkaForwarding != null)
                    hashCode = hashCode * 59 + this.DmsKafkaForwarding.GetHashCode();
                return hashCode;
            }
        }
    }
}
