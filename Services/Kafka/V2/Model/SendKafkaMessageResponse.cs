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
    /// Response Object
    /// </summary>
    public class SendKafkaMessageResponse : SdkResponse
    {

        /// <summary>
        /// Kafka的topic
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// topic的分区信息等
        /// </summary>
        [JsonProperty("property_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> PropertyList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendKafkaMessageResponse {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  propertyList: ").Append(PropertyList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendKafkaMessageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendKafkaMessageResponse input)
        {
            if (input == null) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;
            if (this.PropertyList != input.PropertyList || (this.PropertyList != null && input.PropertyList != null && !this.PropertyList.SequenceEqual(input.PropertyList))) return false;

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
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.PropertyList != null) hashCode = hashCode * 59 + this.PropertyList.GetHashCode();
                return hashCode;
            }
        }
    }
}
