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
    public class NovaDisassociateSecurityGroupRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("removeSecurityGroup", NullValueHandling = NullValueHandling.Ignore)]
        public NovaRemoveSecurityGroupOption RemoveSecurityGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaDisassociateSecurityGroupRequestBody {\n");
            sb.Append("  removeSecurityGroup: ").Append(RemoveSecurityGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaDisassociateSecurityGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaDisassociateSecurityGroupRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoveSecurityGroup == input.RemoveSecurityGroup ||
                    (this.RemoveSecurityGroup != null &&
                    this.RemoveSecurityGroup.Equals(input.RemoveSecurityGroup))
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
                if (this.RemoveSecurityGroup != null)
                    hashCode = hashCode * 59 + this.RemoveSecurityGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
