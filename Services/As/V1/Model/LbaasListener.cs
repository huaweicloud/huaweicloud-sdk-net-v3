using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 增强型负载均衡器信息
    /// </summary>
    public class LbaasListener 
    {

        /// <summary>
        /// 监听器ID。
        /// </summary>
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

        /// <summary>
        /// 后端云服务器组ID。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 后端协议端口，指后端云服务器监听的端口。
        /// </summary>
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// 权重，指后端云服务器分发得到请求的数量比例。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LbaasListener {\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LbaasListener);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LbaasListener input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListenerId == input.ListenerId ||
                    (this.ListenerId != null &&
                    this.ListenerId.Equals(input.ListenerId))
                ) && 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    (this.ProtocolPort != null &&
                    this.ProtocolPort.Equals(input.ProtocolPort))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.ListenerId != null)
                    hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                return hashCode;
            }
        }
    }
}
