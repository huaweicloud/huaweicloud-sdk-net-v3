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
    /// 
    /// </summary>
    public class AgencyAuth 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identity", NullValueHandling = NullValueHandling.Ignore)]
        public AgencyAuthIdentity Identity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgencyAuth {\n");
            sb.Append("  identity: ").Append(Identity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgencyAuth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgencyAuth input)
        {
            if (input == null) return false;
            if (this.Identity != input.Identity || (this.Identity != null && !this.Identity.Equals(input.Identity))) return false;

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
                if (this.Identity != null) hashCode = hashCode * 59 + this.Identity.GetHashCode();
                return hashCode;
            }
        }
    }
}
