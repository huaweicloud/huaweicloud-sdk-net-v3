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
    /// Request Object
    /// </summary>
    public class RejectResourceShareInvitationRequest 
    {

        /// <summary>
        /// 资源共享邀请的ID。
        /// </summary>
        [SDKProperty("resource_share_invitation_id", IsPath = true)]
        [JsonProperty("resource_share_invitation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareInvitationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RejectResourceShareInvitationRequest {\n");
            sb.Append("  resourceShareInvitationId: ").Append(ResourceShareInvitationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RejectResourceShareInvitationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RejectResourceShareInvitationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceShareInvitationId == input.ResourceShareInvitationId ||
                    (this.ResourceShareInvitationId != null &&
                    this.ResourceShareInvitationId.Equals(input.ResourceShareInvitationId))
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
                if (this.ResourceShareInvitationId != null)
                    hashCode = hashCode * 59 + this.ResourceShareInvitationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
