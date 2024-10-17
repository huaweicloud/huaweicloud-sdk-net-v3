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
    public class ListVpcRoutesResponse : SdkResponse
    {

        /// <summary>
        /// route对象列表
        /// </summary>
        [JsonProperty("routes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcRoute> Routes { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("routes_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> RoutesLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVpcRoutesResponse {\n");
            sb.Append("  routes: ").Append(Routes).Append("\n");
            sb.Append("  routesLinks: ").Append(RoutesLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVpcRoutesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVpcRoutesResponse input)
        {
            if (input == null) return false;
            if (this.Routes != input.Routes || (this.Routes != null && input.Routes != null && !this.Routes.SequenceEqual(input.Routes))) return false;
            if (this.RoutesLinks != input.RoutesLinks || (this.RoutesLinks != null && input.RoutesLinks != null && !this.RoutesLinks.SequenceEqual(input.RoutesLinks))) return false;

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
                if (this.Routes != null) hashCode = hashCode * 59 + this.Routes.GetHashCode();
                if (this.RoutesLinks != null) hashCode = hashCode * 59 + this.RoutesLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
