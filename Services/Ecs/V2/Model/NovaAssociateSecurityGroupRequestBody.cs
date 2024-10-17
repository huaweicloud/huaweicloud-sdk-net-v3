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
    public class NovaAssociateSecurityGroupRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("addSecurityGroup", NullValueHandling = NullValueHandling.Ignore)]
        public NovaAddSecurityGroupOption AddSecurityGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaAssociateSecurityGroupRequestBody {\n");
            sb.Append("  addSecurityGroup: ").Append(AddSecurityGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaAssociateSecurityGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaAssociateSecurityGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.AddSecurityGroup != input.AddSecurityGroup || (this.AddSecurityGroup != null && !this.AddSecurityGroup.Equals(input.AddSecurityGroup))) return false;

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
                if (this.AddSecurityGroup != null) hashCode = hashCode * 59 + this.AddSecurityGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
