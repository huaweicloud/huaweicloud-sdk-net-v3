using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class BatchDeleteLoadbalancersRequestBody 
    {

        /// <summary>
        /// 解绑后的游离pool是否被删除
        /// </summary>
        [JsonProperty("unbounded_pool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnboundedPool { get; set; }

        /// <summary>
        /// 是否删除公网IP
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicIp { get; set; }

        /// <summary>
        /// 待删除的负载均衡器id列表。
        /// </summary>
        [JsonProperty("loadbalancer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteLoadbalancersRequestBody {\n");
            sb.Append("  unboundedPool: ").Append(UnboundedPool).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  loadbalancerIds: ").Append(LoadbalancerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteLoadbalancersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteLoadbalancersRequestBody input)
        {
            if (input == null) return false;
            if (this.UnboundedPool != input.UnboundedPool || (this.UnboundedPool != null && !this.UnboundedPool.Equals(input.UnboundedPool))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.LoadbalancerIds != input.LoadbalancerIds || (this.LoadbalancerIds != null && input.LoadbalancerIds != null && !this.LoadbalancerIds.SequenceEqual(input.LoadbalancerIds))) return false;

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
                if (this.UnboundedPool != null) hashCode = hashCode * 59 + this.UnboundedPool.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.LoadbalancerIds != null) hashCode = hashCode * 59 + this.LoadbalancerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
