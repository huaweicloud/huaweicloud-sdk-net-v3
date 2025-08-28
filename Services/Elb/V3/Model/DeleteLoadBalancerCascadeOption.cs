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
    /// **参数解释**：级联删除负载均衡器参数对象。  **约束限制**：不涉及
    /// </summary>
    public class DeleteLoadBalancerCascadeOption 
    {

        /// <summary>
        /// **参数解释**：是否删除关联的后端服务器组。  **约束限制**： - 共享型负载均衡器仅支持传参为true。 [- 若开启多挂特性，且后端服务器组关联了多个LB，则无论传入何值，都不会删除后端服务器组。](tag: hws,hws_hk)  **取值范围**： - true：删除该后端服务器组。 - false：仅解绑后端服务器组，不删除。  **默认取值**：true
        /// </summary>
        [JsonProperty("unbounded_pool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnboundedPool { get; set; }

        /// <summary>
        /// **参数解释**：删除负载均衡器后是否删除关联的公网IP。  **约束限制**：不涉及          **取值范围**： - true：删除关联的EIP。 - false：仅解绑关联的EIP，不删除。  **默认取值**：false
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteLoadBalancerCascadeOption {\n");
            sb.Append("  unboundedPool: ").Append(UnboundedPool).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteLoadBalancerCascadeOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteLoadBalancerCascadeOption input)
        {
            if (input == null) return false;
            if (this.UnboundedPool != input.UnboundedPool || (this.UnboundedPool != null && !this.UnboundedPool.Equals(input.UnboundedPool))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;

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
                return hashCode;
            }
        }
    }
}
