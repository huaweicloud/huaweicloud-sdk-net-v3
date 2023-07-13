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
    public class TokenAuth 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identity", NullValueHandling = NullValueHandling.Ignore)]
        public TokenAuthIdentity Identity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenAuth {\n");
            sb.Append("  identity: ").Append(Identity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TokenAuth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TokenAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
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
                return hashCode;
            }
        }
    }
}
