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
    /// 
    /// </summary>
    public class ConsumerDetailResp 
    {

        /// <summary>
        /// Topic关联代理（当查询topic消费“详情”才显示此参数）。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Brokers> Brokers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerDetailResp {\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumerDetailResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumerDetailResp input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Brokers != null)
                    hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                return hashCode;
            }
        }
    }
}
