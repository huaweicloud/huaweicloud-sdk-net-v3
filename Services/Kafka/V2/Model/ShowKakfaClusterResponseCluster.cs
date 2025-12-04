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
    /// **参数解释**： 集群信息。
    /// </summary>
    public class ShowKakfaClusterResponseCluster 
    {

        /// <summary>
        /// **参数解释**： broker详情。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowKakfaClusterResponseClusterBrokers> Brokers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKakfaClusterResponseCluster {\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKakfaClusterResponseCluster);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKakfaClusterResponseCluster input)
        {
            if (input == null) return false;
            if (this.Brokers != input.Brokers || (this.Brokers != null && input.Brokers != null && !this.Brokers.SequenceEqual(input.Brokers))) return false;

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
                if (this.Brokers != null) hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                return hashCode;
            }
        }
    }
}
