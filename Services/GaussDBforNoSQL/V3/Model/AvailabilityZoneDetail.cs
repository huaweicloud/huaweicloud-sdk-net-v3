using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 主备版的多AZ可用区详情
    /// </summary>
    public class AvailabilityZoneDetail 
    {

        /// <summary>
        /// 主可用区，应为单可用区且和备可用区不同
        /// </summary>
        [JsonProperty("primary_availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryAvailabilityZone { get; set; }

        /// <summary>
        /// 备可用区，应为单可用区且和主可用区不同
        /// </summary>
        [JsonProperty("secondary_availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryAvailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityZoneDetail {\n");
            sb.Append("  primaryAvailabilityZone: ").Append(PrimaryAvailabilityZone).Append("\n");
            sb.Append("  secondaryAvailabilityZone: ").Append(SecondaryAvailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AvailabilityZoneDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AvailabilityZoneDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrimaryAvailabilityZone == input.PrimaryAvailabilityZone ||
                    (this.PrimaryAvailabilityZone != null &&
                    this.PrimaryAvailabilityZone.Equals(input.PrimaryAvailabilityZone))
                ) && 
                (
                    this.SecondaryAvailabilityZone == input.SecondaryAvailabilityZone ||
                    (this.SecondaryAvailabilityZone != null &&
                    this.SecondaryAvailabilityZone.Equals(input.SecondaryAvailabilityZone))
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
                if (this.PrimaryAvailabilityZone != null)
                    hashCode = hashCode * 59 + this.PrimaryAvailabilityZone.GetHashCode();
                if (this.SecondaryAvailabilityZone != null)
                    hashCode = hashCode * 59 + this.SecondaryAvailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
