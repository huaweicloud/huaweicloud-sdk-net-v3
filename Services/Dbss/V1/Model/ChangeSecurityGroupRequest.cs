using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeSecurityGroupRequest 
    {

        /// <summary>
        /// 安全组ID
        /// </summary>
        [JsonProperty("security_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroupIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeSecurityGroupRequest {\n");
            sb.Append("  securityGroupIds: ").Append(SecurityGroupIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeSecurityGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeSecurityGroupRequest input)
        {
            if (input == null) return false;
            if (this.SecurityGroupIds != input.SecurityGroupIds || (this.SecurityGroupIds != null && input.SecurityGroupIds != null && !this.SecurityGroupIds.SequenceEqual(input.SecurityGroupIds))) return false;

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
                if (this.SecurityGroupIds != null) hashCode = hashCode * 59 + this.SecurityGroupIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
