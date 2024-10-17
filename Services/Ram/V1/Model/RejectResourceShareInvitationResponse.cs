using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RejectResourceShareInvitationResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_share_invitation", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceShareInvitation ResourceShareInvitation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RejectResourceShareInvitationResponse {\n");
            sb.Append("  resourceShareInvitation: ").Append(ResourceShareInvitation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RejectResourceShareInvitationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RejectResourceShareInvitationResponse input)
        {
            if (input == null) return false;
            if (this.ResourceShareInvitation != input.ResourceShareInvitation || (this.ResourceShareInvitation != null && !this.ResourceShareInvitation.Equals(input.ResourceShareInvitation))) return false;

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
                if (this.ResourceShareInvitation != null) hashCode = hashCode * 59 + this.ResourceShareInvitation.GetHashCode();
                return hashCode;
            }
        }
    }
}
