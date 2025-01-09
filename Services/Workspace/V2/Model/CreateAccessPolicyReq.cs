using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateAccessPolicyReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public AccessPolicyInfo Policy { get; set; }

        /// <summary>
        /// 策略应用对象列表。
        /// </summary>
        [JsonProperty("policy_objects_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessPolicyObjectInfo> PolicyObjectsList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccessPolicyReq {\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  policyObjectsList: ").Append(PolicyObjectsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccessPolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccessPolicyReq input)
        {
            if (input == null) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.PolicyObjectsList != input.PolicyObjectsList || (this.PolicyObjectsList != null && input.PolicyObjectsList != null && !this.PolicyObjectsList.SequenceEqual(input.PolicyObjectsList))) return false;

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
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.PolicyObjectsList != null) hashCode = hashCode * 59 + this.PolicyObjectsList.GetHashCode();
                return hashCode;
            }
        }
    }
}
