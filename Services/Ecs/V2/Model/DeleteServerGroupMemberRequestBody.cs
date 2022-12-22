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
    /// This is a auto create Body Object
    /// </summary>
    public class DeleteServerGroupMemberRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remove_member", NullValueHandling = NullValueHandling.Ignore)]
        public ServerGroupMember RemoveMember { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteServerGroupMemberRequestBody {\n");
            sb.Append("  removeMember: ").Append(RemoveMember).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteServerGroupMemberRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteServerGroupMemberRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoveMember == input.RemoveMember ||
                    (this.RemoveMember != null &&
                    this.RemoveMember.Equals(input.RemoveMember))
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
                if (this.RemoveMember != null)
                    hashCode = hashCode * 59 + this.RemoveMember.GetHashCode();
                return hashCode;
            }
        }
    }
}
