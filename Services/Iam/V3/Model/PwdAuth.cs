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
    public class PwdAuth 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identity", NullValueHandling = NullValueHandling.Ignore)]
        public PwdIdentity Identity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public AuthScope Scope { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PwdAuth {\n");
            sb.Append("  identity: ").Append(Identity).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PwdAuth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PwdAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
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
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                return hashCode;
            }
        }
    }
}
