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
    /// Response Object
    /// </summary>
    public class ListLoadbalancersResponse : SdkResponse
    {

        /// <summary>
        /// 负载均衡器对象列表
        /// </summary>
        [JsonProperty("loadbalancers", NullValueHandling = NullValueHandling.Ignore)]
        public List<LoadbalancerResp> Loadbalancers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLoadbalancersResponse {\n");
            sb.Append("  loadbalancers: ").Append(Loadbalancers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLoadbalancersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLoadbalancersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Loadbalancers == input.Loadbalancers ||
                    this.Loadbalancers != null &&
                    input.Loadbalancers != null &&
                    this.Loadbalancers.SequenceEqual(input.Loadbalancers)
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
                if (this.Loadbalancers != null)
                    hashCode = hashCode * 59 + this.Loadbalancers.GetHashCode();
                return hashCode;
            }
        }
    }
}
