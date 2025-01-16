using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListServerAzInfoResponse : SdkResponse
    {

        /// <summary>
        /// az详情信息
        /// </summary>
        [JsonProperty("availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListServerAzInfo> AvailabilityZones { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServerAzInfoResponse {\n");
            sb.Append("  availabilityZones: ").Append(AvailabilityZones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServerAzInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServerAzInfoResponse input)
        {
            if (input == null) return false;
            if (this.AvailabilityZones != input.AvailabilityZones || (this.AvailabilityZones != null && input.AvailabilityZones != null && !this.AvailabilityZones.SequenceEqual(input.AvailabilityZones))) return false;

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
                if (this.AvailabilityZones != null) hashCode = hashCode * 59 + this.AvailabilityZones.GetHashCode();
                return hashCode;
            }
        }
    }
}
