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
    /// Response Object
    /// </summary>
    public class AssociateRouteTableResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("routetable", NullValueHandling = NullValueHandling.Ignore)]
        public RouteTableResp Routetable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateRouteTableResponse {\n");
            sb.Append("  routetable: ").Append(Routetable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateRouteTableResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateRouteTableResponse input)
        {
            if (input == null) return false;
            if (this.Routetable != input.Routetable || (this.Routetable != null && !this.Routetable.Equals(input.Routetable))) return false;

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
                if (this.Routetable != null) hashCode = hashCode * 59 + this.Routetable.GetHashCode();
                return hashCode;
            }
        }
    }
}
