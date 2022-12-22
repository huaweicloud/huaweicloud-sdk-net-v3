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
    public class ShowVpcRouteResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("route", NullValueHandling = NullValueHandling.Ignore)]
        public VpcRoute Route { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVpcRouteResponse {\n");
            sb.Append("  route: ").Append(Route).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVpcRouteResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVpcRouteResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Route == input.Route ||
                    (this.Route != null &&
                    this.Route.Equals(input.Route))
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
                if (this.Route != null)
                    hashCode = hashCode * 59 + this.Route.GetHashCode();
                return hashCode;
            }
        }
    }
}
