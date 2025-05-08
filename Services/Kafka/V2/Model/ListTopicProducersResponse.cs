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
    public class ListTopicProducersResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 总条数。 **取值范围**： 0~10000。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 生产者列表。
        /// </summary>
        [JsonProperty("producers", NullValueHandling = NullValueHandling.Ignore)]
        public List<KafkaTopicProducerResponseProducers> Producers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopicProducersResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  producers: ").Append(Producers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopicProducersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopicProducersResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Producers != input.Producers || (this.Producers != null && input.Producers != null && !this.Producers.SequenceEqual(input.Producers))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Producers != null) hashCode = hashCode * 59 + this.Producers.GetHashCode();
                return hashCode;
            }
        }
    }
}
