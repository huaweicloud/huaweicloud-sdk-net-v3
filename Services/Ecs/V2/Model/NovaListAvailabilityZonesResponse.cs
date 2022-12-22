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
    public class NovaListAvailabilityZonesResponse : SdkResponse
    {

        /// <summary>
        /// 可用域信息。
        /// </summary>
        [JsonProperty("availabilityZoneInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaAvailabilityZone> AvailabilityZoneInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaListAvailabilityZonesResponse {\n");
            sb.Append("  availabilityZoneInfo: ").Append(AvailabilityZoneInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaListAvailabilityZonesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaListAvailabilityZonesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilityZoneInfo == input.AvailabilityZoneInfo ||
                    this.AvailabilityZoneInfo != null &&
                    input.AvailabilityZoneInfo != null &&
                    this.AvailabilityZoneInfo.SequenceEqual(input.AvailabilityZoneInfo)
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
                if (this.AvailabilityZoneInfo != null)
                    hashCode = hashCode * 59 + this.AvailabilityZoneInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
