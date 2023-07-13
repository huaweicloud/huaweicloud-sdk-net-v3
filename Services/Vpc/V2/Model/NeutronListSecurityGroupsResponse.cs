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
    public class NeutronListSecurityGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 安全组对象列表
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronSecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("security_groups_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> SecurityGroupsLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListSecurityGroupsResponse {\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  securityGroupsLinks: ").Append(SecurityGroupsLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListSecurityGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListSecurityGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.SecurityGroupsLinks == input.SecurityGroupsLinks ||
                    this.SecurityGroupsLinks != null &&
                    input.SecurityGroupsLinks != null &&
                    this.SecurityGroupsLinks.SequenceEqual(input.SecurityGroupsLinks)
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
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.SecurityGroupsLinks != null)
                    hashCode = hashCode * 59 + this.SecurityGroupsLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
