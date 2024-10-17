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
    public class NeutronListRoutersResponse : SdkResponse
    {

        /// <summary>
        /// router对象列表
        /// </summary>
        [JsonProperty("routers", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronRouter> Routers { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("routers_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> RoutersLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListRoutersResponse {\n");
            sb.Append("  routers: ").Append(Routers).Append("\n");
            sb.Append("  routersLinks: ").Append(RoutersLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListRoutersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListRoutersResponse input)
        {
            if (input == null) return false;
            if (this.Routers != input.Routers || (this.Routers != null && input.Routers != null && !this.Routers.SequenceEqual(input.Routers))) return false;
            if (this.RoutersLinks != input.RoutersLinks || (this.RoutersLinks != null && input.RoutersLinks != null && !this.RoutersLinks.SequenceEqual(input.RoutersLinks))) return false;

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
                if (this.Routers != null) hashCode = hashCode * 59 + this.Routers.GetHashCode();
                if (this.RoutersLinks != null) hashCode = hashCode * 59 + this.RoutersLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
