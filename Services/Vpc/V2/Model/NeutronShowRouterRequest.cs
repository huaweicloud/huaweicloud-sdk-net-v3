using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class NeutronShowRouterRequest 
    {

        /// <summary>
        /// 路由器ID
        /// </summary>
        [SDKProperty("router_id", IsPath = true)]
        [JsonProperty("router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronShowRouterRequest {\n");
            sb.Append("  routerId: ").Append(RouterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronShowRouterRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronShowRouterRequest input)
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
