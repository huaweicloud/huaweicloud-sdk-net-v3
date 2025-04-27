using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RouterForRule 
    {

        /// <summary>
        /// Router(VPC)所属VPC的ID。
        /// </summary>
        [JsonProperty("router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouterForRule {\n");
            sb.Append("  routerId: ").Append(RouterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RouterForRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RouterForRule input)
        {
            if (input == null) return false;
            if (this.RouterId != input.RouterId || (this.RouterId != null && !this.RouterId.Equals(input.RouterId))) return false;

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
                if (this.RouterId != null) hashCode = hashCode * 59 + this.RouterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
