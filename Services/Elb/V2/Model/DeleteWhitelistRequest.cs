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
    /// Request Object
    /// </summary>
    public class DeleteWhitelistRequest 
    {

        /// <summary>
        /// 白名单id
        /// </summary>
        [SDKProperty("whitelist_id", IsPath = true)]
        [JsonProperty("whitelist_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WhitelistId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteWhitelistRequest {\n");
            sb.Append("  whitelistId: ").Append(WhitelistId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteWhitelistRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteWhitelistRequest input)
        {
            if (input == null) return false;
            if (this.WhitelistId != input.WhitelistId || (this.WhitelistId != null && !this.WhitelistId.Equals(input.WhitelistId))) return false;

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
                if (this.WhitelistId != null) hashCode = hashCode * 59 + this.WhitelistId.GetHashCode();
                return hashCode;
            }
        }
    }
}
