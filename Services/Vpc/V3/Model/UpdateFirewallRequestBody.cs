using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class UpdateFirewallRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("firewall", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateFirewallOption Firewall { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFirewallRequestBody {\n");
            sb.Append("  firewall: ").Append(Firewall).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFirewallRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFirewallRequestBody input)
        {
            if (input == null) return false;
            if (this.Firewall != input.Firewall || (this.Firewall != null && !this.Firewall.Equals(input.Firewall))) return false;

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
                if (this.Firewall != null) hashCode = hashCode * 59 + this.Firewall.GetHashCode();
                return hashCode;
            }
        }
    }
}
