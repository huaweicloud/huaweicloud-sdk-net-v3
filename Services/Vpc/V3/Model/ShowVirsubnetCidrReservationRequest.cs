using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowVirsubnetCidrReservationRequest 
    {

        /// <summary>
        /// **参数解释**： 子网预留网段的资源ID。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("virsubnet_cidr_reservation_id", IsPath = true)]
        [JsonProperty("virsubnet_cidr_reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetCidrReservationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVirsubnetCidrReservationRequest {\n");
            sb.Append("  virsubnetCidrReservationId: ").Append(VirsubnetCidrReservationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVirsubnetCidrReservationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVirsubnetCidrReservationRequest input)
        {
            if (input == null) return false;
            if (this.VirsubnetCidrReservationId != input.VirsubnetCidrReservationId || (this.VirsubnetCidrReservationId != null && !this.VirsubnetCidrReservationId.Equals(input.VirsubnetCidrReservationId))) return false;

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
                if (this.VirsubnetCidrReservationId != null) hashCode = hashCode * 59 + this.VirsubnetCidrReservationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
