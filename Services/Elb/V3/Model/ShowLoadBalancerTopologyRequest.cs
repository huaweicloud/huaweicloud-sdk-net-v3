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
    /// Request Object
    /// </summary>
    public class ShowLoadBalancerTopologyRequest 
    {

        /// <summary>
        /// **参数解释**：负载均衡器ID。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [SDKProperty("loadbalancer_id", IsPath = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// 监听器的ID。  支持多值查询，查询条件格式：*listener_id&#x3D;xxx&amp;listener_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("listener_id", IsQuery = true)]
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

        /// <summary>
        /// 后端服务器组的ID。  支持多值查询，查询条件格式：*pool_id&#x3D;xxx&amp;pool_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("pool_id", IsQuery = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 监听器的名称。  支持多值查询，查询条件格式：*listener_name&#x3D;xxx&amp;listener_name&#x3D;xxx*。
        /// </summary>
        [SDKProperty("listener_name", IsQuery = true)]
        [JsonProperty("listener_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerName { get; set; }

        /// <summary>
        /// 监听器的协议。  支持多值查询，查询条件格式：*listener_protocol&#x3D;xxx&amp;listener_protocol&#x3D;xxx*。
        /// </summary>
        [SDKProperty("listener_protocol", IsQuery = true)]
        [JsonProperty("listener_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// 监听器的监听端口。  支持多值查询，查询条件格式：*listener_protocol_port&#x3D;xxx&amp;listener_protocol_port&#x3D;xxx*。
        /// </summary>
        [SDKProperty("listener_protocol_port", IsQuery = true)]
        [JsonProperty("listener_protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ListenerProtocolPort { get; set; }

        /// <summary>
        /// 后端服务器组的名称。  支持多值查询，查询条件格式：*pool_name&#x3D;xxx&amp;pool_name&#x3D;xxx*。
        /// </summary>
        [SDKProperty("pool_name", IsQuery = true)]
        [JsonProperty("pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLoadBalancerTopologyRequest {\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  listenerName: ").Append(ListenerName).Append("\n");
            sb.Append("  listenerProtocol: ").Append(ListenerProtocol).Append("\n");
            sb.Append("  listenerProtocolPort: ").Append(ListenerProtocolPort).Append("\n");
            sb.Append("  poolName: ").Append(PoolName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLoadBalancerTopologyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLoadBalancerTopologyRequest input)
        {
            if (input == null) return false;
            if (this.LoadbalancerId != input.LoadbalancerId || (this.LoadbalancerId != null && !this.LoadbalancerId.Equals(input.LoadbalancerId))) return false;
            if (this.ListenerId != input.ListenerId || (this.ListenerId != null && !this.ListenerId.Equals(input.ListenerId))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.ListenerName != input.ListenerName || (this.ListenerName != null && !this.ListenerName.Equals(input.ListenerName))) return false;
            if (this.ListenerProtocol != input.ListenerProtocol || (this.ListenerProtocol != null && !this.ListenerProtocol.Equals(input.ListenerProtocol))) return false;
            if (this.ListenerProtocolPort != input.ListenerProtocolPort || (this.ListenerProtocolPort != null && !this.ListenerProtocolPort.Equals(input.ListenerProtocolPort))) return false;
            if (this.PoolName != input.PoolName || (this.PoolName != null && !this.PoolName.Equals(input.PoolName))) return false;

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
                if (this.LoadbalancerId != null) hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.ListenerId != null) hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.ListenerName != null) hashCode = hashCode * 59 + this.ListenerName.GetHashCode();
                if (this.ListenerProtocol != null) hashCode = hashCode * 59 + this.ListenerProtocol.GetHashCode();
                if (this.ListenerProtocolPort != null) hashCode = hashCode * 59 + this.ListenerProtocolPort.GetHashCode();
                if (this.PoolName != null) hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                return hashCode;
            }
        }
    }
}
