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
    /// Response Object
    /// </summary>
    public class UpdateVirsubnetCidrReservationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 请求ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("virsubnet_cidr_reservation", NullValueHandling = NullValueHandling.Ignore)]
        public VirsubnetCidrReservation VirsubnetCidrReservation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVirsubnetCidrReservationResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  virsubnetCidrReservation: ").Append(VirsubnetCidrReservation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateVirsubnetCidrReservationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateVirsubnetCidrReservationResponse input)
        {
            if (input == null) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.VirsubnetCidrReservation != input.VirsubnetCidrReservation || (this.VirsubnetCidrReservation != null && !this.VirsubnetCidrReservation.Equals(input.VirsubnetCidrReservation))) return false;

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
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.VirsubnetCidrReservation != null) hashCode = hashCode * 59 + this.VirsubnetCidrReservation.GetHashCode();
                return hashCode;
            }
        }
    }
}
