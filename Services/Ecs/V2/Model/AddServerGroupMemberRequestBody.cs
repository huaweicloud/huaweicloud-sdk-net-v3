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
    public class AddServerGroupMemberRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("add_member", NullValueHandling = NullValueHandling.Ignore)]
        public ServerGroupMember AddMember { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddServerGroupMemberRequestBody {\n");
            sb.Append("  addMember: ").Append(AddMember).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddServerGroupMemberRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddServerGroupMemberRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddMember == input.AddMember ||
                    (this.AddMember != null &&
                    this.AddMember.Equals(input.AddMember))
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
                if (this.AddMember != null)
                    hashCode = hashCode * 59 + this.AddMember.GetHashCode();
                return hashCode;
            }
        }
    }
}
