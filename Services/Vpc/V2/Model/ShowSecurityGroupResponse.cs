using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSecurityGroupResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_group", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityGroup SecurityGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSecurityGroupResponse {\n");
            sb.Append("  securityGroup: ").Append(SecurityGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSecurityGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSecurityGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityGroup == input.SecurityGroup ||
                    (this.SecurityGroup != null &&
                    this.SecurityGroup.Equals(input.SecurityGroup))
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
                if (this.SecurityGroup != null)
                    hashCode = hashCode * 59 + this.SecurityGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
