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
    public class ShowCoordinatorsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 所有消费组对应的协调器列表。
        /// </summary>
        [JsonProperty("coordinators", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCoordinatorsRespCoordinators> Coordinators { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCoordinatorsResponse {\n");
            sb.Append("  coordinators: ").Append(Coordinators).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCoordinatorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCoordinatorsResponse input)
        {
            if (input == null) return false;
            if (this.Coordinators != input.Coordinators || (this.Coordinators != null && input.Coordinators != null && !this.Coordinators.SequenceEqual(input.Coordinators))) return false;

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
                if (this.Coordinators != null) hashCode = hashCode * 59 + this.Coordinators.GetHashCode();
                return hashCode;
            }
        }
    }
}
