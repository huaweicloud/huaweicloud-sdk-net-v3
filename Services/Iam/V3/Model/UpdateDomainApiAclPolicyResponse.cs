using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateDomainApiAclPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("api_acl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AclPolicyResult ApiAclPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainApiAclPolicyResponse {\n");
            sb.Append("  apiAclPolicy: ").Append(ApiAclPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainApiAclPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainApiAclPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiAclPolicy == input.ApiAclPolicy ||
                    (this.ApiAclPolicy != null &&
                    this.ApiAclPolicy.Equals(input.ApiAclPolicy))
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
                if (this.ApiAclPolicy != null)
                    hashCode = hashCode * 59 + this.ApiAclPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
