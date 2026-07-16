using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHyperinstanceClustersCapacityResponse : SdkResponse
    {

        /// <summary>
        /// 容量信息列表
        /// </summary>
        [JsonProperty("capacities", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerHpsClusterCapacity> Capacities { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHyperinstanceClustersCapacityResponse {\n");
            sb.Append("  capacities: ").Append(Capacities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHyperinstanceClustersCapacityResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHyperinstanceClustersCapacityResponse input)
        {
            if (input == null) return false;
            if (this.Capacities != input.Capacities || (this.Capacities != null && input.Capacities != null && !this.Capacities.SequenceEqual(input.Capacities))) return false;

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
                if (this.Capacities != null) hashCode = hashCode * 59 + this.Capacities.GetHashCode();
                return hashCode;
            }
        }
    }
}
