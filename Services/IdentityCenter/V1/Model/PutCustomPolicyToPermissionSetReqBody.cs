using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// the request body of PutCustomPolicyToPermissionSet
    /// </summary>
    public class PutCustomPolicyToPermissionSetReqBody 
    {

        /// <summary>
        /// 要附加到权限集的自定义身份策略
        /// </summary>
        [JsonProperty("custom_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutCustomPolicyToPermissionSetReqBody {\n");
            sb.Append("  customPolicy: ").Append(CustomPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PutCustomPolicyToPermissionSetReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PutCustomPolicyToPermissionSetReqBody input)
        {
            if (input == null) return false;
            if (this.CustomPolicy != input.CustomPolicy || (this.CustomPolicy != null && !this.CustomPolicy.Equals(input.CustomPolicy))) return false;

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
                if (this.CustomPolicy != null) hashCode = hashCode * 59 + this.CustomPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
