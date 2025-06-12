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
    /// 
    /// </summary>
    public class UpdateRecycleBinPolicyReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRecycleBinPolicyOption Policy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRecycleBinPolicyReq {\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRecycleBinPolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRecycleBinPolicyReq input)
        {
            if (input == null) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;

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
                return hashCode;
            }
        }
    }
}
