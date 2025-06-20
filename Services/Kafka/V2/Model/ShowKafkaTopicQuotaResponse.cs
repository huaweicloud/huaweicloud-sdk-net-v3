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
    public class ShowKafkaTopicQuotaResponse : SdkResponse
    {

        /// <summary>
        /// Topic流控配置
        /// </summary>
        [JsonProperty("quotas", NullValueHandling = NullValueHandling.Ignore)]
        public List<KafkaTopicQuota> Quotas { get; set; }

        /// <summary>
        /// Topic流控数量
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKafkaTopicQuotaResponse {\n");
            sb.Append("  quotas: ").Append(Quotas).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKafkaTopicQuotaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKafkaTopicQuotaResponse input)
        {
            if (input == null) return false;
            if (this.Quotas != input.Quotas || (this.Quotas != null && input.Quotas != null && !this.Quotas.SequenceEqual(input.Quotas))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.Quotas != null) hashCode = hashCode * 59 + this.Quotas.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
