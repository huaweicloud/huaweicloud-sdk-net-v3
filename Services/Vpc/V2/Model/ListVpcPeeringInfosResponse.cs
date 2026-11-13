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
    public class ListVpcPeeringInfosResponse : SdkResponse
    {

        /// <summary>
        /// 对等连接信息对象列表
        /// </summary>
        [JsonProperty("peering_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcPeering> PeeringInfos { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("peering_infos_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NeutronPageLink> PeeringInfosLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVpcPeeringInfosResponse {\n");
            sb.Append("  peeringInfos: ").Append(PeeringInfos).Append("\n");
            sb.Append("  peeringInfosLinks: ").Append(PeeringInfosLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVpcPeeringInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVpcPeeringInfosResponse input)
        {
            if (input == null) return false;
            if (this.PeeringInfos != input.PeeringInfos || (this.PeeringInfos != null && input.PeeringInfos != null && !this.PeeringInfos.SequenceEqual(input.PeeringInfos))) return false;
            if (this.PeeringInfosLinks != input.PeeringInfosLinks || (this.PeeringInfosLinks != null && input.PeeringInfosLinks != null && !this.PeeringInfosLinks.SequenceEqual(input.PeeringInfosLinks))) return false;

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
                if (this.PeeringInfos != null) hashCode = hashCode * 59 + this.PeeringInfos.GetHashCode();
                if (this.PeeringInfosLinks != null) hashCode = hashCode * 59 + this.PeeringInfosLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
