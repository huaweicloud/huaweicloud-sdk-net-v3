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
    public class AssociateOrDisassociateRouterWithRuleRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("router", NullValueHandling = NullValueHandling.Ignore)]
        public RouterForRule Router { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateOrDisassociateRouterWithRuleRequestBody {\n");
            sb.Append("  router: ").Append(Router).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateOrDisassociateRouterWithRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateOrDisassociateRouterWithRuleRequestBody input)
        {
            if (input == null) return false;
            if (this.Router != input.Router || (this.Router != null && !this.Router.Equals(input.Router))) return false;

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
                if (this.Router != null) hashCode = hashCode * 59 + this.Router.GetHashCode();
                return hashCode;
            }
        }
    }
}
