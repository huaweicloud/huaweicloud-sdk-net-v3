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
    /// Response Object
    /// </summary>
    public class ShowTopicStatusResponse : SdkResponse
    {

        /// <summary>
        /// 最大偏移量。
        /// </summary>
        [JsonProperty("max_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxOffset { get; set; }

        /// <summary>
        /// 最小偏移量。
        /// </summary>
        [JsonProperty("min_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinOffset { get; set; }

        /// <summary>
        /// 代理。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowTopicStatusRespBrokers> Brokers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopicStatusResponse {\n");
            sb.Append("  maxOffset: ").Append(MaxOffset).Append("\n");
            sb.Append("  minOffset: ").Append(MinOffset).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopicStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopicStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxOffset == input.MaxOffset ||
                    (this.MaxOffset != null &&
                    this.MaxOffset.Equals(input.MaxOffset))
                ) && 
                (
                    this.MinOffset == input.MinOffset ||
                    (this.MinOffset != null &&
                    this.MinOffset.Equals(input.MinOffset))
                ) && 
                (
                    this.Brokers == input.Brokers ||
                    this.Brokers != null &&
                    input.Brokers != null &&
                    this.Brokers.SequenceEqual(input.Brokers)
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
                if (this.MaxOffset != null)
                    hashCode = hashCode * 59 + this.MaxOffset.GetHashCode();
                if (this.MinOffset != null)
                    hashCode = hashCode * 59 + this.MinOffset.GetHashCode();
                if (this.Brokers != null)
                    hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                return hashCode;
            }
        }
    }
}
