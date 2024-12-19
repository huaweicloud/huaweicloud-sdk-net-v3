using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowConfigurationAggregatorRequest 
    {

        /// <summary>
        /// 资源聚合器ID。
        /// </summary>
        [SDKProperty("aggregator_id", IsPath = true)]
        [JsonProperty("aggregator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfigurationAggregatorRequest {\n");
            sb.Append("  aggregatorId: ").Append(AggregatorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigurationAggregatorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigurationAggregatorRequest input)
        {
            if (input == null) return false;
            if (this.AggregatorId != input.AggregatorId || (this.AggregatorId != null && !this.AggregatorId.Equals(input.AggregatorId))) return false;

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
                if (this.AggregatorId != null) hashCode = hashCode * 59 + this.AggregatorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
