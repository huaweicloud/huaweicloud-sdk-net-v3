using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class UpdateWhitelistRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateWhitelistReq Whitelist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWhitelistRequestBody {\n");
            sb.Append("  whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateWhitelistRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateWhitelistRequestBody input)
        {
            if (input == null) return false;
            if (this.Whitelist != input.Whitelist || (this.Whitelist != null && !this.Whitelist.Equals(input.Whitelist))) return false;

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
                if (this.Whitelist != null) hashCode = hashCode * 59 + this.Whitelist.GetHashCode();
                return hashCode;
            }
        }
    }
}
